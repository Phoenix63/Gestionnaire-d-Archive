<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationBox
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.bTitle = New System.Windows.Forms.Label()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bIcon = New System.Windows.Forms.PictureBox()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bContainer = New System.Windows.Forms.Panel()
        Me.bVersion = New System.Windows.Forms.Label()
        Me.bComment = New System.Windows.Forms.Label()
        CType(Me.bIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'bTitle
        '
        Me.bTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.bTitle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bTitle.Location = New System.Drawing.Point(0, 0)
        Me.bTitle.Name = "bTitle"
        Me.bTitle.Size = New System.Drawing.Size(350, 25)
        Me.bTitle.TabIndex = 9
        Me.bTitle.Text = "Titre de la fenêtre"
        Me.bTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_close.FlatAppearance.BorderSize = 0
        Me.bt_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_close.Location = New System.Drawing.Point(325, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(25, 25)
        Me.bt_close.TabIndex = 11
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bIcon
        '
        Me.bIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bIcon.Location = New System.Drawing.Point(0, 0)
        Me.bIcon.Name = "bIcon"
        Me.bIcon.Size = New System.Drawing.Size(25, 25)
        Me.bIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bIcon.TabIndex = 5
        Me.bIcon.TabStop = False
        '
        'bOK
        '
        Me.bOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bOK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOK.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOK.Location = New System.Drawing.Point(0, 165)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(350, 35)
        Me.bOK.TabIndex = 13
        Me.bOK.Text = "Confirmer"
        Me.bOK.UseVisualStyleBackColor = False
        '
        'bContainer
        '
        Me.bContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bContainer.Controls.Add(Me.bComment)
        Me.bContainer.Controls.Add(Me.bVersion)
        Me.bContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bContainer.Location = New System.Drawing.Point(0, 25)
        Me.bContainer.Name = "bContainer"
        Me.bContainer.Size = New System.Drawing.Size(350, 140)
        Me.bContainer.TabIndex = 14
        '
        'bVersion
        '
        Me.bVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bVersion.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.bVersion.Location = New System.Drawing.Point(0, 115)
        Me.bVersion.Name = "bVersion"
        Me.bVersion.Size = New System.Drawing.Size(350, 25)
        Me.bVersion.TabIndex = 0
        Me.bVersion.Text = "Version: "
        Me.bVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bComment
        '
        Me.bComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bComment.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.bComment.Location = New System.Drawing.Point(0, 0)
        Me.bComment.Name = "bComment"
        Me.bComment.Size = New System.Drawing.Size(350, 115)
        Me.bComment.TabIndex = 1
        Me.bComment.Text = "Comment:"
        Me.bComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InformationBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 200)
        Me.Controls.Add(Me.bContainer)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bIcon)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bTitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InformationBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InformationBox"
        Me.TopMost = True
        CType(Me.bIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bTitle As System.Windows.Forms.Label
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents bIcon As System.Windows.Forms.PictureBox
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bContainer As System.Windows.Forms.Panel
    Friend WithEvents bComment As System.Windows.Forms.Label
    Friend WithEvents bVersion As System.Windows.Forms.Label

End Class
