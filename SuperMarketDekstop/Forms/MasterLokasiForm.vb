Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text


Public Class MasterLokasiForm


    Dim edit As Boolean = False
    Dim id As String = Nothing

    Private Sub MasterLokasiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataFromApi()
    End Sub



    Private Sub GetDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/lokasi"
            Dim responsse As HttpResponseMessage = HttpClient.GetAsync(apiUrl).Result

            If responsse.IsSuccessStatusCode Then
                Dim dataJson As String = responsse.Content.ReadAsStringAsync().Result

                Dim dataList As List(Of Lokasi) = JsonConvert.DeserializeObject(Of List(Of Lokasi))(dataJson)

                dgLokasi.DataSource = dataList
            Else
                MsgBox("Data Gagal Dimuat", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub PostDataFromApi(value As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/lokasi"
            Dim jsonContent As String = $"{{""nama_lokasi"":""{value}""}}"
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

    Private Sub DeleteDataFromApi()
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/lokasi/" & id
            Dim response As HttpResponseMessage = HttpClient.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub

    Private Sub PutDataFromApi(value As String)
        Using HttpClient As New HttpClient()
            Dim apiUrl As String = base_url & "/lokasi/" & id
            Dim jsonContent As String = $"{{""nama_lokasi"":""{value}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = HttpClient.PutAsync(apiUrl, content).Result

            If response.IsSuccessStatusCode Then
                MsgBox("Data berhasil diubah", MsgBoxStyle.Information)
                GetDataFromApi()
            Else
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Exclamation)
            End If

        End Using
    End Sub

    Private Sub dgLokasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLokasi.CellClick
        If e.RowIndex >= 0 Then
            tbLokasi.Text = dgLokasi.Rows(e.RowIndex).Cells(1).Value
            id = dgLokasi.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbForm.Visible = True
        gbButton.Visible = False
        tbLokasi.Text = ""
        edit = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gbForm.Visible = False
        gbButton.Visible = True
        dgLokasi.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If edit = False Then
            PostDataFromApi(tbLokasi.Text)
            gbForm.Visible = False
            gbButton.Visible = True
            dgLokasi.Enabled = True
            tbLokasi.Text = ""
        Else
            PutDataFromApi(tbLokasi.Text)
            gbForm.Visible = False
            gbButton.Visible = True
            dgLokasi.Enabled = True
            tbLokasi.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            edit = True
            gbButton.Visible = False
            gbForm.Visible = True
            dgLokasi.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id Is Nothing Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Nothing, "Apakah Anda Yakin", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteDataFromApi()
            End If

        End If
    End Sub
End Class


