<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchFilter))
        Me.buildFilter = New System.Windows.Forms.Button()
        Me.aFinish = New System.Windows.Forms.CheckBox()
        Me.aFollow = New System.Windows.Forms.CheckBox()
        Me.aName = New System.Windows.Forms.TextBox()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.aRank = New Gestionnaire_d_Archive.StarRanking()
        Me.aFilter = New Gestionnaire_d_Archive.AnimeFilter()
        Me.aOut = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'buildFilter
        '
        Me.buildFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.buildFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buildFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.buildFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buildFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.buildFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buildFilter.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.buildFilter.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.search
        Me.buildFilter.Location = New System.Drawing.Point(535, 75)
        Me.buildFilter.Name = "buildFilter"
        Me.buildFilter.Padding = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.buildFilter.Size = New System.Drawing.Size(30, 30)
        Me.buildFilter.TabIndex = 0
        Me.buildFilter.TabStop = False
        Me.Tip.SetToolTip(Me.buildFilter, "Rerchercher avec les filtres sélectionnés")
        Me.buildFilter.UseVisualStyleBackColor = False
        '
        'aFinish
        '
        Me.aFinish.AutoSize = True
        Me.aFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aFinish.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aFinish.FlatAppearance.BorderSize = 0
        Me.aFinish.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aFinish.Location = New System.Drawing.Point(463, 77)
        Me.aFinish.Name = "aFinish"
        Me.aFinish.Size = New System.Drawing.Size(68, 20)
        Me.aFinish.TabIndex = 0
        Me.aFinish.Text = "Terminé"
        Me.aFinish.UseVisualStyleBackColor = True
        '
        'aFollow
        '
        Me.aFollow.AutoSize = True
        Me.aFollow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aFollow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aFollow.FlatAppearance.BorderSize = 0
        Me.aFollow.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aFollow.Location = New System.Drawing.Point(411, 77)
        Me.aFollow.Name = "aFollow"
        Me.aFollow.Size = New System.Drawing.Size(51, 20)
        Me.aFollow.TabIndex = 0
        Me.aFollow.TabStop = False
        Me.aFollow.Text = "Suivi"
        Me.aFollow.UseVisualStyleBackColor = True
        '
        'aName
        '
        Me.aName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.aName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.aName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.aName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.aName.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.aName.Location = New System.Drawing.Point(6, 69)
        Me.aName.MaxLength = 40
        Me.aName.Name = "aName"
        Me.aName.ShortcutsEnabled = False
        Me.aName.Size = New System.Drawing.Size(341, 35)
        Me.aName.TabIndex = 0
        Me.aName.TabStop = False
        Me.aName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tip.SetToolTip(Me.aName, "Filtre par nom (prioritaire sur les autres filtres)")
        '
        'aRank
        '
        Me.aRank.ActiveStar = CType(resources.GetObject("aRank.ActiveStar"), System.Drawing.Bitmap)
        Me.aRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aRank.InactiveStar = CType(resources.GetObject("aRank.InactiveStar"), System.Drawing.Bitmap)
        Me.aRank.Location = New System.Drawing.Point(7, 13)
        Me.aRank.Margin = New System.Windows.Forms.Padding(0)
        Me.aRank.MaximumSize = New System.Drawing.Size(175, 35)
        Me.aRank.MinimumSize = New System.Drawing.Size(175, 35)
        Me.aRank.Name = "aRank"
        Me.aRank.Rank = 1
        Me.aRank.Size = New System.Drawing.Size(175, 35)
        Me.aRank.TabIndex = 0
        Me.aRank.TabStop = False
        Me.Tip.SetToolTip(Me.aRank, "Classement")
        '
        'aFilter
        '
        Me.aFilter.Active = True
        Me.aFilter.AutoScrollOffset = New System.Drawing.Point(0, 25)
        Me.aFilter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.aFilter.Location = New System.Drawing.Point(184, 6)
        Me.aFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.aFilter.MaximumSize = New System.Drawing.Size(0, 54)
        Me.aFilter.MinimumSize = New System.Drawing.Size(380, 54)
        Me.aFilter.Name = "aFilter"
        Me.aFilter.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.aFilter.Separator = Nothing
        Me.aFilter.Size = New System.Drawing.Size(380, 54)
        Me.aFilter.TabIndex = 0
        Me.Tip.SetToolTip(Me.aFilter, "Genre")
        '
        'aOut
        '
        Me.aOut.AutoSize = True
        Me.aOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.aOut.FlatAppearance.BorderSize = 0
        Me.aOut.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.aOut.Location = New System.Drawing.Point(355, 77)
        Me.aOut.Name = "aOut"
        Me.aOut.Size = New System.Drawing.Size(51, 20)
        Me.aOut.TabIndex = 1
        Me.aOut.TabStop = False
        Me.aOut.Text = "Sorti"
        Me.aOut.UseVisualStyleBackColor = True
        '
        'SearchFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.aOut)
        Me.Controls.Add(Me.aName)
        Me.Controls.Add(Me.aFinish)
        Me.Controls.Add(Me.aFollow)
        Me.Controls.Add(Me.buildFilter)
        Me.Controls.Add(Me.aRank)
        Me.Controls.Add(Me.aFilter)
        Me.Name = "SearchFilter"
        Me.Size = New System.Drawing.Size(570, 110)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aFilter As Gestionnaire_d_Archive.AnimeFilter
    Friend WithEvents aRank As Gestionnaire_d_Archive.StarRanking
    Friend WithEvents buildFilter As System.Windows.Forms.Button
    Friend WithEvents aFinish As System.Windows.Forms.CheckBox
    Friend WithEvents aFollow As System.Windows.Forms.CheckBox
    Friend WithEvents aName As System.Windows.Forms.TextBox
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents aOut As System.Windows.Forms.CheckBox

End Class
