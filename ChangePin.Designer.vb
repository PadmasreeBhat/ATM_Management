<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePin
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
        Me.Change = New System.Windows.Forms.Button()
        Me.NewPIN = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmPIN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Change
        '
        Me.Change.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Change.Location = New System.Drawing.Point(149, 171)
        Me.Change.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(110, 40)
        Me.Change.TabIndex = 22
        Me.Change.Text = "CHANGE"
        Me.Change.UseVisualStyleBackColor = True
        '
        'NewPIN
        '
        Me.NewPIN.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPIN.Location = New System.Drawing.Point(208, 74)
        Me.NewPIN.Name = "NewPIN"
        Me.NewPIN.Size = New System.Drawing.Size(144, 29)
        Me.NewPIN.TabIndex = 21
        Me.NewPIN.UseSystemPasswordChar = True
        '
        'Back
        '
        Me.Back.AutoSize = True
        Me.Back.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(179, 215)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(49, 24)
        Me.Back.TabIndex = 19
        Me.Back.Text = "BACK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "NEW PIN"
        '
        'ConfirmPIN
        '
        Me.ConfirmPIN.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPIN.Location = New System.Drawing.Point(208, 124)
        Me.ConfirmPIN.Name = "ConfirmPIN"
        Me.ConfirmPIN.Size = New System.Drawing.Size(144, 29)
        Me.ConfirmPIN.TabIndex = 24
        Me.ConfirmPIN.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CONFIRM PIN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 62)
        Me.Panel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ATM MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Location = New System.Drawing.Point(0, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 11)
        Me.Panel2.TabIndex = 26
        '
        'ChangePin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 267)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ConfirmPIN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.NewPIN)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ChangePin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Change As Button
    Friend WithEvents NewPIN As TextBox
    Friend WithEvents Back As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmPIN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
