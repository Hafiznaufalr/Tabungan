<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HitungNilaiMasaDepan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSetoranBln = New System.Windows.Forms.TextBox()
        Me.txtBunga = New System.Windows.Forms.TextBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.txtNilaiMasaDepan = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setoran Bulanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bunga (tahun)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Tahun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai Masa Depan"
        '
        'txtSetoranBln
        '
        Me.txtSetoranBln.Location = New System.Drawing.Point(172, 33)
        Me.txtSetoranBln.Name = "txtSetoranBln"
        Me.txtSetoranBln.Size = New System.Drawing.Size(126, 20)
        Me.txtSetoranBln.TabIndex = 4
        '
        'txtBunga
        '
        Me.txtBunga.Location = New System.Drawing.Point(172, 69)
        Me.txtBunga.Name = "txtBunga"
        Me.txtBunga.Size = New System.Drawing.Size(126, 20)
        Me.txtBunga.TabIndex = 5
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(172, 109)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(126, 20)
        Me.txtTahun.TabIndex = 6
        '
        'txtNilaiMasaDepan
        '
        Me.txtNilaiMasaDepan.Location = New System.Drawing.Point(172, 153)
        Me.txtNilaiMasaDepan.Name = "txtNilaiMasaDepan"
        Me.txtNilaiMasaDepan.ReadOnly = True
        Me.txtNilaiMasaDepan.Size = New System.Drawing.Size(126, 20)
        Me.txtNilaiMasaDepan.TabIndex = 7
        Me.txtNilaiMasaDepan.TabStop = False
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(74, 210)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 8
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(214, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'HitungNilaiMasaDepan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 280)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtNilaiMasaDepan)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.txtBunga)
        Me.Controls.Add(Me.txtSetoranBln)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HitungNilaiMasaDepan"
        Me.Text = "Hitung Nilai Masa Depan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSetoranBln As System.Windows.Forms.TextBox
    Friend WithEvents txtBunga As System.Windows.Forms.TextBox
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents txtNilaiMasaDepan As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
