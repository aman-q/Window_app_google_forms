<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        btnSubmit = New Button()
        btnStopwatch = New Button()
        lblElapsedTime = New Label()
        Timer1 = New Timer(components)
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubRepo = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(200, 46)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(200, 92)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(265, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(200, 138)
        txtPhoneNumber.Margin = New Padding(4, 5, 4, 5)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(265, 27)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(200, 185)
        txtGitHubRepo.Margin = New Padding(4, 5, 4, 5)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(265, 27)
        txtGitHubRepo.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(167, 306)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(146, 35)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(47, 231)
        btnStopwatch.Margin = New Padding(4, 5, 4, 5)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(144, 35)
        btnStopwatch.TabIndex = 5
        btnStopwatch.Text = "Start(CTRL+T)"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' lblElapsedTime
        ' 
        lblElapsedTime.AutoSize = True
        lblElapsedTime.Location = New Point(234, 238)
        lblElapsedTime.Margin = New Padding(4, 0, 4, 0)
        lblElapsedTime.Name = "lblElapsedTime"
        lblElapsedTime.Size = New Size(113, 20)
        lblElapsedTime.TabIndex = 6
        lblElapsedTime.Text = "Elapsed Time: 0"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(67, 46)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 7
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(67, 92)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(67, 138)
        lblPhoneNumber.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(108, 20)
        lblPhoneNumber.TabIndex = 9
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' lblGitHubRepo
        ' 
        lblGitHubRepo.AutoSize = True
        lblGitHubRepo.Location = New Point(67, 185)
        lblGitHubRepo.Margin = New Padding(4, 0, 4, 0)
        lblGitHubRepo.Name = "lblGitHubRepo"
        lblGitHubRepo.Size = New Size(95, 20)
        lblGitHubRepo.TabIndex = 10
        lblGitHubRepo.Text = "GitHub Repo"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 487)
        Controls.Add(lblGitHubRepo)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblElapsedTime)
        Controls.Add(btnStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubRepo As Label
End Class
