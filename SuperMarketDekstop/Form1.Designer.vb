<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LokasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.lbJam = New System.Windows.Forms.Label()
        Me.tbuser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1409, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LokasiToolStripMenuItem, Me.RakToolStripMenuItem, Me.KaryawanToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'LokasiToolStripMenuItem
        '
        Me.LokasiToolStripMenuItem.Name = "LokasiToolStripMenuItem"
        Me.LokasiToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LokasiToolStripMenuItem.Text = "Lokasi"
        '
        'RakToolStripMenuItem
        '
        Me.RakToolStripMenuItem.Name = "RakToolStripMenuItem"
        Me.RakToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RakToolStripMenuItem.Text = "Rak"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'MainPanel
        '
        Me.MainPanel.Location = New System.Drawing.Point(53, 128)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 703)
        Me.MainPanel.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1340, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TimerJam
        '
        '
        'lbJam
        '
        Me.lbJam.AutoSize = True
        Me.lbJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJam.Location = New System.Drawing.Point(12, 45)
        Me.lbJam.Name = "lbJam"
        Me.lbJam.Size = New System.Drawing.Size(78, 29)
        Me.lbJam.TabIndex = 3
        Me.lbJam.Text = "lbJam"
        '
        'tbuser
        '
        Me.tbuser.AutoSize = True
        Me.tbuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuser.Location = New System.Drawing.Point(12, 84)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(86, 29)
        Me.tbuser.TabIndex = 4
        Me.tbuser.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1409, 921)
        Me.Controls.Add(Me.tbuser)
        Me.Controls.Add(Me.lbJam)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LokasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
    Friend WithEvents RakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerJam As Timer
    Friend WithEvents lbJam As Label
    Friend WithEvents tbuser As Label
End Class
