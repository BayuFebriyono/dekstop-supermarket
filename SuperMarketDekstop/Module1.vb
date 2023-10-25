Module Module1
    Public base_url = "http://127.0.0.1:8000/api"
    Public token = Nothing
    Public Sub ClearTextBoxesInGroupBox(groupBox As GroupBox)
        For Each control As Control In groupBox.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                textBox.Text = String.Empty
            ElseIf TypeOf control Is GroupBox Then
                ' Jika ada GroupBox dalam GroupBox, panggil fungsi ini secara rekursif
                ClearTextBoxesInGroupBox(DirectCast(control, GroupBox))
            End If
        Next
    End Sub

    Public Sub onlyNumber(sender As Object, e As KeyPressEventArgs)
        ' Mengecek apakah karakter yang dimasukkan adalah angka, tanda minus, atau tombol backspace (8)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Mencegah karakter yang tidak diizinkan
        End If

        ' Mengecek apakah karakter minus ("-") hanya ditempatkan di awal TextBox
        If e.KeyChar = "-" AndAlso (TryCast(sender, TextBox)).SelectionStart > 0 Then
            e.Handled = True ' Mencegah tanda minus di tengah TextBox
        End If
    End Sub

    Public Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
End Module
