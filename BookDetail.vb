Public Class BookDetail


    Sub loadByTitle(ByVal bookTitle As String)
        For Each BookRow In BooksTableAdapter.GetData().Rows
            If BookRow("title").Equals(bookTitle) Then
                titleLabel.Text = BookRow("title")
                descriptionBox.Text = BookRow("description")
                authorLabel.Text = BookRow("author")
                yearOfPublishing.Text = BookRow("year_of_publishing")
                isbnLabel.Text = BookRow("isbn")
                For Each CategoryRow In CategoriesTableAdapter.GetData().Rows
                    If (BookRow("category_id") = CategoryRow("id")) Then
                        categoryLabel.Text = CategoryRow("name")
                    End If
                Next
            End If
        Next
        borrowButton.Focus()
    End Sub

End Class