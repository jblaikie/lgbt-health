Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_accounts"
        Dim dt As New DataTable
        Try
            MysqlConn.Open()
            ' MessageBox.Show("Connection to Database has been opened.")
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("Password or Username Incorrect!")

            Else

                sqlcommand.CommandText = "select * from tbl_users where username = '" & UsernameTextBox.Text & "' and password = '" & PasswordTextBox.Text & "'"
                sqlcommand.Connection = MysqlConn
                'MsgBox("connect :)")
                da.SelectCommand = sqlcommand
                'MsgBox("i selected the command")
                da.Fill(dt)
                'MsgBox("i filled it :)")
                If dt.Rows.Count > 0 Then
                    Dim user_type As String
                    user_type = dt.Rows(0).Item(3)

                    If user_type = "Doctor" Then
                        DoctorView.Show()

                    ElseIf user_type = "Nurse" Then
                        NurseView.Show()

                    Else
                        SecretaryView.Show()
                    End If
                Else
                    MsgBox("Contact administrator to registered!")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                End If
                da.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
