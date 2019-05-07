Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class DoctorView
    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Dim currentDr As Doctor
    Private Sub DoctorView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
        sqlcommand.CommandText = "select * from patient_info where primary_dr = @idnum"
        Dim idnum = LoginForm1.idnum
        sqlcommand.Parameters.Add(New MySqlParameter("@idnum", idnum))
        Dim name = LoginForm1.accountname
        LoginForm1.Close()
        currentDr = New Doctor(name, idnum)
        sqlcommand.Connection = MysqlConn

        MysqlConn.Open()
        Dim myReader As MySqlDataReader
        myReader = sqlcommand.ExecuteReader()
        ComboBox1.Items.Clear()

        While (myReader.Read())
            currentDr.AddPatient(New Patient(myReader.GetString(3), myReader.GetString(0), myReader.GetString(1), myReader.GetString(7), myReader.GetString(4), myReader.GetInt32(9), myReader.GetInt32(6))) ', myReader.GetDateTime(2)))
            ComboBox1.Items.Add(myReader.GetString(3) + " " + myReader.GetString(1))
        End While
        myReader.Close()
        MysqlConn.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PatientDetails.CurrentPatient = currentDr.PatientList(ComboBox1.SelectedIndex())
        PatientDetails.Show()
    End Sub
    Public ReadOnly Property CurrDr
        Get
            Return currentDr
        End Get
    End Property
End Class