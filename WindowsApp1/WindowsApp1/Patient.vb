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
    Public Property PicPath() As String
        Get
            Return picstr
        End Get
        Set(ByVal value As String)
            picstr = value
        End Set
    End Property
    Public Property Preferedname() As String
        Get
            Return prefname
        End Get
        Set(ByVal value As String)
            prefname = value
        End Set
    End Property
    Public Property Firstname() As String
        Get
            Return fname
        End Get
        Set(ByVal value As String)
            fname = value
        End Set
    End Property
    Public Property Lastname() As String
        Get
            Return lname
        End Get
        Set(ByVal value As String)
            lname = value
        End Set
    End Property
End Class
