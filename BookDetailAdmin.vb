Public Class BookDetailAdmin

    Private Shared BookDataRow As DataRow

    Sub loadByTitle(ByVal bookTitle As String)
        For Each BookRow In BooksTableAdapter.GetData().Rows
            If BookRow("title").Equals(bookTitle) Then
                TitleBox.Text = BookRow("title")
                DescriptionBox.Text = BookRow("description")
                AuthorBox.Text = BookRow("author")
                PublishYearBox.Text = BookRow("year_of_publishing")
                ISBNBox.Text = BookRow("isbn")
                CategoriesComboBox.Items.Clear()
                For Each CategoryRow In CategoriesTableAdapter.GetData().Rows
                    Dim a As ComboBoxItem
                    a = New ComboBoxItem
                    a.id = CategoryRow("id")
                    a.name = CategoryRow("name")
                    Dim index = CategoriesComboBox.Items.Add(a)
                    If (BookRow("category_id") = a.id) Then
                        CategoriesComboBox.SelectedIndex = index
                    End If
                Next
                BookDataRow = BookRow
            End If
        Next

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        BookDataRow("title") = TitleBox.Text
        BookDataRow("description") = DescriptionBox.Text
        BookDataRow("author") = AuthorBox.Text
        BookDataRow("year_of_publishing") = PublishYearBox.Text
        BookDataRow("isbn") = ISBNBox.Text
        BookDataRow("category_id") = CType(CategoriesComboBox.SelectedItem, ComboBoxItem).id
        BooksTableAdapter.Update(BookDataRow)
        Close()
        'BooksAdmin.asd()
    End Sub
End Class