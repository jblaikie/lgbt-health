Public Class Doctor
    Public PatientList As ArrayList
    Private name As String
    'Private lname As String
    Private idnum As Integer
    ' Private picstr As String


    Public Sub New(ByVal Name As String, id As Integer)
        'constructor
        PatientList = New ArrayList()
        Me.name = Name
        'lname = lastname
        idnum = id
        'picstr = p
    End Sub

    Public Sub AddPatient(ByRef patient As Patient)
        PatientList.Add(patient)
    End Sub

    Public Sub RemovePatient(ByRef patient As Patient)
        PatientList.Remove(patient)

    End Sub

    Public Sub TransferPatient(ByRef doc As Doctor, patient As Patient)
        Me.RemovePatient(patient)
        doc.AddPatient(patient)
    End Sub
    Public ReadOnly Property DrID
        Get
            Return idnum
        End Get
    End Property
End Class
