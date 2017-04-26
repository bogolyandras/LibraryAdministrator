Public Class BorrowsAdmin

    Sub refreshResulst()
        BorrowGridView.Rows.Clear()

        For Each BorrowRow In BookLendingsTableAdapter.GetData().Rows
            If BorrowRow("transaction_finished") Then
                Continue For
            End If

            Dim row As DataGridViewRow
            row = New DataGridViewRow()
            Dim cell As DataGridViewCell

            For Each UserRow In ApplicationUsersTableAdapter.GetData().Rows
                If UserRow("id") = BorrowRow("application_user_id") Then
                    cell = New DataGridViewTextBoxCell()
                    cell.Value = UserRow("username")
                    row.Cells.Add(cell)
                    Exit For
                End If
            Next

            For Each BookRow In BooksTableAdapter.GetData().Rows
                If BookRow("id") = BorrowRow("book_id") Then
                    cell = New DataGridViewTextBoxCell()
                    cell.Value = BookRow("title")
                    row.Cells.Add(cell)
                    Exit For
                End If
            Next

            cell = New DataGridViewTextBoxCell()
            cell.Value = BorrowRow("start_date")
            row.Cells.Add(cell)
            row.Tag = BorrowRow("id")

            BorrowGridView.Rows.Add(row)

        Next
    End Sub

    Private Sub takenBackButton_Click(sender As Object, e As EventArgs) Handles takenBackButton.Click
        If BorrowGridView.SelectedCells.Count > 0 Then

            Dim borrowId = BorrowGridView.SelectedCells(0).OwningRow.Tag

            For Each BorrowRow In BookLendingsTableAdapter.GetData().Rows
                If BorrowRow("id") = borrowId Then

                    For Each BookRow In BooksTableAdapter.GetData().Rows
                        If BorrowRow("book_id") = BookRow("id") Then
                            BookRow("available") = BookRow("available") + 1
                            BooksTableAdapter.Update(BookRow)
                            Exit For
                        End If
                    Next

                    BorrowRow("transaction_finished") = True
                    BorrowRow("end_date") = DateTime.Now
                    BookLendingsTableAdapter.Update(BorrowRow)
                    Exit For
                End If
            Next

            MsgBox("A kölcsönzést lezártuk.")
            refreshResulst()

        End If
    End Sub
End Class