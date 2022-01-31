Public Class Menuform
    Public Property Acc As String
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardNum.Text = Acc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        Dim Obj = New DepositForm()
        Obj.Acc = CardNum.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        Dim Obj = New WithdrawForm()
        Obj.Acc = CardNum.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub FastCash_Click(sender As Object, e As EventArgs) Handles FastCash.Click
        Dim Obj = New FastCash()
        Obj.Acc = CardNum.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub MiniStmt_Click(sender As Object, e As EventArgs) Handles MiniStmt.Click
        Dim Obj = New MiniStatement()
        Obj.Acc = CardNum.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub ChangePin_Click(sender As Object, e As EventArgs) Handles ChangePin.Click
        Dim Obj = New ChangePin()
        Obj.Acc = CardNum.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Balance_Click(sender As Object, e As EventArgs) Handles Balance.Click
        Dim Obj = New BalanceForm()
        Obj.Acc = CardNum.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim Obj = New ThankYou()
        Obj.Show()
        Me.Hide()
    End Sub
End Class