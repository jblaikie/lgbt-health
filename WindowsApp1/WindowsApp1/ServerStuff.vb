'Imports System.Data
'Imports MySql.Data
'Imports MySql.Data.MySqlClient
'Public Class Servershit
'Private Sub PatientInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated


'Dim id As String = "45646511"
'Dim stm As String = "SELECT firstname from patient_info where patient_id = @var"
'test.FirstName.Text = callSql(stm, id)
''Dim lname As String = "Blaikie"
'stm = "SELECT lastname from patient_info where patient_id = @var"
'Me.LastName.Text = callSql(stm, id)
'stm = "SELECT preferredname from patient_info where patient_id = @var"
'Me.PreferredName.Text = callSql(stm, id)
'stm = "SELECT height from patient_info where patient_id = @var"
'Me.Height.Text = callSql(stm, id) + " inches"
'stm = "SELECT weight from patient_info where patient_id = @var"
'Me.Weight.Text = callSql(stm, id) + " pounds"
'stm = "SELECT photopath from patient_info where patient_id = @var"
'Me.Photo.ImageLocation = callSql(stm, id)
'End Sub
''
'Private Function callSql(query As String, var As String) As String ' EDIT to return string, set firstname in prev method 
'Dim cs As String = "Database=db_health;Data Source=localhost;" _
'      & "User Id=admin;Password=luvi$4eva;SslMode=none"
'Dim conn As MySqlConnection
'Dim result As String = ""
'Me.FirstName.Text = "fuck"
'Try
'conn = New MySqlConnection(cs)
'conn.Open()
'
'Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
'cmd.Parameters.AddWithValue("var", var)

'result = Convert.ToString(cmd.ExecuteScalar())
'Me.FirstName.Text = "fuck"
'Console.WriteLine("MySQL version: {0}", version)
'
'Catch ex As MySqlException
'Console.WriteLine("Error: " & ex.ToString())
'Finally
'conn.Close()
'End Try
'Return result
'End Function






'conn = New MySqlConnection


'Dim cs As String = "Database=db_accounts;Data Source=localhost;" + "CertificateFile=C:\\mysqlcerts\\client.pfx" + "CertificatePassword=pass;" + "SSL Mode=Required;" + "User Id=admin;Password=luvi$4eva"
'conn.ConnectionString = cs
'Dim command As New MySqlCommand("SELECT `id`, `password` FROM `tbl_users` WHERE `id` = @username AND `password` = @password", conn)
'command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
'command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxPassword.Text
'
'End Class
