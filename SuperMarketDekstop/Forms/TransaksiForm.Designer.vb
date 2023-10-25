<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1222, 248)
        Me.DataGridView1.TabIndex = 0
        '
        'cbPelanggan
        '
        Me.cbPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(149, 54)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(321, 37)
        Me.cbPelanggan.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pelanggan"
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 665)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TransaksiForm"
        Me.Text = "TransaksiForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbPelanggan As ComboBox
    Friend WithEvents Label1 As Label
End Class
