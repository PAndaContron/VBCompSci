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
        Me.grpBands = New System.Windows.Forms.GroupBox()
        Me.radBeatles = New System.Windows.Forms.RadioButton()
        Me.radBigTimeRush = New System.Windows.Forms.RadioButton()
        Me.radRollingStones = New System.Windows.Forms.RadioButton()
        Me.radSmashMouth = New System.Windows.Forms.RadioButton()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpBands.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBands
        '
        Me.grpBands.Controls.Add(Me.radBeatles)
        Me.grpBands.Controls.Add(Me.radBigTimeRush)
        Me.grpBands.Controls.Add(Me.radRollingStones)
        Me.grpBands.Controls.Add(Me.radSmashMouth)
        Me.grpBands.Location = New System.Drawing.Point(12, 0)
        Me.grpBands.Name = "grpBands"
        Me.grpBands.Size = New System.Drawing.Size(260, 113)
        Me.grpBands.TabIndex = 0
        Me.grpBands.TabStop = False
        Me.grpBands.Text = "Bands"
        '
        'radBeatles
        '
        Me.radBeatles.AutoSize = True
        Me.radBeatles.Location = New System.Drawing.Point(12, 88)
        Me.radBeatles.Name = "radBeatles"
        Me.radBeatles.Size = New System.Drawing.Size(82, 17)
        Me.radBeatles.TabIndex = 3
        Me.radBeatles.TabStop = True
        Me.radBeatles.Text = "The Beatles"
        Me.radBeatles.UseVisualStyleBackColor = True
        '
        'radBigTimeRush
        '
        Me.radBigTimeRush.AutoSize = True
        Me.radBigTimeRush.Location = New System.Drawing.Point(12, 65)
        Me.radBigTimeRush.Name = "radBigTimeRush"
        Me.radBigTimeRush.Size = New System.Drawing.Size(94, 17)
        Me.radBigTimeRush.TabIndex = 2
        Me.radBigTimeRush.TabStop = True
        Me.radBigTimeRush.Text = "Big Time Rush"
        Me.radBigTimeRush.UseVisualStyleBackColor = True
        '
        'radRollingStones
        '
        Me.radRollingStones.AutoSize = True
        Me.radRollingStones.Location = New System.Drawing.Point(12, 42)
        Me.radRollingStones.Name = "radRollingStones"
        Me.radRollingStones.Size = New System.Drawing.Size(93, 17)
        Me.radRollingStones.TabIndex = 1
        Me.radRollingStones.TabStop = True
        Me.radRollingStones.Text = "Rolling Stones"
        Me.radRollingStones.UseVisualStyleBackColor = True
        '
        'radSmashMouth
        '
        Me.radSmashMouth.AutoSize = True
        Me.radSmashMouth.Location = New System.Drawing.Point(12, 19)
        Me.radSmashMouth.Name = "radSmashMouth"
        Me.radSmashMouth.Size = New System.Drawing.Size(90, 17)
        Me.radSmashMouth.TabIndex = 0
        Me.radSmashMouth.TabStop = True
        Me.radSmashMouth.Text = "Smash Mouth"
        Me.radSmashMouth.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(9, 116)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 261)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.grpBands)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpBands.ResumeLayout(False)
        Me.grpBands.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBands As GroupBox
    Friend WithEvents radBigTimeRush As RadioButton
    Friend WithEvents radRollingStones As RadioButton
    Friend WithEvents radSmashMouth As RadioButton
    Friend WithEvents radBeatles As RadioButton
    Friend WithEvents lblInfo As Label
End Class
