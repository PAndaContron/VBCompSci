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
        Me.mnuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHello = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBye = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnGoodbye = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProg})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProg
        '
        Me.mnuProg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHello, Me.mnuBye, Me.mnuExit})
        Me.mnuProg.Name = "mnuProg"
        Me.mnuProg.Size = New System.Drawing.Size(65, 20)
        Me.mnuProg.Text = "Program"
        '
        'mnuHello
        '
        Me.mnuHello.Name = "mnuHello"
        Me.mnuHello.Size = New System.Drawing.Size(152, 22)
        Me.mnuHello.Text = "Hello"
        '
        'mnuBye
        '
        Me.mnuBye.Name = "mnuBye"
        Me.mnuBye.Size = New System.Drawing.Size(152, 22)
        Me.mnuBye.Text = "Good-bye"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(12, 24)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(260, 228)
        Me.lblHello.TabIndex = 1
        Me.lblHello.Text = "Hello!"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(39, 211)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 2
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnGoodbye
        '
        Me.btnGoodbye.Location = New System.Drawing.Point(183, 211)
        Me.btnGoodbye.Name = "btnGoodbye"
        Me.btnGoodbye.Size = New System.Drawing.Size(75, 23)
        Me.btnGoodbye.TabIndex = 3
        Me.btnGoodbye.Text = "Goodbye"
        Me.btnGoodbye.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGoodbye)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProg As ToolStripMenuItem
    Friend WithEvents mnuHello As ToolStripMenuItem
    Friend WithEvents mnuBye As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblHello As Label
    Friend WithEvents btnHello As Button
    Friend WithEvents btnGoodbye As Button
End Class
