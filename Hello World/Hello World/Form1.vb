Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Me.lblGreeting.Text = Int(Me.lblGreeting.Text) + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.lblGreeting.Text = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.lblGreeting.Text = Int(Me.lblGreeting.Text) - 1
    End Sub
End Class
