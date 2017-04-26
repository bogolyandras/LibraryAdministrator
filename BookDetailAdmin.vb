Public Class BookDetailAdmin
    Sub loadByTitle(ByVal bookTitle As String)

        Dim categoryId As Long

        For Each BookRow In BooksTableAdapter.GetData().Rows
            If BookRow("title").Equals(bookTitle) Then
                categoryId = BookRow("category_id")
            End If
        Next

        TitleBox.Text = bookTitle
        CategoriesComboBox.Items.Clear()

        For Each CategoryRow In CategoriesTableAdapter.GetData().Rows
            Dim a As ComboBoxItem
            a = New ComboBoxItem
            a.id = CategoryRow("id")
            a.name = CategoryRow("name")
            Dim index = CategoriesComboBox.Items.Add(a)
            If (categoryId = a.id) Then
                CategoriesComboBox.SelectedIndex = index
            End If
        Next

    End Sub
End Class