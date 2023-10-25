Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports FontAwesome.Sharp
Imports Newtonsoft.Json.Linq

Public Class MainForm
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form


    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

    End Sub

    'methods
    Private Sub activeButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            disableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form Icon
            iconCurrentForm.IconChar = currentBtn.IconChar
            iconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub disableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Navy
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub openChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelDekstop.Controls.Add(childForm)
        panelDekstop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text

    End Sub

    Async Sub getUserDetail()
        Dim apiUrl = base_url & "/mycredentials"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseContent)

                Dim username = jsonResponse("user")("username").ToString()
                lbName.Text = "Welcome back, " & username

            Else
                Login.Show()
                MsgBox("Terjadi Kesalahan silahkan login ulang", MsgBoxStyle.Exclamation)
                Me.Close()

            End If
        End Using
    End Sub

    'events
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        activeButton(sender, Color.FromArgb(102, 102, 255))
        openChildForm(New MasterKaryawan)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activeButton(sender, Color.FromArgb(255, 178, 102))
        openChildForm(New MasterBarang)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        activeButton(sender, Color.FromArgb(255, 153, 204))
        openChildForm(New MasterLokasiForm)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        activeButton(sender, Color.FromArgb(153, 255, 153))
        openChildForm(New MasterPelanggan)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        activeButton(sender, Color.FromArgb(255, 51, 255))
        openChildForm(New MasterRak)
    End Sub
    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        activeButton(sender, Color.FromArgb(79, 218, 170))
        openChildForm(New TransaksiForm)
    End Sub

    Private Sub ImgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        reset()
    End Sub

    Private Sub reset()
        disableButton()

        leftBorderBtn.Visible = False
        iconCurrentForm.IconChar = IconChar.Home
        iconCurrentForm.IconColor = Color.Gainsboro
        lblFormTitle.Text = "Home"
    End Sub

    Private Sub IconDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getUserDetail()
    End Sub


End Class