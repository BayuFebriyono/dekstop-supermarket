Imports System.Net.Http
Imports Newtonsoft.Json

Public Class TransaksiForm

    Sub getPelanggan()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/pelanggan"
            Dim response As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                Dim jsonContent As String = response.Content.ReadAsStringAsync().Result
                Dim items As List(Of Pelanggan) = JsonConvert.DeserializeObject(Of List(Of Pelanggan))(jsonContent)

                cbPelanggan.DataSource = items
                cbPelanggan.ValueMember = "id"
                cbPelanggan.DisplayMember = "nama"
                cbPelanggan.SelectedIndex = 0
            Else
                MsgBox("Data gagal dimuat")

            End If
        End Using
    End Sub

    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPelanggan()
    End Sub
End Class