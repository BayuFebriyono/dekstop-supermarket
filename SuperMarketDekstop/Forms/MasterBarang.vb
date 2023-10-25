Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class MasterBarang

    Dim id As String = Nothing
    Dim edit As Boolean = False
    Private Sub getAllBarang()
        Using httpClient As New HttpClient()
            Dim apiUrl = base_url & "/barang"
            Dim response As HttpResponseMessage = httpClient.GetAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                Dim jsonContent As String = response.Content.ReadAsStringAsync().Result
                Dim items As List(Of Barang) = JsonConvert.DeserializeObject(Of List(Of Barang))(jsonContent)
                dgbarang.DataSource = items.Select(Function(item) New With {
                    .id = item.id,
                    .NamaBarang = item.nama_barang,
                    .NamaRak = item.rak.rak,
                    .satuan = item.satuan,
                    .harga = item.harga,
                    .stock = item.stock,
                    .catatan = item.catatan,
                    .diskon = item.diskon
                }).ToList()
                dgbarang.Columns(3).Visible = False
            Else

                MsgBox("Gagal memuat Data", MsgBoxStyle.Exclamation)

            End If
        End Using
    End Sub

    Private Sub getRak()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/rak"
            Dim responsse As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If responsse.IsSuccessStatusCode Then
                Dim dataJson As String = responsse.Content.ReadAsStringAsync().Result

                Dim dataList As List(Of Rak) = JsonConvert.DeserializeObject(Of List(Of Rak))(dataJson)

                cbRak.DataSource = dataList
                cbRak.DisplayMember = "rak"
                cbRak.ValueMember = "id"
            Else
                MsgBox("Data Gagal Dimuat", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub PostDataFromApi()
        LoadingForm.Show()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/barang"
            Dim jsonContent As String = $"{{""rak_id"":""{cbRak.SelectedValue}"",""nama_barang"":""{tbNama.Text}"", ""satuan"":""{tbSatuan.Text}"", ""harga"":""{Integer.Parse(tbHarga.Text)}"",""stock"":""{Integer.Parse(tbStock.Text)}"", ""catatan"":""{tbCatatan.Text}"",""diskon"":""{tbdiskon.Text}""}}"

            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PostAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                getAllBarang()
            Else
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Exclamation)
            End If

        End Using
        LoadingForm.Close()
    End Sub

    Private Sub PutData()
        LoadingForm.Show()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/barang/" & id
            Dim jsonContent As String = $"{{""rak_id"":""{cbRak.SelectedValue}"",""nama_barang"":""{tbNama.Text}"", ""satuan"":""{tbSatuan.Text}"", ""harga"":""{Integer.Parse(tbHarga.Text)}"",""stock"":""{Integer.Parse(tbStock.Text)}"", ""catatan"":""{tbCatatan.Text}"",""diskon"":""{tbdiskon.Text}""}}"

            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PutAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil diubah", MsgBoxStyle.Information)
                getAllBarang()
            Else
                MsgBox("Data gagal diubah", MsgBoxStyle.Exclamation)
            End If

        End Using
        LoadingForm.Close()
    End Sub

    Private Sub DeleteDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/barang/" & id
            Dim response As HttpResponseMessage = HttpClient.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                getAllBarang()
            Else
                MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub


    Private Sub tbdiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdiskon.KeyPress
        ' Mengecek apakah karakter yang dimasukkan adalah angka, desimal point (.), atau tombol backspace (8)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Mencegah karakter yang tidak diizinkan
        End If

        ' Mengecek apakah ada lebih dari satu desimal point dalam TextBox
        If e.KeyChar = "." AndAlso (TryCast(sender, TextBox)).Text.IndexOf(".") > -1 Then
            e.Handled = True ' Mencegah lebih dari satu desimal point
        End If
    End Sub

    Private Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingForm.Show()
        getAllBarang()
        getRak()
        LoadingForm.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearTextBoxesInGroupBox(gbForm)
        gbForm.Visible = True
        gbButton.Visible = False
        dgbarang.Enabled = False

        edit = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If id IsNot Nothing Then
            gbForm.Visible = True
            gbButton.Visible = False
            dgbarang.Enabled = False

            edit = True
        Else
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If edit = False Then
            LoadingForm.Show()
            PostDataFromApi()
            LoadingForm.Close()
        Else
            LoadingForm.Show()
            PutData()
            LoadingForm.Close()
            id = Nothing
        End If
        gbForm.Visible = False
        gbButton.Visible = True
        dgbarang.Enabled = True
    End Sub



    Private Sub dgbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbarang.CellClick
        If e.RowIndex >= 0 Then
            id = dgbarang.Rows(e.RowIndex).Cells(0).Value
            cbRak.Text = dgbarang.Rows(e.RowIndex).Cells(2).Value
            tbNama.Text = dgbarang.Rows(e.RowIndex).Cells(1).Value
            tbSatuan.Text = dgbarang.Rows(e.RowIndex).Cells(3).Value
            tbHarga.Text = dgbarang.Rows(e.RowIndex).Cells(4).Value
            tbStock.Text = dgbarang.Rows(e.RowIndex).Cells(5).Value
            tbCatatan.Text = dgbarang.Rows(e.RowIndex).Cells(6).Value
            tbdiskon.Text = dgbarang.Rows(e.RowIndex).Cells(7).Value
        End If
    End Sub



    Private Sub tbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHarga.KeyPress
        onlyNumber(sender, e)
    End Sub


    Private Sub tbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStock.KeyPress
        onlyNumber(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Nothing, "Apakah anda ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                LoadingForm.Show()
                DeleteDataFromApi()
                LoadingForm.Close()
                id = Nothing
            End If
        End If
    End Sub
End Class