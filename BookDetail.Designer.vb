<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetail
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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.descriptionBox = New System.Windows.Forms.TextBox()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.yearOfPublishing = New System.Windows.Forms.Label()
        Me.isbnLabel = New System.Windows.Forms.Label()
        Me.borrowButton = New System.Windows.Forms.Button()
        Me.CategoriesTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.categoriesTableAdapter()
        Me.BooksTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.booksTableAdapter()
        Me.BookLendingsTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.bookLendingsTableAdapter()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(13, 13)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(26, 13)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Cím"
        '
        'descriptionBox
        '
        Me.descriptionBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descriptionBox.Location = New System.Drawing.Point(12, 66)
        Me.descriptionBox.Multiline = True
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.ReadOnly = True
        Me.descriptionBox.Size = New System.Drawing.Size(371, 161)
        Me.descriptionBox.TabIndex = 1
        '
        'categoryLabel
        '
        Me.categoryLabel.AutoSize = True
        Me.categoryLabel.Location = New System.Drawing.Point(13, 39)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(52, 13)
        Me.categoryLabel.TabIndex = 2
        Me.categoryLabel.Text = "Kategória"
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Location = New System.Drawing.Point(13, 238)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(39, 13)
        Me.authorLabel.TabIndex = 3
        Me.authorLabel.Text = "Szerző"
        '
        'yearOfPublishing
        '
        Me.yearOfPublishing.AutoSize = True
        Me.yearOfPublishing.Location = New System.Drawing.Point(13, 267)
        Me.yearOfPublishing.Name = "yearOfPublishing"
        Me.yearOfPublishing.Size = New System.Drawing.Size(60, 13)
        Me.yearOfPublishing.TabIndex = 4
        Me.yearOfPublishing.Text = "Kiadás éve"
        '
        'isbnLabel
        '
        Me.isbnLabel.AutoSize = True
        Me.isbnLabel.Location = New System.Drawing.Point(16, 295)
        Me.isbnLabel.Name = "isbnLabel"
        Me.isbnLabel.Size = New System.Drawing.Size(32, 13)
        Me.isbnLabel.TabIndex = 5
        Me.isbnLabel.Text = "ISBN"
        '
        'borrowButton
        '
        Me.borrowButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.borrowButton.Location = New System.Drawing.Point(19, 337)
        Me.borrowButton.Name = "borrowButton"
        Me.borrowButton.Size = New System.Drawing.Size(364, 23)
        Me.borrowButton.TabIndex = 6
        Me.borrowButton.Text = "Kölcsönzés"
        Me.borrowButton.UseVisualStyleBackColor = True
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'BookLendingsTableAdapter
        '
        Me.BookLendingsTableAdapter.ClearBeforeFill = True
        '
        'BookDetail
        '
        Me.AcceptButton = Me.borrowButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 372)
        Me.Controls.Add(Me.borrowButton)
        Me.Controls.Add(Me.isbnLabel)
        Me.Controls.Add(Me.yearOfPublishing)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.categoryLabel)
        Me.Controls.Add(Me.descriptionBox)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "BookDetail"
        Me.Text = "Könyv kölcsönzése"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents descriptionBox As TextBox
    Friend WithEvents categoryLabel As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents yearOfPublishing As Label
    Friend WithEvents isbnLabel As Label
    Friend WithEvents borrowButton As Button
    Friend WithEvents CategoriesTableAdapter As libraryDataSetTableAdapters.categoriesTableAdapter
    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BookLendingsTableAdapter As libraryDataSetTableAdapters.bookLendingsTableAdapter
End Class
