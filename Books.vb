Public Class Books
    Sub loadBooks()

        SearchBox.Text = ""
        CategoriesComboBox.Items.Clear()
        Dim a As ComboBoxItem
        a = New ComboBoxItem
        a.id = -1
        a.name = "<Nincs kiválasztva>"
        Dim index = CategoriesComboBox.Items.Add(a)
        For Each CategoryRow In CategoriesTableAdapter.GetData().Rows
            a = New ComboBoxItem
            a.id = CategoryRow("id")
            a.name = CategoryRow("name")
            CategoriesComboBox.Items.Add(a)
        Next
        CategoriesComboBox.SelectedIndex = 0

        refreshResulst()
        searchButton.Focus()

    End Sub

    Sub refreshResulst()
        BooksGridView.Rows.Clear()
        For Each BookRow In BooksTableAdapter.GetData().Rows

            If BookRow("available") < 1 Then
                Continue For
            End If

            If Not SearchBox.Text = "" Then
                If Not BookRow("title").ToString().Contains(SearchBox.Text) Then
                    Continue For
                End If
            End If

            If Not CType(CategoriesComboBox.SelectedItem, ComboBoxItem).id = -1 Then
                If Not CType(CategoriesComboBox.SelectedItem, ComboBoxItem).id = BookRow("category_id") Then
                    Continue For
                End If
            End If

            Dim row As DataGridViewRow
            row = New DataGridViewRow()
            Dim cell As DataGridViewCell
            cell = New DataGridViewTextBoxCell()
            cell.Value = BookRow("title")
            row.Cells.Add(cell)
            BooksGridView.Rows.Add(row)
        Next
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        refreshResulst()
    End Sub
End Class