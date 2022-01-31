Imports System.Data.SqlClient
Public Class BalanceForm
    Public Property Acc As Integer
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Obj As New Menuform
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim con = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTbl where CardNum=" & Account & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        Balance.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.Close()
    End Sub

    Dim Account As Integer
    Private Sub BalanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(Acc)
        CardNum.Text = Acc
        GetBalance()
    End Sub
End Class