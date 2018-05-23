Public Class Form1
    Dim boxes(10, 18) As PictureBox

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "s"
                Debug.Print("Straight down")
            Case "a"
                Debug.Print("Am going left")
            Case "d"
                Debug.Print("Droite")
            Case " "
                Debug.Print("Spin me round and round")
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intX As Integer = 1 To 10
            For intY As Integer = 1 To 18
                boxes(intX, intY) = New PictureBox
                boxes(intX, intY).Size = New Point(50, 50)
                boxes(intX, intY).BorderStyle = BorderStyle.FixedSingle
                boxes(intX, intY).BackColor = Color.White
                boxes(intX, intY).Location = New Point(50 * (intX - 1), 50 * (intY - 1))
                Me.Controls.Add(boxes(intX, intY))
            Next
        Next
    End Sub
End Class
