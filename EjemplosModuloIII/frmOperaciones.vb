Public Class frmOperaciones
    Private Sub rdbSuma_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSuma.CheckedChanged
        lblOperacion.Text = "+"
    End Sub

    Private Sub rdbResta_CheckedChanged(sender As Object, e As EventArgs) Handles rdbResta.CheckedChanged
        lblOperacion.Text = "-"
    End Sub

    Private Sub rdbMulti_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMulti.CheckedChanged
        lblOperacion.Text = "*"
    End Sub

    Private Sub rdbDivi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDivi.CheckedChanged
        lblOperacion.Text = "/"
    End Sub
End Class