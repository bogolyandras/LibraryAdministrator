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
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.AuthorBox = New System.Windows.Forms.TextBox()
        Me.PublishYearBox = New System.Windows.Forms.TextBox()
        Me.ISBNBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(488, 259)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Mentés"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TitleBox
        '
        Me.TitleBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleBox.Location = New System.Drawing.Point(115, 12)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(448, 20)
        Me.TitleBox.TabIndex = 1
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(116, 39)
        Me.CategoriesComboBox.MaxDropDownItems = 20
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(447, 21)
        Me.CategoriesComboBox.TabIndex = 2
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionBox.Location = New System.Drawing.Point(116, 67)
        Me.DescriptionBox.Multiline = True
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(447, 80)
        Me.DescriptionBox.TabIndex = 3
        '
        'AuthorBox
        '
        Me.AuthorBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorBox.Location = New System.Drawing.Point(116, 154)
        Me.AuthorBox.Name = "AuthorBox"
        Me.AuthorBox.Size = New System.Drawing.Size(447, 20)
        Me.AuthorBox.TabIndex = 4
        '
        'PublishYearBox
        '
        Me.PublishYearBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublishYearBox.Location = New System.Drawing.Point(116, 181)
        Me.PublishYearBox.Name = "PublishYearBox"
        Me.PublishYearBox.Size = New System.Drawing.Size(447, 20)
        Me.PublishYearBox.TabIndex = 5
        '
        'ISBNBox
        '
        Me.ISBNBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ISBNBox.Location = New System.Drawing.Point(116, 208)
        Me.ISBNBox.Name = "ISBNBox"
        Me.ISBNBox.Size = New System.Drawing.Size(447, 20)
        Me.ISBNBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cím"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Kategória"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Leírás"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Szerző"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kiadás éve"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ISBN"
        '
        'BookDetailAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 294)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ISBNBox)
        Me.Controls.Add(Me.PublishYearBox)
        Me.Controls.Add(Me.AuthorBox)
        Me.Controls.Add(Me.DescriptionBox)
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
    Friend WithEvents DescriptionBox As TextBox
    Friend WithEvents AuthorBox As TextBox
    Friend WithEvents PublishYearBox As TextBox
    Friend WithEvents ISBNBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
