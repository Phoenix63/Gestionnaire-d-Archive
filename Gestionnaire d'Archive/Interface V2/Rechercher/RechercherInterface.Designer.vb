﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RechercherInterface))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rReturn = New System.Windows.Forms.Button()
        Me.slider = New Gestionnaire_d_Archive.AnimeSlider()
        Me.searchFilter = New Gestionnaire_d_Archive.SearchFilter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'rReturn
        '
        Me.rReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.rReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.rReturn.FlatAppearance.BorderSize = 0
        Me.rReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.rReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.rReturn.Image = CType(resources.GetObject("rReturn.Image"), System.Drawing.Image)
        Me.rReturn.Location = New System.Drawing.Point(3, 3)
        Me.rReturn.Name = "rReturn"
        Me.rReturn.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.rReturn.Size = New System.Drawing.Size(25, 25)
        Me.rReturn.TabIndex = 41
        Me.rReturn.UseVisualStyleBackColor = False
        '
        'slider
        '
        Me.slider.Location = New System.Drawing.Point(15, 140)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(570, 220)
        Me.slider.TabIndex = 22
        '
        'searchFilter
        '
        Me.searchFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.searchFilter.Location = New System.Drawing.Point(15, 15)
        Me.searchFilter.Name = "searchFilter"
        Me.searchFilter.Size = New System.Drawing.Size(570, 110)
        Me.searchFilter.TabIndex = 25
        '
        'RechercherInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.rReturn)
        Me.Controls.Add(Me.slider)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.searchFilter)
        Me.Name = "RechercherInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents slider As Gestionnaire_d_Archive.AnimeSlider
    Friend WithEvents searchFilter As Gestionnaire_d_Archive.SearchFilter
    Friend WithEvents rReturn As System.Windows.Forms.Button

End Class
