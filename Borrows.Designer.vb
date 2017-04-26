<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrows
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
        Me.BooksTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.booksTableAdapter()
        Me.BorrowGridView = New System.Windows.Forms.DataGridView()
        Me.book = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BorrowGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookLendingsTableAdapter
        '
        Me.BookLendingsTableAdapter.ClearBeforeFill = True
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
        Me.BorrowGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book, Me.borrowDate})
        Me.BorrowGridView.Location = New System.Drawing.Point(13, 13)
        Me.BorrowGridView.Name = "BorrowGridView"
        Me.BorrowGridView.ReadOnly = True
        Me.BorrowGridView.Size = New System.Drawing.Size(545, 335)
        Me.BorrowGridView.TabIndex = 0
        '
        'book
        '
        Me.book.HeaderText = "Könyv címe"
        Me.book.Name = "book"
        Me.book.ReadOnly = True
        Me.book.Width = 200
        '
        'borrowDate
        '
        Me.borrowDate.HeaderText = "Kölcsönzés dátuma"
        Me.borrowDate.Name = "borrowDate"
        Me.borrowDate.ReadOnly = True
        Me.borrowDate.Width = 300
        '
        'Borrows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 360)
        Me.Controls.Add(Me.BorrowGridView)
        Me.Name = "Borrows"
        Me.Text = "Kölcsönzés alatt lévő könyvek"
        CType(Me.BorrowGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookLendingsTableAdapter As libraryDataSetTableAdapters.bookLendingsTableAdapter
    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BorrowGridView As DataGridView
    Friend WithEvents book As DataGridViewTextBoxColumn
    Friend WithEvents borrowDate As DataGridViewTextBoxColumn
End Class
