Public Class payslipForm1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Bank_ACLabel_Click(sender As Object, e As EventArgs) Handles Bank_ACLabel.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If MsgBox("Are you sure you want to print this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            PrintDialog1.Document = PrintDocument1

            If PrintDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                PrintDocument1.Print()

            End If

        End If
    End Sub
End Class