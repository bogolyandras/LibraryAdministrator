Public Class Borrows

    Sub refreshResulst()

        BorrowGridView.Rows.Clear()

        For Each BorrowRow In BookLendingsTableAdapter.GetData().Rows
            If Not BorrowRow("application_user_id") = Status.UserId Then
                Continue For
            End If
            If BorrowRow("transaction_finished") Then
                Continue For
            End If

            Dim row As DataGridViewRow
            row = New DataGridViewRow()
            Dim cell As DataGridViewCell



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

            BorrowGridView.Rows.Add(row)

        Next
    End Sub

End Class