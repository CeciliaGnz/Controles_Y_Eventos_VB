Public Class frmRecorrido
    Dim cantidad As Integer
    Private Sub nudTope_ValueChanged(sender As Object, e As EventArgs) Handles nudTope.ValueChanged
        cantidad = nudTope.Value
        If cantidad >= 1 Then
            dgvNumeros.RowCount = cantidad
            dgvRecorrido.RowCount = cantidad
            dgvNumeros.ColumnCount = cantidad
            dgvRecorrido.ColumnCount = cantidad
        End If

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim fila, columna As Integer
        Dim rand As New Random()
        For fila = 0 To cantidad - 1
            For columna = 0 To cantidad - 1
                dgvNumeros.Rows(fila).Cells(columna).Value = rand.Next(1, 101)
            Next columna
        Next fila
    End Sub

    Private Sub btnRecorrido_Click(sender As Object, e As EventArgs) Handles btnRecorrido.Click
        Dim i, j, pos As Integer, fin As Integer = cantidad - 1
        For i = 0 To fin
            pos = 0
            For j = IIf(i Mod 2 = 0, 0, fin) To IIf(i Mod 2 = 0, fin, 0) Step IIf(i Mod 2 = 0, 1, -1)
                dgvRecorrido.Rows(i).Cells(pos).Value = dgvNumeros.Rows(i).Cells(j).Value
                pos += 1
            Next
        Next
    End Sub
End Class