<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMidLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMidCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMidRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBotLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBotCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBotRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHere = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProg, Me.mnuPos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProg
        '
        Me.mnuProg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuProg.Name = "mnuProg"
        Me.mnuProg.Size = New System.Drawing.Size(65, 20)
        Me.mnuProg.Text = "Program"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuPos
        '
        Me.mnuPos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTop, Me.mnuMid, Me.mnuBot})
        Me.mnuPos.Name = "mnuPos"
        Me.mnuPos.Size = New System.Drawing.Size(62, 20)
        Me.mnuPos.Text = "Position"
        '
        'mnuTop
        '
        Me.mnuTop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopLeft, Me.mnuTopCenter, Me.mnuTopRight})
        Me.mnuTop.Name = "mnuTop"
        Me.mnuTop.Size = New System.Drawing.Size(152, 22)
        Me.mnuTop.Text = "Top"
        '
        'mnuTopLeft
        '
        Me.mnuTopLeft.Name = "mnuTopLeft"
        Me.mnuTopLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopLeft.Text = "Left"
        '
        'mnuTopCenter
        '
        Me.mnuTopCenter.Name = "mnuTopCenter"
        Me.mnuTopCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopCenter.Text = "Center"
        '
        'mnuTopRight
        '
        Me.mnuTopRight.Name = "mnuTopRight"
        Me.mnuTopRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopRight.Text = "Right"
        '
        'mnuMid
        '
        Me.mnuMid.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMidLeft, Me.mnuMidCenter, Me.mnuMidRight})
        Me.mnuMid.Name = "mnuMid"
        Me.mnuMid.Size = New System.Drawing.Size(152, 22)
        Me.mnuMid.Text = "Middle"
        '
        'mnuMidLeft
        '
        Me.mnuMidLeft.Name = "mnuMidLeft"
        Me.mnuMidLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuMidLeft.Text = "Left"
        '
        'mnuMidCenter
        '
        Me.mnuMidCenter.Name = "mnuMidCenter"
        Me.mnuMidCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuMidCenter.Text = "Center"
        '
        'mnuMidRight
        '
        Me.mnuMidRight.Name = "mnuMidRight"
        Me.mnuMidRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuMidRight.Text = "Right"
        '
        'mnuBot
        '
        Me.mnuBot.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBotLeft, Me.mnuBotCenter, Me.mnuBotRight})
        Me.mnuBot.Name = "mnuBot"
        Me.mnuBot.Size = New System.Drawing.Size(152, 22)
        Me.mnuBot.Text = "Bottom"
        '
        'mnuBotLeft
        '
        Me.mnuBotLeft.Name = "mnuBotLeft"
        Me.mnuBotLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuBotLeft.Text = "Left"
        '
        'mnuBotCenter
        '
        Me.mnuBotCenter.Name = "mnuBotCenter"
        Me.mnuBotCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuBotCenter.Text = "Center"
        '
        'mnuBotRight
        '
        Me.mnuBotRight.Name = "mnuBotRight"
        Me.mnuBotRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuBotRight.Text = "Right"
        '
        'lblHere
        '
        Me.lblHere.Location = New System.Drawing.Point(12, 24)
        Me.lblHere.Name = "lblHere"
        Me.lblHere.Size = New System.Drawing.Size(260, 228)
        Me.lblHere.TabIndex = 1
        Me.lblHere.Text = "HERE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblHere)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProg As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuPos As ToolStripMenuItem
    Friend WithEvents mnuTop As ToolStripMenuItem
    Friend WithEvents mnuTopLeft As ToolStripMenuItem
    Friend WithEvents mnuTopCenter As ToolStripMenuItem
    Friend WithEvents mnuTopRight As ToolStripMenuItem
    Friend WithEvents mnuMid As ToolStripMenuItem
    Friend WithEvents mnuMidLeft As ToolStripMenuItem
    Friend WithEvents mnuMidCenter As ToolStripMenuItem
    Friend WithEvents mnuMidRight As ToolStripMenuItem
    Friend WithEvents mnuBot As ToolStripMenuItem
    Friend WithEvents mnuBotLeft As ToolStripMenuItem
    Friend WithEvents mnuBotCenter As ToolStripMenuItem
    Friend WithEvents mnuBotRight As ToolStripMenuItem
    Friend WithEvents lblHere As Label
End Class
