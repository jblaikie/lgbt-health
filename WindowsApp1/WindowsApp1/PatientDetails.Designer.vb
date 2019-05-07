<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dob_lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pronouns_lbl = New System.Windows.Forms.Label()
        Me.note_btn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.fetch_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.adl_info_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Temp_lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BP_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.oxy_lbl = New System.Windows.Forms.Label()
        Me.weight_lbl = New System.Windows.Forms.Label()
        Me.height_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'name_lbl
        '
        Me.name_lbl.AutoSize = True
        Me.name_lbl.Location = New System.Drawing.Point(134, 156)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(51, 17)
        Me.name_lbl.TabIndex = 1
        Me.name_lbl.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date of Birth"
        '
        'dob_lbl
        '
        Me.dob_lbl.AutoSize = True
        Me.dob_lbl.Location = New System.Drawing.Point(238, 156)
        Me.dob_lbl.Name = "dob_lbl"
        Me.dob_lbl.Size = New System.Drawing.Size(51, 17)
        Me.dob_lbl.TabIndex = 3
        Me.dob_lbl.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pronouns"
        '
        'pronouns_lbl
        '
        Me.pronouns_lbl.AutoSize = True
        Me.pronouns_lbl.Location = New System.Drawing.Point(337, 156)
        Me.pronouns_lbl.Name = "pronouns_lbl"
        Me.pronouns_lbl.Size = New System.Drawing.Size(51, 17)
        Me.pronouns_lbl.TabIndex = 5
        Me.pronouns_lbl.Text = "Label6"
        '
        'note_btn
        '
        Me.note_btn.Location = New System.Drawing.Point(90, 401)
        Me.note_btn.Name = "note_btn"
        Me.note_btn.Size = New System.Drawing.Size(123, 43)
        Me.note_btn.TabIndex = 6
        Me.note_btn.Text = "Add Note"
        Me.note_btn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 462)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 107)
        Me.TextBox1.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(803, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(262, 356)
        Me.ListBox1.TabIndex = 8
        '
        'fetch_btn
        '
        Me.fetch_btn.Location = New System.Drawing.Point(708, 6)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.Size = New System.Drawing.Size(89, 60)
        Me.fetch_btn.TabIndex = 9
        Me.fetch_btn.Text = "Fetch Notes"
        Me.fetch_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(15, 15)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(50, 44)
        Me.back_btn.TabIndex = 10
        Me.back_btn.Text = "<-"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'adl_info_btn
        '
        Me.adl_info_btn.Location = New System.Drawing.Point(694, 206)
        Me.adl_info_btn.Name = "adl_info_btn"
        Me.adl_info_btn.Size = New System.Drawing.Size(103, 55)
        Me.adl_info_btn.TabIndex = 11
        Me.adl_info_btn.Text = "Additional Info"
        Me.adl_info_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "BP"
        '
        'Temp_lbl
        '
        Me.Temp_lbl.AutoSize = True
        Me.Temp_lbl.Location = New System.Drawing.Point(499, 156)
        Me.Temp_lbl.Name = "Temp_lbl"
        Me.Temp_lbl.Size = New System.Drawing.Size(51, 17)
        Me.Temp_lbl.TabIndex = 13
        Me.Temp_lbl.Text = "Label4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Temperature"
        '
        'BP_lbl
        '
        Me.BP_lbl.AutoSize = True
        Me.BP_lbl.Location = New System.Drawing.Point(428, 156)
        Me.BP_lbl.Name = "BP_lbl"
        Me.BP_lbl.Size = New System.Drawing.Size(51, 17)
        Me.BP_lbl.TabIndex = 15
        Me.BP_lbl.Text = "Label7"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Height"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(499, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Updated On"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(337, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Oxygen Saturation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Weight"
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Location = New System.Drawing.Point(499, 266)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(59, 17)
        Me.date_lbl.TabIndex = 20
        Me.date_lbl.Text = "Label10"
        '
        'oxy_lbl
        '
        Me.oxy_lbl.AutoSize = True
        Me.oxy_lbl.Location = New System.Drawing.Point(337, 266)
        Me.oxy_lbl.Name = "oxy_lbl"
        Me.oxy_lbl.Size = New System.Drawing.Size(59, 17)
        Me.oxy_lbl.TabIndex = 21
        Me.oxy_lbl.Text = "Label11"
        '
        'weight_lbl
        '
        Me.weight_lbl.AutoSize = True
        Me.weight_lbl.Location = New System.Drawing.Point(238, 266)
        Me.weight_lbl.Name = "weight_lbl"
        Me.weight_lbl.Size = New System.Drawing.Size(59, 17)
        Me.weight_lbl.TabIndex = 22
        Me.weight_lbl.Text = "Label12"
        '
        'height_lbl
        '
        Me.height_lbl.AutoSize = True
        Me.height_lbl.Location = New System.Drawing.Point(134, 266)
        Me.height_lbl.Name = "height_lbl"
        Me.height_lbl.Size = New System.Drawing.Size(59, 17)
        Me.height_lbl.TabIndex = 23
        Me.height_lbl.Text = "Label13"
        '
        'PatientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 623)
        Me.Controls.Add(Me.height_lbl)
        Me.Controls.Add(Me.weight_lbl)
        Me.Controls.Add(Me.oxy_lbl)
        Me.Controls.Add(Me.date_lbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BP_lbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Temp_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adl_info_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.fetch_btn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.note_btn)
        Me.Controls.Add(Me.pronouns_lbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dob_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientDetails"
        Me.Text = "PatientDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents name_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dob_lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pronouns_lbl As Label
    Friend WithEvents note_btn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents fetch_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents adl_info_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Temp_lbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BP_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents date_lbl As Label
    Friend WithEvents oxy_lbl As Label
    Friend WithEvents weight_lbl As Label
    Friend WithEvents height_lbl As Label
End Class
