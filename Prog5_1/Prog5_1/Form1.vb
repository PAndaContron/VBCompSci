Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If Val(txtNum.Text) < 1 OrElse Val(txtNum.Text) > 99 Then
            lblAnswer.Text = "Invalid number"
        ElseIf Val(txtNum.Text) < 10 Then
            lblAnswer.Text = "One digit"
        Else
            lblAnswer.Text = "Two digits"
        End If
    End Sub
End Class
