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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnBye = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(34, 194)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnBye
        '
        Me.btnBye.Location = New System.Drawing.Point(177, 194)
        Me.btnBye.Name = "btnBye"
        Me.btnBye.Size = New System.Drawing.Size(75, 23)
        Me.btnBye.TabIndex = 1
        Me.btnBye.Text = "Good-bye"
        Me.btnBye.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(12, 9)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(260, 182)
        Me.lblHello.TabIndex = 2
        Me.lblHello.Text = "Hello!"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnBye)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHello As Button
    Friend WithEvents btnBye As Button
    Friend WithEvents lblHello As Label
End Class
