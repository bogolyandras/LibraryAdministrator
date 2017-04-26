Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        For Each UserDataRow In ApplicationUsersTableAdapter.GetData().Rows
            If UserDataRow("username") = UsernameTextBox.Text Then
                If UserDataRow("password") = PasswordTextBox.Text Then
                    Status.LoggedIn = True
                    Status.IsAdmin = UserDataRow("role").Equals("Adminisztrátor")
                    Status.UserId = Long.Parse(UserDataRow("id"))
                    Exit For
                End If
            End If
        Next
        If Not Status.LoggedIn Then
            MsgBox("Helytelen Felhasználónév vagy jelszó!")
        Else
            My.MyProject.Forms.MainWindow.ReshapeMyself()
            Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
