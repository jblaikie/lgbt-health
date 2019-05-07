Imports System.Text
Imports MySql.Data.MySqlClient
Public Class RegisterForm

    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Dim category As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"

        Try
            MysqlConn.Open()
            ' MessageBox.Show("Connection to Database has been opened.")
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("Please Enter both username and password")

            Else
                Dim salt As String
                salt = createRandomSalt()
                Dim passhash = hash(PasswordTextBox.Text, salt)
                sqlcommand.CommandText = "select id_num from tbl_users where username = @uname"
                sqlcommand.Parameters.Add(New MySqlParameter("@uname", UsernameTextBox.Text))
                sqlcommand.Connection = MysqlConn
                If sqlcommand.ExecuteScalar() = Nothing Then
                    sqlcommand.CommandText = "insert into tbl_users (username,password,type,name,creation_date) values (@uname, @pword, @type, @name, @date)"



                    sqlcommand.Parameters.Add(New MySqlParameter("@pword", passhash))
                    sqlcommand.Parameters.Add(New MySqlParameter("@type", category))
                    sqlcommand.Parameters.Add(New MySqlParameter("@name", NameTextBox.Text))
                    sqlcommand.Parameters.Add(New MySqlParameter("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
                    sqlcommand.ExecuteNonQuery()

                    sqlcommand.CommandText = "insert into salts (username,salt) values (@uname, @salt)"
                    'sqlcommand.Parameters.Add(New MySqlParameter("@uname", UsernameTextBox.Text))
                    sqlcommand.Parameters.Add(New MySqlParameter("@salt", salt))
                    sqlcommand.ExecuteNonQuery()

                    MsgBox("Added!")
                    LoginForm1.Show()
                Else
                    MsgBox("entry already exists")
                    'TODO: forgot password
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Function hash(ByVal pass As String, ByVal salt As String) As String
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(pass & salt)
        Dim hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(bytes)
        Dim strHash As String = Convert.ToBase64String(hashOfBytes)
        Return strHash
    End Function

    Private Sub DoctorButton_CheckedChanged(sender As Object, e As EventArgs) Handles DoctorButton.CheckedChanged
        category = "Doctor"
    End Sub

    Private Sub NurseButton_CheckedChanged(sender As Object, e As EventArgs) Handles NurseButton.CheckedChanged
        category = "Nurse"
    End Sub

    Private Sub SecretaryButton_CheckedChanged(sender As Object, e As EventArgs) Handles SecretaryButton.CheckedChanged
        category = "Secretary"
    End Sub

    Public Shared Function createRandomSalt() As String

        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!£$%^&*()-_=+{}][@'~#:;?/>.<,\|"
        Dim salt As String = ""

        Dim rnd As New Random

        Dim sb As New StringBuilder

        For i As Integer = 1 To 50
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next

        Return salt
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub
End Class
