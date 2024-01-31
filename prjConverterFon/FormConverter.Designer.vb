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
        Me.txtKilometres = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        'FormConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 574)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtKilometres)
        Me.Name = "FormConverter"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKilometres As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
