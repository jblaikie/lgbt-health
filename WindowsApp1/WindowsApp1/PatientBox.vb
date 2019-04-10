'Public Class PatientBox
'    Inherits GroupBox
'    Dim person As Patient
'    Dim picBox As New PictureBox
'    Dim lblName As New Label
'    Dim lblFullName As New Label

'    Public Sub New(patient As Patient)
'        person = patient
'        Size = New Size(208, 301)
'        FlatStyle = FlatStyle.Standard
'        Location = New Point(0, 0)
'        With picBox
'            .ImageLocation = person.PicPath
'            .BackgroundImageLayout = ImageLayout.Stretch
'            .Size = New Size(162, 141)
'            .Location = New Point(24, 21)
'        End With

'        With lblName
'            .Text = person.Preferedname
'            .AutoSize = True
'            .Location = New Point(21, 189)
'        End With

'        With lblFullName
'            .Text = person.Firstname + person.Lastname
'            .AutoSize = False
'            .AutoEllipsis = True
'            .Size = New Size(163, 23)
'            .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
'            .Location = New Point(21, 253)
'        End With
'        components.Add(picBox)
'        components.Add(lblName)
'        components.Add(lblFullName)
'    End Sub
'End Class
