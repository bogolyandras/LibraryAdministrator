Public Class MainWindow
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        UsersWindow.ShowDialog()
    End Sub

    Private Sub KategóriákToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategóriákToolStripMenuItem.Click
        CategoriesWindow.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
