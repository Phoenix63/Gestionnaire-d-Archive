<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAnimeInterface
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAnimeInterface))
        Me.nEpisode = New System.Windows.Forms.TextBox()
        Me.nTitle = New System.Windows.Forms.TextBox()
        Me.nSmartLink = New System.Windows.Forms.CheckBox()
        Me.nFollow = New System.Windows.Forms.CheckBox()
        Me.nCommentaire = New System.Windows.Forms.TextBox()
        Me.nFinish = New System.Windows.Forms.CheckBox()
        Me.nDate = New System.Windows.Forms.DateTimePicker()
        Me.nLienModifiable = New System.Windows.Forms.TextBox()
        Me.nReturn = New System.Windows.Forms.Button()
        Me.nAjouter = New System.Windows.Forms.Button()
        Me.nDimiss = New System.Windows.Forms.Button()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.nFilter = New Gestionnaire_d_Archive.AnimeFilter()
        Me.nRank = New Gestionnaire_d_Archive.StarRanking()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(35, 60)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(120, 35)
        Label1.TabIndex = 0
        Label1.Text = "* Episode :"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(35, 170)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(355, 25)
        Label2.TabIndex = 30
        Label2.Text = "* Date de sortie de la série :"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(35, 205)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 25)
        Label3.TabIndex = 31
        Label3.Text = "* Lien :"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(35, 15)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(120, 35)
        Label4.TabIndex = 35
        Label4.Text = "* Nom :"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label5.Location = New System.Drawing.Point(35, 105)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(120, 35)
        Label5.TabIndex = 36
        Label5.Text = "  Genre :"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label6.Location = New System.Drawing.Point(248, 60)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(120, 35)
        Label6.TabIndex = 37
        Label6.Text = "  Classement :"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label7.Location = New System.Drawing.Point(35, 240)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(120, 35)
        Label7.TabIndex = 38
        Label7.Text = "  Commentaire :"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label8.Location = New System.Drawing.Point(35, 325)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(120, 35)
        Label8.TabIndex = 39
        Label8.Text = "  Options :"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.SystemColors.Control
        Label9.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label9.Location = New System.Drawing.Point(155, 325)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(315, 35)
        Label9.TabIndex = 41
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nEpisode
        '
        Me.nEpisode.BackColor = System.Drawing.SystemColors.Control
        Me.nEpisode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nEpisode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.nEpisode.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.nEpisode.Location = New System.Drawing.Point(155, 60)
        Me.nEpisode.MaxLength = 4
        Me.nEpisode.Name = "nEpisode"
        Me.nEpisode.Size = New System.Drawing.Size(58, 35)
        Me.nEpisode.TabIndex = 0
        Me.nEpisode.TabStop = False
        Me.nEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tip.SetToolTip(Me.nEpisode, "(Requis) Numéro de l'épisode")
        '
        'nTitle
        '
        Me.nTitle.BackColor = System.Drawing.SystemColors.Control
        Me.nTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.nTitle.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.nTitle.Location = New System.Drawing.Point(155, 15)
        Me.nTitle.MaxLength = 40
        Me.nTitle.Name = "nTitle"
        Me.nTitle.Size = New System.Drawing.Size(410, 35)
        Me.nTitle.TabIndex = 15
        Me.nTitle.TabStop = False
        Me.nTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tip.SetToolTip(Me.nTitle, "(Requis) Nom de la série")
        '
        'nSmartLink
        '
        Me.nSmartLink.AutoSize = True
        Me.nSmartLink.BackColor = System.Drawing.SystemColors.Control
        Me.nSmartLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nSmartLink.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nSmartLink.FlatAppearance.BorderSize = 0
        Me.nSmartLink.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.nSmartLink.Location = New System.Drawing.Point(169, 333)
        Me.nSmartLink.Name = "nSmartLink"
        Me.nSmartLink.Size = New System.Drawing.Size(82, 20)
        Me.nSmartLink.TabIndex = 17
        Me.nSmartLink.Text = "Lien Smart"
        Me.tip.SetToolTip(Me.nSmartLink, "Si coché, le logiciel essayera de changer votre lien en fonction de l'épisode cou" & _
        "rant")
        Me.nSmartLink.UseVisualStyleBackColor = False
        '
        'nFollow
        '
        Me.nFollow.AutoSize = True
        Me.nFollow.BackColor = System.Drawing.SystemColors.Control
        Me.nFollow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nFollow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nFollow.FlatAppearance.BorderSize = 0
        Me.nFollow.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.nFollow.Location = New System.Drawing.Point(252, 333)
        Me.nFollow.Name = "nFollow"
        Me.nFollow.Size = New System.Drawing.Size(140, 20)
        Me.nFollow.TabIndex = 18
        Me.nFollow.Text = "Suivre chaque semaine"
        Me.tip.SetToolTip(Me.nFollow, "Si coché, vous indiquera si votre série est sortie ou dans combien de temps elle " & _
        "sortira (basé sur la date de sortie de la série)")
        Me.nFollow.UseVisualStyleBackColor = False
        '
        'nCommentaire
        '
        Me.nCommentaire.BackColor = System.Drawing.SystemColors.Control
        Me.nCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nCommentaire.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.nCommentaire.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.nCommentaire.Location = New System.Drawing.Point(155, 240)
        Me.nCommentaire.MaxLength = 100
        Me.nCommentaire.Multiline = True
        Me.nCommentaire.Name = "nCommentaire"
        Me.nCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nCommentaire.Size = New System.Drawing.Size(410, 75)
        Me.nCommentaire.TabIndex = 25
        Me.nCommentaire.TabStop = False
        Me.tip.SetToolTip(Me.nCommentaire, "Zone de commentaire pour vous")
        '
        'nFinish
        '
        Me.nFinish.AutoSize = True
        Me.nFinish.BackColor = System.Drawing.SystemColors.Control
        Me.nFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nFinish.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nFinish.FlatAppearance.BorderSize = 0
        Me.nFinish.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.nFinish.Location = New System.Drawing.Point(390, 333)
        Me.nFinish.Name = "nFinish"
        Me.nFinish.Size = New System.Drawing.Size(68, 20)
        Me.nFinish.TabIndex = 27
        Me.nFinish.Text = "Terminé"
        Me.tip.SetToolTip(Me.nFinish, "Si coché, ajoutera la série comme fini")
        Me.nFinish.UseVisualStyleBackColor = False
        '
        'nDate
        '
        Me.nDate.CalendarFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nDate.Checked = False
        Me.nDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nDate.CustomFormat = " dd MMMM yyyy"
        Me.nDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.nDate.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.nDate.Location = New System.Drawing.Point(390, 170)
        Me.nDate.Name = "nDate"
        Me.nDate.Size = New System.Drawing.Size(175, 25)
        Me.nDate.TabIndex = 28
        Me.tip.SetToolTip(Me.nDate, "(Requis) Date de sortie")
        Me.nDate.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'nLienModifiable
        '
        Me.nLienModifiable.BackColor = System.Drawing.SystemColors.Control
        Me.nLienModifiable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nLienModifiable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nLienModifiable.Font = New System.Drawing.Font("Palatino Linotype", 13.5!, System.Drawing.FontStyle.Bold)
        Me.nLienModifiable.Location = New System.Drawing.Point(155, 205)
        Me.nLienModifiable.MaxLength = 200
        Me.nLienModifiable.Name = "nLienModifiable"
        Me.nLienModifiable.Size = New System.Drawing.Size(410, 25)
        Me.nLienModifiable.TabIndex = 34
        Me.nLienModifiable.TabStop = False
        Me.tip.SetToolTip(Me.nLienModifiable, "(Requis) Lien vers la série, peut être une site web ou un chemin sur votre disque" & _
        "")
        '
        'nReturn
        '
        Me.nReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.nReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.nReturn.FlatAppearance.BorderSize = 0
        Me.nReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.nReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.nReturn.Image = CType(resources.GetObject("nReturn.Image"), System.Drawing.Image)
        Me.nReturn.Location = New System.Drawing.Point(3, 3)
        Me.nReturn.Name = "nReturn"
        Me.nReturn.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.nReturn.Size = New System.Drawing.Size(25, 25)
        Me.nReturn.TabIndex = 40
        Me.tip.SetToolTip(Me.nReturn, "Retour")
        Me.nReturn.UseVisualStyleBackColor = False
        '
        'nAjouter
        '
        Me.nAjouter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.nAjouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nAjouter.Enabled = False
        Me.nAjouter.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.nAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.nAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nAjouter.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.nAjouter.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_valid
        Me.nAjouter.Location = New System.Drawing.Point(527, 325)
        Me.nAjouter.Name = "nAjouter"
        Me.nAjouter.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.nAjouter.Size = New System.Drawing.Size(35, 35)
        Me.nAjouter.TabIndex = 2
        Me.nAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tip.SetToolTip(Me.nAjouter, "Valider")
        Me.nAjouter.UseVisualStyleBackColor = False
        '
        'nDimiss
        '
        Me.nDimiss.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.nDimiss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nDimiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.nDimiss.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nDimiss.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.nDimiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nDimiss.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.nDimiss.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_dimiss
        Me.nDimiss.Location = New System.Drawing.Point(481, 325)
        Me.nDimiss.Name = "nDimiss"
        Me.nDimiss.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.nDimiss.Size = New System.Drawing.Size(35, 35)
        Me.nDimiss.TabIndex = 42
        Me.nDimiss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tip.SetToolTip(Me.nDimiss, "Annuler")
        Me.nDimiss.UseVisualStyleBackColor = False
        '
        'nFilter
        '
        Me.nFilter.Active = True
        Me.nFilter.AutoScrollOffset = New System.Drawing.Point(0, 25)
        Me.nFilter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nFilter.Location = New System.Drawing.Point(155, 105)
        Me.nFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.nFilter.MaximumSize = New System.Drawing.Size(0, 54)
        Me.nFilter.MinimumSize = New System.Drawing.Size(410, 54)
        Me.nFilter.Name = "nFilter"
        Me.nFilter.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.nFilter.Size = New System.Drawing.Size(410, 54)
        Me.nFilter.TabIndex = 0
        Me.tip.SetToolTip(Me.nFilter, "Genre de la série")
        '
        'nRank
        '
        Me.nRank.ActiveStar = CType(resources.GetObject("nRank.ActiveStar"), System.Drawing.Bitmap)
        Me.nRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nRank.InactiveStar = CType(resources.GetObject("nRank.InactiveStar"), System.Drawing.Bitmap)
        Me.nRank.Location = New System.Drawing.Point(376, 60)
        Me.nRank.Margin = New System.Windows.Forms.Padding(0)
        Me.nRank.MaximumSize = New System.Drawing.Size(175, 35)
        Me.nRank.MinimumSize = New System.Drawing.Size(175, 35)
        Me.nRank.Name = "nRank"
        Me.nRank.Rank = 1
        Me.nRank.Size = New System.Drawing.Size(175, 35)
        Me.nRank.TabIndex = 0
        Me.tip.SetToolTip(Me.nRank, "Note")
        '
        'NewAnimeInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.nDimiss)
        Me.Controls.Add(Me.nReturn)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.nAjouter)
        Me.Controls.Add(Me.nCommentaire)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.nDate)
        Me.Controls.Add(Me.nFinish)
        Me.Controls.Add(Me.nFollow)
        Me.Controls.Add(Me.nSmartLink)
        Me.Controls.Add(Me.nTitle)
        Me.Controls.Add(Me.nEpisode)
        Me.Controls.Add(Me.nFilter)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.nRank)
        Me.Controls.Add(Me.nLienModifiable)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label9)
        Me.Name = "NewAnimeInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nRank As Gestionnaire_d_Archive.StarRanking
    Friend WithEvents nAjouter As System.Windows.Forms.Button
    Friend WithEvents nFilter As Gestionnaire_d_Archive.AnimeFilter
    Friend WithEvents nEpisode As System.Windows.Forms.TextBox
    Friend WithEvents nTitle As System.Windows.Forms.TextBox
    Friend WithEvents nSmartLink As System.Windows.Forms.CheckBox
    Friend WithEvents nFollow As System.Windows.Forms.CheckBox
    Friend WithEvents nCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents nFinish As System.Windows.Forms.CheckBox
    Friend WithEvents nDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents nLienModifiable As System.Windows.Forms.TextBox
    Friend WithEvents nReturn As System.Windows.Forms.Button
    Friend WithEvents nDimiss As System.Windows.Forms.Button
    Friend WithEvents tip As System.Windows.Forms.ToolTip

End Class
