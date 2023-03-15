Public Class NewProduct
    Private Access As New DBController

    Private errorColor As Color = Color.FromArgb(255, 150, 150)
    Private validColor As Color = Color.FromArgb(150, 255, 150)

    Private nameInputValid As Boolean = False
    Private descInputValid As Boolean = False
    Private priceInputValid As Boolean = False
    Private amtInputValid As Boolean = False
    Private imageValid As Boolean = False

    Private allValid As Boolean = False

    Private saveSuccess As Boolean = True
    Private CheckForDuplicatesError = False

    ' TODO: FIX VALIDATION UX (done)

    '' \\\\\\\\\\\\\\\\\\\\\\\\\ control events functions //////////////////////// ''
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        ' clear everything before closing
        ResetPage()
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If imgDisplay.Image Is Nothing Then
            imageValid = False
        Else
            imageValid = True
        End If

        ValidateAll()

        If allValid Then
            AddProduct()
        Else
            saveSuccess = False
            MsgBox("Make sure ALL information is present and correctly entered",
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete!")
        End If
    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Using fileChooser As New OpenFileDialog
            ' set fiters and title
            fileChooser.Filter = "Image file | *.jpg; *.jpeg; *.png; *.bmp; *.gif"
            fileChooser.Title = "Choose Image"

            fileChooser.ShowDialog()

            Try
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

    '' \\\\\\\\\\\\\\\\\\\\\\\\\ DB related functions //////////////////////// ''
    Private Sub AddProduct()
        ' if there are no duplicates then process
        If CheckForDuplicates() = False Then
            ' using parameters
            Access.AddParams("@pName", nameInput.Text)
            Access.AddParams("@pDesc", descInput.Text)
            Access.AddParams("@pPrice", CDbl(priceInput.Text))
            Access.AddParams("@pImage", ProcessImage())
            Access.AddParams("@pAmt", CInt(amtInput.Text))
            ' run query on DB
            Access.RunQuery("INSERT INTO products(ProductName, ProductDesc, ProductPrice, ProductImage, Amount)" &
                        "VALUES (@pName, @pDesc, @pPrice, @pImage, @pAmt);")

            ' if has errors, abort and report
            If HasErrors(True) Then Exit Sub

            ' if successful, notify and refresh page
            MsgBox("New product saved to database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Saved!")
            AdminForm.RefreshPage()

            ' clear everything before closing
            ResetPage()
            Me.Close()
        Else
            saveSuccess = False
            If Not CheckForDuplicatesError Then
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

        Return Not Access.RecordCount = 0
    End Function

    '' \\\\\\\\\\\\\\\\\\\\\\\\\ other functions //////////////////////// ''
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

    Private Sub ResetPage()
        nameInput.Text = Nothing
        descInput.Text = Nothing
        priceInput.Text = Nothing
        amtInput.Text = Nothing
        imgDisplay.Image = Nothing

        nameInput.BackColor = Nothing
        descInput.BackColor = Nothing
        priceInput.BackColor = Nothing
        amtInput.BackColor = Nothing

        saveSuccess = True
    End Sub

    ' check if any errors on DB query
    Private Function HasErrors(Optional report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
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