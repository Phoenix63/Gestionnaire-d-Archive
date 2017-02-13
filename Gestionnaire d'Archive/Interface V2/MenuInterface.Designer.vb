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
        Me.mNew = New System.Windows.Forms.Button()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.mClose = New System.Windows.Forms.Button()
        Me.mLoad = New System.Windows.Forms.Button()
        Me.mSave = New System.Windows.Forms.Button()
        Me.mSignin = New System.Windows.Forms.Button()
        Me.mInfo = New System.Windows.Forms.Button()
        Me.mExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mTitle
        '
        Me.mTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mTitle.Font = New System.Drawing.Font("Myriad Web Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTitle.Location = New System.Drawing.Point(0, 0)
        Me.mTitle.Name = "mTitle"
        Me.mTitle.Size = New System.Drawing.Size(150, 40)
        Me.mTitle.TabIndex = 0
        Me.mTitle.Text = "Menu"
        Me.mTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mNew
        '
        Me.mNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mNew.FlatAppearance.BorderSize = 0
        Me.mNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mNew.Location = New System.Drawing.Point(0, 40)
        Me.mNew.Name = "mNew"
        Me.mNew.Size = New System.Drawing.Size(150, 25)
        Me.mNew.TabIndex = 8
        Me.mNew.Text = "Nouveau"
        Me.mNew.UseVisualStyleBackColor = False
        '
        'timerAnimation
        '
        Me.timerAnimation.Interval = 50
        '
        'mClose
        '
        Me.mClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mClose.FlatAppearance.BorderSize = 0
        Me.mClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mClose.Location = New System.Drawing.Point(7, 7)
        Me.mClose.Name = "mClose"
        Me.mClose.Size = New System.Drawing.Size(25, 25)
        Me.mClose.TabIndex = 9
        Me.mClose.Text = "X"
        Me.mClose.UseVisualStyleBackColor = False
        Me.mClose.Visible = False
        '
        'mLoad
        '
        Me.mLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mLoad.FlatAppearance.BorderSize = 0
        Me.mLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mLoad.Location = New System.Drawing.Point(0, 92)
        Me.mLoad.Name = "mLoad"
        Me.mLoad.Size = New System.Drawing.Size(150, 25)
        Me.mLoad.TabIndex = 10
        Me.mLoad.Text = "Charger"
        Me.mLoad.UseVisualStyleBackColor = False
        '
        'mSave
        '
        Me.mSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mSave.FlatAppearance.BorderSize = 0
        Me.mSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mSave.Location = New System.Drawing.Point(0, 66)
        Me.mSave.Name = "mSave"
        Me.mSave.Size = New System.Drawing.Size(150, 25)
        Me.mSave.TabIndex = 11
        Me.mSave.Text = "Sauvegarder"
        Me.mSave.UseVisualStyleBackColor = False
        '
        'mSignin
        '
        Me.mSignin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mSignin.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mSignin.FlatAppearance.BorderSize = 0
        Me.mSignin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mSignin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mSignin.Location = New System.Drawing.Point(0, 118)
        Me.mSignin.Name = "mSignin"
        Me.mSignin.Size = New System.Drawing.Size(150, 25)
        Me.mSignin.TabIndex = 12
        Me.mSignin.Text = "S'enregistrer"
        Me.mSignin.UseVisualStyleBackColor = False
        '
        'mInfo
        '
        Me.mInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mInfo.FlatAppearance.BorderSize = 0
        Me.mInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mInfo.Location = New System.Drawing.Point(0, 144)
        Me.mInfo.Name = "mInfo"
        Me.mInfo.Size = New System.Drawing.Size(150, 25)
        Me.mInfo.TabIndex = 13
        Me.mInfo.Text = "Information"
        Me.mInfo.UseVisualStyleBackColor = False
        '
        'mExit
        '
        Me.mExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mExit.FlatAppearance.BorderSize = 0
        Me.mExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.mExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mExit.Location = New System.Drawing.Point(0, 375)
        Me.mExit.Name = "mExit"
        Me.mExit.Size = New System.Drawing.Size(150, 25)
        Me.mExit.TabIndex = 14
        Me.mExit.Text = "Quitter"
        Me.mExit.UseVisualStyleBackColor = False
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
        'MenuInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.mExit)
        Me.Controls.Add(Me.mInfo)
        Me.Controls.Add(Me.mSignin)
        Me.Controls.Add(Me.mSave)
        Me.Controls.Add(Me.mLoad)
        Me.Controls.Add(Me.mClose)
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
    Friend WithEvents mClose As System.Windows.Forms.Button
    Friend WithEvents mLoad As System.Windows.Forms.Button
    Friend WithEvents mSave As System.Windows.Forms.Button
    Friend WithEvents mSignin As System.Windows.Forms.Button
    Friend WithEvents mInfo As System.Windows.Forms.Button
    Friend WithEvents mExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
