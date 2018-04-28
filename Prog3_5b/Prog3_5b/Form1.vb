Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAssoc.Click
        lblProperty.Text = "(a + b) + c = a + (b + c)"
    End Sub

    Private Sub btnComm_Click(sender As Object, e As EventArgs) Handles btnComm.Click
        lblProperty.Text = "a + b = b + a"
    End Sub
End Class
