Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intPeople = 1 To 365
            Dim decChance As Decimal = 1
            For intDay = 365 To 366 - intPeople
                decChance *= intDay / 365
            Next
            decChance = 1 - decChance
            lstList.Items.Add(Str(intPeople) + " People: " & Format(Str(decChance), "Percent"))
        Next
    End Sub
End Class
