<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatientForm
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
        Me.PrefNameTextBox = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LegalLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PronounTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'PrefNameTextBox
        '
        Me.PrefNameTextBox.Location = New System.Drawing.Point(26, 53)
        Me.PrefNameTextBox.Name = "PrefNameTextBox"
        Me.PrefNameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.PrefNameTextBox.TabIndex = 12
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(24, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(220, 23)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Preferred Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date of Birth"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LegalLastNameTextBox
        '
        Me.LegalLastNameTextBox.Location = New System.Drawing.Point(308, 124)
        Me.LegalLastNameTextBox.Name = "LegalLastNameTextBox"
        Me.LegalLastNameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.LegalLastNameTextBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(308, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Legal Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(308, 53)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.FirstNameTextBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(308, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Legal First Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PronounTextBox
        '
        Me.PronounTextBox.Location = New System.Drawing.Point(25, 129)
        Me.PronounTextBox.Name = "PronounTextBox"
        Me.PronounTextBox.Size = New System.Drawing.Size(220, 22)
        Me.PronounTextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pronouns"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContinueButton
        '
        Me.ContinueButton.Location = New System.Drawing.Point(194, 305)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(185, 46)
        Me.ContinueButton.TabIndex = 21
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(433, 341)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(277, 22)
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.Value = New Date(2019, 4, 10, 0, 0, 0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(25, 216)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(112, 216)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(71, 24)
        Me.ComboBox2.TabIndex = 24
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(206, 216)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(71, 24)
        Me.ComboBox3.TabIndex = 25
        '
        'NewUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.PronounTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LegalLastNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrefNameTextBox)
        Me.Controls.Add(Me.lblName)
        Me.Name = "NewUserForm"
        Me.Text = "NewUserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrefNameTextBox As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LegalLastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PronounTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContinueButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
