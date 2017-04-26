Imports System.IO
Imports System.Text

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

    Private Sub KölcsönzésekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KölcsönzésekToolStripMenuItem.Click
        BorrowsAdmin.refreshResulst()
        BorrowsAdmin.ShowDialog()
    End Sub

    Private Sub borrowExportButton_Click(sender As Object, e As EventArgs) Handles borrowExportButton.Click
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        Dim myStream = SaveFileDialog.OpenFile()
        Dim a = New StreamWriter(myStream, New UTF8Encoding(True))

        a.WriteLine("Felhasználónév,Könyv cím,Kölcsönzés állapota,Kölcsönzés kezdete,Kölcsönzés vége")

        For Each BorrowRow In BookLendingsTableAdapter.GetData().Rows

            Dim username As String = ""
            Dim title As String = ""
            Dim transactionState As String

            For Each UserRow In ApplicationUsersTableAdapter.GetData().Rows
                If UserRow("id") = BorrowRow("application_user_id") Then
                    username = UserRow("username")
                    Exit For
                End If
            Next

            For Each BookRow In BooksTableAdapter.GetData().Rows
                If BookRow("id") = BorrowRow("book_id") Then
                    title = BookRow("title")
                    Exit For
                End If
            Next

            If BorrowRow("transaction_finished") Then
                transactionState = "Befejezett"
            Else
                transactionState = "Folyamatban van"
            End If

            a.WriteLine(username + "," + title + "," + transactionState + "," + BorrowRow("start_date") + "," + BorrowRow("end_date"))

        Next


        a.Flush()
        a.Close()
    End Sub
End Class
