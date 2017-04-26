<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowsAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BookLendingsTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.bookLendingsTableAdapter()
        Me.ApplicationUsersTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.applicationUsersTableAdapter()
        Me.BooksTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.booksTableAdapter()
        Me.BorrowGridView = New System.Windows.Forms.DataGridView()
        Me.takenBackButton = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.start_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BorrowGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookLendingsTableAdapter
        '
        Me.BookLendingsTableAdapter.ClearBeforeFill = True
        '
        'ApplicationUsersTableAdapter
        '
        Me.ApplicationUsersTableAdapter.ClearBeforeFill = True
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'BorrowGridView
        '
        Me.BorrowGridView.AllowUserToAddRows = False
        Me.BorrowGridView.AllowUserToDeleteRows = False
        Me.BorrowGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.book, Me.start_date})
        Me.BorrowGridView.Location = New System.Drawing.Point(13, 13)
        Me.BorrowGridView.Name = "BorrowGridView"
        Me.BorrowGridView.ReadOnly = True
        Me.BorrowGridView.Size = New System.Drawing.Size(598, 283)
        Me.BorrowGridView.TabIndex = 0
        '
        'takenBackButton
        '
        Me.takenBackButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.takenBackButton.Location = New System.Drawing.Point(13, 302)
        Me.takenBackButton.Name = "takenBackButton"
        Me.takenBackButton.Size = New System.Drawing.Size(598, 23)
        Me.takenBackButton.TabIndex = 1
        Me.takenBackButton.Text = "Visszakapva"
        Me.takenBackButton.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.HeaderText = "Felhasználónév"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 150
        '
        'book
        '
        Me.book.HeaderText = "Könyv"
        Me.book.Name = "book"
        Me.book.ReadOnly = True
        Me.book.Width = 200
        '
        'start_date
        '
        Me.start_date.HeaderText = "Kölcsönzés Dátuma"
        Me.start_date.Name = "start_date"
        Me.start_date.ReadOnly = True
        Me.start_date.Width = 200
        '
        'BorrowsAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 337)
        Me.Controls.Add(Me.takenBackButton)
        Me.Controls.Add(Me.BorrowGridView)
        Me.Name = "BorrowsAdmin"
        Me.Text = "Kölcsönzés alatt lévő könyvek"
        CType(Me.BorrowGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookLendingsTableAdapter As libraryDataSetTableAdapters.bookLendingsTableAdapter
    Friend WithEvents ApplicationUsersTableAdapter As libraryDataSetTableAdapters.applicationUsersTableAdapter
    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BorrowGridView As DataGridView
    Friend WithEvents takenBackButton As Button
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents book As DataGridViewTextBoxColumn
    Friend WithEvents start_date As DataGridViewTextBoxColumn
End Class
