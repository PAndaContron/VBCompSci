Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim dblLength As Double = Val(txtLength.Text)
        Dim dblWidth As Double = Val(txtWidth.Text)

        lblArea.Text = "Area = " + Str(dblLength * dblWidth)
        lblPerimeter.Text = "Perimeter = " + Str(2 * (dblLength + dblWidth))
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub
End Class
