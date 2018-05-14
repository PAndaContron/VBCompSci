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
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblJump1 = New System.Windows.Forms.Label()
        Me.lblJump2 = New System.Windows.Forms.Label()
        Me.lblJump3 = New System.Windows.Forms.Label()
        Me.lblJump4 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtJump1 = New System.Windows.Forms.TextBox()
        Me.txtJump2 = New System.Windows.Forms.TextBox()
        Me.txtJump3 = New System.Windows.Forms.TextBox()
        Me.txtJump4 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(247, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblJump1
        '
        Me.lblJump1.AutoSize = True
        Me.lblJump1.Location = New System.Drawing.Point(24, 66)
        Me.lblJump1.Name = "lblJump1"
        Me.lblJump1.Size = New System.Drawing.Size(97, 13)
        Me.lblJump1.TabIndex = 1
        Me.lblJump1.Text = "Length of 1st jump:"
        '
        'lblJump2
        '
        Me.lblJump2.AutoSize = True
        Me.lblJump2.Location = New System.Drawing.Point(24, 95)
        Me.lblJump2.Name = "lblJump2"
        Me.lblJump2.Size = New System.Drawing.Size(101, 13)
        Me.lblJump2.TabIndex = 2
        Me.lblJump2.Text = "Length of 2nd jump:"
        '
        'lblJump3
        '
        Me.lblJump3.AutoSize = True
        Me.lblJump3.Location = New System.Drawing.Point(24, 124)
        Me.lblJump3.Name = "lblJump3"
        Me.lblJump3.Size = New System.Drawing.Size(98, 13)
        Me.lblJump3.TabIndex = 3
        Me.lblJump3.Text = "Length of 3rd jump:"
        '
        'lblJump4
        '
        Me.lblJump4.AutoSize = True
        Me.lblJump4.Location = New System.Drawing.Point(24, 153)
        Me.lblJump4.Name = "lblJump4"
        Me.lblJump4.Size = New System.Drawing.Size(98, 13)
        Me.lblJump4.TabIndex = 4
        Me.lblJump4.Text = "Length of 4th jump:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(24, 226)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 13)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "Average:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(139, 221)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Average"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtJump1
        '
        Me.txtJump1.Location = New System.Drawing.Point(155, 63)
        Me.txtJump1.Name = "txtJump1"
        Me.txtJump1.Size = New System.Drawing.Size(59, 20)
        Me.txtJump1.TabIndex = 7
        '
        'txtJump2
        '
        Me.txtJump2.Location = New System.Drawing.Point(155, 92)
        Me.txtJump2.Name = "txtJump2"
        Me.txtJump2.Size = New System.Drawing.Size(59, 20)
        Me.txtJump2.TabIndex = 8
        '
        'txtJump3
        '
        Me.txtJump3.Location = New System.Drawing.Point(155, 121)
        Me.txtJump3.Name = "txtJump3"
        Me.txtJump3.Size = New System.Drawing.Size(59, 20)
        Me.txtJump3.TabIndex = 9
        '
        'txtJump4
        '
        Me.txtJump4.Location = New System.Drawing.Point(155, 150)
        Me.txtJump4.Name = "txtJump4"
        Me.txtJump4.Size = New System.Drawing.Size(59, 20)
        Me.txtJump4.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 261)
        Me.Controls.Add(Me.txtJump4)
        Me.Controls.Add(Me.txtJump3)
        Me.Controls.Add(Me.txtJump2)
        Me.Controls.Add(Me.txtJump1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblJump4)
        Me.Controls.Add(Me.lblJump3)
        Me.Controls.Add(Me.lblJump2)
        Me.Controls.Add(Me.lblJump1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Long Jump"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblJump1 As Label
    Friend WithEvents lblJump2 As Label
    Friend WithEvents lblJump3 As Label
    Friend WithEvents lblJump4 As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtJump1 As TextBox
    Friend WithEvents txtJump2 As TextBox
    Friend WithEvents txtJump3 As TextBox
    Friend WithEvents txtJump4 As TextBox
End Class
