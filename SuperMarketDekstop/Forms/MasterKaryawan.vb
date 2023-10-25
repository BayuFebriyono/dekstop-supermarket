Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class MasterKaryawan

    Dim id As String = Nothing
    Dim edit As Boolean = False
    Private Sub GetDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/karyawan"
            Dim responsse As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If responsse.IsSuccessStatusCode Then
                Dim dataJson As String = responsse.Content.ReadAsStringAsync().Result

                Dim dataList As List(Of Kayawan) = JsonConvert.DeserializeObject(Of List(Of Kayawan))(dataJson)

                dgKaryawan.DataSource = dataList
            Else
                MsgBox("Data Gagal Dimuat", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub PostDataFromApi(nama As String, alamat As String, tempat_lahir As String, tanggal_lahir As String, no_hp As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/karyawan"
            Dim jsonContent As String = $"{{""nama"":""{nama}"",""alamat"":""{alamat}"",""tempat_lahir"":""{tempat_lahir}"",""tanggal_lahir"":""{tanggal_lahir}"",""no_hp"":""{no_hp}""}}"
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

    Private Sub PutDataFromApi(nama As String, alamat As String, tempat_lahir As String, tanggal_lahir As String, no_hp As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/karyawan/" & id
            Dim jsonContent As String = $"{{""nama"":""{nama}"",""alamat"":""{alamat}"",""tempat_lahir"":""{tempat_lahir}"",""tanggal_lahir"":""{tanggal_lahir}"",""no_hp"":""{no_hp}""}}"
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
            Dim apiUrl As String = base_url & "/karyawan/" & id
            Dim response As HttpResponseMessage = HttpClient.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub
    Private Sub Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingForm.Show()
        GetDataFromApi()
        LoadingForm.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbButton.Visible = False
        gbForm.Visible = True
        dgKaryawan.Enabled = False
        edit = False
        ClearTextBoxesInGroupBox(gbForm)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If edit = False Then
            LoadingForm.Show()
            PostDataFromApi(tbNama.Text, tbAlamat.Text, tbTempatLahir.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), tbNohp.Text)
            LoadingForm.Close()
        Else

            LoadingForm.Show()
            PutDataFromApi(tbNama.Text, tbAlamat.Text, tbTempatLahir.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), tbNohp.Text)
            LoadingForm.Close()
        End If

        gbButton.Visible = True
        gbForm.Visible = False
        dgKaryawan.Enabled = True
    End Sub



    Private Sub dgKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKaryawan.CellClick
        If e.RowIndex >= 0 Then
            id = dgKaryawan.Rows(e.RowIndex).Cells(0).Value
            tbNama.Text = dgKaryawan.Rows(e.RowIndex).Cells(1).Value
            tbAlamat.Text = dgKaryawan.Rows(e.RowIndex).Cells(2).Value
            tbTempatLahir.Text = dgKaryawan.Rows(e.RowIndex).Cells(3).Value
            DateTimePicker1.Value = dgKaryawan.Rows(e.RowIndex).Cells(4).Value
            tbNohp.Text = dgKaryawan.Rows(e.RowIndex).Cells(5).Value
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            gbButton.Visible = False
            gbForm.Visible = True
            dgKaryawan.Enabled = False
            edit = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Nothing, "Apakah anda igin menghapus data", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteDataFromApi()
            End If
        End If
    End Sub
End Class