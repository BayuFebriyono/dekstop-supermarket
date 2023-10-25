<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterRak
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
        Me.dgrak = New System.Windows.Forms.DataGridView()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cblokasi = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbrak = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgrak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbForm.SuspendLayout()
        Me.gbButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrak
        '
        Me.dgrak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrak.Location = New System.Drawing.Point(12, 12)
        Me.dgrak.Name = "dgrak"
        Me.dgrak.RowHeadersWidth = 51
        Me.dgrak.RowTemplate.Height = 24
        Me.dgrak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrak.Size = New System.Drawing.Size(1249, 251)
        Me.dgrak.TabIndex = 0
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.cblokasi)
        Me.gbForm.Controls.Add(Me.Button5)
        Me.gbForm.Controls.Add(Me.Button4)
        Me.gbForm.Controls.Add(Me.tbrak)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(57, 284)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(1204, 135)
        Me.gbForm.TabIndex = 8
        Me.gbForm.TabStop = False
        Me.gbForm.Text = "Form"
        Me.gbForm.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(616, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rak"
        '
        'cblokasi
        '
        Me.cblokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblokasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cblokasi.FormattingEnabled = True
        Me.cblokasi.Location = New System.Drawing.Point(100, 15)
        Me.cblokasi.Name = "cblokasi"
        Me.cblokasi.Size = New System.Drawing.Size(353, 37)
        Me.cblokasi.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(797, 58)
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
        Me.Button4.Location = New System.Drawing.Point(699, 58)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tbrak
        '
        Me.tbrak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrak.Location = New System.Drawing.Point(691, 18)
        Me.tbrak.Name = "tbrak"
        Me.tbrak.Size = New System.Drawing.Size(321, 34)
        Me.tbrak.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lokasi"
        '
        'gbButton
        '
        Me.gbButton.Controls.Add(Me.Button3)
        Me.gbButton.Controls.Add(Me.Button2)
        Me.gbButton.Controls.Add(Me.Button1)
        Me.gbButton.Location = New System.Drawing.Point(230, 565)
        Me.gbButton.Name = "gbButton"
        Me.gbButton.Size = New System.Drawing.Size(947, 88)
        Me.gbButton.TabIndex = 7
        Me.gbButton.TabStop = False
        Me.gbButton.Text = "Buttons"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(613, 21)
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
        Me.Button2.Location = New System.Drawing.Point(325, 21)
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
        Me.Button1.Location = New System.Drawing.Point(38, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MasterRak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 764)
        Me.Controls.Add(Me.gbForm)
        Me.Controls.Add(Me.gbButton)
        Me.Controls.Add(Me.dgrak)
        Me.Name = "MasterRak"
        Me.Text = "MasterRak"
        CType(Me.dgrak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.gbButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgrak As DataGridView
    Friend WithEvents gbForm As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbrak As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbButton As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cblokasi As ComboBox
End Class
