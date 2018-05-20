Public Class HitungNilaiMasaDepan

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim setoranBln As Decimal = CDec(txtSetoranBln.Text)
        Dim bunga As Integer = CDec(txtBunga.Text)
        Dim tahun As Integer = CInt(txtTahun.Text)

        Dim bungaBln As Decimal = bunga / 12 / 100
        Dim bulan As Integer = tahun * 12

        Dim nilaiMasaDepan As Decimal = Me.NilaiMasaDepan(setoranBln, bungaBln, bulan)
        txtNilaiMasaDepan.Text = FormatCurrency(nilaiMasaDepan)
        txtSetoranBln.Select()
    End Sub

    Private Function NilaiMasaDepan(ByVal setoranBln As Decimal, ByVal bungaBln As Decimal, ByVal Bulan As Integer) As Decimal
        NilaiMasaDepan = 0
        For i As Integer = 1 To Bulan
            NilaiMasaDepan = (NilaiMasaDepan + setoranBln) * (1 + bungaBln)
        Next
        Return NilaiMasaDepan
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
