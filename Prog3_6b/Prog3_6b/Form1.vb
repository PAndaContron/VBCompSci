﻿Public Class Form1
    Private Sub mnuHello_Click(sender As Object, e As EventArgs) Handles mnuHello.Click
        lblHello.Text = "Hello!"
    End Sub

    Private Sub mnuBye_Click(sender As Object, e As EventArgs) Handles mnuBye.Click
        lblHello.Text = "Good-bye!"
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        lblHello.Text = "Hello!"
    End Sub

    Private Sub btnGoodbye_Click(sender As Object, e As EventArgs) Handles btnGoodbye.Click
        lblHello.Text = "Good-bye!"
    End Sub
End Class
