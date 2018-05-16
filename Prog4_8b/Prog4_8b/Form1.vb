Public Class Form1
    Private Sub btnDigits_Click(sender As Object, e As EventArgs) Handles btnDigits.Click
        lblFirst.Text = "The first digit is: " + Str(Val(txtNum.Text) \ 10)
        lblSecond.Text = "The second digit is: " + Str(Val(txtNum.Text) Mod 10)
    End Sub
End Class
