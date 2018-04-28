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
        Me.lblCirc = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(24, 19)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(142, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the radius of the circle:"
        '
        'lblCirc
        '
        Me.lblCirc.AutoSize = True
        Me.lblCirc.Location = New System.Drawing.Point(12, 74)
        Me.lblCirc.Name = "lblCirc"
        Me.lblCirc.Size = New System.Drawing.Size(81, 13)
        Me.lblCirc.TabIndex = 1
        Me.lblCirc.Text = "Circumference: "
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(12, 115)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(35, 13)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Area: "
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(172, 16)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(104, 159)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblCirc)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblCirc As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents btnCalc As Button
End Class
