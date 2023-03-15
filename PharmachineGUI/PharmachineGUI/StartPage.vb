Public Class StartPage
    '' \\\\\\\\\\\\\\\\\\\\ control events functions ////////////////////// ''
    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        ListPage.Show()
        Hide()
    End Sub

    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        AboutPage.Show()
    End Sub

    Private Sub statsBtn_Click(sender As Object, e As EventArgs) Handles statsBtn.Click
        StatsPage.Show()
        Hide()
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ simple animations ////////////////////// ''
    ' handle simple press animation For button
    Private Sub startBtn_MouseDown(sender As Object, e As EventArgs) Handles startBtn.MouseDown
        startBtn.BackgroundImage = My.Resources.startBtnPressed
    End Sub
    Private Sub startBtn_MouseUp(sender As Object, e As EventArgs) Handles startBtn.MouseUp
        startBtn.BackgroundImage = My.Resources.startBtn
    End Sub

    Private Sub statsBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles statsBtn.MouseUp
        statsBtn.BackgroundImage = My.Resources.statsBtn
    End Sub
    Private Sub statsBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles statsBtn.MouseDown
        statsBtn.BackgroundImage = My.Resources.statsBtnPressed
    End Sub

    Private Sub aboutBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles aboutBtn.MouseUp
        aboutBtn.BackgroundImage = My.Resources.aboutBtn
    End Sub
    Private Sub aboutBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles aboutBtn.MouseDown
        aboutBtn.BackgroundImage = My.Resources.aboutBtnPressed
    End Sub
End Class
