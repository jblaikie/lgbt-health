Imports Microsoft.VisualBasic

Public Class Patient
    Dim idnum As String
    Dim prefname As String
    Dim fname As String
    Dim lname As String
    Dim height As Double
    Dim weight As Double
    Dim picstr As String
    Dim checkin As Boolean

    Public Sub New(ByVal id As String, pname As String, firstname As String, lastname As String, h As Double, w As Double, p As String)
        'constructor
        idnum = id
        prefname = pname
        fname = firstname
        lname = lastname
        height = h
        weight = w
        picstr = p
        checkin = False
    End Sub

End Class
