<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimeFilter
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
        Me.fContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'fContainer
        '
        Me.fContainer.AutoScroll = True
        Me.fContainer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.fContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fContainer.Location = New System.Drawing.Point(0, 0)
        Me.fContainer.MinimumSize = New System.Drawing.Size(200, 25)
        Me.fContainer.Name = "fContainer"
        Me.fContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.fContainer.Size = New System.Drawing.Size(237, 35)
        Me.fContainer.TabIndex = 1
        '
        'AnimeFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.fContainer)
        Me.Enabled = False
        Me.MinimumSize = New System.Drawing.Size(200, 25)
        Me.Name = "AnimeFilter"
        Me.Size = New System.Drawing.Size(237, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fContainer As System.Windows.Forms.FlowLayoutPanel

End Class
