<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V2_GUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V2_GUI))
        Me.pContainer = New System.Windows.Forms.Panel()
        Me.pAccueil = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pQuick = New System.Windows.Forms.Panel()
        Me.quickOut = New System.Windows.Forms.Button()
        Me.quickCurrent = New System.Windows.Forms.Button()
        Me.quickEnded = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.blank = New System.Windows.Forms.Label()
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.bt_menu = New System.Windows.Forms.Button()
        Me.bt_reduce = New System.Windows.Forms.Button()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.history = New Gestionnaire_d_Archive.AnimeSlider()
        Me.pContainer.SuspendLayout()
        Me.pAccueil.SuspendLayout()
        Me.pQuick.SuspendLayout()
        Me.pnl_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'pContainer
        '
        Me.pContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pContainer.Controls.Add(Me.pAccueil)
        Me.pContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pContainer.Location = New System.Drawing.Point(0, 25)
        Me.pContainer.Name = "pContainer"
        Me.pContainer.Size = New System.Drawing.Size(600, 375)
        Me.pContainer.TabIndex = 8
        '
        'pAccueil
        '
        Me.pAccueil.Controls.Add(Me.history)
        Me.pAccueil.Controls.Add(Me.Label4)
        Me.pAccueil.Controls.Add(Me.Label2)
        Me.pAccueil.Controls.Add(Me.pQuick)
        Me.pAccueil.Controls.Add(Me.Label3)
        Me.pAccueil.Controls.Add(Me.Label1)
        Me.pAccueil.Controls.Add(Me.blank)
        Me.pAccueil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAccueil.Location = New System.Drawing.Point(0, 0)
        Me.pAccueil.Name = "pAccueil"
        Me.pAccueil.Size = New System.Drawing.Size(600, 375)
        Me.pAccueil.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(600, 35)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Historique"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 10)
        Me.Label2.TabIndex = 40
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pQuick
        '
        Me.pQuick.Controls.Add(Me.quickOut)
        Me.pQuick.Controls.Add(Me.quickCurrent)
        Me.pQuick.Controls.Add(Me.quickEnded)
        Me.pQuick.Dock = System.Windows.Forms.DockStyle.Top
        Me.pQuick.Location = New System.Drawing.Point(0, 55)
        Me.pQuick.Name = "pQuick"
        Me.pQuick.Size = New System.Drawing.Size(600, 40)
        Me.pQuick.TabIndex = 38
        '
        'quickOut
        '
        Me.quickOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.quickOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quickOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.quickOut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.quickOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.quickOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quickOut.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.quickOut.Location = New System.Drawing.Point(10, 0)
        Me.quickOut.Name = "quickOut"
        Me.quickOut.Size = New System.Drawing.Size(190, 40)
        Me.quickOut.TabIndex = 0
        Me.quickOut.TabStop = False
        Me.quickOut.Text = "Séries sorties"
        Me.quickOut.UseVisualStyleBackColor = False
        '
        'quickCurrent
        '
        Me.quickCurrent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.quickCurrent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quickCurrent.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.quickCurrent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.quickCurrent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.quickCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quickCurrent.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.quickCurrent.Location = New System.Drawing.Point(205, 0)
        Me.quickCurrent.Name = "quickCurrent"
        Me.quickCurrent.Size = New System.Drawing.Size(190, 40)
        Me.quickCurrent.TabIndex = 0
        Me.quickCurrent.TabStop = False
        Me.quickCurrent.Text = "Séries en cours"
        Me.quickCurrent.UseVisualStyleBackColor = False
        '
        'quickEnded
        '
        Me.quickEnded.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.quickEnded.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quickEnded.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.quickEnded.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.quickEnded.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.quickEnded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quickEnded.Font = New System.Drawing.Font("Palatino Linotype", 11.0!)
        Me.quickEnded.Location = New System.Drawing.Point(400, 0)
        Me.quickEnded.Name = "quickEnded"
        Me.quickEnded.Size = New System.Drawing.Size(190, 40)
        Me.quickEnded.TabIndex = 0
        Me.quickEnded.TabStop = False
        Me.quickEnded.Text = "Séries finis"
        Me.quickEnded.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(600, 10)
        Me.Label3.TabIndex = 35
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 35)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Accès rapide"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'blank
        '
        Me.blank.BackColor = System.Drawing.Color.Transparent
        Me.blank.Dock = System.Windows.Forms.DockStyle.Top
        Me.blank.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blank.Location = New System.Drawing.Point(0, 0)
        Me.blank.Name = "blank"
        Me.blank.Size = New System.Drawing.Size(600, 10)
        Me.blank.TabIndex = 32
        Me.blank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_header
        '
        Me.pnl_header.Controls.Add(Me.bt_menu)
        Me.pnl_header.Controls.Add(Me.bt_reduce)
        Me.pnl_header.Controls.Add(Me.bt_close)
        Me.pnl_header.Controls.Add(Me.title)
        Me.pnl_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_header.Location = New System.Drawing.Point(0, 0)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(600, 25)
        Me.pnl_header.TabIndex = 10
        '
        'bt_menu
        '
        Me.bt_menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_menu.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_menu.FlatAppearance.BorderSize = 0
        Me.bt_menu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_menu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_menu.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_menu
        Me.bt_menu.Location = New System.Drawing.Point(0, 0)
        Me.bt_menu.Name = "bt_menu"
        Me.bt_menu.Size = New System.Drawing.Size(49, 25)
        Me.bt_menu.TabIndex = 11
        Me.bt_menu.UseVisualStyleBackColor = False
        '
        'bt_reduce
        '
        Me.bt_reduce.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt_reduce.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_reduce.FlatAppearance.BorderSize = 0
        Me.bt_reduce.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_reduce.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_reduce.Location = New System.Drawing.Point(550, 0)
        Me.bt_reduce.Name = "bt_reduce"
        Me.bt_reduce.Size = New System.Drawing.Size(25, 25)
        Me.bt_reduce.TabIndex = 10
        Me.bt_reduce.Text = "_"
        Me.bt_reduce.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_reduce.UseVisualStyleBackColor = False
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_close.FlatAppearance.BorderSize = 0
        Me.bt_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Location = New System.Drawing.Point(575, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(25, 25)
        Me.bt_close.TabIndex = 9
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'title
        '
        Me.title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.title.Dock = System.Windows.Forms.DockStyle.Top
        Me.title.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(600, 25)
        Me.title.TabIndex = 8
        Me.title.Text = "Titre de l'application"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoSave
        '
        Me.AutoSave.Interval = 60000
        '
        'history
        '
        Me.history.Location = New System.Drawing.Point(15, 140)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(570, 220)
        Me.history.TabIndex = 42
        '
        'V2_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_header)
        Me.Controls.Add(Me.pContainer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "V2_GUI"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionnaire d'Archive"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.pContainer.ResumeLayout(False)
        Me.pAccueil.ResumeLayout(False)
        Me.pQuick.ResumeLayout(False)
        Me.pnl_header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pContainer As System.Windows.Forms.Panel
    Friend WithEvents pnl_header As System.Windows.Forms.Panel
    Friend WithEvents bt_menu As System.Windows.Forms.Button
    Friend WithEvents bt_reduce As System.Windows.Forms.Button
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents AutoSave As System.Windows.Forms.Timer
    Friend WithEvents pAccueil As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pQuick As System.Windows.Forms.Panel
    Friend WithEvents quickOut As System.Windows.Forms.Button
    Friend WithEvents quickCurrent As System.Windows.Forms.Button
    Friend WithEvents quickEnded As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents blank As System.Windows.Forms.Label
    Friend WithEvents history As Gestionnaire_d_Archive.AnimeSlider
End Class
