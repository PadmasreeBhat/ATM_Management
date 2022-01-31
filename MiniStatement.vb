Imports System.Data.SqlClient
Public Class MiniStatement
    Public Property Acc As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Obj = New Menuform
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub DisplayTr()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from TrsnTable where AccountNo='" & Acc & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(sda)
        Dim ds As DataSet = New DataSet
        sda.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub MiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTr()
    End Sub

End Class