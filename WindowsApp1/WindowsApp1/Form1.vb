Imports System.Data.SqlClient


Public Class Form1
    Dim queryString As String = "SELECT * FROM dbo.Name;"
    Dim connection As New SqlConnection("Server = NO-3113; Database = LGBT-Health; Integrated Security = True")
    Dim command As New SqlCommand(queryString, connection)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim click As String = TextBox1.Text
        'Label1.Text = click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            Label1.Text = "Connected"
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Label1.Text = reader(0)
                End While
            Finally
                ' Always call Close when done reading.
                reader.Close()
            End Try
        End If
    End Sub
End Class
