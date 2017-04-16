<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialBox
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
        Me.bOK = New System.Windows.Forms.Button()
        Me.bHeader = New System.Windows.Forms.Panel()
        Me.bIcon = New System.Windows.Forms.PictureBox()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bTitle = New System.Windows.Forms.Label()
        Me.bContainer = New System.Windows.Forms.Panel()
        Me.bText = New System.Windows.Forms.Label()
        Me.bPicture = New System.Windows.Forms.PictureBox()
        Me.bNo = New System.Windows.Forms.Button()
        Me.bYes = New System.Windows.Forms.Button()
        Me.bHeader.SuspendLayout()
        CType(Me.bIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bContainer.SuspendLayout()
        CType(Me.bPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.bOK.Visible = False
        '
        'bHeader
        '
        Me.bHeader.Controls.Add(Me.bTitle)
        Me.bHeader.Controls.Add(Me.bt_close)
        Me.bHeader.Controls.Add(Me.bIcon)
        Me.bHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.bHeader.Location = New System.Drawing.Point(0, 0)
        Me.bHeader.Name = "bHeader"
        Me.bHeader.Size = New System.Drawing.Size(350, 25)
        Me.bHeader.TabIndex = 4
        '
        'bIcon
        '
        Me.bIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.bIcon.Location = New System.Drawing.Point(0, 0)
        Me.bIcon.Name = "bIcon"
        Me.bIcon.Size = New System.Drawing.Size(25, 25)
        Me.bIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bIcon.TabIndex = 6
        Me.bIcon.TabStop = False
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.bt_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_close.FlatAppearance.BorderSize = 0
        Me.bt_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_close.Location = New System.Drawing.Point(325, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(25, 25)
        Me.bt_close.TabIndex = 12
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bTitle
        '
        Me.bTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bTitle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bTitle.Location = New System.Drawing.Point(25, 0)
        Me.bTitle.Name = "bTitle"
        Me.bTitle.Size = New System.Drawing.Size(300, 25)
        Me.bTitle.TabIndex = 13
        Me.bTitle.Text = "Titre de la fenêtre"
        Me.bTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bContainer
        '
        Me.bContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bContainer.Controls.Add(Me.bText)
        Me.bContainer.Controls.Add(Me.bPicture)
        Me.bContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.bContainer.Location = New System.Drawing.Point(0, 25)
        Me.bContainer.Name = "bContainer"
        Me.bContainer.Size = New System.Drawing.Size(350, 140)
        Me.bContainer.TabIndex = 16
        '
        'bText
        '
        Me.bText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.bText.Location = New System.Drawing.Point(100, 0)
        Me.bText.Name = "bText"
        Me.bText.Size = New System.Drawing.Size(250, 140)
        Me.bText.TabIndex = 3
        Me.bText.Text = "Comment:"
        Me.bText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bPicture
        '
        Me.bPicture.Dock = System.Windows.Forms.DockStyle.Left
        Me.bPicture.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.pic_information
        Me.bPicture.Location = New System.Drawing.Point(0, 0)
        Me.bPicture.Name = "bPicture"
        Me.bPicture.Size = New System.Drawing.Size(100, 140)
        Me.bPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.bPicture.TabIndex = 2
        Me.bPicture.TabStop = False
        Me.bPicture.Visible = False
        '
        'bNo
        '
        Me.bNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNo.Dock = System.Windows.Forms.DockStyle.Left
        Me.bNo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bNo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bNo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNo.Location = New System.Drawing.Point(0, 165)
        Me.bNo.Name = "bNo"
        Me.bNo.Size = New System.Drawing.Size(175, 0)
        Me.bNo.TabIndex = 18
        Me.bNo.Text = "Non"
        Me.bNo.UseVisualStyleBackColor = False
        '
        'bYes
        '
        Me.bYes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bYes.Dock = System.Windows.Forms.DockStyle.Right
        Me.bYes.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bYes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bYes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bYes.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bYes.Location = New System.Drawing.Point(175, 165)
        Me.bYes.Name = "bYes"
        Me.bYes.Size = New System.Drawing.Size(175, 0)
        Me.bYes.TabIndex = 17
        Me.bYes.Text = "Oui"
        Me.bYes.UseVisualStyleBackColor = False
        Me.bYes.Visible = False
        '
        'DialBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 200)
        Me.Controls.Add(Me.bNo)
        Me.Controls.Add(Me.bYes)
        Me.Controls.Add(Me.bContainer)
        Me.Controls.Add(Me.bHeader)
        Me.Controls.Add(Me.bOK)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InformationBox"
        Me.TopMost = True
        Me.bHeader.ResumeLayout(False)
        CType(Me.bIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bContainer.ResumeLayout(False)
        CType(Me.bPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bHeader As System.Windows.Forms.Panel
    Friend WithEvents bTitle As System.Windows.Forms.Label
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents bIcon As System.Windows.Forms.PictureBox
    Friend WithEvents bContainer As System.Windows.Forms.Panel
    Friend WithEvents bText As System.Windows.Forms.Label
    Friend WithEvents bPicture As System.Windows.Forms.PictureBox
    Friend WithEvents bNo As System.Windows.Forms.Button
    Friend WithEvents bYes As System.Windows.Forms.Button

End Class
