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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MorningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EveningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorning1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorning2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorning3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEvening1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEvening2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEvening3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MorningToolStripMenuItem, Me.EveningToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MorningToolStripMenuItem
        '
        Me.MorningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMorning1, Me.mnuMorning2, Me.mnuMorning3})
        Me.MorningToolStripMenuItem.Name = "MorningToolStripMenuItem"
        Me.MorningToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MorningToolStripMenuItem.Text = "Morning"
        '
        'EveningToolStripMenuItem
        '
        Me.EveningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEvening1, Me.mnuEvening2, Me.mnuEvening3})
        Me.EveningToolStripMenuItem.Name = "EveningToolStripMenuItem"
        Me.EveningToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EveningToolStripMenuItem.Text = "Evening"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuMorning1
        '
        Me.mnuMorning1.Name = "mnuMorning1"
        Me.mnuMorning1.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorning1.Text = "Morning1"
        '
        'mnuMorning2
        '
        Me.mnuMorning2.Name = "mnuMorning2"
        Me.mnuMorning2.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorning2.Text = "Morning2"
        '
        'mnuMorning3
        '
        Me.mnuMorning3.Name = "mnuMorning3"
        Me.mnuMorning3.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorning3.Text = "Morning3"
        '
        'mnuEvening1
        '
        Me.mnuEvening1.Name = "mnuEvening1"
        Me.mnuEvening1.Size = New System.Drawing.Size(152, 22)
        Me.mnuEvening1.Text = "Evening1"
        '
        'mnuEvening2
        '
        Me.mnuEvening2.Name = "mnuEvening2"
        Me.mnuEvening2.Size = New System.Drawing.Size(152, 22)
        Me.mnuEvening2.Text = "Evening2"
        '
        'mnuEvening3
        '
        Me.mnuEvening3.Name = "mnuEvening3"
        Me.mnuEvening3.Size = New System.Drawing.Size(152, 22)
        Me.mnuEvening3.Text = "Evening3"
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Location = New System.Drawing.Point(12, 24)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 13)
        Me.lblGreeting.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Greeting"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents MorningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMorning1 As ToolStripMenuItem
    Friend WithEvents mnuMorning2 As ToolStripMenuItem
    Friend WithEvents mnuMorning3 As ToolStripMenuItem
    Friend WithEvents EveningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEvening1 As ToolStripMenuItem
    Friend WithEvents mnuEvening2 As ToolStripMenuItem
    Friend WithEvents mnuEvening3 As ToolStripMenuItem
    Friend WithEvents lblGreeting As Label
End Class
