Public Class Form1
    Dim boxes(10, 18) As PictureBox

    Const NONE As Integer = 0
    Const I As Integer = 1
    Const T As Integer = 2
    Const O As Integer = 3
    Const L As Integer = 4
    Const J As Integer = 5
    Const S As Integer = 6
    Const Z As Integer = 7
    Dim intCurrentBox As Integer = NONE

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                Debug.Print("Straight down")
            Case Keys.Left
                Debug.Print("Am going left")
            Case Keys.Right
                Debug.Print("Droite")
            Case Keys.Space
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
        tmrMain.Start()
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        Select Case intCurrentBox
            Case NONE
                Debug.Print("Tick")
            Case I

            Case T

            Case O

            Case L

            Case J

            Case S

            Case Z

        End Select
    End Sub
End Class
