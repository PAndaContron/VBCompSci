Public Class Form1
    Private Sub mnuTopLeft_Click(sender As Object, e As EventArgs) Handles mnuTopLeft.Click
        lblHere.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub mnuTopCenter_Click(sender As Object, e As EventArgs) Handles mnuTopCenter.Click
        lblHere.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub mnuTopRight_Click(sender As Object, e As EventArgs) Handles mnuTopRight.Click
        lblHere.TextAlign = ContentAlignment.TopRight
    End Sub

    Private Sub mnuMidLeft_Click(sender As Object, e As EventArgs) Handles mnuMidLeft.Click
        lblHere.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub mnuMidCenter_Click(sender As Object, e As EventArgs) Handles mnuMidCenter.Click
        lblHere.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub mnuMidRight_Click(sender As Object, e As EventArgs) Handles mnuMidRight.Click
        lblHere.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub mnuBotLeft_Click(sender As Object, e As EventArgs) Handles mnuBotLeft.Click
        lblHere.TextAlign = ContentAlignment.BottomLeft
    End Sub

    Private Sub mnuBotCenter_Click(sender As Object, e As EventArgs) Handles mnuBotCenter.Click
        lblHere.TextAlign = ContentAlignment.BottomCenter
    End Sub

    Private Sub mnuBotRight_Click(sender As Object, e As EventArgs) Handles mnuBotRight.Click
        lblHere.TextAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub
End Class
