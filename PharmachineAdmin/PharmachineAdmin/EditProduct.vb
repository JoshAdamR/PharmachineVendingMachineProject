Public Class EditProduct
    Private Access As New DBController

    Private CurrentRecord As Integer = 0

    Private errorColor As Color = Color.FromArgb(255, 150, 150)
    Private validColor As Color = Color.FromArgb(150, 255, 150)

    Private nameInputValid As Boolean = False
    Private descInputValid As Boolean = False
    Private priceInputValid As Boolean = False
    Private amtInputValid As Boolean = False
    Private imageValid As Boolean = False

    Private allValid As Boolean = False

    Private saveSuccess As Boolean = True
    Private editingEnabled As Boolean = False

    Private CheckForDuplicatesError = False
    Private CheckNameIsCurrentError = False

    ' TODO: DATA VALIDATION AS IN NEWPRODUCT.VB (done)
    ' TODO: INFORM AFTER UPDATE (done)
    ' TODO: READ-ONLY STATE FUNCTION (done)

    '' \\\\\\\\\\\\\\\\\\\\\\\\ Control events functions ///////////////////////''
    Private Sub EditProduct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CurrentRecord = 0
        DisableEditing()
        GetProducts()
    End Sub

    Private Sub movPrevBtn_Click(sender As Object, e As EventArgs) Handles movPrevBtn.Click
        NavigateRecords(-1)
    End Sub

    Private Sub movNextBtn_Click(sender As Object, e As EventArgs) Handles movNextBtn.Click
        NavigateRecords(1)
    End Sub

    Private Sub movLastBtn_Click(sender As Object, e As EventArgs) Handles movLastBtn.Click
        CurrentRecord = Access.DataTable.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub movFirstBtn_Click(sender As Object, e As EventArgs) Handles movFirstBtn.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Using fileChooser As New OpenFileDialog
            ' set fiters and title
            fileChooser.Filter = "Image file | *.jpg; *.jpeg; *.png; *.bmp; *.gif"
            fileChooser.Title = "Choose Image"

            fileChooser.ShowDialog()

            Try
                'imgDisplay.Image = Image.FromFile(fileChooser.FileName)
                imgDisplay.Image = Image.FromStream(fileChooser.OpenFile)
                Debug.Print(fileChooser.FileName)
            Catch ex As Exception
                Debug.Print(ex.Message)
                MsgBox("Corrupt image!", MsgBoxStyle.Exclamation, "Corrupt!")
            End Try

        End Using
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        imgDisplay.Image = Nothing
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If imgDisplay.Image Is Nothing Then
            imageValid = False
        Else
            imageValid = True
        End If

        ValidateAll()

        If allValid Then
            UpdateRecord()
        Else
            saveSuccess = False
            MsgBox("Make sure ALL information is present and correctly entered",
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete!")
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        DisableEditing()
        ResetPage()
        Close()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If Not editingEnabled Then
            EnableEditing()
        Else
            DisableEditing()
        End If
    End Sub

    ' validate name so it isn't empty
    Private Sub nameInput_TextChanged(sender As Object, e As EventArgs) Handles nameInput.TextChanged
        If Not saveSuccess Then
            nameInputValidate()
        End If
    End Sub

    ' validate description so it isn't empty
    Private Sub descInput_TextChanged(sender As Object, e As EventArgs) Handles descInput.TextChanged
        If Not saveSuccess Then
            descInputValidate()
        End If
    End Sub

    ' validate price
    Private Sub priceInput_TextChange(sender As Object, e As EventArgs) Handles priceInput.TextChanged
        If Not saveSuccess Then
            priceInputValidate()
        End If
    End Sub

    ' validate amount
    Private Sub amtInput_TextChanged(sender As Object, e As EventArgs) Handles amtInput.TextChanged
        If Not saveSuccess Then
            amtInputValidate()
        End If
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\\\\\ DB Related functions ///////////////////////''
    Private Sub GetProducts()
        ' get all records
        Access.RunQuery("SELECT * FROM products ORDER BY ProductName ASC")

        ' if errors and no records retrieved, abort and report
        If HasErrors(True) OrElse Access.RecordCount < 1 Then Exit Sub

        ' if everything ok, get individual record
        GetRecord()
    End Sub

    Private Sub GetRecord()
        ' check if no records or position is out of range
        If Access.DataTable.Rows.Count < 1 OrElse
            CurrentRecord > Access.DataTable.Rows.Count - 1 Then Exit Sub

        ' get information and display
        Dim Row As DataRow = Access.DataTable.Rows(CurrentRecord)

        idLabel.Text = Row("ID")
        nameInput.Text = Row("ProductName").ToString
        descInput.Text = Row("ProductDesc").ToString
        priceInput.Text = Format(Row("ProductPrice"), "0.00")
        amtInput.Text = Row("Amount")
        imgDisplay.Image = RetrieveImageFromDb(Row)
    End Sub

    Private Sub NavigateRecords(value As Integer)
        CurrentRecord += value
        If CurrentRecord > Access.DataTable.Rows.Count - 1 Then
            CurrentRecord = 0
        ElseIf CurrentRecord < 0 Then
            CurrentRecord = Access.DataTable.Rows.Count - 1
        End If

        ' update the form, gives scrolling effect
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        ' make sure user cannot rename to existing record
        ' but user can rename to it's current name
        If (CheckForDuplicates() = False) OrElse (CheckNameIsCurrent() = True) Then
            ' check if error or no records
            If IsNotEmpty(idLabel.Text) Then
                'use parameters - (ORDER MATTERS!)
                Access.AddParams("@pName", nameInput.Text)
                Access.AddParams("@pDesc", descInput.Text)
                Access.AddParams("@pPrice", priceInput.Text)
                Access.AddParams("@pImage", ProcessImage())
                Access.AddParams("@pAmt", amtInput.Text)
                Access.AddParams("@pid", idLabel.Text)

                ' run query
                Access.RunQuery("UPDATE products " &
                                "SET ProductName=@pName, ProductDesc=@pDesc, ProductPrice=@pPrice, " &
                                "ProductImage=@pImage, Amount=@pAmt " &
                                "WHERE ID=@pid")

                ' if errors abort report
                If HasErrors(True) Then Exit Sub

                ' refresh edit page and main page if success
                GetProducts()
                ResetPage()
                DisableEditing()
                AdminForm.RefreshPage()

                MsgBox("Item saved!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Edited!")
            End If
        Else
            saveSuccess = False
            If (Not CheckForDuplicatesError) Or (Not CheckNameIsCurrentError) Then
                MsgBox("Product name already exists", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly,
                   "Duplicate found!")
            End If
        End If
    End Sub

    Private Function CheckForDuplicates() As Boolean
        ' use parameters
        Access.AddParams("@nameTest", nameInput.Text)
        ' query for duplicates
        Access.RunQuery("SELECT ProductName FROM products " &
                        "WHERE ProductName=@nameTest")
        ' if error abort and report
        If HasErrors(True) Then
            CheckForDuplicatesError = True
            Return True
        End If

        Return Not (Access.RecordCount = 0)
    End Function

    Private Function CheckNameIsCurrent() As Boolean
        Dim pid As String

        ' use parameters
        Access.AddParams("@nameCheck", nameInput.Text)
        Access.RunQuery("SELECT TOP 1 ID FROM Products " &
                        "WHERE ProductName=@nameCheck")

        If HasErrors(True) Then
            CheckNameIsCurrentError = True
            Return False
        End If

        Dim Row As DataRow = Access.DataTable.Rows(0)
        pid = Row("ID").ToString

        Return idLabel.Text = pid
    End Function

    '' \\\\\\\\\\\\\\\\\\\\\\\\ other functions ///////////////////////''
    Private Function RetrieveImageFromDb(imgFromDb As DataRow) As Image
        Using memStream As New IO.MemoryStream(DirectCast(imgFromDb("ProductImage"), Byte()))
            Return Image.FromStream(memStream)
        End Using
    End Function

    Private Function ProcessImage() As Byte()
        Try
            Dim imgByteArr() As Byte = Nothing

            Using memStream As New IO.MemoryStream
                Dim bitmap As New Bitmap(imgDisplay.Image)

                ' saves the image in the specified memory stream in the specified format
                bitmap.Save(memStream, Imaging.ImageFormat.Png)
                ' save the contents of the stream into an array of Bytes
                imgByteArr = memStream.ToArray()
            End Using

            Return imgByteArr
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "IOException")
        End Try

        Return Nothing
    End Function

    Private Sub EnableEditing()
        ' change text
        editBtn.Text = "Cancel Edit"

        ' enable buttons
        uploadBtn.Enabled = True
        removeBtn.Enabled = True

        ' enable textboxes
        nameInput.ReadOnly = False
        descInput.ReadOnly = False
        ' setting color because color change not automatic
        descInput.BackColor = SystemColors.Window
        priceInput.ReadOnly = False
        amtInput.ReadOnly = False

        editingEnabled = True
    End Sub

    Private Sub DisableEditing()
        ' change text
        editBtn.Text = "Edit"

        ' enable buttons
        uploadBtn.Enabled = False
        removeBtn.Enabled = False

        ' enable textboxes
        nameInput.ReadOnly = True
        descInput.ReadOnly = True
        ' setting color because color change not automatic
        descInput.BackColor = Color.FromArgb(240, 240, 240) ' SystemColor.Control doesn't work (not sure why)
        priceInput.ReadOnly = True
        amtInput.ReadOnly = True

        editingEnabled = False
    End Sub

    Private Sub ResetPage()
        nameInput.BackColor = Nothing
        descInput.BackColor = Nothing
        priceInput.BackColor = Nothing
        amtInput.BackColor = Nothing

        saveSuccess = True
    End Sub

    Private Function IsNotEmpty(str As String) As Boolean
        Return Not String.IsNullOrEmpty(str)
    End Function

    Private Function HasErrors(Optional report As Boolean = False) As Boolean
        If IsNotEmpty(Access.Exception) Then
            If report = True Then
                MsgBox(Access.Exception, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "DB Error")
            End If
            Return True
        Else
            Return False
        End If
    End Function

    '' \\\\\\\\\\\\\\\\\\\\\\\\\ validation functions //////////////////////// ''
    Private Sub ValidateAll()
        nameInputValidate()
        descInputValidate()
        priceInputValidate()
        amtInputValidate()

        allValid = nameInputValid And descInputValid And priceInputValid And
            amtInputValid And imageValid
    End Sub

    Private Sub nameInputValidate()
        If String.IsNullOrEmpty(nameInput.Text) Then
            nameInputValid = False
            nameInput.BackColor = errorColor
        Else
            nameInputValid = True
            nameInput.BackColor = validColor
        End If
    End Sub

    Private Sub descInputValidate()
        If String.IsNullOrEmpty(descInput.Text) Then
            descInputValid = False
            descInput.BackColor = errorColor
        Else
            descInputValid = True
            descInput.BackColor = validColor
        End If
    End Sub

    Private Sub priceInputValidate()
        Dim value As Double

        If String.IsNullOrEmpty(priceInput.Text) Then
            priceInputValid = False
            priceInput.BackColor = errorColor
        ElseIf Not Double.TryParse(priceInput.Text, value) Then
            priceInputValid = False
            priceInput.BackColor = errorColor
        ElseIf Not (value > 0 And value < 100) Then
            priceInputValid = False
            priceInput.BackColor = errorColor
        Else
            priceInputValid = True
            priceInput.BackColor = validColor
        End If
    End Sub

    Private Sub amtInputValidate()
        Dim value As Integer

        If String.IsNullOrEmpty(amtInput.Text) Then
            amtInputValid = False
            amtInput.BackColor = errorColor
            Exit Sub
        ElseIf Not Integer.TryParse(amtInput.Text, value) Then
            amtInputValid = False
            amtInput.BackColor = errorColor
            Exit Sub
        ElseIf Not (value > 0 And value <= 20) Then
            amtInputValid = False
            amtInput.BackColor = errorColor
            Exit Sub
        Else
            amtInputValid = True
            amtInput.BackColor = validColor
        End If
    End Sub
End Class