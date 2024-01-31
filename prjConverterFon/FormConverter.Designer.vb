<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConverter
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
        Me.components = New System.ComponentModel.Container()
        Me.txtKilometres = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenüüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SulgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKilometres
        '
        Me.txtKilometres.Location = New System.Drawing.Point(479, 226)
        Me.txtKilometres.Name = "txtKilometres"
        Me.txtKilometres.Size = New System.Drawing.Size(249, 26)
        Me.txtKilometres.TabIndex = 0
        '
        'txtMiles
        '
        Me.txtMiles.Enabled = False
        Me.txtMiles.Location = New System.Drawing.Point(479, 297)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(249, 26)
        Me.txtMiles.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(479, 258)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(249, 33)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Teisenda"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sisend kilomeetrites"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vastus miilides"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüüToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1181, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenüüToolStripMenuItem
        '
        Me.MenüüToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SulgeToolStripMenuItem})
        Me.MenüüToolStripMenuItem.Name = "MenüüToolStripMenuItem"
        Me.MenüüToolStripMenuItem.Size = New System.Drawing.Size(83, 32)
        Me.MenüüToolStripMenuItem.Text = "Menüü"
        '
        'SulgeToolStripMenuItem
        '
        Me.SulgeToolStripMenuItem.Name = "SulgeToolStripMenuItem"
        Me.SulgeToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SulgeToolStripMenuItem.Text = "sulge"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(565, 476)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(34, 20)
        Me.lblClock.TabIndex = 6
        Me.lblClock.Text = "Kell"
        '
        'FormConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 574)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtKilometres)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormConverter"
        Me.Text = "Distantsi teisendaja "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKilometres As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SulgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerClock As Timer
    Friend WithEvents lblClock As Label
End Class
