Public Class UsersWindow
    Private Sub Application_usersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Application_usersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Application_usersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub UsersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.application_users' table. You can move, or remove it, as needed.
        Me.ApplicationUsersTableAdapter.Fill(Me.LibraryDataSet.application_users)

    End Sub
End Class