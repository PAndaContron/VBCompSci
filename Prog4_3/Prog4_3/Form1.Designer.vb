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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(55, 62)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(213, 62)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "Width:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(16, 135)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(38, 13)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Area ="
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(16, 166)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(60, 13)
        Me.lblPerimeter.TabIndex = 3
        Me.lblPerimeter.Text = "Perimeter ="
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(257, 59)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(48, 20)
        Me.txtWidth.TabIndex = 5
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(104, 59)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(48, 20)
        Me.txtLength.TabIndex = 6
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(243, 156)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 7
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 210)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents btnAnswer As Button
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
