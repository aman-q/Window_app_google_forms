Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Await LoadSubmissionsAsync(currentIndex)
            ShowSubmission(currentIndex)
            AddHandler Me.KeyDown, AddressOf ViewSubmissionsForm_KeyDown
            Me.KeyPreview = True
        Catch ex As Exception
            MessageBox.Show("Error during form load: " & ex.Message)
        End Try
    End Sub

    Private Async Function LoadSubmissionsAsync(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/api/read?index={index}")
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Debug.WriteLine("JSON Response: " & responseBody)
                Dim singleSubmission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)
                If submissions.Count <= index Then
                    submissions.Add(singleSubmission)
                Else
                    submissions(index) = singleSubmission
                End If
            Catch ex As HttpRequestException
                MessageBox.Show("Error fetching data: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub ShowSubmission(index As Integer)
        If submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            Debug.WriteLine("Showing Submission at index " & index & ": " & submission.TimeStamp)
            lblName.Text = "Name: " & submission.Name
            lblEmail.Text = "Email: " & submission.Email
            lblPhoneNumber.Text = "Phone Number: " & submission.PhoneNumber
            lblGitHubRepo.Text = "GitHub Repo: " & submission.GitHubRepo
            lblTimeStamp.Text = "Time Stamp: " & submission.TimeStamp.ToString()
        Else
            lblName.Text = "Name: "
            lblEmail.Text = "Email: "
            lblPhoneNumber.Text = "Phone Number: "
            lblGitHubRepo.Text = "GitHub Repo: "
            lblTimeStamp.Text = "Time Stamp: "
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Try
                Await LoadSubmissionsAsync(currentIndex)
                ShowSubmission(currentIndex)
            Catch ex As Exception
                MessageBox.Show("Error during previous navigation: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No previous submission available.")
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Try
            Await LoadSubmissionsAsync(currentIndex)
            ShowSubmission(currentIndex)
        Catch ex As Exception
            MessageBox.Show("Error during next navigation: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submissionToDelete = submissions(currentIndex)
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the submission from {submissionToDelete.Name}?", "Confirm Deletion", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Await DeleteSubmissionAsync(submissionToDelete)
                    submissions.RemoveAt(currentIndex)
                    If currentIndex >= submissions.Count Then
                        currentIndex = submissions.Count - 1
                    End If
                    ShowSubmission(currentIndex)
                Catch ex As Exception
                    MessageBox.Show("Error during deletion: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("No submission available to delete.")
        End If
    End Sub

    Private Async Function DeleteSubmissionAsync(submission As Submission) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/api/delete?index={currentIndex}")
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission deleted successfully.")
            Catch ex As HttpRequestException
                MessageBox.Show("Error deleting submission: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.F Then
            e.SuppressKeyPress = True
            Invoke(New Action(Sub() btnNext.PerformClick()))
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            e.SuppressKeyPress = True
            Invoke(New Action(Sub() btnPrevious.PerformClick()))
        End If
    End Sub

    Public Class Submission
        <JsonProperty("name")>
        Public Property Name As String

        <JsonProperty("email")>
        Public Property Email As String

        <JsonProperty("phone")>
        Public Property PhoneNumber As String

        <JsonProperty("github_link")>
        Public Property GitHubRepo As String

        <JsonProperty("stopwatch_time")>
        Public Property TimeStamp As Integer
    End Class
End Class
