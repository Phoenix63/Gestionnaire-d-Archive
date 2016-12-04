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
        Me.sliderRight = New System.Windows.Forms.Button()
        Me.sliderLeft = New System.Windows.Forms.Button()
        Me.slider = New System.Windows.Forms.Panel()
        Me.slider.SuspendLayout()
        Me.SuspendLayout()
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
        Me.sliderRight.Location = New System.Drawing.Point(545, 75)
        Me.sliderRight.Name = "sliderRight"
        Me.sliderRight.Size = New System.Drawing.Size(20, 70)
        Me.sliderRight.TabIndex = 23
        Me.sliderRight.Text = ">"
        Me.sliderRight.UseVisualStyleBackColor = False
        Me.sliderRight.Visible = False
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
        Me.sliderLeft.Location = New System.Drawing.Point(5, 75)
        Me.sliderLeft.Name = "sliderLeft"
        Me.sliderLeft.Size = New System.Drawing.Size(20, 70)
        Me.sliderLeft.TabIndex = 24
        Me.sliderLeft.Text = "<"
        Me.sliderLeft.UseVisualStyleBackColor = False
        Me.sliderLeft.Visible = False
        '
        'slider
        '
        Me.slider.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.slider.Controls.Add(Me.sliderLeft)
        Me.slider.Controls.Add(Me.sliderRight)
        Me.slider.Location = New System.Drawing.Point(0, 0)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(570, 220)
        Me.slider.TabIndex = 25
        '
        'AnimeSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.slider)
        Me.Name = "AnimeSlider"
        Me.Size = New System.Drawing.Size(648, 616)
        Me.slider.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sliderRight As System.Windows.Forms.Button
    Friend WithEvents sliderLeft As System.Windows.Forms.Button
    Friend WithEvents slider As System.Windows.Forms.Panel

End Class
