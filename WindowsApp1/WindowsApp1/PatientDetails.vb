Imports MySql.Data.MySqlClient
Public Class PatientDetails
    Dim curPatient As Patient
    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Public Property CurrentPatient() As Patient
        Get
            Return curPatient
        End Get
        Set(value As Patient)
            curPatient = value
        End Set
    End Property

    Private Sub PatientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If curPatient.Equals(Nothing) Then
            MsgBox("Error, no patient.")
            Me.Close()
        Else
            name_lbl.Text = curPatient.Preferredname() + curPatient.Lastname()
            dob_lbl.Text = DateTime.Today 'curPatient.DateofBirth()
            pronouns_lbl.Text = curPatient.Pronouns()
        End If
    End Sub

    Private Sub note_btn_Click(sender As Object, e As EventArgs) Handles note_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
        Try
            MysqlConn.Open()
            sqlcommand.CommandText = "insert into dr_notes (dr_id, patient_id, date, content) values (@drid, @pid, @date, @content)"
            sqlcommand.Connection = MysqlConn
            sqlcommand.Parameters.Add(New MySqlParameter("@drid", DoctorView.CurrDr.DrID))
            sqlcommand.Parameters.Add(New MySqlParameter("@pid", CurrentPatient.ID))
            sqlcommand.Parameters.Add(New MySqlParameter("@content", TextBox1.Text))
            sqlcommand.Parameters.Add(New MySqlParameter("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            sqlcommand.ExecuteNonQuery()

            MsgBox("Added!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        DoctorView.Show()
        Me.Close()

    End Sub

    Private Sub fetch_btn_Click(sender As Object, e As EventArgs) Handles fetch_btn.Click
        Try
            MysqlConn = New MySqlConnection()
            MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
            sqlcommand.CommandText = "select date, content from dr_notes where patient_id = @idnum"

            sqlcommand.Parameters.Add(New MySqlParameter("@idnum", curPatient.ID))


            sqlcommand.Connection = MysqlConn

            MysqlConn.Open()
            Dim myReader As MySqlDataReader
            myReader = sqlcommand.ExecuteReader()
            ListBox1.Items.Clear()

            While (myReader.Read())
                ListBox1.Items.Add(myReader.GetString(0) + " " + myReader.GetString(1))
            End While
            myReader.Close()
            MysqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class