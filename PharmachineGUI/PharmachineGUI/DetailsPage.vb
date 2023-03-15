Public Class DetailsPage
    Private Access As New DBController

    '' \\\\\\\\\\\\\\\\\\\\ Control event functions////////////////////// ''
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ListPage.Show()
        Close()
    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        CheckoutPage.LoadProductDetails(nameLabel.Text)
        CheckoutPage.Show()
        Close()
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ DB Related functions////////////////////// ''
    Public Sub LoadProductDetails(pName As String)
        Access.AddParams("@pName", pName)

        Access.RunQuery("SELECT ProductName, ProductDesc, ProductPrice, ProductImage " &
                        "FROM Products " &
                        "WHERE ProductName=@pName")

        If HasErrors(True) Then Exit Sub

        Dim Row As DataRow = Access.DataTable.Rows(0)

        nameLabel.Text = Row("ProductName")
        priceLabel.Text = Format(Row("ProductPrice"), "RM 0.00")
        descBox.Text = Row("ProductDesc")
        imgDisplay.Image = RetrieveImageFromDb(Row)
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ Other functions////////////////////// ''
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
    ' simple pressing animation for back button
    Private Sub backBtn_MouseDown(sender As Object, e As EventArgs) Handles backBtn.MouseDown
        backBtn.BackgroundImage = My.Resources.backBtnPressed
    End Sub
    Private Sub backBtn_MouseUp(sender As Object, e As EventArgs) Handles backBtn.MouseUp
        backBtn.BackgroundImage = My.Resources.backBtn
    End Sub

    ' simple pressing animation for buy btn
    Private Sub buyBtn_MouseDown(sender As Object, e As EventArgs) Handles buyBtn.MouseDown
        buyBtn.BackgroundImage = My.Resources.buyBtnPressed
    End Sub
    Private Sub buyBtn_MouseUp(sender As Object, e As EventArgs) Handles buyBtn.MouseUp
        buyBtn.BackgroundImage = My.Resources.buyBtn
    End Sub
End Class