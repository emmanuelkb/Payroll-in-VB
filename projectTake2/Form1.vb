Public Class Form1
    Private Sub staffButton_Click(sender As Object, e As EventArgs) Handles staffButton.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub adminButton_Click(sender As Object, e As EventArgs) Handles adminButton.Click
        AdminLoginForm.Show()
        Me.Hide()
    End Sub
End Class
