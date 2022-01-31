Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class SignupForm

    Dim Generator As System.Random = New System.Random()
    Private Function GetRandom(myGenerator As System.Random, ByVal Digits As Integer) As Integer
        Dim min = 10 ^ (Digits - 1)
        Dim max = (10 ^ Digits) - 1
        Return myGenerator.Next(min, max + 1)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Dim accNum As Integer
        Dim pinNum As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim bal = 0
        con.ConnectionString = ("Data Source=DESKTOP-BDMQA1G\DATACAMP_SQL;Initial Catalog=ATM_ManagementDB;Integrated Security=True")
        con.Open()
        cmd.Connection = con

        Dim queryResult As Int16
        If (FirstName.Text = "" And LastName.Text = "" And Address.Text = "" And Mobile.Text = "") Then
            MsgBox("Please Enter all the Details")

        Else
            While True
                accNum = GetRandom(Generator, 5)
                pinNum = GetRandom(Generator, 4)

                Try
                    cmd = New SqlCommand("Insert into AccountTbl Values('" & accNum & "','" & FirstName.Text & "','" & LastName.Text & "','" & Address.Text & "','" & pinNum & "','" & Mobile.Text & "','" & DateOfBirth.Text & "','" & bal & "')", con)
                    queryResult = cmd.ExecuteNonQuery()

                Catch sqlEx As SqlException
                    MsgBox(sqlEx.Message)
                    MsgBox("User Already Exists")
                    Continue While
                Catch ex As Exception
                    MsgBox(ex.Message)
                    'MsgBox("Something went Wrong")
                End Try
                Exit While
            End While
        End If

        If (queryResult = 1) Then
            MsgBox("Account Created", MsgBoxStyle.Information, "Success")
            MsgBox(" AccountNumber= " & accNum & " Pin Number = " & pinNum)
            Dim Obj = New SignupForm
            Obj.ResetText()
            Obj.Show()
            con.Close()
        End If

    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim Obj = New Login
        Me.Hide()
        Obj.Show()
    End Sub
End Class