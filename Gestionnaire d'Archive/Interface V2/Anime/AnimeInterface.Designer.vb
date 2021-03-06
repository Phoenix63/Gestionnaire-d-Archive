﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimeInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnimeInterface))
        Me.lbEpisode = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbLien = New System.Windows.Forms.Label()
        Me.aEpisode = New System.Windows.Forms.TextBox()
        Me.aTitle = New System.Windows.Forms.TextBox()
        Me.aSmartLink = New System.Windows.Forms.CheckBox()
        Me.aFollow = New System.Windows.Forms.CheckBox()
        Me.aLien = New System.Windows.Forms.LinkLabel()
        Me.aCommentaire = New System.Windows.Forms.TextBox()
        Me.aFinish = New System.Windows.Forms.CheckBox()
        Me.aDate = New System.Windows.Forms.DateTimePicker()
        Me.aLienModifiable = New System.Windows.Forms.TextBox()
        Me.aFollowLabel = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.aCloturer = New System.Windows.Forms.Button()
        Me.aDimiss = New System.Windows.Forms.Button()
        Me.aSupprimer = New System.Windows.Forms.Button()
        Me.TipLink = New System.Windows.Forms.ToolTip(Me.components)
        Me.aModifier = New System.Windows.Forms.Button()
        Me.aNext = New System.Windows.Forms.Button()
        Me.aReturn = New System.Windows.Forms.Button()
        Me.aPicture = New System.Windows.Forms.PictureBox()
        Me.pictureCM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.changePicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.deletePicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.aFilter = New Gestionnaire_d_Archive.AnimeFilter()
        Me.aRank = New Gestionnaire_d_Archive.StarRanking()
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pictureCM.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbEpisode
        '
        Me.lbEpisode.BackColor = System.Drawing.SystemColors.Control
        Me.lbEpisode.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbEpisode.Location = New System.Drawing.Point(200, 60)
        Me.lbEpisode.Name = "lbEpisode"
        Me.lbEpisode.Size = New System.Drawing.Size(86, 35)
        Me.lbEpisode.TabIndex = 0
        Me.lbEpisode.Text = "Episode :"
        Me.lbEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDate
        '
        Me.lbDate.BackColor = System.Drawing.SystemColors.Control
        Me.lbDate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbDate.Location = New System.Drawing.Point(200, 170)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(210, 25)
        Me.lbDate.TabIndex = 0
        Me.lbDate.Text = "Date de sortie de la série :"
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLien
        '
        Me.lbLien.BackColor = System.Drawing.SystemColors.Control
        Me.lbLien.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbLien.Location = New System.Drawing.Point(200, 205)
        Me.lbLien.Name = "lbLien"
        Me.lbLien.Size = New System.Drawing.Size(63, 25)
        Me.lbLien.TabIndex = 0
        Me.lbLien.Text = "Lien :"
        Me.lbLien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aEpisode
        '
        Me.aEpisode.BackColor = System.Drawing.SystemColors.Control
        Me.aEpisode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aEpisode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.aEpisode.Enabled = False
        Me.aEpisode.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.aEpisode.Location = New System.Drawing.Point(286, 60)
        Me.aEpisode.MaxLength = 4
        Me.aEpisode.Name = "aEpisode"
        Me.aEpisode.Size = New System.Drawing.Size(58, 35)
        Me.aEpisode.TabIndex = 0
        Me.aEpisode.TabStop = False
        Me.aEpisode.Text = "1"
        Me.aEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aTitle
        '
        Me.aTitle.BackColor = System.Drawing.SystemColors.Control
        Me.aTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.aTitle.Font = New System.Drawing.Font("Palatino Linotype", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aTitle.Location = New System.Drawing.Point(200, 15)
        Me.aTitle.MaxLength = 40
        Me.aTitle.Name = "aTitle"
        Me.aTitle.ReadOnly = True
        Me.aTitle.Size = New System.Drawing.Size(385, 34)
        Me.aTitle.TabIndex = 0
        Me.aTitle.TabStop = False
        Me.aTitle.Text = "Anime Panel Title"
        Me.aTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aSmartLink
        '
        Me.aSmartLink.AutoSize = True
        Me.aSmartLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aSmartLink.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aSmartLink.FlatAppearance.BorderSize = 0
        Me.aSmartLink.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aSmartLink.Location = New System.Drawing.Point(200, 333)
        Me.aSmartLink.Name = "aSmartLink"
        Me.aSmartLink.Size = New System.Drawing.Size(82, 20)
        Me.aSmartLink.TabIndex = 0
        Me.aSmartLink.Text = "Lien Smart"
        Me.aSmartLink.UseVisualStyleBackColor = True
        '
        'aFollow
        '
        Me.aFollow.AutoSize = True
        Me.aFollow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aFollow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aFollow.FlatAppearance.BorderSize = 0
        Me.aFollow.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aFollow.Location = New System.Drawing.Point(288, 333)
        Me.aFollow.Name = "aFollow"
        Me.aFollow.Size = New System.Drawing.Size(140, 20)
        Me.aFollow.TabIndex = 0
        Me.aFollow.Text = "Suivre chaque semaine"
        Me.aFollow.UseVisualStyleBackColor = True
        '
        'aLien
        '
        Me.aLien.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.aLien.AutoEllipsis = True
        Me.aLien.BackColor = System.Drawing.SystemColors.Control
        Me.aLien.Cursor = System.Windows.Forms.Cursors.Default
        Me.aLien.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.aLien.LinkArea = New System.Windows.Forms.LinkArea(0, 500)
        Me.aLien.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.aLien.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.aLien.Location = New System.Drawing.Point(263, 205)
        Me.aLien.Name = "aLien"
        Me.aLien.Size = New System.Drawing.Size(322, 25)
        Me.aLien.TabIndex = 1
        Me.aLien.TabStop = True
        Me.aLien.Text = "http://foo.fr/bar"
        Me.aLien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aLien.UseCompatibleTextRendering = True
        '
        'aCommentaire
        '
        Me.aCommentaire.BackColor = System.Drawing.SystemColors.Control
        Me.aCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aCommentaire.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.aCommentaire.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.aCommentaire.Location = New System.Drawing.Point(200, 270)
        Me.aCommentaire.MaxLength = 100
        Me.aCommentaire.Multiline = True
        Me.aCommentaire.Name = "aCommentaire"
        Me.aCommentaire.ReadOnly = True
        Me.aCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.aCommentaire.Size = New System.Drawing.Size(385, 45)
        Me.aCommentaire.TabIndex = 25
        Me.aCommentaire.TabStop = False
        Me.aCommentaire.Text = "Commentaire"
        '
        'aFinish
        '
        Me.aFinish.AutoSize = True
        Me.aFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aFinish.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aFinish.FlatAppearance.BorderSize = 0
        Me.aFinish.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aFinish.Location = New System.Drawing.Point(434, 333)
        Me.aFinish.Name = "aFinish"
        Me.aFinish.Size = New System.Drawing.Size(68, 20)
        Me.aFinish.TabIndex = 0
        Me.aFinish.Text = "Terminé"
        Me.aFinish.UseVisualStyleBackColor = True
        '
        'aDate
        '
        Me.aDate.CalendarFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.aDate.Checked = False
        Me.aDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aDate.CustomFormat = " dd MMMM yyyy"
        Me.aDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.aDate.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.aDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.aDate.Location = New System.Drawing.Point(410, 170)
        Me.aDate.Name = "aDate"
        Me.aDate.Size = New System.Drawing.Size(175, 25)
        Me.aDate.TabIndex = 0
        Me.aDate.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'aLienModifiable
        '
        Me.aLienModifiable.BackColor = System.Drawing.SystemColors.Control
        Me.aLienModifiable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aLienModifiable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aLienModifiable.Font = New System.Drawing.Font("Palatino Linotype", 13.5!, System.Drawing.FontStyle.Bold)
        Me.aLienModifiable.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.aLienModifiable.Location = New System.Drawing.Point(263, 205)
        Me.aLienModifiable.MaxLength = 200
        Me.aLienModifiable.Name = "aLienModifiable"
        Me.aLienModifiable.Size = New System.Drawing.Size(322, 25)
        Me.aLienModifiable.TabIndex = 34
        Me.aLienModifiable.TabStop = False
        Me.aLienModifiable.Text = "LinkModifiable"
        Me.aLienModifiable.Visible = False
        '
        'aFollowLabel
        '
        Me.aFollowLabel.BackColor = System.Drawing.SystemColors.Control
        Me.aFollowLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aFollowLabel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.aFollowLabel.Location = New System.Drawing.Point(200, 240)
        Me.aFollowLabel.Name = "aFollowLabel"
        Me.aFollowLabel.Size = New System.Drawing.Size(385, 20)
        Me.aFollowLabel.TabIndex = 0
        Me.aFollowLabel.Text = "L'épisode est sorti il y a ## jours"
        Me.aFollowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aCloturer
        '
        Me.aCloturer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aCloturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aCloturer.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aCloturer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aCloturer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aCloturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aCloturer.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aCloturer.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_close
        Me.aCloturer.Location = New System.Drawing.Point(200, 325)
        Me.aCloturer.Name = "aCloturer"
        Me.aCloturer.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.aCloturer.Size = New System.Drawing.Size(35, 35)
        Me.aCloturer.TabIndex = 3
        Me.aCloturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aCloturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tip.SetToolTip(Me.aCloturer, "Faire passer la série de l'état en cours à l'état fini")
        Me.aCloturer.UseVisualStyleBackColor = False
        '
        'aDimiss
        '
        Me.aDimiss.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aDimiss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aDimiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aDimiss.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aDimiss.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aDimiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aDimiss.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aDimiss.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_editdimiss
        Me.aDimiss.Location = New System.Drawing.Point(506, 325)
        Me.aDimiss.Name = "aDimiss"
        Me.aDimiss.Size = New System.Drawing.Size(35, 35)
        Me.aDimiss.TabIndex = 37
        Me.aDimiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tip.SetToolTip(Me.aDimiss, "Annuler les changements")
        Me.aDimiss.UseVisualStyleBackColor = False
        Me.aDimiss.Visible = False
        '
        'aSupprimer
        '
        Me.aSupprimer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aSupprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aSupprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aSupprimer.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aSupprimer.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_delete
        Me.aSupprimer.Location = New System.Drawing.Point(506, 325)
        Me.aSupprimer.Name = "aSupprimer"
        Me.aSupprimer.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.aSupprimer.Size = New System.Drawing.Size(35, 35)
        Me.aSupprimer.TabIndex = 35
        Me.aSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tip.SetToolTip(Me.aSupprimer, "Supprimer la série")
        Me.aSupprimer.UseVisualStyleBackColor = False
        '
        'aModifier
        '
        Me.aModifier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aModifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aModifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aModifier.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aModifier.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aModifier.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aModifier.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_edit
        Me.aModifier.Location = New System.Drawing.Point(550, 325)
        Me.aModifier.Name = "aModifier"
        Me.aModifier.Size = New System.Drawing.Size(35, 35)
        Me.aModifier.TabIndex = 3
        Me.aModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aModifier.UseVisualStyleBackColor = False
        '
        'aNext
        '
        Me.aNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aNext.FlatAppearance.BorderSize = 0
        Me.aNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aNext.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aNext.Image = CType(resources.GetObject("aNext.Image"), System.Drawing.Image)
        Me.aNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aNext.Location = New System.Drawing.Point(344, 60)
        Me.aNext.Name = "aNext"
        Me.aNext.Size = New System.Drawing.Size(35, 35)
        Me.aNext.TabIndex = 2
        Me.aNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.aNext.UseVisualStyleBackColor = False
        '
        'aReturn
        '
        Me.aReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aReturn.FlatAppearance.BorderSize = 0
        Me.aReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aReturn.Image = CType(resources.GetObject("aReturn.Image"), System.Drawing.Image)
        Me.aReturn.Location = New System.Drawing.Point(3, 3)
        Me.aReturn.Name = "aReturn"
        Me.aReturn.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.aReturn.Size = New System.Drawing.Size(25, 25)
        Me.aReturn.TabIndex = 3
        Me.aReturn.UseVisualStyleBackColor = False
        '
        'aPicture
        '
        Me.aPicture.BackColor = System.Drawing.SystemColors.Control
        Me.aPicture.ContextMenuStrip = Me.pictureCM
        Me.aPicture.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.defaultPic
        Me.aPicture.Location = New System.Drawing.Point(15, 15)
        Me.aPicture.Name = "aPicture"
        Me.aPicture.Size = New System.Drawing.Size(170, 345)
        Me.aPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.aPicture.TabIndex = 0
        Me.aPicture.TabStop = False
        '
        'pictureCM
        '
        Me.pictureCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changePicture, Me.deletePicture})
        Me.pictureCM.Name = "ContextMenuStrip1"
        Me.pictureCM.Size = New System.Drawing.Size(162, 48)
        '
        'changePicture
        '
        Me.changePicture.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_imagechange
        Me.changePicture.Name = "changePicture"
        Me.changePicture.Size = New System.Drawing.Size(161, 22)
        Me.changePicture.Text = "Changer l'image"
        '
        'deletePicture
        '
        Me.deletePicture.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_delete
        Me.deletePicture.Name = "deletePicture"
        Me.deletePicture.Size = New System.Drawing.Size(161, 22)
        Me.deletePicture.Text = "Supprimer"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.Button2.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.modifier
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(342, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Partager"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'aFilter
        '
        Me.aFilter.Active = False
        Me.aFilter.AutoScrollOffset = New System.Drawing.Point(0, 25)
        Me.aFilter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.aFilter.Location = New System.Drawing.Point(200, 105)
        Me.aFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.aFilter.MaximumSize = New System.Drawing.Size(0, 54)
        Me.aFilter.MinimumSize = New System.Drawing.Size(385, 54)
        Me.aFilter.Name = "aFilter"
        Me.aFilter.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.aFilter.Size = New System.Drawing.Size(385, 54)
        Me.aFilter.TabIndex = 0
        '
        'aRank
        '
        Me.aRank.ActiveStar = CType(resources.GetObject("aRank.ActiveStar"), System.Drawing.Bitmap)
        Me.aRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aRank.Enabled = False
        Me.aRank.InactiveStar = CType(resources.GetObject("aRank.InactiveStar"), System.Drawing.Bitmap)
        Me.aRank.Location = New System.Drawing.Point(400, 60)
        Me.aRank.Margin = New System.Windows.Forms.Padding(0)
        Me.aRank.MaximumSize = New System.Drawing.Size(175, 35)
        Me.aRank.MinimumSize = New System.Drawing.Size(175, 35)
        Me.aRank.Name = "aRank"
        Me.aRank.Rank = 1
        Me.aRank.Size = New System.Drawing.Size(175, 35)
        Me.aRank.TabIndex = 0
        '
        'AnimeInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.aCloturer)
        Me.Controls.Add(Me.aDimiss)
        Me.Controls.Add(Me.aSupprimer)
        Me.Controls.Add(Me.aModifier)
        Me.Controls.Add(Me.aFollowLabel)
        Me.Controls.Add(Me.aCommentaire)
        Me.Controls.Add(Me.aNext)
        Me.Controls.Add(Me.lbLien)
        Me.Controls.Add(Me.lbDate)
        Me.Controls.Add(Me.aDate)
        Me.Controls.Add(Me.aFinish)
        Me.Controls.Add(Me.aFollow)
        Me.Controls.Add(Me.aSmartLink)
        Me.Controls.Add(Me.aTitle)
        Me.Controls.Add(Me.aEpisode)
        Me.Controls.Add(Me.aFilter)
        Me.Controls.Add(Me.lbEpisode)
        Me.Controls.Add(Me.aReturn)
        Me.Controls.Add(Me.aRank)
        Me.Controls.Add(Me.aPicture)
        Me.Controls.Add(Me.aLien)
        Me.Controls.Add(Me.aLienModifiable)
        Me.Controls.Add(Me.Button2)
        Me.Name = "AnimeInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pictureCM.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aPicture As System.Windows.Forms.PictureBox
    Friend WithEvents aRank As Gestionnaire_d_Archive.StarRanking
    Friend WithEvents aReturn As System.Windows.Forms.Button
    Friend WithEvents aCloturer As System.Windows.Forms.Button
    Friend WithEvents aModifier As System.Windows.Forms.Button
    Friend WithEvents aFilter As Gestionnaire_d_Archive.AnimeFilter
    Friend WithEvents aEpisode As System.Windows.Forms.TextBox
    Friend WithEvents aTitle As System.Windows.Forms.TextBox
    Friend WithEvents aSmartLink As System.Windows.Forms.CheckBox
    Friend WithEvents aFollow As System.Windows.Forms.CheckBox
    Friend WithEvents aLien As System.Windows.Forms.LinkLabel
    Friend WithEvents aCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents aFinish As System.Windows.Forms.CheckBox
    Friend WithEvents aDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents aNext As System.Windows.Forms.Button
    Friend WithEvents aLienModifiable As System.Windows.Forms.TextBox
    Friend WithEvents aFollowLabel As System.Windows.Forms.Label
    Friend WithEvents lbEpisode As System.Windows.Forms.Label
    Friend WithEvents lbDate As System.Windows.Forms.Label
    Friend WithEvents lbLien As System.Windows.Forms.Label
    Friend WithEvents aSupprimer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents TipLink As System.Windows.Forms.ToolTip
    Friend WithEvents aDimiss As System.Windows.Forms.Button
    Friend WithEvents pictureCM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents changePicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deletePicture As System.Windows.Forms.ToolStripMenuItem

End Class
