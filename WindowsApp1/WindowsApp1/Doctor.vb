Public Class Doctor
    Private PatientList As ArrayList
    Private fname As String
    Private lname As String
    Private picstr As String


    Public Sub New(ByVal pname As String, firstname As String, lastname As String, p As String)
        'constructor
        PatientList = New ArrayList()
        fname = firstname
        lname = lastname
        picstr = p
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
End Class
