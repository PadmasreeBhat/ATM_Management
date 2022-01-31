Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class DepositForm
    Dim cmd As New SqlCommand
    Dim con = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Dim OldBalance = 0
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTbl where CardNum=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.Close()
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance + Convert.ToInt32(DepositAmt.Text)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Update AccountTbl set Balance=" & NewBal & "where CardNum=" & MyAcc & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Property Acc As String
    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        If DepositAmt.Text = "" Or Convert.ToInt32(DepositAmt.Text) < 1 Then
            MsgBox("Missing Information")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Deposit"
            Try
                Dim Bal = 0
                con.open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & DepositAmt.Text & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Deposit Successful")
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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim MyAcc As Integer
    Private Sub DepositForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub
End Class