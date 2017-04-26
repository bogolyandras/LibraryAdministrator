Public Class BookDetail

    Private Shared selectedDataRow As DataRow

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
                selectedDataRow = BookRow
            End If
        Next
        borrowButton.Focus()
    End Sub

    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        BookLendingsTableAdapter.Insert(selectedDataRow("id"), False, Status.UserId, DateTime.Now, Nothing)
        selectedDataRow("available") = selectedDataRow("available") - 1
        BooksTableAdapter.Update(selectedDataRow)
        MsgBox("A kölcsönzés sikeres volt!")
        Close()
        Books.refreshResulst()
    End Sub
End Class