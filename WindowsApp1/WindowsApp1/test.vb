Imports System.Data
'Imports System.Security
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class PatientInfo




    'Sub Main()
    ' setuppass(pass1)

    'End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Dim click As String = TextBox1.Text
        'Label1.Text = click
        ' If connection.State = ConnectionState.Closed Then
        'connection.Open()
        'FirstName.Text = "Connected"
        'Dim reader As SqlDataReader = command.ExecuteReader()
        'Try
        'While reader.Read()
        'FirstName.Text = reader(0)
        'End While
        'Finally
        '' Always call Close when done reading.
        'reader.Close()
        'End Try
        'End If
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs)
        ' Dim query = From pat In localhost

        Dim cs As String = "Database=db_health;Data Source=localhost;" _
        & "User Id=admin;Password=luvi$4eva"

        Dim fname As String = "J"
        Dim stm As String = "SELECT * from patient_info where firstname = @firstname"
        Dim version As String
        Dim conn As MySqlConnection

        Try
            conn = New MySqlConnection(cs)
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.Parameters.AddWithValue("firstname", fname)

            'Me.FirstName.Text = Convert.ToString(cmd.ExecuteScalar())
            Me.FirstName.Text = "fuck"
            'Console.WriteLine("MySQL version: {0}", version)

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try


        'Me.FirstName.Text = ""

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles FirstName.Click
        Me.FirstName.Text = "fuck"
    End Sub



    Private Sub PatientInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        Dim id As String = "45646511"
        Dim stm As String = "SELECT firstname from patient_info where patient_id = @var"
        Me.FirstName.Text = callSql(stm, id)
        'Dim lname As String = "Blaikie"
        stm = "SELECT lastname from patient_info where patient_id = @var"
        Me.LastName.Text = callSql(stm, id)
        stm = "SELECT preferredname from patient_info where patient_id = @var"
        Me.PreferredName.Text = callSql(stm, id)
        stm = "SELECT height from patient_info where patient_id = @var"
        Me.Height.Text = callSql(stm, id) + " inches"
        stm = "SELECT weight from patient_info where patient_id = @var"
        Me.Weight.Text = callSql(stm, id) + " pounds"
    End Sub

    Private Function callSql(query As String, var As String) As String ' EDIT to return string, set firstname in prev method 
        Dim cs As String = "Database=db_health;Data Source=localhost;" _
       & "User Id=admin;Password=luvi$4eva;SslMode=none"
        Dim conn As MySqlConnection
        Dim result As String = ""
        'Me.FirstName.Text = "fuck"
        Try
            conn = New MySqlConnection(cs)
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("var", var)

            result = Convert.ToString(cmd.ExecuteScalar())
            'Me.FirstName.Text = "fuck"
            'Console.WriteLine("MySQL version: {0}", version)

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        Return result
    End Function
End Class
