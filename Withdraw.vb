Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataSetDateTime
Public Class WithdrawForm
    Public Property Acc As String
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim MyAcc As Integer
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub
    Dim OldBalance = 0
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTbl where CardNum=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        BalAmt.Text = OldBalance
        con.Close()
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Convert.ToInt32(WithdrawAmt.Text)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Update AccountTbl set Balance=" & NewBal & "where CardNum=" & Acc & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        If WithdrawAmt.Text = "" Then
            MsgBox("Missing Information")
        ElseIf Convert.ToInt32(WithdrawAmt.Text) > OldBalance Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim Bal = 0
                Dim TrDate As DateTime = DateTime.Now
                Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
                con.Open()

                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & WithdrawAmt.Text & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal()
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class