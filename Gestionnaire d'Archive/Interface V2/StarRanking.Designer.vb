<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StarRanking
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
        Me.s1 = New System.Windows.Forms.PictureBox()
        Me.s2 = New System.Windows.Forms.PictureBox()
        Me.s3 = New System.Windows.Forms.PictureBox()
        Me.s4 = New System.Windows.Forms.PictureBox()
        Me.s5 = New System.Windows.Forms.PictureBox()
        CType(Me.s1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        's1
        '
        Me.s1.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.activestar
        Me.s1.Location = New System.Drawing.Point(0, 0)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(35, 35)
        Me.s1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s1.TabIndex = 0
        Me.s1.TabStop = False
        '
        's2
        '
        Me.s2.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
        Me.s2.Location = New System.Drawing.Point(35, 0)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(35, 35)
        Me.s2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s2.TabIndex = 1
        Me.s2.TabStop = False
        '
        's3
        '
        Me.s3.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
        Me.s3.Location = New System.Drawing.Point(70, 0)
        Me.s3.Name = "s3"
        Me.s3.Size = New System.Drawing.Size(35, 35)
        Me.s3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s3.TabIndex = 2
        Me.s3.TabStop = False
        '
        's4
        '
        Me.s4.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
        Me.s4.Location = New System.Drawing.Point(105, 0)
        Me.s4.Name = "s4"
        Me.s4.Size = New System.Drawing.Size(35, 35)
        Me.s4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s4.TabIndex = 3
        Me.s4.TabStop = False
        '
        's5
        '
        Me.s5.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.inactivestar
        Me.s5.Location = New System.Drawing.Point(140, 0)
        Me.s5.Name = "s5"
        Me.s5.Size = New System.Drawing.Size(35, 35)
        Me.s5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s5.TabIndex = 4
        Me.s5.TabStop = False
        '
        'StarRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.s5)
        Me.Controls.Add(Me.s4)
        Me.Controls.Add(Me.s3)
        Me.Controls.Add(Me.s2)
        Me.Controls.Add(Me.s1)
        Me.Name = "StarRanking"
        Me.Size = New System.Drawing.Size(175, 35)
        CType(Me.s1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents s1 As System.Windows.Forms.PictureBox
    Friend WithEvents s2 As System.Windows.Forms.PictureBox
    Friend WithEvents s3 As System.Windows.Forms.PictureBox
    Friend WithEvents s4 As System.Windows.Forms.PictureBox
    Friend WithEvents s5 As System.Windows.Forms.PictureBox

End Class
