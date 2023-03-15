Public Class AdminForm
    Private Access As New DBController

    ''\\\\\\\\\\\\\\\\\\\\\\\\ section of handling control events ///////////////////////''
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshPage()
    End Sub

    Private Sub AdminForm_Close(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm.Show()
    End Sub

    Private Sub msItemNew_Click(sender As Object, e As EventArgs) Handles msItemNew.Click
        ' display window to add new item
        NewProduct.ShowDialog()
    End Sub

    Private Sub msItemDynamicQ_Click(sender As Object, e As EventArgs) Handles msItemDynamicQ.Click
        DynamicQ.Show()
    End Sub
    Private Sub msItemExit_Click(sender As Object, e As EventArgs) Handles msItemExit.Click
        Close()
    End Sub

    Private Sub msItemEdit_Click(sender As Object, e As EventArgs) Handles msItemEdit.Click
        EditProduct.ShowDialog()
    End Sub

    Private Sub msItemDelete_Click(sender As Object, e As EventArgs) Handles msItemDelete.Click
        DeleteProduct()
    End Sub

    Private Sub msItemAbout_Click(sender As Object, e As EventArgs) Handles msItemAbout.Click
        AboutPharmachine.Show()
    End Sub

    Private Sub deleteCtxItem_Click(sender As Object, e As EventArgs) Handles deleteCtxItem.Click
        DeleteProduct()
    End Sub

    Private Sub msItemDeleteAll_Click(sender As Object, e As EventArgs) Handles msItemDeleteAll.Click
        DeleteAllProducts()
        If dgv.RowCount < 1 Then
            imgDisplay.Image = Nothing
            idLabel.Text = Nothing
            nameLabel.Text = Nothing
            descTextbox.Text = Nothing
        End If
    End Sub

    Private Sub dgv_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseUp
        ' make sure is right click
        If e.Button = MouseButtons.Right Then
            dgv.Rows(e.RowIndex).Selected = True ' this is to show the selected one
            SelectProduct(dgv.Item(1, e.RowIndex).Value) ' select
            dgvCtxMenu.Show(Cursor.Position) ' position ContextMenu
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        ' prevent from processing index range errors
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        ' select ProductName for Select function
        SelectProduct(dgv.Item(1, e.RowIndex).Value)
    End Sub

    Private Sub cbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBox.SelectedIndexChanged
        ' if the cbBox is not empty then select the first product
        If IsNotEmpty(cbBox.Text) Then SelectProduct(cbBox.Text)
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        SearchProduct()
    End Sub

    ''\\\\\\\\\\\\\\\\\\\\\\\\ DB related functions ///////////////////////''
    Public Sub RefreshPage()
        ' Get all data execpt image in ascending order
        Access.RunQuery("SELECT ID, ProductName, ProductPrice, Amount " &
                        "FROM Products ORDER BY ProductName ASC")
        ' if there are errors Abort and Report
        If HasErrors(True) Then Exit Sub

        ' fill Table and formatting columns
        dgv.DataSource = Access.DataTable
        dgv.Columns(2).DefaultCellStyle.Format = "RM 0.00"

        ' disable delete item button
        ' ensure cannot delete if no items selected
        msItemDelete.Enabled = False

        ' clear ComboBox before populating to prevent duplicates
        cbBox.Items.Clear()
        ' fill ComboBox with username and select first
        For Each Row As DataRow In Access.DataTable.Rows
            cbBox.Items.Add(Row("ProductName"))
        Next
        If Access.RecordCount > 0 Then cbBox.SelectedIndex = 0
    End Sub

    Private Sub DeleteProduct()
        ' confirm user
        If MsgBox("Are you sure you want to delete " & nameLabel.Text & "?",
                  MsgBoxStyle.OkCancel + MsgBoxStyle.Question,
                  "Confirm delete?") = MsgBoxResult.Ok Then
            Access.AddParams("@pid", idLabel.Text)
            Access.RunQuery("DELETE FROM products WHERE id = @pid")

            ' if any errors abort and report else, refresh
            If HasErrors(True) Then Exit Sub
            RefreshPage()
        End If
    End Sub

    Private Sub DeleteAllProducts()
        ' confirm user
        If MsgBox("Are you sure you want to delete all records?",
                  MsgBoxStyle.OkCancel + MsgBoxStyle.Question,
                  "Confirm delete?") = MsgBoxResult.Ok Then
            Access.RunQuery("DELETE FROM products")

            ' if any errors abort and report else, refresh
            If HasErrors(True) Then Exit Sub
            RefreshPage()
        End If
    End Sub

    Private Sub SelectProduct(pName As String)
        Access.AddParams("@pName", pName)
        ' get one row as user will only be able to click one row
        Access.RunQuery("SELECT TOP 1 ID, ProductName, ProductDesc, ProductImage " &
                        "FROM products " &
                        "WHERE ProductName=@pName")

        ' if errors or empty abort and report
        If HasErrors(True) OrElse Access.RecordCount < 1 Then Exit Sub

        ' get information from row and display information
        Dim Row As DataRow = Access.DataTable.Rows(0)

        ' display information
        idLabel.Text = Row("ID")
        nameLabel.Text = Row("ProductName").ToString()
        descTextbox.Text = Row("ProductDesc").ToString()
        cbBox.SelectedItem = Row("ProductName").ToString()

        imgDisplay.Image = RetrieveImageFromDb(Row)

        ' enable delete (as something is selected)
        msItemDelete.Enabled = True
    End Sub

    Private Sub SearchProduct()
        ' general search, characters before and after text will be "optional"
        Access.AddParams("@pName", "%" & searchBar.Text & "%")

        Access.RunQuery("SELECT ID, ProductName, ProductPrice, Amount FROM products " &
                        "WHERE ProductName LIKE @pName")

        ' if any errors abort and report, else update table
        If HasErrors(True) Then Exit Sub
        dgv.DataSource = Access.DataTable
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\\\\\ other functions ///////////////////////''
    Private Function RetrieveImageFromDb(imgFromDb As DataRow) As Image
        Using memStream As New IO.MemoryStream(DirectCast(imgFromDb("ProductImage"), Byte()))
            Return Image.FromStream(memStream)
        End Using
    End Function

    ' Sub to check if a String is empty
    Private Function IsNotEmpty(str As String) As Boolean
        Return Not String.IsNullOrEmpty(str)
    End Function

    ' Sub to check if Errors from the DB Query is Present
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
End Class
