<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimeSlider
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
        Me.slider = New System.Windows.Forms.Panel()
        Me.noResponse = New System.Windows.Forms.Label()
        Me.loading = New System.Windows.Forms.PictureBox()
        Me.sliderLeft = New System.Windows.Forms.Button()
        Me.sliderRight = New System.Windows.Forms.Button()
        Me.worker = New System.ComponentModel.BackgroundWorker()
        Me.slider.SuspendLayout()
        CType(Me.loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slider
        '
        Me.slider.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.slider.Controls.Add(Me.noResponse)
        Me.slider.Controls.Add(Me.loading)
        Me.slider.Controls.Add(Me.sliderLeft)
        Me.slider.Controls.Add(Me.sliderRight)
        Me.slider.Location = New System.Drawing.Point(0, 0)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(570, 220)
        Me.slider.TabIndex = 25
        '
        'noResponse
        '
        Me.noResponse.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.noResponse.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noResponse.Location = New System.Drawing.Point(72, 88)
        Me.noResponse.Name = "noResponse"
        Me.noResponse.Size = New System.Drawing.Size(434, 39)
        Me.noResponse.TabIndex = 25
        Me.noResponse.Text = "Aucun résultat pour votre recherche"
        Me.noResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.noResponse.Visible = False
        '
        'loading
        '
        Me.loading.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.pic_loading
        Me.loading.Location = New System.Drawing.Point(187, 10)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(200, 200)
        Me.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loading.TabIndex = 26
        Me.loading.TabStop = False
        Me.loading.Visible = False
        '
        'sliderLeft
        '
        Me.sliderLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sliderLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sliderLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sliderLeft.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sliderLeft.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sliderLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sliderLeft.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sliderLeft.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_arrowleft
        Me.sliderLeft.Location = New System.Drawing.Point(5, 75)
        Me.sliderLeft.Name = "sliderLeft"
        Me.sliderLeft.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.sliderLeft.Size = New System.Drawing.Size(20, 70)
        Me.sliderLeft.TabIndex = 24
        Me.sliderLeft.UseVisualStyleBackColor = False
        Me.sliderLeft.Visible = False
        '
        'sliderRight
        '
        Me.sliderRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sliderRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sliderRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sliderRight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sliderRight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sliderRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sliderRight.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sliderRight.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_arrowright
        Me.sliderRight.Location = New System.Drawing.Point(545, 75)
        Me.sliderRight.Name = "sliderRight"
        Me.sliderRight.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.sliderRight.Size = New System.Drawing.Size(20, 70)
        Me.sliderRight.TabIndex = 23
        Me.sliderRight.UseVisualStyleBackColor = False
        Me.sliderRight.Visible = False
        '
        'worker
        '
        Me.worker.WorkerReportsProgress = True
        Me.worker.WorkerSupportsCancellation = True
        '
        'AnimeSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.slider)
        Me.Name = "AnimeSlider"
        Me.Size = New System.Drawing.Size(648, 317)
        Me.slider.ResumeLayout(False)
        CType(Me.loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sliderRight As System.Windows.Forms.Button
    Friend WithEvents sliderLeft As System.Windows.Forms.Button
    Friend WithEvents slider As System.Windows.Forms.Panel
    Friend WithEvents noResponse As System.Windows.Forms.Label
    Friend WithEvents worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents loading As System.Windows.Forms.PictureBox

End Class
