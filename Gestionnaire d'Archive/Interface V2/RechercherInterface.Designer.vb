<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rTitle = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rLoad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'rTitle
        '
        Me.rTitle.BackColor = System.Drawing.SystemColors.Control
        Me.rTitle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold)
        Me.rTitle.Location = New System.Drawing.Point(15, 15)
        Me.rTitle.Name = "rTitle"
        Me.rTitle.Size = New System.Drawing.Size(570, 35)
        Me.rTitle.TabIndex = 2
        Me.rTitle.Text = "Rechercher Panel Title"
        Me.rTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'rLoad
        '
        Me.rLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.rLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.rLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.rLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rLoad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.rLoad.Location = New System.Drawing.Point(221, 205)
        Me.rLoad.Name = "rLoad"
        Me.rLoad.Size = New System.Drawing.Size(142, 25)
        Me.rLoad.TabIndex = 7
        Me.rLoad.Text = "<"
        Me.rLoad.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(221, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RechercherInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rLoad)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.rTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "RechercherInterface"
        Me.Size = New System.Drawing.Size(600, 375)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents rLoad As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
