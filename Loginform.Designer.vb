<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CardNumber = New System.Windows.Forms.TextBox()
        Me.PINNumber = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Signup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LOGIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CARD NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PIN NUMBER"
        '
        'CardNumber
        '
        Me.CardNumber.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNumber.Location = New System.Drawing.Point(406, 167)
        Me.CardNumber.Name = "CardNumber"
        Me.CardNumber.Size = New System.Drawing.Size(196, 35)
        Me.CardNumber.TabIndex = 4
        '
        'PINNumber
        '
        Me.PINNumber.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINNumber.Location = New System.Drawing.Point(406, 227)
        Me.PINNumber.Name = "PINNumber"
        Me.PINNumber.Size = New System.Drawing.Size(196, 35)
        Me.PINNumber.TabIndex = 5
        Me.PINNumber.UseSystemPasswordChar = True
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.Transparent
        Me.Submit.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(307, 303)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(176, 44)
        Me.Submit.TabIndex = 7
        Me.Submit.Text = "SUBMIT"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Signup
        '
        Me.Signup.BackColor = System.Drawing.Color.Transparent
        Me.Signup.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup.Location = New System.Drawing.Point(336, 372)
        Me.Signup.Name = "Signup"
        Me.Signup.Size = New System.Drawing.Size(119, 42)
        Me.Signup.TabIndex = 8
        Me.Signup.Text = "SIGNUP"
        Me.Signup.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 71)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 37)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ATM MANAGEMENT SYSTEM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel3.Location = New System.Drawing.Point(1, 435)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 13)
        Me.Panel3.TabIndex = 14
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Signup)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.PINNumber)
        Me.Controls.Add(Me.CardNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CardNumber As TextBox
    Friend WithEvents PINNumber As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Signup As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
End Class
