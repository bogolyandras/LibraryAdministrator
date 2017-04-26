Public Class BooksAdmin
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub BooksAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadDataSet()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If BooksDataGridView.SelectedCells.Count > 0 Then
            BookDetailAdmin.loadByTitle(BooksDataGridView.SelectedCells(0).Value)
            BookDetailAdmin.ShowDialog()
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        BookDetailAdmin.ShowDialog()
    End Sub

    Public Sub reloadDataSet()
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet.books)
    End Sub
End Class