<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveInterface
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
        Me.saveText = New System.Windows.Forms.Label()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'saveText
        '
        Me.saveText.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveText.Location = New System.Drawing.Point(-1, 17)
        Me.saveText.Name = "saveText"
        Me.saveText.Size = New System.Drawing.Size(202, 18)
        Me.saveText.TabIndex = 0
        Me.saveText.Text = "Sauvegarde en cours"
        Me.saveText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerAnimation
        '
        Me.timerAnimation.Interval = 500
        '
        'SaveInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.saveText)
        Me.Name = "SaveInterface"
        Me.Size = New System.Drawing.Size(200, 50)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents saveText As System.Windows.Forms.Label
    Private WithEvents timerAnimation As System.Windows.Forms.Timer

End Class
