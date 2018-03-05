Imports System.Data.SqlClient
Imports System.Security


Public Class Form1
    Dim queryString As String = "SELECT * FROM dbo.Name;"

    Dim pass1 As String = "luvi$4eva"
    Dim connection As New SqlConnection("Server = NO-3113; Database = LGBT-Health", New SqlCredential("admin", setuppass(pass1)))
    Dim command As New SqlCommand(queryString, connection)



    'Sub Main()
    ' setuppass(pass1)

    'End Sub

    Private Function setuppass(pass As String)
        Dim index As Integer = 0
        Dim password As New SecureString()
        While index < pass.Length
            password.AppendChar(pass.Chars(index))
            index = index + 1
        End While
        password.MakeReadOnly()
        Return password
    End Function

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
