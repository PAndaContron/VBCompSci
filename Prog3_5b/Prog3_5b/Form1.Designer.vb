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
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.btnAssoc = New System.Windows.Forms.Button()
        Me.btnComm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProperty
        '
        Me.lblProperty.Location = New System.Drawing.Point(0, 96)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(284, 23)
        Me.lblProperty.TabIndex = 0
        Me.lblProperty.Text = "(a + b) + c = a + (b + c)"
        Me.lblProperty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAssoc
        '
        Me.btnAssoc.Location = New System.Drawing.Point(50, 151)
        Me.btnAssoc.Name = "btnAssoc"
        Me.btnAssoc.Size = New System.Drawing.Size(75, 23)
        Me.btnAssoc.TabIndex = 1
        Me.btnAssoc.Text = "Associative"
        Me.btnAssoc.UseVisualStyleBackColor = True
        '
        'btnComm
        '
        Me.btnComm.Location = New System.Drawing.Point(153, 151)
        Me.btnComm.Name = "btnComm"
        Me.btnComm.Size = New System.Drawing.Size(80, 23)
        Me.btnComm.TabIndex = 2
        Me.btnComm.Text = "Commutative"
        Me.btnComm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnComm)
        Me.Controls.Add(Me.btnAssoc)
        Me.Controls.Add(Me.lblProperty)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblProperty As Label
    Friend WithEvents btnAssoc As Button
    Friend WithEvents btnComm As Button
End Class
