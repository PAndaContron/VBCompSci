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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.grpConversions = New System.Windows.Forms.GroupBox()
        Me.radTime = New System.Windows.Forms.RadioButton()
        Me.radSeconds = New System.Windows.Forms.RadioButton()
        Me.grpConversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 15)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(125, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the time in minutes:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(12, 105)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 1
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(172, 12)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutes.TabIndex = 2
        '
        'grpConversions
        '
        Me.grpConversions.Controls.Add(Me.radTime)
        Me.grpConversions.Controls.Add(Me.radSeconds)
        Me.grpConversions.Location = New System.Drawing.Point(15, 38)
        Me.grpConversions.Name = "grpConversions"
        Me.grpConversions.Size = New System.Drawing.Size(257, 55)
        Me.grpConversions.TabIndex = 3
        Me.grpConversions.TabStop = False
        Me.grpConversions.Text = "Select time conversion"
        '
        'radTime
        '
        Me.radTime.AutoSize = True
        Me.radTime.Location = New System.Drawing.Point(141, 19)
        Me.radTime.Name = "radTime"
        Me.radTime.Size = New System.Drawing.Size(94, 17)
        Me.radTime.TabIndex = 1
        Me.radTime.TabStop = True
        Me.radTime.Text = "Minutes to h:m"
        Me.radTime.UseVisualStyleBackColor = True
        '
        'radSeconds
        '
        Me.radSeconds.AutoSize = True
        Me.radSeconds.Location = New System.Drawing.Point(21, 19)
        Me.radSeconds.Name = "radSeconds"
        Me.radSeconds.Size = New System.Drawing.Size(117, 17)
        Me.radSeconds.TabIndex = 0
        Me.radSeconds.TabStop = True
        Me.radSeconds.Text = "Minutes to seconds"
        Me.radSeconds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 135)
        Me.Controls.Add(Me.grpConversions)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpConversions.ResumeLayout(False)
        Me.grpConversions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents grpConversions As GroupBox
    Friend WithEvents radTime As RadioButton
    Friend WithEvents radSeconds As RadioButton
End Class
