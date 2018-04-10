Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub Morning1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMorning1.Click
        lblGreeting.Text = "Good morning"
    End Sub

    Private Sub mnuMorning2_Click(sender As Object, e As EventArgs) Handles mnuMorning2.Click
        lblGreeting.Text = "Better morning"
    End Sub

    Private Sub mnuMorning3_Click(sender As Object, e As EventArgs) Handles mnuMorning3.Click
        lblGreeting.Text = "Best morning"
    End Sub

    Private Sub mnuEvening1_Click(sender As Object, e As EventArgs) Handles mnuEvening1.Click
        lblGreeting.Text = "Good evening"
    End Sub

    Private Sub mnuEvening2_Click(sender As Object, e As EventArgs) Handles mnuEvening2.Click
        lblGreeting.Text = "Better evening"
    End Sub

    Private Sub mnuEvening3_Click(sender As Object, e As EventArgs) Handles mnuEvening3.Click
        lblGreeting.Text = "Best evening"
    End Sub
End Class
