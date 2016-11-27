<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim PictureBox11 As System.Windows.Forms.PictureBox
        Dim PictureBox10 As System.Windows.Forms.PictureBox
        Dim PictureBox9 As System.Windows.Forms.PictureBox
        Dim PictureBox8 As System.Windows.Forms.PictureBox
        Dim PictureBox7 As System.Windows.Forms.PictureBox
        Dim PictureBox6 As System.Windows.Forms.PictureBox
        Dim PictureBox5 As System.Windows.Forms.PictureBox
        Dim PictureBox4 As System.Windows.Forms.PictureBox
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim PictureBox3 As System.Windows.Forms.PictureBox
        Dim PictureBox2 As System.Windows.Forms.PictureBox
        Me.aReturn = New System.Windows.Forms.Button()
        Me.aCloturer = New System.Windows.Forms.Button()
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
        Me.aModifier = New System.Windows.Forms.Button()
        Me.aNext = New System.Windows.Forms.Button()
        Me.aPicture = New System.Windows.Forms.PictureBox()
        Me.aFilter = New Gestionnaire_d_Archive.AnimeFilter()
        Me.aRank = New Gestionnaire_d_Archive.StarRanking()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        PictureBox11 = New System.Windows.Forms.PictureBox()
        PictureBox10 = New System.Windows.Forms.PictureBox()
        PictureBox9 = New System.Windows.Forms.PictureBox()
        PictureBox8 = New System.Windows.Forms.PictureBox()
        PictureBox7 = New System.Windows.Forms.PictureBox()
        PictureBox6 = New System.Windows.Forms.PictureBox()
        PictureBox5 = New System.Windows.Forms.PictureBox()
        PictureBox4 = New System.Windows.Forms.PictureBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        PictureBox3 = New System.Windows.Forms.PictureBox()
        PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.SystemColors.Control
        Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(200, 60)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 35)
        Label1.TabIndex = 0
        Label1.Text = "* Episode :"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.SystemColors.Control
        Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(200, 170)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(210, 25)
        Label2.TabIndex = 30
        Label2.Text = "* Date de sortie de la série :"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.SystemColors.Control
        Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(200, 205)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 25)
        Label3.TabIndex = 31
        Label3.Text = "* Lien :"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox11
        '
        PictureBox11.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox11.Location = New System.Drawing.Point(200, 230)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New System.Drawing.Size(385, 10)
        PictureBox11.TabIndex = 33
        PictureBox11.TabStop = False
        PictureBox11.Visible = False
        '
        'PictureBox10
        '
        PictureBox10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox10.Location = New System.Drawing.Point(200, 160)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New System.Drawing.Size(385, 10)
        PictureBox10.TabIndex = 29
        PictureBox10.TabStop = False
        PictureBox10.Visible = False
        '
        'PictureBox9
        '
        PictureBox9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox9.Location = New System.Drawing.Point(200, 260)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New System.Drawing.Size(385, 10)
        PictureBox9.TabIndex = 26
        PictureBox9.TabStop = False
        PictureBox9.Visible = False
        '
        'PictureBox8
        '
        PictureBox8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox8.Location = New System.Drawing.Point(200, 195)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New System.Drawing.Size(385, 10)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        PictureBox8.Visible = False
        '
        'PictureBox7
        '
        PictureBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox7.Location = New System.Drawing.Point(200, 0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New System.Drawing.Size(385, 15)
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        PictureBox7.Visible = False
        '
        'PictureBox6
        '
        PictureBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox6.Location = New System.Drawing.Point(200, 360)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New System.Drawing.Size(385, 15)
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        PictureBox6.Visible = False
        '
        'PictureBox5
        '
        PictureBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox5.Location = New System.Drawing.Point(200, 315)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New System.Drawing.Size(385, 10)
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        PictureBox5.Visible = False
        '
        'PictureBox4
        '
        PictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox4.Location = New System.Drawing.Point(200, 50)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New System.Drawing.Size(385, 10)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        PictureBox4.Visible = False
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox1.Location = New System.Drawing.Point(200, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(385, 10)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        '
        'PictureBox3
        '
        PictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox3.Location = New System.Drawing.Point(585, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New System.Drawing.Size(15, 375)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        PictureBox3.Visible = False
        '
        'PictureBox2
        '
        PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        PictureBox2.Location = New System.Drawing.Point(185, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(15, 375)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        '
        'aReturn
        '
        Me.aReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.aReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.aReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.aReturn.Location = New System.Drawing.Point(3, 3)
        Me.aReturn.Name = "aReturn"
        Me.aReturn.Size = New System.Drawing.Size(25, 25)
        Me.aReturn.TabIndex = 3
        Me.aReturn.Text = "<"
        Me.aReturn.UseVisualStyleBackColor = False
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
        Me.aCloturer.Location = New System.Drawing.Point(200, 325)
        Me.aCloturer.Name = "aCloturer"
        Me.aCloturer.Size = New System.Drawing.Size(80, 35)
        Me.aCloturer.TabIndex = 10
        Me.aCloturer.Text = "Cloturer"
        Me.aCloturer.UseVisualStyleBackColor = False
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
        Me.aEpisode.ShortcutsEnabled = False
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
        Me.aTitle.Enabled = False
        Me.aTitle.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.aTitle.Location = New System.Drawing.Point(200, 15)
        Me.aTitle.MaxLength = 40
        Me.aTitle.Name = "aTitle"
        Me.aTitle.ShortcutsEnabled = False
        Me.aTitle.Size = New System.Drawing.Size(385, 35)
        Me.aTitle.TabIndex = 15
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
        Me.aSmartLink.TabIndex = 17
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
        Me.aFollow.Location = New System.Drawing.Point(283, 333)
        Me.aFollow.Name = "aFollow"
        Me.aFollow.Size = New System.Drawing.Size(140, 20)
        Me.aFollow.TabIndex = 18
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
        Me.aLien.LinkArea = New System.Windows.Forms.LinkArea(0, 25)
        Me.aLien.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.aLien.LinkColor = System.Drawing.SystemColors.ControlText
        Me.aLien.Location = New System.Drawing.Point(263, 205)
        Me.aLien.Name = "aLien"
        Me.aLien.Size = New System.Drawing.Size(322, 25)
        Me.aLien.TabIndex = 22
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
        Me.aFinish.Location = New System.Drawing.Point(421, 333)
        Me.aFinish.Name = "aFinish"
        Me.aFinish.Size = New System.Drawing.Size(68, 20)
        Me.aFinish.TabIndex = 27
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
        Me.aDate.TabIndex = 28
        Me.aDate.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'aLienModifiable
        '
        Me.aLienModifiable.BackColor = System.Drawing.SystemColors.Control
        Me.aLienModifiable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aLienModifiable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aLienModifiable.Font = New System.Drawing.Font("Palatino Linotype", 13.5!, System.Drawing.FontStyle.Bold)
        Me.aLienModifiable.Location = New System.Drawing.Point(263, 205)
        Me.aLienModifiable.MaxLength = 200
        Me.aLienModifiable.Name = "aLienModifiable"
        Me.aLienModifiable.ShortcutsEnabled = False
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
        Me.aFollowLabel.TabIndex = 35
        Me.aFollowLabel.Text = "L'épisode est sorti il y a ## jours"
        Me.aFollowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.aModifier.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.modifier
        Me.aModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aModifier.Location = New System.Drawing.Point(501, 325)
        Me.aModifier.Name = "aModifier"
        Me.aModifier.Size = New System.Drawing.Size(84, 35)
        Me.aModifier.TabIndex = 2
        Me.aModifier.Text = "Modifier"
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
        Me.aNext.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.plus
        Me.aNext.Location = New System.Drawing.Point(344, 60)
        Me.aNext.Name = "aNext"
        Me.aNext.Padding = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.aNext.Size = New System.Drawing.Size(35, 35)
        Me.aNext.TabIndex = 32
        Me.aNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aNext.UseVisualStyleBackColor = False
        '
        'aPicture
        '
        Me.aPicture.BackColor = System.Drawing.SystemColors.Control
        Me.aPicture.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.defaultPic
        Me.aPicture.Location = New System.Drawing.Point(15, 15)
        Me.aPicture.Name = "aPicture"
        Me.aPicture.Size = New System.Drawing.Size(170, 345)
        Me.aPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.aPicture.TabIndex = 0
        Me.aPicture.TabStop = False
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
        Me.aRank.ActiveStar = Global.Gestionnaire_d_Archive.My.Resources.Resources.activestar
        Me.aRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aRank.Enabled = False
        Me.aRank.InactiveStar = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
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
        Me.Controls.Add(Me.aModifier)
        Me.Controls.Add(Me.aFollowLabel)
        Me.Controls.Add(Me.aCommentaire)
        Me.Controls.Add(PictureBox11)
        Me.Controls.Add(Me.aNext)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(PictureBox10)
        Me.Controls.Add(Me.aDate)
        Me.Controls.Add(Me.aFinish)
        Me.Controls.Add(Me.aFollow)
        Me.Controls.Add(Me.aSmartLink)
        Me.Controls.Add(PictureBox9)
        Me.Controls.Add(PictureBox8)
        Me.Controls.Add(Me.aTitle)
        Me.Controls.Add(Me.aEpisode)
        Me.Controls.Add(Me.aFilter)
        Me.Controls.Add(Label1)
        Me.Controls.Add(PictureBox7)
        Me.Controls.Add(PictureBox6)
        Me.Controls.Add(PictureBox5)
        Me.Controls.Add(PictureBox4)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.aReturn)
        Me.Controls.Add(Me.aRank)
        Me.Controls.Add(PictureBox3)
        Me.Controls.Add(PictureBox2)
        Me.Controls.Add(Me.aPicture)
        Me.Controls.Add(Me.aLien)
        Me.Controls.Add(Me.aLienModifiable)
        Me.Controls.Add(Me.aCloturer)
        Me.Name = "AnimeInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
