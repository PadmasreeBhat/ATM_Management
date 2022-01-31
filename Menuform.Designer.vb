<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.FastCash = New System.Windows.Forms.Button()
        Me.ChangePin = New System.Windows.Forms.Button()
        Me.Withdraw = New System.Windows.Forms.Button()
        Me.MiniStmt = New System.Windows.Forms.Button()
        Me.Balance = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.CardNum = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PLEASE SELECT YOUR TRANSACTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CARD NUMBER : "
        '
        'Deposit
        '
        Me.Deposit.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit.Location = New System.Drawing.Point(174, 161)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(162, 33)
        Me.Deposit.TabIndex = 4
        Me.Deposit.Text = "DEPOSIT"
        Me.Deposit.UseVisualStyleBackColor = True
        '
        'FastCash
        '
        Me.FastCash.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastCash.Location = New System.Drawing.Point(174, 230)
        Me.FastCash.Name = "FastCash"
        Me.FastCash.Size = New System.Drawing.Size(162, 33)
        Me.FastCash.TabIndex = 5
        Me.FastCash.Text = "FAST CASH"
        Me.FastCash.UseVisualStyleBackColor = True
        '
        'ChangePin
        '
        Me.ChangePin.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePin.Location = New System.Drawing.Point(174, 303)
        Me.ChangePin.Name = "ChangePin"
        Me.ChangePin.Size = New System.Drawing.Size(162, 33)
        Me.ChangePin.TabIndex = 6
        Me.ChangePin.Text = "CHANGE PIN"
        Me.ChangePin.UseVisualStyleBackColor = True
        '
        'Withdraw
        '
        Me.Withdraw.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Withdraw.Location = New System.Drawing.Point(458, 161)
        Me.Withdraw.Name = "Withdraw"
        Me.Withdraw.Size = New System.Drawing.Size(162, 33)
        Me.Withdraw.TabIndex = 7
        Me.Withdraw.Text = "WITHDRAW"
        Me.Withdraw.UseVisualStyleBackColor = True
        '
        'MiniStmt
        '
        Me.MiniStmt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniStmt.Location = New System.Drawing.Point(458, 230)
        Me.MiniStmt.Name = "MiniStmt"
        Me.MiniStmt.Size = New System.Drawing.Size(162, 33)
        Me.MiniStmt.TabIndex = 8
        Me.MiniStmt.Text = "MINI STATEMENT"
        Me.MiniStmt.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.Balance.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance.Location = New System.Drawing.Point(458, 303)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(162, 33)
        Me.Balance.TabIndex = 9
        Me.Balance.Text = "BALANCE"
        Me.Balance.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Location = New System.Drawing.Point(307, 375)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(162, 33)
        Me.Logout.TabIndex = 10
        Me.Logout.Text = "LOGOUT"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'CardNum
        '
        Me.CardNum.AutoSize = True
        Me.CardNum.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNum.Location = New System.Drawing.Point(444, 85)
        Me.CardNum.Name = "CardNum"
        Me.CardNum.Size = New System.Drawing.Size(56, 30)
        Me.CardNum.TabIndex = 11
        Me.CardNum.Text = "NUM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 69)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Location = New System.Drawing.Point(1, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 13)
        Me.Panel2.TabIndex = 13
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CardNum)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.MiniStmt)
        Me.Controls.Add(Me.Withdraw)
        Me.Controls.Add(Me.ChangePin)
        Me.Controls.Add(Me.FastCash)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Deposit As Button
    Friend WithEvents FastCash As Button
    Friend WithEvents ChangePin As Button
    Friend WithEvents Withdraw As Button
    Friend WithEvents MiniStmt As Button
    Friend WithEvents Balance As Button
    Friend WithEvents Logout As Button
    Friend WithEvents CardNum As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
