<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInterface
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
        Me.mTitle = New System.Windows.Forms.Label()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.mExit = New System.Windows.Forms.Button()
        Me.mNew = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mLoad = New System.Windows.Forms.Button()
        Me.mSave = New System.Windows.Forms.Button()
        Me.mSignin = New System.Windows.Forms.Button()
        Me.mSettings = New System.Windows.Forms.Button()
        Me.mInfo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mTitle
        '
        Me.mTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.mTitle.Font = New System.Drawing.Font("Myriad Web Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTitle.Location = New System.Drawing.Point(0, 0)
        Me.mTitle.Name = "mTitle"
        Me.mTitle.Size = New System.Drawing.Size(150, 40)
        Me.mTitle.TabIndex = 0
        Me.mTitle.Text = "Menu"
        Me.mTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerAnimation
        '
        Me.timerAnimation.Interval = 50
        '
        'mExit
        '
        Me.mExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mExit.FlatAppearance.BorderSize = 0
        Me.mExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mExit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mExit.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_quit
        Me.mExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mExit.Location = New System.Drawing.Point(0, 365)
        Me.mExit.Name = "mExit"
        Me.mExit.Size = New System.Drawing.Size(150, 35)
        Me.mExit.TabIndex = 0
        Me.mExit.TabStop = False
        Me.mExit.Text = "Quitter"
        Me.mExit.UseVisualStyleBackColor = False
        '
        'mNew
        '
        Me.mNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.mNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mNew.FlatAppearance.BorderSize = 0
        Me.mNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mNew.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNew.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_add
        Me.mNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mNew.Location = New System.Drawing.Point(0, 40)
        Me.mNew.Name = "mNew"
        Me.mNew.Size = New System.Drawing.Size(150, 35)
        Me.mNew.TabIndex = 0
        Me.mNew.TabStop = False
        Me.mNew.Text = "  Ajouter"
        Me.mNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mNew.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 400)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'mLoad
        '
        Me.mLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mLoad.Dock = System.Windows.Forms.DockStyle.Top
        Me.mLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mLoad.FlatAppearance.BorderSize = 0
        Me.mLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mLoad.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mLoad.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_search
        Me.mLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mLoad.Location = New System.Drawing.Point(0, 75)
        Me.mLoad.Name = "mLoad"
        Me.mLoad.Size = New System.Drawing.Size(150, 35)
        Me.mLoad.TabIndex = 17
        Me.mLoad.TabStop = False
        Me.mLoad.Text = "  Rechercher"
        Me.mLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mLoad.UseVisualStyleBackColor = False
        '
        'mSave
        '
        Me.mSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mSave.Dock = System.Windows.Forms.DockStyle.Top
        Me.mSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mSave.FlatAppearance.BorderSize = 0
        Me.mSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mSave.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mSave.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_save
        Me.mSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSave.Location = New System.Drawing.Point(0, 110)
        Me.mSave.Name = "mSave"
        Me.mSave.Size = New System.Drawing.Size(150, 35)
        Me.mSave.TabIndex = 18
        Me.mSave.TabStop = False
        Me.mSave.Text = "  Sauvegarder"
        Me.mSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mSave.UseVisualStyleBackColor = False
        '
        'mSignin
        '
        Me.mSignin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mSignin.Dock = System.Windows.Forms.DockStyle.Top
        Me.mSignin.Enabled = False
        Me.mSignin.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mSignin.FlatAppearance.BorderSize = 0
        Me.mSignin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mSignin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mSignin.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mSignin.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_login
        Me.mSignin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSignin.Location = New System.Drawing.Point(0, 145)
        Me.mSignin.Name = "mSignin"
        Me.mSignin.Size = New System.Drawing.Size(150, 35)
        Me.mSignin.TabIndex = 19
        Me.mSignin.TabStop = False
        Me.mSignin.Text = "  S'enregistrer"
        Me.mSignin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSignin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mSignin.UseVisualStyleBackColor = False
        '
        'mSettings
        '
        Me.mSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.mSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mSettings.FlatAppearance.BorderSize = 0
        Me.mSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mSettings.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mSettings.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_settings
        Me.mSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSettings.Location = New System.Drawing.Point(0, 180)
        Me.mSettings.Name = "mSettings"
        Me.mSettings.Size = New System.Drawing.Size(150, 35)
        Me.mSettings.TabIndex = 20
        Me.mSettings.TabStop = False
        Me.mSettings.Text = "  Options"
        Me.mSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mSettings.UseVisualStyleBackColor = False
        '
        'mInfo
        '
        Me.mInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.mInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mInfo.FlatAppearance.BorderSize = 0
        Me.mInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mInfo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mInfo.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_information
        Me.mInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mInfo.Location = New System.Drawing.Point(0, 215)
        Me.mInfo.Name = "mInfo"
        Me.mInfo.Size = New System.Drawing.Size(150, 35)
        Me.mInfo.TabIndex = 21
        Me.mInfo.TabStop = False
        Me.mInfo.Text = "  Information"
        Me.mInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mInfo.UseVisualStyleBackColor = False
        '
        'MenuInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.mInfo)
        Me.Controls.Add(Me.mSettings)
        Me.Controls.Add(Me.mSignin)
        Me.Controls.Add(Me.mSave)
        Me.Controls.Add(Me.mLoad)
        Me.Controls.Add(Me.mExit)
        Me.Controls.Add(Me.mNew)
        Me.Controls.Add(Me.mTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuInterface"
        Me.Size = New System.Drawing.Size(150, 400)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mTitle As System.Windows.Forms.Label
    Friend WithEvents mNew As System.Windows.Forms.Button
    Private WithEvents timerAnimation As System.Windows.Forms.Timer
    Friend WithEvents mExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mLoad As System.Windows.Forms.Button
    Friend WithEvents mSave As System.Windows.Forms.Button
    Friend WithEvents mSignin As System.Windows.Forms.Button
    Friend WithEvents mSettings As System.Windows.Forms.Button
    Friend WithEvents mInfo As System.Windows.Forms.Button

End Class
