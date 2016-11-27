<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercherInterface
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
        Me.rTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AnimeCard4 = New Gestionnaire_d_Archive.AnimeCard()
        Me.AnimeCard1 = New Gestionnaire_d_Archive.AnimeCard()
        Me.AnimeCard3 = New Gestionnaire_d_Archive.AnimeCard()
        Me.AnimeCard2 = New Gestionnaire_d_Archive.AnimeCard()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rTitle
        '
        Me.rTitle.BackColor = System.Drawing.SystemColors.Control
        Me.rTitle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold)
        Me.rTitle.Location = New System.Drawing.Point(15, 15)
        Me.rTitle.Name = "rTitle"
        Me.rTitle.Size = New System.Drawing.Size(570, 35)
        Me.rTitle.TabIndex = 2
        Me.rTitle.Text = "Rechercher Panel Title"
        Me.rTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(438, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 375)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.AnimeCard4)
        Me.Panel1.Controls.Add(Me.AnimeCard1)
        Me.Panel1.Controls.Add(Me.AnimeCard3)
        Me.Panel1.Controls.Add(Me.AnimeCard2)
        Me.Panel1.Location = New System.Drawing.Point(15, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 220)
        Me.Panel1.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(545, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 70)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 70)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AnimeCard4
        '
        Me.AnimeCard4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AnimeCard4.Location = New System.Drawing.Point(420, 10)
        Me.AnimeCard4.Name = "AnimeCard4"
        Me.AnimeCard4.Size = New System.Drawing.Size(120, 200)
        Me.AnimeCard4.TabIndex = 20
        '
        'AnimeCard1
        '
        Me.AnimeCard1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AnimeCard1.Location = New System.Drawing.Point(30, 10)
        Me.AnimeCard1.Name = "AnimeCard1"
        Me.AnimeCard1.Size = New System.Drawing.Size(120, 200)
        Me.AnimeCard1.TabIndex = 17
        '
        'AnimeCard3
        '
        Me.AnimeCard3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AnimeCard3.Location = New System.Drawing.Point(290, 10)
        Me.AnimeCard3.Name = "AnimeCard3"
        Me.AnimeCard3.Size = New System.Drawing.Size(120, 200)
        Me.AnimeCard3.TabIndex = 19
        '
        'AnimeCard2
        '
        Me.AnimeCard2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AnimeCard2.Location = New System.Drawing.Point(160, 10)
        Me.AnimeCard2.Name = "AnimeCard2"
        Me.AnimeCard2.Size = New System.Drawing.Size(120, 200)
        Me.AnimeCard2.TabIndex = 18
        '
        'RechercherInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "RechercherInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AnimeCard1 As Gestionnaire_d_Archive.AnimeCard
    Friend WithEvents AnimeCard2 As Gestionnaire_d_Archive.AnimeCard
    Friend WithEvents AnimeCard3 As Gestionnaire_d_Archive.AnimeCard
    Friend WithEvents AnimeCard4 As Gestionnaire_d_Archive.AnimeCard
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
