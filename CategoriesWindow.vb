Public Class CategoriesWindow
    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub CategoriesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.LibraryDataSet.categories)

    End Sub
End Class