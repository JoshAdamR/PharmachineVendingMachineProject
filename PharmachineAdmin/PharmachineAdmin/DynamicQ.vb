Public Class DynamicQ
    Private Access As New DBController

    ''\\\\\\\\\\\\\\\\\\\\\\\\ section of handling control events ///////////////////////''
    Private Sub DynamicQ_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadTables()
        DynamicSearch("")
    End Sub

    Private Sub listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbox.SelectedIndexChanged
        dgv.Columns.Clear()
        LoadCols()
        DynamicSearch("")
    End Sub

    Private Sub searchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles searchBar.KeyUp
        DynamicSearch(searchBar.Text)
    End Sub

    ''\\\\\\\\\\\\\\\\\\\\\\\\ DB Related functions ///////////////////////''
    Private Sub LoadTables()
        ' clear list every time to prevent duplicates
        listbox.Items.Clear()

        For Each tName As String In Access.GetTables
            listbox.Items.Add(tName)
        Next

        ' if there are any items, select the first one
        If listbox.Items.Count > 0 Then listbox.SelectedIndex = 0
    End Sub

    Private Sub LoadCols()
        ' clear cbBox to avoid duplicates everytime populated
        cbBox.Items.Clear()

        For Each cName As String In Access.GetTableCols(listbox.Text)
            cbBox.Items.Add(cName)
        Next

        ' if any items then select first
        If cbBox.Items.Count > 0 Then cbBox.SelectedIndex = 0
    End Sub

    Private Sub DynamicSearch(searchValue As String)
        Access.AddParams("@value", "%" & searchValue & "%")

        Dim query As String = String.Format("SELECT * " &
                                            "FROM {0} " &
                                            "WHERE {1} LIKE @value",
                                            listbox.Text, cbBox.Text)

        Access.RunQuery(query)

        ' if db errors abort report
        If HasErrors(True) Then Exit Sub

        dgv.DataSource = Access.DataTable
    End Sub

    ''\\\\\\\\\\\\\\\\\\\\\\\\ Other functions ///////////////////////''
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