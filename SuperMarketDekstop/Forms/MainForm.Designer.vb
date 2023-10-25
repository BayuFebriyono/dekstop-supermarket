<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.panelDekstop = New System.Windows.Forms.Panel()
        Me.iconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Navy
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.IconButton5)
        Me.PanelMenu.Controls.Add(Me.IconButton4)
        Me.PanelMenu.Controls.Add(Me.IconButton3)
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 787)
        Me.PanelMenu.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 1
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.DarkBlue
        Me.PanelTitleBar.Controls.Add(Me.lbName)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.iconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1273, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbName.Location = New System.Drawing.Point(929, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(344, 32)
        Me.lbName.TabIndex = 2
        Me.lbName.Text = "Welcome back, Username"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(44, 32)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(44, 16)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'panelDekstop
        '
        Me.panelDekstop.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelDekstop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDekstop.Location = New System.Drawing.Point(220, 75)
        Me.panelDekstop.Name = "panelDekstop"
        Me.panelDekstop.Size = New System.Drawing.Size(1273, 712)
        Me.panelDekstop.TabIndex = 2
        '
        'iconCurrentForm
        '
        Me.iconCurrentForm.BackColor = System.Drawing.Color.DarkBlue
        Me.iconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        Me.iconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconCurrentForm.Location = New System.Drawing.Point(6, 21)
        Me.iconCurrentForm.Name = "iconCurrentForm"
        Me.iconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.iconCurrentForm.TabIndex = 0
        Me.iconCurrentForm.TabStop = False
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.IconButton6.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 32
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 440)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Size = New System.Drawing.Size(220, 60)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.Text = "Transaksi"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.IconButton5.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 32
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 380)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton5.Size = New System.Drawing.Size(220, 60)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.Text = "Master Rak"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.ChildReaching
        Me.IconButton4.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 32
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 320)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton4.Size = New System.Drawing.Size(220, 60)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.Text = "Master Pelanggan"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.LocationDot
        Me.IconButton3.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 32
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 260)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton3.Size = New System.Drawing.Size(220, 60)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.Text = "Master Lokasi"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.IconButton2.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 32
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 200)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(220, 60)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "Master Barang"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 140)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(220, 60)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "Master Karyawan"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'ImgHome
        '
        Me.ImgHome.Image = Global.SuperMarketDekstop.My.Resources.Resources.pngwing_com
        Me.ImgHome.Location = New System.Drawing.Point(12, 32)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(189, 73)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 787)
        Me.Controls.Add(Me.panelDekstop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents iconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents panelDekstop As Panel
    Friend WithEvents lbName As Label
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
End Class
