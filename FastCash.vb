Imports System.Data.SqlClient
Public Class FastCash
    Public Property Acc As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
    Dim OldBalance = 0
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTbl where CardNum=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Balance.Text = OldBalance
        con.Close()
    End Sub
    Dim MyAcc = 0
    Dim Amount As Integer
    Private Sub UpdateBal(Amt As Integer)
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Amt
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
    Private Sub Hundred_Click(sender As Object, e As EventArgs) Handles Hundred.Click
        If OldBalance < 100 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 100
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FastCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub

    Private Sub FiveHundred_Click(sender As Object, e As EventArgs) Handles FiveHundred.Click
        If OldBalance < 500 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 500
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Thousand_Click(sender As Object, e As EventArgs) Handles Thousand.Click
        If OldBalance < 1000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 1000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TwoThousand_Click(sender As Object, e As EventArgs) Handles TwoThousand.Click
        If OldBalance < 2000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 2000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FiveThousand_Click(sender As Object, e As EventArgs) Handles FiveThousand.Click
        If OldBalance < 5000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 5000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TenThousand_Click(sender As Object, e As EventArgs) Handles TenThousand.Click
        If OldBalance < 10000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 10000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & Amount & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
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
End Class