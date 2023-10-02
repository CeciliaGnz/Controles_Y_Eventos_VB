Public Class frmImagen
    Private Sub cboImagen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImagen.SelectedIndexChanged
        If cboImagen.Text = "Perro" Then
            pctImagen.Image = Image.FromFile("../../img/perro.jpg")
        Else
            pctImagen.Image = Image.FromFile("../../img/tiburon.jpg")
        End If
    End Sub


End Class