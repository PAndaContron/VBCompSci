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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAssoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAssoc = New System.Windows.Forms.Button()
        Me.btnComm = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProperty
        '
        Me.lblProperty.Location = New System.Drawing.Point(12, 24)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(260, 228)
        Me.lblProperty.TabIndex = 0
        Me.lblProperty.Text = "(a + b) + c = a + (b + c)"
        Me.lblProperty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProg})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProg
        '
        Me.mnuProg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAssoc, Me.mnuComm, Me.mnuExit})
        Me.mnuProg.Name = "mnuProg"
        Me.mnuProg.Size = New System.Drawing.Size(65, 20)
        Me.mnuProg.Text = "Program"
        '
        'mnuAssoc
        '
        Me.mnuAssoc.Name = "mnuAssoc"
        Me.mnuAssoc.Size = New System.Drawing.Size(147, 22)
        Me.mnuAssoc.Text = "Associative"
        '
        'mnuComm
        '
        Me.mnuComm.Name = "mnuComm"
        Me.mnuComm.Size = New System.Drawing.Size(147, 22)
        Me.mnuComm.Text = "Commutative"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(147, 22)
        Me.mnuExit.Text = "Exit"
        '
        'btnAssoc
        '
        Me.btnAssoc.Location = New System.Drawing.Point(37, 195)
        Me.btnAssoc.Name = "btnAssoc"
        Me.btnAssoc.Size = New System.Drawing.Size(82, 23)
        Me.btnAssoc.TabIndex = 2
        Me.btnAssoc.Text = "Associative"
        Me.btnAssoc.UseVisualStyleBackColor = True
        '
        'btnComm
        '
        Me.btnComm.Location = New System.Drawing.Point(161, 195)
        Me.btnComm.Name = "btnComm"
        Me.btnComm.Size = New System.Drawing.Size(81, 23)
        Me.btnComm.TabIndex = 3
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProperty As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProg As ToolStripMenuItem
    Friend WithEvents mnuAssoc As ToolStripMenuItem
    Friend WithEvents mnuComm As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnAssoc As Button
    Friend WithEvents btnComm As Button
End Class
