Imports System.Data.SqlClient
Public Class ChangePin
    Public Property Acc As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Dim MyAcc As Integer
    Private Sub ChangePin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Change_Click(sender As Object, e As EventArgs) Handles Change.Click
        If NewPIN.Text = "" Or ConfirmPIN.Text = "" Then
            MsgBox("Missing Information")
        ElseIf NewPIN.Text = ConfirmPIN.Text Then
            Try
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Update AccountTbl set PIN='" & NewPIN.Text & "' where CardNum='" & MyAcc & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("PIN Changed Successfully")
                con.Close()
                Dim log = New Login()
                log.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("New Pin and Confirmed Pin doesn't Match")
        End If
    End Sub

End Class