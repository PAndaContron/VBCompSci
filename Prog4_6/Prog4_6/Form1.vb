Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblAverage.Text = "Average:" + vbTab + Str((Val(txtJump1.Text) + Val(txtJump2.Text) + Val(txtJump3.Text) + Val(txtJump4.Text)) / 4)
    End Sub
End Class
