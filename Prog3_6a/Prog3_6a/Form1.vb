Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        lblHello.Text = "Hello!"
    End Sub

    Private Sub btnBye_Click(sender As Object, e As EventArgs) Handles btnBye.Click
        lblHello.Text = "Good-bye!"
    End Sub
End Class
