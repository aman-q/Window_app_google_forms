<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(84, 105)
        btnViewSubmissions.Margin = New Padding(3, 4, 3, 4)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(339, 65)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions(CTRL+V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCreateNewSubmission.Location = New Point(84, 214)
        btnCreateNewSubmission.Margin = New Padding(3, 4, 3, 4)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(339, 75)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "Create New Submission(CTRL +N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(378, 50)
        Label1.TabIndex = 2
        Label1.Text = "FORM APPLICATION"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 391)
        Controls.Add(Label1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "SLIDELY TASK"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label
End Class
