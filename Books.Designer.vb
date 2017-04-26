<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Me.BooksGridView = New System.Windows.Forms.DataGridView()
        Me.CategoriesComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.booksTableAdapter()
        Me.CategoriesTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.categoriesTableAdapter()
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BooksGridView
        '
        Me.BooksGridView.AllowUserToAddRows = False
        Me.BooksGridView.AllowUserToDeleteRows = False
        Me.BooksGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.title})
        Me.BooksGridView.Location = New System.Drawing.Point(12, 42)
        Me.BooksGridView.Name = "BooksGridView"
        Me.BooksGridView.ReadOnly = True
        Me.BooksGridView.Size = New System.Drawing.Size(550, 339)
        Me.BooksGridView.TabIndex = 0
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(291, 13)
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(152, 21)
        Me.CategoriesComboBox.TabIndex = 1
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Location = New System.Drawing.Point(13, 13)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(272, 20)
        Me.SearchBox.TabIndex = 2
        '
        'searchButton
        '
        Me.searchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchButton.Location = New System.Drawing.Point(449, 13)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(113, 23)
        Me.searchButton.TabIndex = 3
        Me.searchButton.Text = "Keresés"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.HeaderText = "Cím"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 500
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'Books
        '
        Me.AcceptButton = Me.searchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 393)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.CategoriesComboBox)
        Me.Controls.Add(Me.BooksGridView)
        Me.Name = "Books"
        Me.Text = "Könyvek böngészése"
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksGridView As DataGridView
    Friend WithEvents CategoriesComboBox As ComboBox
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents CategoriesTableAdapter As libraryDataSetTableAdapters.categoriesTableAdapter
End Class
