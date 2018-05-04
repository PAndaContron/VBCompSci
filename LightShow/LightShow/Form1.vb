Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Visible = False

        Dim intCounter As Integer = 0
        Do While (True)
            Select Case intCounter
                Case 0
                    My.Computer.Keyboard.SendKeys("{NUMLOCK}")
                Case 1
                    My.Computer.Keyboard.SendKeys("{CAPSLOCK}")
                Case 2
                    My.Computer.Keyboard.SendKeys("{SCROLLLOCK}")
            End Select
            intCounter = (intCounter + 1) Mod 3
        Loop

    End Sub
End Class
