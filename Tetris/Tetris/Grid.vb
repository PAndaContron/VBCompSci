Imports Microsoft.VisualBasic

Public Class Grid
    Public ReadOnly picGrid(,) As PictureBox
    Public ReadOnly pntCellDim As Point
    Public ReadOnly clrBack As Color
    Public ReadOnly pntSize As Point

    Public Sub New(ByVal intDimX As Integer, ByVal intDimY As Integer, ByVal intCellWidth As Integer, ByVal intCellHeight As Integer, ByVal clrBackColor As Color)
        pntSize = New Point(intDimX, intDimY)
        Dim picTemp(intDimX, intDimY) As PictureBox
        picGrid = picTemp
        pntCellDim = New Point(intCellWidth, intCellHeight)
        clrBack = clrBackColor
        For intX As Integer = 0 To intDimX - 1
            For intY As Integer = 0 To intDimY - 1
                picGrid(intX, intY) = New PictureBox
                picGrid(intX, intY).Size = New Point(intCellWidth, intCellHeight)
                picGrid(intX, intY).BorderStyle = BorderStyle.FixedSingle
                picGrid(intX, intY).BackColor = clrBack
                picGrid(intX, intY).Location = New Point(316 + intCellWidth * intX, intCellHeight * intY)
            Next
        Next
    End Sub

    Public Sub SetColor(ByVal intX As Integer, ByVal intY As Integer, ByVal clrColor As Color)
        If WithinBounds(intX, intY) Then
            picGrid(intX, intY).BackColor = clrColor
        End If
    End Sub

    Public Sub SetColor(ByVal pnt As Point, ByVal clrColor As Color)
        SetColor(pnt.X, pnt.Y, clrColor)
    End Sub

    Public Sub ResetColor(ByVal intX As Integer, ByVal intY As Integer)
        If WithinBounds(intX, intY) Then
            picGrid(intX, intY).BackColor = clrBack
        End If
    End Sub

    Public Sub ResetColor(ByVal pnt As Point)
        ResetColor(pnt.X, pnt.Y)
    End Sub

    Public Sub MoveRowDown(ByVal intY As Integer)
        For intX As Integer = 0 To pntSize.X - 1
            If (WithinBounds(intX, intY)) Then
                picGrid(intX, intY + 1).BackColor = GetColor(intX, intY)
            Else
                picGrid(intX, intY + 1).BackColor = Color.White
            End If
        Next
    End Sub

    Public Function ScoreRows() As Integer
        Dim intRows As Integer = 0
        For intY As Integer = pntSize.Y - 1 To 0 Step -1
            Dim blnFilled As Boolean = True
            For intX As Integer = 0 To pntSize.X - 1
                blnFilled = blnFilled AndAlso GetColor(intX, intY) <> clrBack
            Next
            If blnFilled Then
                For intRow As Integer = intY - 1 To -1 Step -1
                    MoveRowDown(intRow)
                Next
                intRows += 1
                intY += 1
            End If
        Next
        Return Sum(intRows) * 10
    End Function

    Public Function GetColor(ByVal intX As Integer, ByVal intY As Integer) As Color
        If WithinBounds(intX, intY) Then
            Return picGrid(intX, intY).BackColor
        Else
            Return clrBack
        End If
    End Function

    Public Function GetColor(ByVal pnt As Point) As Color
        Return GetColor(pnt.X, pnt.Y)
    End Function

    Public Function WithinBounds(ByVal intX As Integer, ByVal intY As Integer) As Boolean
        Return intX >= 0 AndAlso intY >= 0 AndAlso intX < pntSize.X AndAlso intY < pntSize.Y
    End Function

    Public Function WithinBounds(ByVal pnt As Point) As Boolean
        Return WithinBounds(pnt.X, pnt.Y)
    End Function

    Public Function WithinBoundsNoTop(ByVal intX As Integer, ByVal intY As Integer) As Boolean
        Return intX >= 0 AndAlso intX < pntSize.X AndAlso intY < pntSize.Y
    End Function

    Public Function WithinBoundsNoTop(ByVal pnt As Point) As Boolean
        Return WithinBoundsNoTop(pnt.X, pnt.Y)
    End Function

    Public Function WithinTop(ByVal intX As Integer, ByVal intY As Integer) As Boolean
        Return intY >= 0
    End Function

    Public Function WithinTop(ByVal pnt As Point) As Boolean
        Return WithinTop(pnt.X, pnt.Y)
    End Function

    Private Function Sum(ByVal intX As Integer) As Integer
        Return If(intX = 0, 0, intX + Sum(intX - 1))
    End Function
End Class
