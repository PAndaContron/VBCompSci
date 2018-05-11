Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intPeople = 1 To 365
            Dim decChance As Decimal = 1
            For intDay = 365 To 366 - intPeople Step -1
                decChance *= intDay / 365
            Next
            decChance = 1 - decChance
            If (intPeople = 1) Then
                lstList.Items.Add(Str(intPeople) + " Person: " + vbTab + Format(Str(decChance), "Percent"))
            Else
                lstList.Items.Add(Str(intPeople) + " People: " + vbTab + Format(Str(decChance), "Percent"))
            End If
        Next
    End Sub
End Class
