Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        frmRecorrido.MdiParent = Me
        frmRecorrido.WindowState = FormWindowState.Maximized
        frmRecorrido.Show()
    End Sub

    Private Sub OperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperaciónToolStripMenuItem.Click
        frmOperaciones.MdiParent = Me 'LLAMAMOS EL FORMULARIO PARA QUE LO MUESTRE
        frmOperaciones.WindowState = FormWindowState.Maximized
        frmOperaciones.Show()
    End Sub
End Class
