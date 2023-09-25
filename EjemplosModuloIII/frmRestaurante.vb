Public Class frmRestaurante
    Private Sub frmRestaurante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lasCarnes(6) As String
        cboMenestras.Items.Add("Poroto:1.15")
        cboMenestras.Items.Add("Frijoles:0.90")
        cboMenestras.Items.Add("Arvejas:0.95")
        cboMenestras.Items.Add("Garbanzo:0.90")
        lasCarnes(0) = "Carne de Res: 2.05"
        lasCarnes(1) = "Carne de Venado: 7.50"
        lasCarnes(2) = "Polo: 1.75"
        lasCarnes(3) = "Pavo: 5.80"
        lasCarnes(4) = "Pescado: 4.50"
        lasCarnes(5) = "Camarones: 5.20"
        cboCarnes.DataSource = lasCarnes 'Pasa informacion a un combobox

    End Sub

    Private Sub cboArroces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArroces.SelectedIndexChanged

    End Sub
End Class