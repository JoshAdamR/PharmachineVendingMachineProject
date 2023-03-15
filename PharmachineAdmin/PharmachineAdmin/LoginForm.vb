Public Class LoginForm
    Private username As String = "__admin__"
    Private password As String = "__admin__"

    Private Sub LoginForm_Hidden(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        nameInput.Text = ""
        pwdInput.Text = ""
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If nameInput.Text = username And pwdInput.Text = password Then
            AdminForm.Show()
            Hide()
        Else
            MsgBox("Wrong password or username", MsgBoxStyle.Exclamation, "Incorrect Information")
        End If
    End Sub
End Class