<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGitHubRepo = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.btnPrevious.Location = New System.Drawing.Point(6, 312)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(164, 50)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous (CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.btnNext.Location = New System.Drawing.Point(231, 312)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(164, 50)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next (CTRL+F)"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.btnDelete.Location = New System.Drawing.Point(125, 370)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 50)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.lblName.Location = New System.Drawing.Point(50, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name: "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.lblEmail.Location = New System.Drawing.Point(50, 112)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(61, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email: "
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(50, 162)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(130, 20)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.Text = "Phone Number: "
        '
        'lblGitHubRepo
        '
        Me.lblGitHubRepo.AutoSize = True
        Me.lblGitHubRepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.lblGitHubRepo.Location = New System.Drawing.Point(50, 212)
        Me.lblGitHubRepo.Name = "lblGitHubRepo"
        Me.lblGitHubRepo.Size = New System.Drawing.Size(116, 20)
        Me.lblGitHubRepo.TabIndex = 6
        Me.lblGitHubRepo.Text = "GitHub Repo: "
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F)
        Me.lblTimeStamp.Location = New System.Drawing.Point(50, 262)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(116, 20)
        Me.lblTimeStamp.TabIndex = 7
        Me.lblTimeStamp.Text = "Time Stamp: "
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.lblTimeStamp)
        Me.Controls.Add(Me.lblGitHubRepo)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubRepo As Label
    Friend WithEvents lblTimeStamp As Label
End Class
