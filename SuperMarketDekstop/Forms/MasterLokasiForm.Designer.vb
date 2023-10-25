<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterLokasiForm
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
        Me.dgLokasi = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLokasi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.gbButton = New System.Windows.Forms.GroupBox()
        CType(Me.dgLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbForm.SuspendLayout()
        Me.gbButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgLokasi
        '
        Me.dgLokasi.AllowUserToAddRows = False
        Me.dgLokasi.AllowUserToDeleteRows = False
        Me.dgLokasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgLokasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLokasi.Location = New System.Drawing.Point(12, 26)
        Me.dgLokasi.Name = "dgLokasi"
        Me.dgLokasi.ReadOnly = True
        Me.dgLokasi.RowHeadersWidth = 51
        Me.dgLokasi.RowTemplate.Height = 24
        Me.dgLokasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLokasi.Size = New System.Drawing.Size(1204, 365)
        Me.dgLokasi.TabIndex = 0
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
        'tbLokasi
        '
        Me.tbLokasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLokasi.Location = New System.Drawing.Point(100, 21)
        Me.tbLokasi.Name = "tbLokasi"
        Me.tbLokasi.Size = New System.Drawing.Size(321, 34)
        Me.tbLokasi.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(40, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(327, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(615, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(267, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.Button5)
        Me.gbForm.Controls.Add(Me.Button4)
        Me.gbForm.Controls.Add(Me.tbLokasi)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(12, 397)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(1204, 135)
        Me.gbForm.TabIndex = 6
        Me.gbForm.TabStop = False
        Me.gbForm.Text = "Form"
        Me.gbForm.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(198, 61)
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
        Me.Button4.Location = New System.Drawing.Point(100, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'gbButton
        '
        Me.gbButton.Controls.Add(Me.Button3)
        Me.gbButton.Controls.Add(Me.Button2)
        Me.gbButton.Controls.Add(Me.Button1)
        Me.gbButton.Location = New System.Drawing.Point(168, 552)
        Me.gbButton.Name = "gbButton"
        Me.gbButton.Size = New System.Drawing.Size(947, 100)
        Me.gbButton.TabIndex = 3
        Me.gbButton.TabStop = False
        Me.gbButton.Text = "Buttons"
        '
        'MasterLokasiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 656)
        Me.Controls.Add(Me.dgLokasi)
        Me.Controls.Add(Me.gbForm)
        Me.Controls.Add(Me.gbButton)
        Me.Name = "MasterLokasiForm"
        Me.Text = "MasterLokasiForm"
        CType(Me.dgLokasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.gbButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgLokasi As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbLokasi As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gbForm As GroupBox
    Friend WithEvents gbButton As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
