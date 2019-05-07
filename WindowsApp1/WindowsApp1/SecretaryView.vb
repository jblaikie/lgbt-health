Imports MySql.Data.MySqlClient
Public Class SecretaryView
    Dim MysqlConn As MySqlConnection
    Dim sqlcommand As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=program; password=luvi$4eva; database=db_health"
        Dim dt As New DataTable
        Try
            sqlcommand.CommandText = "select blood_pressure, temperature from tbl_vitals inner join conditions_and_meds inner join patient_info where lastname = @lname"
            sqlcommand.Connection = MysqlConn
            sqlcommand.Parameters.Add(New MySqlParameter("@lname", "Blaikie"))

            da.SelectCommand = sqlcommand

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Label1.Text = dt.Rows(0).Item(0)
                Label2.Text = dt.Rows(0).Item(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SecretaryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub new_patient_btn_Click(sender As Object, e As EventArgs) Handles new_patient_btn.Click
        NewPatientForm.Show()
        Me.Hide()
    End Sub
End Class