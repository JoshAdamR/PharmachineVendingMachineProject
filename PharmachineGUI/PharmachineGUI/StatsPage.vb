Public Class StatsPage
    Private Access As New DBController

    Private CurrentRecord As Integer = 0
    Private ProductNames As New List(Of String)

    '' \\\\\\\\\\\\\\\\\\\\ control events functions ////////////////////// ''
    Private Sub StatsPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub StatsPage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartPage.Show()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Close()
    End Sub

    Private Sub prevBtn_Click(sender As Object, e As EventArgs) Handles prevBtn.Click
        NavigateRecords(-1)
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        NavigateRecords(1)
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ DB functions ////////////////////// ''
    Private Sub LoadData()
        ' get all available products names
        Access.RunQuery("SELECT DISTINCT productname FROM Stats")

        ' if any errors, abort and report
        If HasErrors(True) Then Exit Sub

        ' if no data, exit stats page
        If Access.RecordCount < 1 Then
            MsgBox("No data available", MsgBoxStyle.Information, "Empty")
            Close()
            Exit Sub
        End If

        ' if any data add to list
        For Each Row As DataRow In Access.DataTable.Rows
            ProductNames.Add(Row("productname"))
        Next

        ShowRecord()
    End Sub

    Private Sub ShowRecord()
        If Access.RecordCount < 1 Then Exit Sub

        Dim Row As DataRow
        ' access names inside list
        Dim pName As String = ProductNames(CurrentRecord)

        ' clear chart before plotting graph
        ClearChart()

        ' find for data from the past 5 days
        Access.AddParams("@pName", pName)
        Access.RunQuery("SELECT TOP 5 purchasedate, amount " &
                        "FROM Stats " &
                        "WHERE productname=@pName " &
                        "ORDER BY purchasedate DESC")

        ' if any errors abort and report
        If HasErrors(True) Then Exit Sub

        ' set name label
        nameLbl.Text = pName

        ' iterate through data and plot points on graph
        For i As Integer = 0 To Access.RecordCount - 1
            Row = Access.DataTable.Rows(i)
            statsChart.Series("Amount").Points.AddXY(Row("purchasedate"), Row("amount"))
        Next
    End Sub

    Private Sub NavigateRecords(value As Integer)
        CurrentRecord += value

        If CurrentRecord < 0 Then
            CurrentRecord = ProductNames.Count - 1
        ElseIf CurrentRecord > ProductNames.Count - 1 Then
            CurrentRecord = 0
        End If

        ShowRecord()
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ other functions ////////////////////// ''
    Private Sub ClearChart()
        statsChart.Series("Amount").Points.Clear()
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

    '' \\\\\\\\\\\\\\\\\\\\ simple animations ////////////////////// ''
    Private Sub backBtn_MouseDown(sender As Object, e As EventArgs) Handles backBtn.MouseDown
        backBtn.BackgroundImage = My.Resources.backBtnPressed
    End Sub
    Private Sub backBtn_MouseUp(sender As Object, e As EventArgs) Handles backBtn.MouseUp
        backBtn.BackgroundImage = My.Resources.backBtn
    End Sub

    Private Sub prevBtn_MouseDown(sender As Object, e As EventArgs) Handles prevBtn.MouseDown
        prevBtn.BackgroundImage = My.Resources.prevBtnPressed
    End Sub
    Private Sub prevtBtn_MouseUp(sender As Object, e As EventArgs) Handles prevBtn.MouseUp
        prevBtn.BackgroundImage = My.Resources.prevBtn
    End Sub

    Private Sub nextBtn_MouseDown(sender As Object, e As EventArgs) Handles nextBtn.MouseDown
        nextBtn.BackgroundImage = My.Resources.nextBtnPressed
    End Sub
    Private Sub nextBtn_MouseUp(sender As Object, e As EventArgs) Handles nextBtn.MouseUp
        nextBtn.BackgroundImage = My.Resources.nextBtn
    End Sub
End Class