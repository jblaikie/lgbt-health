Imports Microsoft.VisualBasic

Public Class Patient
    Dim prefname As String
    Dim fname As String
    Dim lname As String
    Dim height As Double
    Dim weight As Double
    Dim picstr As String

    Public Sub New(ByVal pname As String, firstname As String, lastname As String, h As Double, w As Double, p As String)
        'constructor
        prefname = pname
        fname = firstname
        lname = lastname
        height = h
        weight = w
        picstr = p
    End Sub

End Class
