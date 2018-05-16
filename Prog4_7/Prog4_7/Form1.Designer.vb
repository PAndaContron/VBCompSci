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
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickel = New System.Windows.Forms.Label()
        Me.lblDime = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.btnCoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(24, 162)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 0
        Me.lblPennies.Text = "Pennies:"
        '
        'lblNickel
        '
        Me.lblNickel.AutoSize = True
        Me.lblNickel.Location = New System.Drawing.Point(24, 129)
        Me.lblNickel.Name = "lblNickel"
        Me.lblNickel.Size = New System.Drawing.Size(45, 13)
        Me.lblNickel.TabIndex = 1
        Me.lblNickel.Text = "Nickels:"
        '
        'lblDime
        '
        Me.lblDime.AutoSize = True
        Me.lblDime.Location = New System.Drawing.Point(24, 96)
        Me.lblDime.Name = "lblDime"
        Me.lblDime.Size = New System.Drawing.Size(42, 13)
        Me.lblDime.TabIndex = 2
        Me.lblDime.Text = "Dimes: "
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(16, 24)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(87, 13)
        Me.lblChange.TabIndex = 3
        Me.lblChange.Text = "Change in cents:"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(24, 63)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarter.TabIndex = 4
        Me.lblQuarter.Text = "Quarters:"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(158, 21)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(100, 20)
        Me.txtChange.TabIndex = 5
        '
        'btnCoins
        '
        Me.btnCoins.Location = New System.Drawing.Point(183, 157)
        Me.btnCoins.Name = "btnCoins"
        Me.btnCoins.Size = New System.Drawing.Size(75, 23)
        Me.btnCoins.TabIndex = 6
        Me.btnCoins.Text = "Coins"
        Me.btnCoins.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 201)
        Me.Controls.Add(Me.btnCoins)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblDime)
        Me.Controls.Add(Me.lblNickel)
        Me.Controls.Add(Me.lblPennies)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickel As Label
    Friend WithEvents lblDime As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnCoins As Button
End Class
