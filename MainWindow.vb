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

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginStripMenuItem.Click
        LoginForm.ShowDialog()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles LoginToolStripButton.Click
        LoginForm.ShowDialog()
    End Sub

    Public Sub ReshapeMyself()
        LogoutMenuItem.Enabled = Status.LoggedIn
        MyBooksToolStripMenuItem.Enabled = Status.LoggedIn
        BrowseToolStripMenuItem.Enabled = Status.LoggedIn
        BrowseToolStripButton.Enabled = Status.LoggedIn
        LogoutMenuItem.Enabled = Status.LoggedIn
        LoginStripMenuItem.Enabled = Not Status.LoggedIn
        LoginToolStripButton.Enabled = Not Status.LoggedIn
        AdminToolStripMenuItem.Enabled = Status.IsAdmin
    End Sub

    Private Sub LogoutMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutMenuItem.Click
        Status.LoggedIn = False
        Status.IsAdmin = False
        ReshapeMyself()
    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click
        BooksAdmin.ShowDialog()
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        Books.loadBooks()
        Books.ShowDialog()
    End Sub

    Private Sub BrowseToolStripButton_Click(sender As Object, e As EventArgs) Handles BrowseToolStripButton.Click
        BrowseToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub MyBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyBooksToolStripMenuItem.Click
        Borrows.refreshResulst()
        Borrows.ShowDialog()
    End Sub
End Class
