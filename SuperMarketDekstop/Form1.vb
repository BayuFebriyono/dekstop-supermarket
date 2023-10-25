Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private tampil As Form
    Dim username As String = Nothing

    Private Sub openForm(form As Form)
        If tampil IsNot Nothing Then

        End If
        tampil = form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        MainPanel.Controls.Add(form)
        MainPanel.Tag = form
        form.BringToFront()
        form.Show()
    End Sub

    Async Sub getUserDetail()
        Dim apiUrl = base_url & "/mycredentials"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseContent)

                username = jsonResponse("user")("username").ToString()
                tbuser.Text = "Welcome back, " & username
            Else
                MsgBox("Terjadi Kesalahan silahkan login ulang", MsgBoxStyle.Exclamation)

                Login.Show()
                Me.Hide()

            End If
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerJam.Start()
        getUserDetail()
    End Sub

    Private Sub LokasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LokasiToolStripMenuItem.Click
        openForm(MasterLokasiForm)
    End Sub

    Private Sub RakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RakToolStripMenuItem.Click
        openForm(MasterRak)
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        openForm(MasterKaryawan)
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        openForm(MasterBarang)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        Dim time As DateTime = DateTime.Now
        Dim formatedTime As String = time.ToString("dd/MM/yyyy HH::mm::ss")
        lbJam.Text = formatedTime
    End Sub


End Class
