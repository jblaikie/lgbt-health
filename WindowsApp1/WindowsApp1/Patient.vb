Imports Microsoft.VisualBasic

Public Class Patient
    Dim prefname As String
    Dim fname As String
    'Dim mname As String
    Dim lname As String
    Dim pronoun As String
    Dim pDr As Integer
    Dim pId As Integer
    Dim picstr As String
    Dim dob As Date

    Public Sub New(ByVal pname As String, firstname As String, lastname As String, p As String, pro As String, pd As Integer, patid As Integer) ', 'bday As Date)
        'constructor
        prefname = pname
        fname = firstname
        lname = lastname
        Pronouns = pro
        pDr = pd
        pId = patid
        picstr = p
        'dob = bday
    End Sub
    Public Property PicPath() As String
        Get
            Return picstr
        End Get
        Set(ByVal value As String)
            picstr = value
        End Set
    End Property
    Public Property Preferredname() As String
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
    Public Property DateofBirth() As Date
        Get
            Return dob
        End Get
        Set(value As Date)
            dob = value
        End Set
    End Property
    Public Property Pronouns() As String
        Get
            Return pronoun
        End Get
        Set(value As String)
            pronoun = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return pId
        End Get
        Set(value As Integer)
            pId = value
        End Set
    End Property
End Class
