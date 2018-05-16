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
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnDigits = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(48, 75)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(99, 13)
        Me.lblSecond.TabIndex = 0
        Me.lblSecond.Text = "The second digit is:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(48, 51)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(80, 13)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "The first digit is:"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 16)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(124, 13)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Enter a two-digit number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(172, 13)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(73, 20)
        Me.txtNum.TabIndex = 3
        '
        'btnDigits
        '
        Me.btnDigits.Location = New System.Drawing.Point(12, 140)
        Me.btnDigits.Name = "btnDigits"
        Me.btnDigits.Size = New System.Drawing.Size(75, 23)
        Me.btnDigits.TabIndex = 4
        Me.btnDigits.Text = "Digits"
        Me.btnDigits.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 175)
        Me.Controls.Add(Me.btnDigits)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblSecond)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSecond As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnDigits As Button
End Class
