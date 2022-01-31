<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NEW ACCOUNT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FIRST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "LAST NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(436, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 26)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "MOBILE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(436, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 26)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "DOB"
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Submit.Location = New System.Drawing.Point(261, 340)
        Me.Submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(278, 40)
        Me.Submit.TabIndex = 12
        Me.Submit.Text = "SUBMIT"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Logout.Location = New System.Drawing.Point(288, 388)
        Me.Logout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(222, 32)
        Me.Logout.TabIndex = 13
        Me.Logout.Text = "LOGOUT"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'FirstName
        '
        Me.FirstName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.Location = New System.Drawing.Point(197, 151)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(193, 31)
        Me.FirstName.TabIndex = 14
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(197, 222)
        Me.Address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Address.Size = New System.Drawing.Size(193, 80)
        Me.Address.TabIndex = 15
        '
        'LastName
        '
        Me.LastName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.Location = New System.Drawing.Point(570, 153)
        Me.LastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(170, 31)
        Me.LastName.TabIndex = 18
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirth.Location = New System.Drawing.Point(570, 276)
        Me.DateOfBirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateOfBirth.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.DateOfBirth.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(183, 31)
        Me.DateOfBirth.TabIndex = 22
        Me.DateOfBirth.Value = New Date(2003, 12, 31, 0, 0, 0, 0)
        '
        'Mobile
        '
        Me.Mobile.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile.Location = New System.Drawing.Point(570, 215)
        Me.Mobile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mobile.MaxLength = 10
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(170, 31)
        Me.Mobile.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 75)
        Me.Panel1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 37)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ATM MANAGEMENT SYSTEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Location = New System.Drawing.Point(3, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 13)
        Me.Panel2.TabIndex = 25
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SignupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Logout As Button
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents Mobile As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
End Class
