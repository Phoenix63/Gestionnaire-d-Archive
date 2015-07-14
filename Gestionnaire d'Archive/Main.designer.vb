<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoadEnCours = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoadFini = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdition = New System.Windows.Forms.ToolStripMenuItem()
        Me.modifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cloturer = New System.Windows.Forms.ToolStripMenuItem()
        Me.supprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOutils = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefautToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.importer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSignIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.urlClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.urlCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.opf = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip.SuspendLayout()
        Me.urlClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.menuEdition, Me.menuOutils, Me.menuSignIn, Me.InfoMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(479, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNew, Me.ChargerToolStripMenuItem, Me.menuExit})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MenuToolStripMenuItem.Text = "Fichier"
        '
        'menuNew
        '
        Me.menuNew.Name = "menuNew"
        Me.menuNew.Size = New System.Drawing.Size(122, 22)
        Me.menuNew.Text = "Nouveau"
        '
        'ChargerToolStripMenuItem
        '
        Me.ChargerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLoadEnCours, Me.menuLoadFini})
        Me.ChargerToolStripMenuItem.Name = "ChargerToolStripMenuItem"
        Me.ChargerToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ChargerToolStripMenuItem.Text = "Charger"
        '
        'menuLoadEnCours
        '
        Me.menuLoadEnCours.Name = "menuLoadEnCours"
        Me.menuLoadEnCours.Size = New System.Drawing.Size(119, 22)
        Me.menuLoadEnCours.Text = "En cours"
        '
        'menuLoadFini
        '
        Me.menuLoadFini.Name = "menuLoadFini"
        Me.menuLoadFini.Size = New System.Drawing.Size(119, 22)
        Me.menuLoadFini.Text = "Terminé"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(122, 22)
        Me.menuExit.Text = "Quitter"
        '
        'menuEdition
        '
        Me.menuEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modifier, Me.Cloturer, Me.supprimer})
        Me.menuEdition.Name = "menuEdition"
        Me.menuEdition.Size = New System.Drawing.Size(56, 20)
        Me.menuEdition.Text = "Edition"
        '
        'modifier
        '
        Me.modifier.Enabled = False
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(129, 22)
        Me.modifier.Text = "Modifier"
        '
        'Cloturer
        '
        Me.Cloturer.Enabled = False
        Me.Cloturer.Name = "Cloturer"
        Me.Cloturer.Size = New System.Drawing.Size(129, 22)
        Me.Cloturer.Text = "Cloturer"
        '
        'supprimer
        '
        Me.supprimer.Enabled = False
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(129, 22)
        Me.supprimer.Text = "Supprimer"
        '
        'menuOutils
        '
        Me.menuOutils.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserToolStripMenuItem, Me.RechercheToolStripMenuItem, Me.importer})
        Me.menuOutils.Name = "menuOutils"
        Me.menuOutils.Size = New System.Drawing.Size(50, 20)
        Me.menuOutils.Text = "Outils"
        '
        'BrowserToolStripMenuItem
        '
        Me.BrowserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefautToolStripMenuItem, Me.AutreToolStripMenuItem, Me.ModifierToolStripMenuItem1})
        Me.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem"
        Me.BrowserToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.BrowserToolStripMenuItem.Text = "Browser"
        '
        'DefautToolStripMenuItem
        '
        Me.DefautToolStripMenuItem.Checked = True
        Me.DefautToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DefautToolStripMenuItem.Name = "DefautToolStripMenuItem"
        Me.DefautToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DefautToolStripMenuItem.Text = "Defaut"
        '
        'AutreToolStripMenuItem
        '
        Me.AutreToolStripMenuItem.Name = "AutreToolStripMenuItem"
        Me.AutreToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AutreToolStripMenuItem.Text = "Autres"
        '
        'ModifierToolStripMenuItem1
        '
        Me.ModifierToolStripMenuItem1.Name = "ModifierToolStripMenuItem1"
        Me.ModifierToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.ModifierToolStripMenuItem1.Text = "Modifier"
        '
        'RechercheToolStripMenuItem
        '
        Me.RechercheToolStripMenuItem.Name = "RechercheToolStripMenuItem"
        Me.RechercheToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.RechercheToolStripMenuItem.Text = "Recherche"
        '
        'importer
        '
        Me.importer.Name = "importer"
        Me.importer.Size = New System.Drawing.Size(129, 22)
        Me.importer.Text = "Importer"
        '
        'menuSignIn
        '
        Me.menuSignIn.Name = "menuSignIn"
        Me.menuSignIn.Size = New System.Drawing.Size(84, 20)
        Me.menuSignIn.Text = "S'enregistrer"
        '
        'InfoMenu
        '
        Me.InfoMenu.Name = "InfoMenu"
        Me.InfoMenu.Size = New System.Drawing.Size(40, 20)
        Me.InfoMenu.Text = "Info"
        Me.InfoMenu.Visible = False
        '
        'urlClick
        '
        Me.urlClick.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.urlClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.urlCopy})
        Me.urlClick.Name = "urlClick"
        Me.urlClick.Size = New System.Drawing.Size(110, 26)
        '
        'urlCopy
        '
        Me.urlCopy.Name = "urlCopy"
        Me.urlCopy.Size = New System.Drawing.Size(109, 22)
        Me.urlCopy.Text = "Copier"
        '
        'opf
        '
        Me.opf.DefaultExt = "mga"
        Me.opf.FileName = """"""
        Me.opf.Filter = "Gestionnaire d'Archive Data|*.mga"
        '
        'sfd
        '
        Me.sfd.DefaultExt = "mga"
        Me.sfd.FileName = """"""
        Me.sfd.Filter = "Gestionnaire d'Archive Data|*.mga"
        '
        'AutoSave
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 118)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Gestionnaire d'Archive"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.urlClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLoadEnCours As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLoadFini As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOutils As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefautToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSignIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents urlClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents urlCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modifier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cloturer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents supprimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents importer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opf As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AutoSave As System.Windows.Forms.Timer

End Class
