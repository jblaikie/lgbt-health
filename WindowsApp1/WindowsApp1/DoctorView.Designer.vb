﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ptntpic2 = New System.Windows.Forms.PictureBox()
        Me.ptntpic3 = New System.Windows.Forms.PictureBox()
        Me.Labelptnt = New System.Windows.Forms.Label()
        Me.ptntname2 = New System.Windows.Forms.Label()
        Me.ptntname3 = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.lblPtntName = New System.Windows.Forms.Label()
        Me.ptntpic = New System.Windows.Forms.PictureBox()
        Me.grpPatientDisplay = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ptntpic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptntpic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptntpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPatientDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptntpic2
        '
        Me.ptntpic2.Location = New System.Drawing.Point(256, 257)
        Me.ptntpic2.Name = "ptntpic2"
        Me.ptntpic2.Size = New System.Drawing.Size(122, 94)
        Me.ptntpic2.TabIndex = 1
        Me.ptntpic2.TabStop = False
        Me.ptntpic2.Visible = False
        '
        'ptntpic3
        '
        Me.ptntpic3.Location = New System.Drawing.Point(440, 257)
        Me.ptntpic3.Name = "ptntpic3"
        Me.ptntpic3.Size = New System.Drawing.Size(109, 94)
        Me.ptntpic3.TabIndex = 2
        Me.ptntpic3.TabStop = False
        Me.ptntpic3.Visible = False
        '
        'Labelptnt
        '
        Me.Labelptnt.AutoSize = True
        Me.Labelptnt.Location = New System.Drawing.Point(33, 137)
        Me.Labelptnt.Name = "Labelptnt"
        Me.Labelptnt.Size = New System.Drawing.Size(78, 17)
        Me.Labelptnt.TabIndex = 3
        Me.Labelptnt.Text = "Patient List"
        '
        'ptntname2
        '
        Me.ptntname2.AutoSize = True
        Me.ptntname2.Location = New System.Drawing.Point(265, 375)
        Me.ptntname2.Name = "ptntname2"
        Me.ptntname2.Size = New System.Drawing.Size(51, 17)
        Me.ptntname2.TabIndex = 5
        Me.ptntname2.Text = "Label1"
        Me.ptntname2.Visible = False
        '
        'ptntname3
        '
        Me.ptntname3.AutoSize = True
        Me.ptntname3.Location = New System.Drawing.Point(448, 380)
        Me.ptntname3.Name = "ptntname3"
        Me.ptntname3.Size = New System.Drawing.Size(51, 17)
        Me.ptntname3.TabIndex = 6
        Me.ptntname3.Text = "Label1"
        Me.ptntname3.Visible = False
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Location = New System.Drawing.Point(52, 41)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(90, 17)
        Me.welcome.TabIndex = 7
        Me.welcome.Text = "Hello, Doctor"
        '
        'lblDoctorName
        '
        Me.lblDoctorName.AutoSize = True
        Me.lblDoctorName.Location = New System.Drawing.Point(148, 41)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(0, 17)
        Me.lblDoctorName.TabIndex = 8
        '
        'lblPtntName
        '
        Me.lblPtntName.AutoSize = True
        Me.lblPtntName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPtntName.Location = New System.Drawing.Point(78, 370)
        Me.lblPtntName.Name = "lblPtntName"
        Me.lblPtntName.Size = New System.Drawing.Size(126, 19)
        Me.lblPtntName.TabIndex = 4
        Me.lblPtntName.Text = "Patient name bruh"
        Me.lblPtntName.Visible = False
        '
        'ptntpic
        '
        Me.ptntpic.Location = New System.Drawing.Point(43, 38)
        Me.ptntpic.Name = "ptntpic"
        Me.ptntpic.Size = New System.Drawing.Size(112, 95)
        Me.ptntpic.TabIndex = 0
        Me.ptntpic.TabStop = False
        '
        'grpPatientDisplay
        '
        Me.grpPatientDisplay.Controls.Add(Me.ptntpic)
        Me.grpPatientDisplay.Location = New System.Drawing.Point(35, 218)
        Me.grpPatientDisplay.Name = "grpPatientDisplay"
        Me.grpPatientDisplay.Size = New System.Drawing.Size(200, 196)
        Me.grpPatientDisplay.TabIndex = 9
        Me.grpPatientDisplay.TabStop = False
        Me.grpPatientDisplay.Text = "Patient Display"
        Me.grpPatientDisplay.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(415, 400)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(297, 20)
        Me.ListBox1.TabIndex = 10
        Me.ListBox1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(92, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 11
        '
        'DoctorView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblDoctorName)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.ptntname3)
        Me.Controls.Add(Me.ptntname2)
        Me.Controls.Add(Me.lblPtntName)
        Me.Controls.Add(Me.Labelptnt)
        Me.Controls.Add(Me.ptntpic3)
        Me.Controls.Add(Me.ptntpic2)
        Me.Controls.Add(Me.grpPatientDisplay)
        Me.Name = "DoctorView"
        Me.Text = "DoctorView"
        CType(Me.ptntpic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptntpic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptntpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPatientDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptntpic2 As PictureBox
    Friend WithEvents ptntpic3 As PictureBox
    Friend WithEvents Labelptnt As Label
    Friend WithEvents ptntname2 As Label
    Friend WithEvents ptntname3 As Label
    Friend WithEvents welcome As Label
    Friend WithEvents lblDoctorName As Label
    Friend WithEvents lblPtntName As Label
    Friend WithEvents ptntpic As PictureBox
    Friend WithEvents grpPatientDisplay As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
