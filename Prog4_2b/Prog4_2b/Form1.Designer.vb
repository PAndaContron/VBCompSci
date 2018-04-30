<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFahrenheit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCelsius = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(13, 45)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(176, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the temperature in Fahrenheit:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(13, 136)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(145, 13)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.Text = "The temperature in Celsius is:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(195, 42)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProg})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(308, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProg
        '
        Me.mnuProg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFahrenheit, Me.mnuCelsius, Me.mnuExit})
        Me.mnuProg.Name = "mnuProg"
        Me.mnuProg.Size = New System.Drawing.Size(65, 20)
        Me.mnuProg.Text = "Program"
        '
        'mnuFahrenheit
        '
        Me.mnuFahrenheit.Name = "mnuFahrenheit"
        Me.mnuFahrenheit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFahrenheit.Text = "Fahrenheit"
        '
        'mnuCelsius
        '
        Me.mnuCelsius.Name = "mnuCelsius"
        Me.mnuCelsius.Size = New System.Drawing.Size(152, 22)
        Me.mnuCelsius.Text = "Celsius"
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
        Me.ClientSize = New System.Drawing.Size(308, 193)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProg As ToolStripMenuItem
    Friend WithEvents mnuFahrenheit As ToolStripMenuItem
    Friend WithEvents mnuCelsius As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
