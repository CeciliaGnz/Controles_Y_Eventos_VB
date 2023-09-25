Public Class frmMenu
    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        frmRecorrido.MdiParent = Me
        frmRecorrido.WindowState = FormWindowState.Maximized
        frmRecorrido.Show()
    End Sub
    Private Sub OperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperaciónToolStripMenuItem.Click
        frmOperaciones.MdiParent = Me
        frmOperaciones.WindowState = FormWindowState.Maximized
        frmOperaciones.Show()
    End Sub

    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        frmImagen.MdiParent = Me
        frmImagen.WindowState = FormWindowState.Maximized
        frmImagen.Show()
    End Sub

    Private Sub RestauranteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestauranteToolStripMenuItem.Click
        frmRestaurante.MdiParent = Me
        frmRestaurante.WindowState = FormWindowState.Maximized
        frmRestaurante.Show()
    End Sub
End Class
