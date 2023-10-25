Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class MasterRak

    Dim edit As Boolean = False
    Dim id As String = Nothing
    Private Sub getAllRak()
        Using httpClient As New HttpClient()
            Dim apiUrl = base_url & "/rak"
            Dim response As HttpResponseMessage = httpClient.GetAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                Dim jsonContent As String = response.Content.ReadAsStringAsync().Result
                Dim items As List(Of Rak) = JsonConvert.DeserializeObject(Of List(Of Rak))(jsonContent)
                dgrak.DataSource = items.Select(Function(item) New With {
                    .id = item.id,
                    .Rak = item.rak,
                    .NamaLokasi = item.lokasi.nama_lokasi,
                    .LoksaiId = item.lokasi.id
                }).ToList()
                dgrak.Columns(3).Visible = False
            Else

                MsgBox("Gagal memuat Data", MsgBoxStyle.Exclamation)

            End If
        End Using
    End Sub

    Sub getLokasi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/lokasi"
            Dim responsse As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If responsse.IsSuccessStatusCode Then
                Dim dataJson As String = responsse.Content.ReadAsStringAsync().Result

                Dim dataList As List(Of Lokasi) = JsonConvert.DeserializeObject(Of List(Of Lokasi))(dataJson)

                cblokasi.DataSource = dataList
                cblokasi.ValueMember = "id"
                cblokasi.DisplayMember = "nama_lokasi"
                cblokasi.SelectedIndex = 0
            Else
                MsgBox("Data Gagal Dimuat", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub PostDataFromApi(rak_id As String, rak As String)
        LoadingForm.Show()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/rak"
            Dim jsonContent As String = $"{{""lokasi_id"":""{rak_id}"",""rak"":""{rak}""}}"

            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PostAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                getAllRak()
            Else
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Exclamation)
            End If

        End Using
        LoadingForm.Close()
    End Sub

    Private Sub DeleteDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/rak/" & id
            Dim response As HttpResponseMessage = HttpClient.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                getAllRak()
            Else
                MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub

    Private Sub PutData(lokasi_id As String, rak As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/rak/" & id
            Dim jsonContent As String = $"{{""lokasi_id"":""{lokasi_id}"", ""rak"":""{rak}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PutAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil diubah", MsgBoxStyle.Information)
                getAllRak()
            Else
                MsgBox("Data gagal diubah", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub

    Private Sub MasterRak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingForm.Show()

        getAllRak()
        getLokasi()
        LoadingForm.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbButton.Visible = False
        gbForm.Visible = True
        dgrak.Enabled = False
        edit = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If edit = False Then

            PostDataFromApi(cblokasi.SelectedValue, tbrak.Text)
            gbForm.Visible = False
            gbButton.Visible = True
            dgrak.Enabled = True
            tbrak.Text = ""
        Else
            PutData(cblokasi.SelectedValue, tbrak.Text)
            gbForm.Visible = False
            gbButton.Visible = True
            dgrak.Enabled = True
            tbrak.Text = ""
            id = Nothing
        End If

        gbButton.Visible = True
        gbForm.Visible = False
        dgrak.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If id IsNot Nothing Then
            gbButton.Visible = False
            gbForm.Visible = True
            dgrak.Enabled = False
            edit = True
        Else
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Private Sub dgrak_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrak.CellClick
        If (e.RowIndex >= 0) Then
            id = dgrak.Rows(e.RowIndex).Cells(0).Value
            tbrak.Text = dgrak.Rows(e.RowIndex).Cells(1).Value
            cblokasi.SelectedValue = dgrak.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Nothing,"Apakah anda ingin menghapus data?","konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteDataFromApi()
            End If
        End If
    End Sub
End Class