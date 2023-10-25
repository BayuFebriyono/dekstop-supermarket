

Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class Login
    Private Async Sub PostDataFromApi()
        LoadingForm.Show()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/login"
            Dim jsonContent As String = $"{{""username"":""{tbusername.Text}"",""password"":""{tbpass.Text}""}}"

            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PostAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then

                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseContent)
                token = jsonResponse("token").ToString()

                MsgBox("Login Berhasil", MsgBoxStyle.Information)

                MainForm.Show()
                Me.Hide()

            Else
                MsgBox("Login Gagal", MsgBoxStyle.Exclamation)
            End If

        End Using
        LoadingForm.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PostDataFromApi()
    End Sub
End Class