Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        frmRecorrido.MdiParent = Me
        frmRecorrido.WindowState = FormWindowState.Maximized
        frmRecorrido.Show()
    End Sub
End Class
