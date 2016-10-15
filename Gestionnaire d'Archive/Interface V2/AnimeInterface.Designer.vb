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
        Me.aTitle = New System.Windows.Forms.Label()
        Me.aReturn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.aPicture = New System.Windows.Forms.PictureBox()
        Me.aRank = New Gestionnaire_d_Archive.StarRanking()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aTitle
        '
        Me.aTitle.BackColor = System.Drawing.SystemColors.Control
        Me.aTitle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold)
        Me.aTitle.Location = New System.Drawing.Point(200, 15)
        Me.aTitle.Name = "aTitle"
        Me.aTitle.Size = New System.Drawing.Size(385, 35)
        Me.aTitle.TabIndex = 2
        Me.aTitle.Text = "Anime Panel Title"
        Me.aTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.aReturn.TabIndex = 6
        Me.aReturn.Text = "<"
        Me.aReturn.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox4.Location = New System.Drawing.Point(200, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(385, 15)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Location = New System.Drawing.Point(200, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 15)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox3.Location = New System.Drawing.Point(585, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 375)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.Location = New System.Drawing.Point(185, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 375)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
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
        'aRank
        '
        Me.aRank.ActiveStar = Global.Gestionnaire_d_Archive.My.Resources.Resources.activestar
        Me.aRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aRank.InactiveStar = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
        Me.aRank.Location = New System.Drawing.Point(310, 65)
        Me.aRank.Margin = New System.Windows.Forms.Padding(0)
        Me.aRank.MaximumSize = New System.Drawing.Size(175, 35)
        Me.aRank.MinimumSize = New System.Drawing.Size(175, 35)
        Me.aRank.Name = "aRank"
        Me.aRank.Rank = 1
        Me.aRank.Size = New System.Drawing.Size(175, 35)
        Me.aRank.TabIndex = 4
        '
        'AnimeInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.aReturn)
        Me.Controls.Add(Me.aRank)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.aTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.aPicture)
        Me.Name = "AnimeInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents aTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents aPicture As System.Windows.Forms.PictureBox
    Friend WithEvents aRank As Gestionnaire_d_Archive.StarRanking
    Friend WithEvents aReturn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
