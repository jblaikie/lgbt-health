Imports MySql.Data.MySqlClient
Public Class NewPatientForm
    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand


    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
        Try
            MysqlConn.Open()
            sqlcommand.CommandText = "insert into patient_info (firstname, lastname, preferredname, pronouns, dob) values (@fname, @lname, @pname, @pron, @date)"
            sqlcommand.Connection = MysqlConn


            sqlcommand.Parameters.Add(New MySqlParameter("@fname", FirstNameTextBox.Text))
            sqlcommand.Parameters.Add(New MySqlParameter("@lname", LegalLastNameTextBox.Text))
            sqlcommand.Parameters.Add(New MySqlParameter("@pname", PrefNameTextBox.Text))
            sqlcommand.Parameters.Add(New MySqlParameter("@pron", PronounTextBox.Text))
            sqlcommand.Parameters.Add(New MySqlParameter("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            sqlcommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        SecretaryView.Show()
        Me.Close()
    End Sub


End Class