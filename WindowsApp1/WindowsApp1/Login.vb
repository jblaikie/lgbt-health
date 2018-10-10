Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Dim conn As MySqlConnection
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        conn = New MySqlConnection


        Dim cs As String = "Database=db_accounts;Data Source=localhost;" + "CertificateFile=C:\\mysqlcerts\\client.pfx" + "CertificatePassword=pass;" + "SSL Mode=Required;" + "User Id=admin;Password=luvi$4eva"
        conn.ConnectionString = cs
        Dim command As New MySqlCommand("SELECT `id`, `password` FROM `tbl_users` WHERE `id` = @username AND `password` = @password", conn)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        Try
            conn.Open()
            'MessageBox.Show("Connection Succsessful")
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count = 0 Then

                MessageBox.Show("Invalid Username Or Password")

            Else

                MessageBox.Show("Logged In")

                ' Dim newForm As New Insert_Update_Delete_Search()
                ' newForm.Show()
                'Me.Hide()

            End If
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub CheckBoxSP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSP.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar = True Then

            ' show password
            TextBoxPassword.UseSystemPasswordChar = False

        Else

            ' hide password
            TextBoxPassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub NewUser_Click(sender As Object, e As EventArgs) Handles NewUser.Click

    End Sub
End Class