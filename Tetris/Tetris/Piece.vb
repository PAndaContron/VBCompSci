Imports Microsoft.VisualBasic

Public MustInherit Class Piece
    Public pntPoints(3) As Point
    Protected clrPieceColor As Color
    Public intOrientation As Integer = 0
    Protected grdBoard As Grid
    Public blnLose As Boolean = False
    Public blnCanMove As Boolean = True

    Public Sub New(ByRef grd As Grid, ByVal pnt1 As Point, ByVal pnt2 As Point, ByVal pnt3 As Point, ByVal pnt4 As Point)
        grdBoard = grd
        pntPoints(0) = pnt1
        pntPoints(1) = pnt2
        pntPoints(2) = pnt3
        pntPoints(3) = pnt4
        For Each pnt In pntPoints
            If Not IsFree(pnt) Then
                blnLose = True
            End If
        Next
    End Sub

    Protected Function IsFree(ByVal intX As Integer, ByVal intY As Integer) As Boolean
        Return grdBoard.WithinBoundsNoTop(intX, intY) AndAlso ((Not grdBoard.WithinTop(intX, intY)) OrElse grdBoard.GetColor(intX, intY) = Color.White OrElse grdBoard.GetColor(intX, intY) = Color.LightGray)
    End Function

    Protected Function IsFree(ByVal pnt As Point) As Boolean
        Return grdBoard.WithinBoundsNoTop(pnt) AndAlso ((Not grdBoard.WithinTop(pnt)) OrElse grdBoard.GetColor(pnt) = Color.White OrElse grdBoard.GetColor(pnt) = Color.LightGray)
    End Function

    Protected Sub DrawTiles()
        For Each pnt In pntPoints
            If grdBoard.WithinBounds(pnt) Then
                grdBoard.SetColor(pnt, clrPieceColor)
            End If
            For intY As Integer = pnt.Y + 1 To 17
                If IsFree(pnt.X, intY) Then
                    grdBoard.SetColor(pnt.X, intY, Color.LightGray)
                Else
                    Exit For
                End If
            Next
        Next
    End Sub

    Protected Sub ResetTiles()
        For Each pnt In pntPoints
            If grdBoard.WithinBounds(pnt) Then
                grdBoard.ResetColor(pnt)
            End If
            ResetShadow()
        Next
    End Sub

    Public Sub ResetShadow()
        For Each pnt In pntPoints
            For intY As Integer = pnt.Y + 1 To 17
                If IsFree(pnt.X, intY) Then
                    grdBoard.SetColor(pnt.X, intY, Color.White)
                End If
            Next
        Next
    End Sub

    Public Sub Move(ByVal pntVect As Point)
        If CanMove(pntVect) Then
            ResetTiles()
            For intI As Integer = 0 To 3
                pntPoints(intI) += pntVect
            Next
            DrawTiles()
        End If
    End Sub

    Public Function CanMove(ByVal pntVect As Point) As Boolean
        Dim blnOut As Boolean = blnCanMove
        For Each pnt In pntPoints
            Dim pntNext = pnt + pntVect
            blnOut = blnOut AndAlso grdBoard.WithinBoundsNoTop(pntNext) AndAlso (IsFree(pntNext) OrElse pntPoints.Contains(pntNext))
        Next
        Return blnOut
    End Function

    Public MustOverride Sub RotateClockwise()
    Public MustOverride Sub RotateCounterClockwise()
End Class

Public Class O
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(4, 0), New Point(5, 0), New Point(4, 1), New Point(5, 1))
        clrPieceColor = Color.Orange
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
    End Sub
End Class

Public Class I
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(3, 0), New Point(4, 0), New Point(5, 0), New Point(6, 0))
        clrPieceColor = Color.Blue
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, -2)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -2)
                    pntPoints(1) = pntPoints(2) + New Point(0, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-2, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-2, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, -2)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -2)
                    pntPoints(1) = pntPoints(2) + New Point(0, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-2, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-2, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub
End Class

Public Class T
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(5, 1), New Point(4, 0), New Point(5, 0), New Point(6, 0))
        clrPieceColor = Color.Yellow
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(3) = pntPoints(2) + New Point(0, -1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(1, 0)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(1) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(0, 1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(1) = pntPoints(2) + New Point(0, -1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(0, 1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                End If
        End Select
        DrawTiles()
    End Sub
End Class

Public Class L
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(4, 1), New Point(4, 0), New Point(5, 0), New Point(6, 0))
        clrPieceColor = Color.Cyan
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(-1, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, -1)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, -1)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, 1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-1, 1)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, 1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-1, 1)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(-1, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, -1)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, -1)
                End If
        End Select
        DrawTiles()
    End Sub
End Class

Public Class J
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(4, 0), New Point(4, 1), New Point(5, 1), New Point(6, 1))
        clrPieceColor = Color.Purple
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 1)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 1)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(-1, 1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-1, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(-1, 1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 3
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(-1, 1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-1, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(-1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
            Case 2
                If IsFree(pntPoints(2) + New Point(0, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, -1)) AndAlso IsFree(pntPoints(2) + New Point(0, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(0, -1)
                    pntPoints(1) = pntPoints(2) + New Point(1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(0, 1)
                End If
            Case 3
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 1)) Then
                    ResetTiles()
                    intOrientation = 2
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(1) = pntPoints(2) + New Point(1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 1)
                End If
        End Select
        DrawTiles()
    End Sub
End Class

Public Class S
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(5, 0), New Point(4, 0), New Point(4, 1), New Point(3, 1))
        clrPieceColor = Color.Lime
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(1, 0)) AndAlso IsFree(pntPoints(2) + New Point(1, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(1, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(1, -1)) AndAlso IsFree(pntPoints(2) + New Point(-1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(-1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        RotateClockwise()
    End Sub
End Class

Public Class Z
    Inherits Piece

    Public Sub New(ByRef grd As Grid)
        MyBase.New(grd, New Point(3, 0), New Point(4, 0), New Point(4, 1), New Point(5, 1))
        clrPieceColor = Color.Red
        DrawTiles()
    End Sub

    Public Overrides Sub RotateClockwise()
        Select Case intOrientation
            Case 0
                If IsFree(pntPoints(2) + New Point(-1, 0)) AndAlso IsFree(pntPoints(2) + New Point(-1, 1)) Then
                    ResetTiles()
                    intOrientation = 1
                    pntPoints(0) = pntPoints(2) + New Point(-1, 0)
                    pntPoints(3) = pntPoints(2) + New Point(-1, 1)
                End If
            Case 1
                If IsFree(pntPoints(2) + New Point(-1, -1)) AndAlso IsFree(pntPoints(2) + New Point(1, 0)) Then
                    ResetTiles()
                    intOrientation = 0
                    pntPoints(0) = pntPoints(2) + New Point(-1, -1)
                    pntPoints(3) = pntPoints(2) + New Point(1, 0)
                End If
        End Select
        DrawTiles()
    End Sub

    Public Overrides Sub RotateCounterClockwise()
        RotateClockwise()
    End Sub
End Class
