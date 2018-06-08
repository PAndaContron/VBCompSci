Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblResult.Text = ""
        Dim intSum As Integer = 0
        For intI As Integer = Val(txtStart.Text) To Val(txtEnd.Text)
            lblResult.Text = lblResult.Text & intI & "+"
            intSum += intI
        Next
        lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length() - 1) + "=" & intSum
    End Sub
End Class
