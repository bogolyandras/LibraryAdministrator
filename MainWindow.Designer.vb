<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategóriákToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KölcsönzésekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LoginToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BrowseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginStripMenuItem, Me.LogoutMenuItem, Me.toolStripSeparator, Me.BrowseToolStripMenuItem, Me.MyBooksToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&Fájl"
        '
        'LoginStripMenuItem
        '
        Me.LoginStripMenuItem.Image = CType(resources.GetObject("LoginStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoginStripMenuItem.Name = "LoginStripMenuItem"
        Me.LoginStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.LoginStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LoginStripMenuItem.Text = "&Bejelentkezés"
        '
        'LogoutMenuItem
        '
        Me.LogoutMenuItem.Enabled = False
        Me.LogoutMenuItem.Name = "LogoutMenuItem"
        Me.LogoutMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LogoutMenuItem.Text = "Kijelentkezés"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(184, 6)
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Enabled = False
        Me.BrowseToolStripMenuItem.Image = CType(resources.GetObject("BrowseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.BrowseToolStripMenuItem.Text = "&Böngészés"
        '
        'MyBooksToolStripMenuItem
        '
        Me.MyBooksToolStripMenuItem.Enabled = False
        Me.MyBooksToolStripMenuItem.Image = CType(resources.GetObject("MyBooksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MyBooksToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MyBooksToolStripMenuItem.Name = "MyBooksToolStripMenuItem"
        Me.MyBooksToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MyBooksToolStripMenuItem.Text = "Könyveim"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(184, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ExitToolStripMenuItem.Text = "&Kilépés"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.KategóriákToolStripMenuItem, Me.CustomizeToolStripMenuItem, Me.KölcsönzésekToolStripMenuItem})
        Me.AdminToolStripMenuItem.Enabled = False
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdminToolStripMenuItem.Text = "&Adminisztráció"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OptionsToolStripMenuItem.Text = "&Felhasználók"
        '
        'KategóriákToolStripMenuItem
        '
        Me.KategóriákToolStripMenuItem.Name = "KategóriákToolStripMenuItem"
        Me.KategóriákToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KategóriákToolStripMenuItem.Text = "&Könyvkategóriák"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CustomizeToolStripMenuItem.Text = "Kö&nyvek"
        '
        'KölcsönzésekToolStripMenuItem
        '
        Me.KölcsönzésekToolStripMenuItem.Name = "KölcsönzésekToolStripMenuItem"
        Me.KölcsönzésekToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KölcsönzésekToolStripMenuItem.Text = "Kö&lcsönzések"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.HelpToolStripMenuItem.Text = "&Súgó"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutToolStripMenuItem.Text = "&A programról..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripButton, Me.BrowseToolStripButton, Me.toolStripSeparator7, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(764, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LoginToolStripButton
        '
        Me.LoginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoginToolStripButton.Image = CType(resources.GetObject("LoginToolStripButton.Image"), System.Drawing.Image)
        Me.LoginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoginToolStripButton.Name = "LoginToolStripButton"
        Me.LoginToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.LoginToolStripButton.Text = "&Bejelentkezés"
        '
        'BrowseToolStripButton
        '
        Me.BrowseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseToolStripButton.Enabled = False
        Me.BrowseToolStripButton.Image = CType(resources.GetObject("BrowseToolStripButton.Image"), System.Drawing.Image)
        Me.BrowseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseToolStripButton.Name = "BrowseToolStripButton"
        Me.BrowseToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BrowseToolStripButton.Text = "Böngészés"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 411)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.Text = "Könyvtár Adminisztráció"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents MyBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LoginToolStripButton As ToolStripButton
    Friend WithEvents BrowseToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator7 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents KategóriákToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KölcsönzésekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutMenuItem As ToolStripMenuItem
End Class
