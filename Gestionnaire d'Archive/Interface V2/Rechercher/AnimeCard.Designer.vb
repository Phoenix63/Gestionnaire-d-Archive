<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimeCard
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
        Me.cardName = New System.Windows.Forms.Label()
        Me.cardFont = New System.Windows.Forms.PictureBox()
        CType(Me.cardFont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardName
        '
        Me.cardName.AutoEllipsis = True
        Me.cardName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cardName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardName.Location = New System.Drawing.Point(0, 165)
        Me.cardName.Name = "cardName"
        Me.cardName.Size = New System.Drawing.Size(120, 23)
        Me.cardName.TabIndex = 15
        Me.cardName.Text = "Anime name"
        Me.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cardFont
        '
        Me.cardFont.BackColor = System.Drawing.Color.Gainsboro
        Me.cardFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cardFont.Location = New System.Drawing.Point(0, 0)
        Me.cardFont.Name = "cardFont"
        Me.cardFont.Size = New System.Drawing.Size(120, 200)
        Me.cardFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardFont.TabIndex = 11
        Me.cardFont.TabStop = False
        '
        'AnimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Controls.Add(Me.cardName)
        Me.Controls.Add(Me.cardFont)
        Me.Name = "AnimeCard"
        Me.Size = New System.Drawing.Size(330, 348)
        CType(Me.cardFont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cardFont As System.Windows.Forms.PictureBox
    Friend WithEvents cardName As System.Windows.Forms.Label

End Class
