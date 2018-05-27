Public Class Form1
    Dim grdBoard As Grid

    Const I As Integer = 0
    Const O As Integer = 1
    Const T As Integer = 2
    Const L As Integer = 3
    Const J As Integer = 4
    Const S As Integer = 5
    Const Z As Integer = 6

    ReadOnly DOWN As Point = New Point(0, 1)
    Shadows ReadOnly LEFT As Point = New Point(-1, 0)
    Shadows ReadOnly RIGHT As Point = New Point(1, 0)

    Dim intScore As Integer = 0

    Dim pceCurrent As Piece

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                While pceCurrent.CanMove(DOWN)
                    pceCurrent.Move(DOWN)
                End While
                pceCurrent.blnCanMove = False
                pceCurrent.ResetShadow()
            Case Keys.Left
                pceCurrent.Move(LEFT)
            Case Keys.Right
                pceCurrent.Move(RIGHT)
            Case Keys.Z
                pceCurrent.RotateCounterClockwise()
            Case Keys.X
                pceCurrent.RotateClockwise()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Music, AudioPlayMode.BackgroundLoop)
        lblScore.Text = "SCORE" + vbNewLine + Str(intScore)
        grdBoard = New Grid(10, 18, 30, 30, Color.White)
        For intX As Integer = 0 To 9
            For intY As Integer = 0 To 17
                Me.Controls.Add(grdBoard.picGrid(intX, intY))
            Next
        Next
        pceCurrent = NewPiece()
        tmrMain.Start()
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        pceCurrent.Move(DOWN)
        If Not pceCurrent.CanMove(DOWN) Then
            pceCurrent.ResetShadow()
            intScore += grdBoard.ScoreRows()
            lblLevel.Text = If(intScore < 16000, "LEVEL" + Str(Math.Floor(intScore / 1000) + 1), "LEVEL16")
            tmrMain.Interval = 1060 - 60 * Val(lblLevel.Text.Substring(5))
            lblScore.Text = "SCORE" + vbNewLine + Str(intScore)
            pceCurrent = NewPiece()
            If pceCurrent.blnLose Then
                tmrMain.Stop()
                MsgBox("You Lose!" + vbNewLine + "Score: " + Str(intScore))
                End
            End If
        End If
    End Sub

    Private Function NewPiece() As Piece
        Dim rand As Random = New Random()
        Select Case Math.Floor(rand.NextDouble * 7)
            Case I
                Return New I(grdBoard)
            Case O
                Return New O(grdBoard)
            Case T
                Return New T(grdBoard)
            Case L
                Return New L(grdBoard)
            Case J
                Return New J(grdBoard)
            Case S
                Return New S(grdBoard)
            Case Z
                Return New Z(grdBoard)
        End Select
        Return NewPiece()
    End Function
End Class
