Public Class Form1
    Private Sub txtMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtMinutes.TextChanged, radTime.CheckedChanged, radSeconds.CheckedChanged
        If txtMinutes.Text <> "" Then
            If radSeconds.Checked Then
                lblAnswer.Text = 60 * Val(txtMinutes.Text)
            ElseIf radTime.Checked Then
                lblAnswer.Text = txtMinutes.Text \ 60 & ":" & Str(txtMinutes.Text Mod 60).Substring(1).PadLeft(2, "0")
                Debug.Print(Str(txtMinutes.Text Mod 60).PadLeft(2, "0"))
            End If
        End If
    End Sub
End Class
