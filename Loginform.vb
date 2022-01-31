Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Login
    Public Property Acc As String
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from AccountTbl where CardNum='" + CardNumber.Text + "' and PIN='" + PINNumber.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim v = sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Obj = New Menuform
            Obj.Acc = CardNumber.Text
            Me.Hide()
            Obj.Show()
            CardNumber.Clear()
            PINNumber.Clear()
        Else
            MessageBox.Show("Login Unsuccessful. Please Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Signup.Click
        Dim Obj = New SignupForm
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class