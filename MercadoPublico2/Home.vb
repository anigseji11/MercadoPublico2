Public Class Home
    Private Sub SELECCIONAVANZADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECCIONAVANZADAToolStripMenuItem.Click
        SeleccionAvanzada.Show()
    End Sub

    Private Sub SELECCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECCIONToolStripMenuItem.Click
        Seleccion.Show()
    End Sub

    Private Sub IMPORTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPORTARToolStripMenuItem.Click
        Detalle.Show()
    End Sub

    Private Sub GESTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GESTIONToolStripMenuItem.Click
        Gestion.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AUTOMATICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AUTOMATICAToolStripMenuItem.Click
        Postulados.Show()
    End Sub
End Class