Public Class Form1

    Dim blnCelsius As Boolean = True

    Private Sub mnuFahrenheit_Click(sender As Object, e As EventArgs) Handles mnuFahrenheit.Click
        blnCelsius = False
        lblPrompt.Text = "Enter the temperature in Celsius:"
        lblAnswer.Text = lblAnswer.Text.Replace("Celsius", "Fahrenheit")
    End Sub

    Private Sub mnuCelsius_Click(sender As Object, e As EventArgs) Handles mnuCelsius.Click
        blnCelsius = True
        lblPrompt.Text = "Enter the temperature in Fahrenheit:"
        lblAnswer.Text = lblAnswer.Text.Replace("Fahrenheit", "Celsius")
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        Dim dblInput As Double = Conversion.Val(txtInput.Text)
        If (blnCelsius) Then
            lblAnswer.Text = "The temperature in Celsius is: " + Conversion.Str((dblInput - 32) * 5 / 9)
        Else
            lblAnswer.Text = "The temperature in Fahrenheit is: " + Conversion.Str((9 / 5 * dblInput) + 32)
        End If
    End Sub
End Class
