<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailAdmin
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
        Me.BooksTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.booksTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.CategoriesTableAdapter = New LibraryAdministrator.libraryDataSetTableAdapters.categoriesTableAdapter()
        Me.CategoriesComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(488, 280)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Mentés"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TitleBox
        '
        Me.TitleBox.Location = New System.Drawing.Point(12, 12)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(291, 20)
        Me.TitleBox.TabIndex = 1
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(13, 39)
        Me.CategoriesComboBox.MaxDropDownItems = 20
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(290, 21)
        Me.CategoriesComboBox.TabIndex = 2
        '
        'BookDetailAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 315)
        Me.Controls.Add(Me.CategoriesComboBox)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Name = "BookDetailAdmin"
        Me.Text = "Könyv szerkesztése"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksTableAdapter As libraryDataSetTableAdapters.booksTableAdapter
    Friend WithEvents SaveButton As Button
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents CategoriesTableAdapter As libraryDataSetTableAdapters.categoriesTableAdapter
    Friend WithEvents CategoriesComboBox As ComboBox
End Class
