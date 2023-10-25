<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPelanggan
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
        Me.dgPelanggan = New System.Windows.Forms.DataGridView()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.tbPoin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNohp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tanggal_lahir = New System.Windows.Forms.Label()
        Me.tbTempatLahir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbButton.SuspendLayout()
        Me.gbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgPelanggan
        '
        Me.dgPelanggan.AllowUserToAddRows = False
        Me.dgPelanggan.AllowUserToDeleteRows = False
        Me.dgPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPelanggan.Location = New System.Drawing.Point(12, 12)
        Me.dgPelanggan.Name = "dgPelanggan"
        Me.dgPelanggan.ReadOnly = True
        Me.dgPelanggan.RowHeadersWidth = 51
        Me.dgPelanggan.RowTemplate.Height = 24
        Me.dgPelanggan.Size = New System.Drawing.Size(1238, 309)
        Me.dgPelanggan.TabIndex = 0
        '
        'gbButton
        '
        Me.gbButton.Controls.Add(Me.Button3)
        Me.gbButton.Controls.Add(Me.Button2)
        Me.gbButton.Controls.Add(Me.Button1)
        Me.gbButton.Location = New System.Drawing.Point(156, 574)
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
        Me.Button3.Location = New System.Drawing.Point(610, 21)
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
        Me.Button2.Location = New System.Drawing.Point(322, 21)
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
        Me.Button1.Location = New System.Drawing.Point(35, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.tbPoin)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.tbNohp)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.DateTimePicker1)
        Me.gbForm.Controls.Add(Me.tanggal_lahir)
        Me.gbForm.Controls.Add(Me.tbTempatLahir)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Controls.Add(Me.tbAlamat)
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.Button5)
        Me.gbForm.Controls.Add(Me.Button4)
        Me.gbForm.Controls.Add(Me.tbNama)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(9, 332)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(1221, 236)
        Me.gbForm.TabIndex = 9
        Me.gbForm.TabStop = False
        Me.gbForm.Text = "Form"
        Me.gbForm.Visible = False
        '
        'tbPoin
        '
        Me.tbPoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPoin.Location = New System.Drawing.Point(692, 127)
        Me.tbPoin.Name = "tbPoin"
        Me.tbPoin.Size = New System.Drawing.Size(321, 34)
        Me.tbPoin.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Poin"
        '
        'tbNohp
        '
        Me.tbNohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNohp.Location = New System.Drawing.Point(692, 67)
        Me.tbNohp.Name = "tbNohp"
        Me.tbNohp.Size = New System.Drawing.Size(321, 34)
        Me.tbNohp.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "No HP"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(692, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(321, 30)
        Me.DateTimePicker1.TabIndex = 13
        '
        'tanggal_lahir
        '
        Me.tanggal_lahir.AutoSize = True
        Me.tanggal_lahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal_lahir.Location = New System.Drawing.Point(536, 15)
        Me.tanggal_lahir.Name = "tanggal_lahir"
        Me.tanggal_lahir.Size = New System.Drawing.Size(132, 25)
        Me.tanggal_lahir.TabIndex = 12
        Me.tanggal_lahir.Text = "Tanggal Lahir"
        '
        'tbTempatLahir
        '
        Me.tbTempatLahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTempatLahir.Location = New System.Drawing.Point(147, 153)
        Me.tbTempatLahir.Name = "tbTempatLahir"
        Me.tbTempatLahir.Size = New System.Drawing.Size(321, 34)
        Me.tbTempatLahir.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tempat Lahir"
        '
        'tbAlamat
        '
        Me.tbAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlamat.Location = New System.Drawing.Point(147, 67)
        Me.tbAlamat.Multiline = True
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(321, 61)
        Me.tbAlamat.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Alamat"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(921, 179)
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
        Me.Button4.Location = New System.Drawing.Point(823, 179)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(147, 15)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(321, 34)
        Me.tbNama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'MasterPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 656)
        Me.Controls.Add(Me.gbButton)
        Me.Controls.Add(Me.gbForm)
        Me.Controls.Add(Me.dgPelanggan)
        Me.Name = "MasterPelanggan"
        Me.Text = "MasterPelangga"
        CType(Me.dgPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbButton.ResumeLayout(False)
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgPelanggan As DataGridView
    Friend WithEvents gbButton As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents gbForm As GroupBox
    Friend WithEvents tbPoin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNohp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tanggal_lahir As Label
    Friend WithEvents tbTempatLahir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label1 As Label
End Class
