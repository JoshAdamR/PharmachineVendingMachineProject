Public Class ListPage
    Private Access As New DBController

    Private NameLabelArr() As Label
    Private PriceLabelArr() As Label
    Private DisplayArr() As PictureBox

    Const Normal = 9
    Private PageNum As Integer = 0

    Private ListController As Integer = 0

    Private RowStart As Integer = 0
    Private RowEnd As Integer = 8

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' initializing array in constructor to avoid errors
        NameLabelArr = New Label() {
            nameLbl0, nameLbl1, nameLbl2,
            nameLbl3, nameLbl4, nameLbl5,
            nameLbl6, nameLbl7, nameLbl8
        }
        PriceLabelArr = New Label() {
            priceLbl0, priceLbl1, priceLbl2,
            priceLbl3, priceLbl4, priceLbl5,
            priceLbl6, priceLbl7, priceLbl8
        }
        DisplayArr = New PictureBox() {
            display0, display1, display2,
            display3, display4, display5,
            display6, display7, display8
        }
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ control events functions ////////////////////// ''
    Private Sub ListPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearDisplays()
        GetProducts()
        NavigateRecords(0)
    End Sub

    Private Sub ListPage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ClearDisplays()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        StartPage.Show()
        Close()
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        NavigateRecords(1)
        GetRecords()
    End Sub

    Private Sub prevBtn_Click(sender As Object, e As EventArgs) Handles prevBtn.Click
        NavigateRecords(-1)
        GetRecords()
    End Sub

    Private Sub Card_Clicked(sender As Object, e As EventArgs) Handles display0.Click, display1.Click, display2.Click, display3.Click, display4.Click, display5.Click, display6.Click, display7.Click, display8.Click
        Dim displayList As New List(Of PictureBox)(DisplayArr)
        Dim pName As String = NameLabelArr(displayList.IndexOf(sender)).Text

        If DirectCast(sender, PictureBox).Image IsNot Nothing Then
            Access.AddParams("@pName", pName)
            Access.RunQuery("SELECT Amount FROM Products " &
                            "WHERE ProductName=@pName")

            If HasErrors(True) Then Exit Sub

            Dim Row As DataRow = Access.DataTable.Rows(0)

            If Row("Amount") > 0 Then
                DetailsPage.LoadProductDetails(pName)
                DetailsPage.Show()
                Close()
            Else
                MsgBox("Item out of stock", MsgBoxStyle.Information, "No Stock")
                GetProducts()
            End If
        End If
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ DB Functions ////////////////////// ''
    Private Sub GetProducts()
        ' get all products name price and image to display
        Access.RunQuery("SELECT ProductName, ProductPrice, ProductImage " &
                        "FROM products " &
                        "ORDER BY ProductName ASC")

        ' if any errors or no records found abort and or report
        If HasErrors(True) Then
            Exit Sub
        ElseIf Access.RecordCount < 1 Then
            MsgBox("No Items found", MsgBoxStyle.Information, "No items")
            Exit Sub
        End If

        GetRecords()
    End Sub

    Private Sub GetRecords()
        If Access.RecordCount < 1 Then Exit Sub

        If Access.RecordCount < RowEnd Then
            RowEnd = Access.RecordCount - 1
        End If

        ' display
        For i As Integer = RowStart To RowEnd
            Dim ListIndex As Integer = i

            ' rows can go above 8
            Dim Row As DataRow = Access.DataTable.Rows(i)

            ' normalize index for accessing displays
            ListIndex -= ListController

            ' displays end at 8
            NameLabelArr(ListIndex).Text = Row("ProductName").ToString
            PriceLabelArr(ListIndex).Text = Format(Row("ProductPrice"), "RM 0.00")
            DisplayArr(ListIndex).Image = RetrieveImageFromDb(Row)
        Next i
    End Sub

    Private Sub NavigateRecords(value As Integer)
        If Access.RecordCount > 9 Then
            PageNum += value

            ListController = Normal * PageNum

            RowStart = 0 + ListController
            RowEnd = 8 + ListController

            If RowStart <= 0 Then
                prevBtn.Visible = False
            Else
                prevBtn.Visible = True
            End If

            If RowEnd >= Access.RecordCount Then
                nextBtn.Visible = False
                ClearDisplays()
            Else
                nextBtn.Visible = True
            End If
        Else
            nextBtn.Visible = False
            prevBtn.Visible = False
        End If
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ Other functions ////////////////////// ''
    Private Sub ClearDisplays()
        For Each lbl As Label In NameLabelArr
            lbl.Text = ""
        Next

        For Each lbl As Label In PriceLabelArr
            lbl.Text = ""
        Next

        For Each img As PictureBox In DisplayArr
            img.Image = Nothing
        Next
    End Sub

    Private Function RetrieveImageFromDb(imgFromDb As DataRow) As Image
        Using memStream As New IO.MemoryStream(DirectCast(imgFromDb("ProductImage"), Byte()))
            Return Image.FromStream(memStream)
        End Using
    End Function

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

    '' \\\\\\\\\\\\\\\\\\\\ simple animations ////////////////////// ''
    ' handle simple animation for next arrow button
    Private Sub nextBtn_MouseDown(sender As Object, e As EventArgs) Handles nextBtn.MouseDown
        nextBtn.BackgroundImage = My.Resources.nextBtnPressed
    End Sub
    Private Sub nextBtn_MouseUp(sender As Object, e As EventArgs) Handles nextBtn.MouseUp
        nextBtn.BackgroundImage = My.Resources.nextBtn
    End Sub

    ' handle simple animation for prev arrow button 
    Private Sub prevBtn_MouseDown(sender As Object, e As EventArgs) Handles prevBtn.MouseDown
        prevBtn.BackgroundImage = My.Resources.prevBtnPressed
    End Sub
    Private Sub prevBtn_MouseUp(sender As Object, e As EventArgs) Handles prevBtn.MouseUp
        prevBtn.BackgroundImage = My.Resources.prevBtn
    End Sub

    ' handle simple animation for back btn
    Private Sub backBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles backBtn.MouseDown
        backBtn.BackgroundImage = My.Resources.backBtnPressed
    End Sub
    Private Sub backBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles backBtn.MouseUp
        backBtn.BackgroundImage = My.Resources.backBtn
    End Sub
End Class