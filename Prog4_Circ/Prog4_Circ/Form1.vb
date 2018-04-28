Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblCirc.Text = "Circumference: " + Conversion.Str(6.28 * Val(txtRadius.Text))
        lblArea.Text = "Area: " + Conversion.Str(3.14 * Val(txtRadius.Text) ^ 2)
    End Sub
End Class
