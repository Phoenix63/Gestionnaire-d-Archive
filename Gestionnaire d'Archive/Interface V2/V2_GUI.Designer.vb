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
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.bt_menu = New System.Windows.Forms.Button()
        Me.bt_reduce = New System.Windows.Forms.Button()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'pContainer
        '
        Me.pContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pContainer.Location = New System.Drawing.Point(0, 25)
        Me.pContainer.Name = "pContainer"
        Me.pContainer.Size = New System.Drawing.Size(600, 375)
        Me.pContainer.TabIndex = 8
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
        Me.bt_menu.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt_menu.FlatAppearance.BorderSize = 0
        Me.bt_menu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_menu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_menu.Location = New System.Drawing.Point(0, 0)
        Me.bt_menu.Name = "bt_menu"
        Me.bt_menu.Size = New System.Drawing.Size(49, 25)
        Me.bt_menu.TabIndex = 11
        Me.bt_menu.Text = "Menu"
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
End Class
