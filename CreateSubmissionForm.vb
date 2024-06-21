Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As Integer = 0

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
            btnStopwatch.Text = "Start (CTRL +T)"
        Else
            Timer1.Start()
            stopwatchRunning = True
            btnStopwatch.Text = "Stop (CTRL +T)"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime += 1
        lblElapsedTime.Text = "Elapsed Time: " & elapsedTime & " seconds"
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Await SubmitForm()
    End Sub

    Private Async Function SubmitForm() As Task
        If Not IsValidEmail(txtEmail.Text) Then
            MessageBox.Show("Invalid email format.")
            Return
        End If

        If elapsedTime <= 0 Then
            MessageBox.Show("Stopwatch time should be more than 0.")
            Return
        End If

        Dim submission As New Submissions With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhoneNumber.Text,
            .github_link = txtGitHubRepo.Text,
            .stopwatch_time = elapsedTime
        }

        Dim json As String = JsonConvert.SerializeObject(submission)

        MessageBox.Show(json)

        Using client As New HttpClient()
            Try
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/api/submit", content)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission saved!")
                    ClearFields() ' Clear the fields after successful submission
                Else
                    MessageBox.Show("Error: " & response.StatusCode & " - " & response.ReasonPhrase & Environment.NewLine & responseContent)
                End If
            Catch ex As Exception
                MessageBox.Show("Exception occurred: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub ClearFields()
        txtName.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhoneNumber.Text = String.Empty
        txtGitHubRepo.Text = String.Empty
        elapsedTime = 0
        lblElapsedTime.Text = "Elapsed Time: 0 seconds"
        btnStopwatch.Text = "Start"
        stopwatchRunning = False
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub
End Class

Public Class Submissions
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As Integer
End Class
