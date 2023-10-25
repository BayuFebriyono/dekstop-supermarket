Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class MasterPelanggan

    Dim id As String = Nothing
    Dim edit As Boolean = False
    Private Sub GetDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/pelanggan"
            Dim responsse As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If responsse.IsSuccessStatusCode Then
                Dim dataJson As String = responsse.Content.ReadAsStringAsync().Result

                Dim items As List(Of Pelanggan) = JsonConvert.DeserializeObject(Of List(Of Pelanggan))(dataJson)

                dgPelanggan.DataSource = items.Select(Function(item) New With {
                    .id = item.id,
                    .Nama = item.nama,
                    .Alamat = item.alamat,
                    .TempatLahir = item.tempat_lahir,
                    .TanggalLahir = item.tanggal_lahir,
                    .NoHp = item.no_hp,
                    .Poin = If(item.poin IsNot Nothing, item.poin, 0)
                }).ToList()

            Else
                MsgBox("Data Gagal Dimuat", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub PostDataFromApi(nama As String, alamat As String, tempat_lahir As String, tanggal_lahir As String, no_hp As String, poin As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/pelanggan"
            Dim jsonContent As String = $"{{""nama"":""{nama}"",""alamat"":""{alamat}"",""tempat_lahir"":""{tempat_lahir}"",""tanggal_lahir"":""{tanggal_lahir}"",""no_hp"":""{no_hp}"", ""poin"":""{poin}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")


            Dim response As HttpResponseMessage = HttpClient.PostAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub

    Private Sub PutDataFromApi(nama As String, alamat As String, tempat_lahir As String, tanggal_lahir As String, no_hp As String, poin As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/pelanggan/" & id
            Dim jsonContent As String = $"{{""nama"":""{nama}"",""alamat"":""{alamat}"",""tempat_lahir"":""{tempat_lahir}"",""tanggal_lahir"":""{tanggal_lahir}"",""no_hp"":""{no_hp}"", ""poin"":""{poin}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")


            Dim response As HttpResponseMessage = HttpClient.PutAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil diubah", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal diubah", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub
    Private Sub DeleteDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/pelanggan/" & id
            Dim response As HttpResponseMessage = HttpClient.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub
    Private Sub MasterPelangga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingForm.Show()
        GetDataFromApi()
        LoadingForm.Close()
    End Sub



    Private Sub tbPoin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPoin.KeyPress
        onlyNumber(sender, e)
    End Sub

    Private Sub tbNohp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNohp.KeyPress
        onlyNumber(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbForm.Visible = True
        gbButton.Visible = False
        dgPelanggan.Enabled = False
        edit = False
        ClearTextBoxesInGroupBox(gbForm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            gbForm.Visible = True
            gbButton.Visible = False
            dgPelanggan.Enabled = False
            edit = True
        End If
    End Sub


    Private Sub dgPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPelanggan.CellClick
        If e.RowIndex >= 0 Then
            id = dgPelanggan.Rows(e.RowIndex).Cells(0).Value
            tbNama.Text = dgPelanggan.Rows(e.RowIndex).Cells(1).Value
            tbAlamat.Text = dgPelanggan.Rows(e.RowIndex).Cells(2).Value
            tbTempatLahir.Text = dgPelanggan.Rows(e.RowIndex).Cells(3).Value
            DateTimePicker1.Value = dgPelanggan.Rows(e.RowIndex).Cells(4).Value
            tbNohp.Text = dgPelanggan.Rows(e.RowIndex).Cells(5).Value
            tbPoin.Text = dgPelanggan.Rows(e.RowIndex).Cells(6).Value
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If edit = False Then
            LoadingForm.Show()
            PostDataFromApi(tbNama.Text, tbAlamat.Text, tbTempatLahir.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), tbNohp.Text, tbPoin.Text)
            LoadingForm.Close()
        Else
            LoadingForm.Show()
            PutDataFromApi(tbNama.Text, tbAlamat.Text, tbTempatLahir.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), tbNohp.Text, tbPoin.Text)
            LoadingForm.Close()
        End If
        gbForm.Visible = False
        gbButton.Visible = True
        dgPelanggan.Enabled = True
        id = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Nothing, "Apakah anda ingin menghapus data ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteDataFromApi()
            End If
        End If
    End Sub
End Class