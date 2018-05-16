Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCoins.Click
        Dim intChange As Integer = Val(txtChange.Text)
        lblQuarter.Text = "Quarters: " + Str(intChange \ 25)
        lblDime.Text = "Dimes: " + Str((intChange Mod 25) \ 10)
        lblNickel.Text = "Nickels: " + Str((intChange Mod 25 Mod 10) \ 5)
        lblPennies.Text = "Pennies: " + Str(intChange Mod 5)
    End Sub
End Class
