<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterBarang
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
        Me.dgbarang = New System.Windows.Forms.DataGridView()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.tbdiskon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCatatan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.cbRak = New System.Windows.Forms.ComboBox()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tanggal_lahir = New System.Windows.Forms.Label()
        Me.tbSatuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbButton.SuspendLayout()
        Me.gbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgbarang
        '
        Me.dgbarang.AllowUserToAddRows = False
        Me.dgbarang.AllowUserToDeleteRows = False
        Me.dgbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbarang.Location = New System.Drawing.Point(12, 12)
        Me.dgbarang.Name = "dgbarang"
        Me.dgbarang.ReadOnly = True
        Me.dgbarang.RowHeadersWidth = 51
        Me.dgbarang.RowTemplate.Height = 24
        Me.dgbarang.Size = New System.Drawing.Size(1238, 220)
        Me.dgbarang.TabIndex = 0
        '
        'gbButton
        '
        Me.gbButton.Controls.Add(Me.Button3)
        Me.gbButton.Controls.Add(Me.Button2)
        Me.gbButton.Controls.Add(Me.Button1)
        Me.gbButton.Location = New System.Drawing.Point(176, 506)
        Me.gbButton.Name = "gbButton"
        Me.gbButton.Size = New System.Drawing.Size(947, 100)
        Me.gbButton.TabIndex = 10
        Me.gbButton.TabStop = False
        Me.gbButton.Text = "Buttons"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(612, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(267, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(324, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.tbdiskon)
        Me.gbForm.Controls.Add(Me.Label6)
        Me.gbForm.Controls.Add(Me.tbCatatan)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.tbHarga)
        Me.gbForm.Controls.Add(Me.cbRak)
        Me.gbForm.Controls.Add(Me.tbStock)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.tanggal_lahir)
        Me.gbForm.Controls.Add(Me.tbSatuan)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Controls.Add(Me.tbNama)
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.Button5)
        Me.gbForm.Controls.Add(Me.Button4)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(29, 248)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(1221, 236)
        Me.gbForm.TabIndex = 9
        Me.gbForm.TabStop = False
        Me.gbForm.Text = "Form"
        Me.gbForm.Visible = False
        '
        'tbdiskon
        '
        Me.tbdiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdiskon.Location = New System.Drawing.Point(692, 186)
        Me.tbdiskon.Name = "tbdiskon"
        Me.tbdiskon.Size = New System.Drawing.Size(321, 34)
        Me.tbdiskon.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(536, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Diskon"
        '
        'tbCatatan
        '
        Me.tbCatatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCatatan.Location = New System.Drawing.Point(692, 107)
        Me.tbCatatan.Multiline = True
        Me.tbCatatan.Name = "tbCatatan"
        Me.tbCatatan.Size = New System.Drawing.Size(321, 61)
        Me.tbCatatan.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Catatan"
        '
        'tbHarga
        '
        Me.tbHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHarga.Location = New System.Drawing.Point(692, 21)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(321, 34)
        Me.tbHarga.TabIndex = 17
        '
        'cbRak
        '
        Me.cbRak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRak.FormattingEnabled = True
        Me.cbRak.Location = New System.Drawing.Point(147, 21)
        Me.cbRak.Name = "cbRak"
        Me.cbRak.Size = New System.Drawing.Size(321, 37)
        Me.cbRak.TabIndex = 16
        '
        'tbStock
        '
        Me.tbStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStock.Location = New System.Drawing.Point(692, 67)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(321, 34)
        Me.tbStock.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stock"
        '
        'tanggal_lahir
        '
        Me.tanggal_lahir.AutoSize = True
        Me.tanggal_lahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal_lahir.Location = New System.Drawing.Point(536, 15)
        Me.tanggal_lahir.Name = "tanggal_lahir"
        Me.tanggal_lahir.Size = New System.Drawing.Size(65, 25)
        Me.tanggal_lahir.TabIndex = 12
        Me.tanggal_lahir.Text = "Harga"
        '
        'tbSatuan
        '
        Me.tbSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSatuan.Location = New System.Drawing.Point(147, 153)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.Size = New System.Drawing.Size(321, 34)
        Me.tbSatuan.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Satuan"
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(147, 67)
        Me.tbNama.Multiline = True
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(321, 61)
        Me.tbNama.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Barang"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1123, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 32)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1025, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rak"
        '
        'MasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 656)
        Me.Controls.Add(Me.gbButton)
        Me.Controls.Add(Me.gbForm)
        Me.Controls.Add(Me.dgbarang)
        Me.Name = "MasterBarang"
        Me.Text = "MasterBarang"
        CType(Me.dgbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbButton.ResumeLayout(False)
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgbarang As DataGridView
    Friend WithEvents gbButton As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents gbForm As GroupBox
    Friend WithEvents tbStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tanggal_lahir As Label
    Friend WithEvents tbSatuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbCatatan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents cbRak As ComboBox
    Friend WithEvents tbdiskon As TextBox
    Friend WithEvents Label6 As Label
End Class
