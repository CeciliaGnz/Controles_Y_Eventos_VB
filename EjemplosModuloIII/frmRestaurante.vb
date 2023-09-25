Public Class frmRestaurante

    'Creamos una instancia para la clase restaurante
    Dim objRestaurante As New Restaurante
    Private Sub frmRestaurante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lasCarnes(6) As String
        cboMenestras.Items.Add("Poroto: 1.15")
        cboMenestras.Items.Add("Frijoles: 0.90")
        cboMenestras.Items.Add("Arvejas: 0.95")
        cboMenestras.Items.Add("Garbanzo: 0.90")
        lasCarnes(0) = "Carne de Res: 2.05"
        lasCarnes(1) = "Carne de Venado: 7.50"
        lasCarnes(2) = "Pollo: 1.75"
        lasCarnes(3) = "Pavo: 5.80"
        lasCarnes(4) = "Pescado: 4.50"
        lasCarnes(5) = "Camarones: 5.20"
        cboCarnes.DataSource = lasCarnes 'Pasa informacion a un combobox

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstMenu.Items.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub cboArroces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArroces.SelectedIndexChanged
        objRestaurante.asignar(cboArroces.Text)
        txtTotal.Text = Val(txtTotal.Text) + objRestaurante.extraerPrecio 'VER QUE HACE ESTO NO ENTENDI
        lstMenu.Items.Add(cboArroces.Text)
    End Sub

    Private Sub cboCarnes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarnes.SelectedIndexChanged
        objRestaurante.asignar(cboCarnes.Text)
        txtTotal.Text = Val(txtTotal.Text) + objRestaurante.extraerPrecio
        lstMenu.Items.Add(cboCarnes.Text)
    End Sub

    Private Sub cboMenestras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenestras.SelectedIndexChanged
        objRestaurante.asignar(cboMenestras.Text)
        txtTotal.Text = Val(txtTotal.Text) + objRestaurante.extraerPrecio
        lstMenu.Items.Add(cboMenestras.Text)
    End Sub

    Private Sub lstMenu_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstMenu.MouseDoubleClick
        If lstMenu.Items.Count >= 1 Then
            objRestaurante.asignar(lstMenu.Text)
            txtTotal.Text = Val((txtTotal.Text) - objRestaurante.extraerPrecio())
            lstMenu.Items.Remove(lstMenu.Text)

        End If
    End Sub
End Class