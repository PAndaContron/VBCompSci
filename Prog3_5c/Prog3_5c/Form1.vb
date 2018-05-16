Public Class Form1
    Private Sub mnuAssoc_Click(sender As Object, e As EventArgs) Handles mnuAssoc.Click
        lblProperty.Text = "(a + b) + c = a + (b + c)"
    End Sub

    Private Sub mnuComm_Click(sender As Object, e As EventArgs) Handles mnuComm.Click
        lblProperty.Text = "a + b = b + a"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAssoc.Click
        lblProperty.Text = "(a + b) + c = a + (b + c)"
    End Sub

    Private Sub btnComm_Click(sender As Object, e As EventArgs) Handles btnComm.Click
        lblProperty.Text = "a + b = b + a"
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub
End Class
