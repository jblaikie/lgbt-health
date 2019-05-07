Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Public accountname As String
    Public idnum As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
        Dim dt As New DataTable
        Try
            MysqlConn.Open()
            ' MessageBox.Show("Connection to Database has been opened.")
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("Password or Username Incorrect!")

            Else
                'Dim passhash = hash(PasswordTextBox.Text)
                sqlcommand.CommandText = "select salt from salts where username = @uname"
                sqlcommand.Connection = MysqlConn
                sqlcommand.Parameters.Add(New MySqlParameter("@uname", UsernameTextBox.Text))
                Dim salt As String
                salt = sqlcommand.ExecuteScalar()

                sqlcommand.CommandText = "select * from tbl_users where username = @uname and password = @pword"
                    sqlcommand.Connection = MysqlConn
                    ' sqlcommand.Parameters.Add(New MySqlParameter("@uname", UsernameTextBox.Text))
                    sqlcommand.Parameters.Add(New MySqlParameter("@pword", hash(PasswordTextBox.Text, salt)))

                    da.SelectCommand = sqlcommand

                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Dim user_type As String
                    user_type = dt.Rows(0).Item(3)
                    idnum = dt.Rows(0).Item(0)
                    name = dt.Rows(0).Item(4)

                    If user_type = "Doctor" Then
                            DoctorView.Show()
                        Me.Hide()
                    ElseIf user_type = "Nurse" Then
                            NurseView.Show()
                        Me.Hide()
                    Else
                            SecretaryView.Show()
                        Me.Hide()
                    End If
                    Else
                        MsgBox("The username and/or password is incorrect.")
                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""

                    End If
                    da.Dispose()
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Function hash(ByVal pass As String, ByVal salt As String) As String
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(pass & salt)
        Dim hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(bytes)
        Dim strHash As String = Convert.ToBase64String(hashOfBytes)
        Return strHash
    End Function
End Class
