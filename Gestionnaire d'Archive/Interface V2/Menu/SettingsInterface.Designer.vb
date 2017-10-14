<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsInterface
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsInterface))
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.sTitle = New System.Windows.Forms.Label()
        Me.sPanelSetting = New System.Windows.Forms.Panel()
        Me.pDB = New System.Windows.Forms.Panel()
        Me.sDatabaseChange = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pNav = New System.Windows.Forms.Panel()
        Me.sUpdateBrowser = New System.Windows.Forms.Button()
        Me.sOtherBrowser = New System.Windows.Forms.Button()
        Me.sDefaultBrowser = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pSave = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.sAutoSave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sPanelSum = New System.Windows.Forms.Panel()
        Me.sSerieSum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.sEpSum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.genreChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.sReturn = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.sPanelSetting.SuspendLayout()
        Me.pDB.SuspendLayout()
        Me.pNav.SuspendLayout()
        Me.pSave.SuspendLayout()
        Me.sPanelSum.SuspendLayout()
        CType(Me.genreChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Dock = System.Windows.Forms.DockStyle.Top
        Label2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(15, 50)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(570, 10)
        Label2.TabIndex = 41
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Dock = System.Windows.Forms.DockStyle.Top
        Label7.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(15, 190)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(570, 10)
        Label7.TabIndex = 60
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Dock = System.Windows.Forms.DockStyle.Top
        Label5.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(15, 145)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(570, 10)
        Label5.TabIndex = 58
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Dock = System.Windows.Forms.DockStyle.Left
        Label9.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(140, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(10, 85)
        Label9.TabIndex = 42
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Label16.BackColor = System.Drawing.Color.Transparent
        Label16.Dock = System.Windows.Forms.DockStyle.Left
        Label16.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(420, 0)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(10, 85)
        Label16.TabIndex = 44
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Dock = System.Windows.Forms.DockStyle.Top
        Label3.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(15, 235)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(570, 10)
        Label3.TabIndex = 63
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sTitle
        '
        Me.sTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.sTitle.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Bold)
        Me.sTitle.Location = New System.Drawing.Point(15, 15)
        Me.sTitle.Name = "sTitle"
        Me.sTitle.Size = New System.Drawing.Size(570, 35)
        Me.sTitle.TabIndex = 34
        Me.sTitle.Text = "Paramètres"
        Me.sTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sPanelSetting
        '
        Me.sPanelSetting.BackColor = System.Drawing.Color.Transparent
        Me.sPanelSetting.Controls.Add(Me.pDB)
        Me.sPanelSetting.Controls.Add(Label16)
        Me.sPanelSetting.Controls.Add(Me.pNav)
        Me.sPanelSetting.Controls.Add(Label9)
        Me.sPanelSetting.Controls.Add(Me.pSave)
        Me.sPanelSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPanelSetting.Location = New System.Drawing.Point(15, 60)
        Me.sPanelSetting.Name = "sPanelSetting"
        Me.sPanelSetting.Size = New System.Drawing.Size(570, 85)
        Me.sPanelSetting.TabIndex = 42
        '
        'pDB
        '
        Me.pDB.Controls.Add(Me.sDatabaseChange)
        Me.pDB.Controls.Add(Me.Label18)
        Me.pDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.pDB.Location = New System.Drawing.Point(430, 0)
        Me.pDB.Name = "pDB"
        Me.pDB.Size = New System.Drawing.Size(140, 85)
        Me.pDB.TabIndex = 45
        '
        'sDatabaseChange
        '
        Me.sDatabaseChange.BackColor = System.Drawing.SystemColors.Control
        Me.sDatabaseChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDatabaseChange.Enabled = False
        Me.sDatabaseChange.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sDatabaseChange.FlatAppearance.BorderSize = 0
        Me.sDatabaseChange.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sDatabaseChange.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sDatabaseChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sDatabaseChange.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sDatabaseChange.Location = New System.Drawing.Point(0, 50)
        Me.sDatabaseChange.Name = "sDatabaseChange"
        Me.sDatabaseChange.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.sDatabaseChange.Size = New System.Drawing.Size(140, 35)
        Me.sDatabaseChange.TabIndex = 54
        Me.sDatabaseChange.Text = "Changer"
        Me.sDatabaseChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sDatabaseChange.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 50)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Changer la base de données"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pNav
        '
        Me.pNav.Controls.Add(Me.sUpdateBrowser)
        Me.pNav.Controls.Add(Me.sOtherBrowser)
        Me.pNav.Controls.Add(Me.sDefaultBrowser)
        Me.pNav.Controls.Add(Me.Label11)
        Me.pNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pNav.Location = New System.Drawing.Point(150, 0)
        Me.pNav.Name = "pNav"
        Me.pNav.Size = New System.Drawing.Size(270, 85)
        Me.pNav.TabIndex = 43
        '
        'sUpdateBrowser
        '
        Me.sUpdateBrowser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sUpdateBrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sUpdateBrowser.Dock = System.Windows.Forms.DockStyle.Left
        Me.sUpdateBrowser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sUpdateBrowser.FlatAppearance.BorderSize = 0
        Me.sUpdateBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sUpdateBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sUpdateBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sUpdateBrowser.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sUpdateBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sUpdateBrowser.Location = New System.Drawing.Point(180, 50)
        Me.sUpdateBrowser.Name = "sUpdateBrowser"
        Me.sUpdateBrowser.Size = New System.Drawing.Size(90, 35)
        Me.sUpdateBrowser.TabIndex = 57
        Me.sUpdateBrowser.Text = "Changer"
        Me.sUpdateBrowser.UseVisualStyleBackColor = False
        '
        'sOtherBrowser
        '
        Me.sOtherBrowser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sOtherBrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sOtherBrowser.Dock = System.Windows.Forms.DockStyle.Left
        Me.sOtherBrowser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sOtherBrowser.FlatAppearance.BorderSize = 0
        Me.sOtherBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sOtherBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sOtherBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sOtherBrowser.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sOtherBrowser.Image = Global.Gestionnaire_d_Archive.My.Resources.Resources.ic_unchecked
        Me.sOtherBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sOtherBrowser.Location = New System.Drawing.Point(90, 50)
        Me.sOtherBrowser.Name = "sOtherBrowser"
        Me.sOtherBrowser.Size = New System.Drawing.Size(90, 35)
        Me.sOtherBrowser.TabIndex = 56
        Me.sOtherBrowser.Text = "Autre  "
        Me.sOtherBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sOtherBrowser.UseVisualStyleBackColor = False
        '
        'sDefaultBrowser
        '
        Me.sDefaultBrowser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sDefaultBrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDefaultBrowser.Dock = System.Windows.Forms.DockStyle.Left
        Me.sDefaultBrowser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sDefaultBrowser.FlatAppearance.BorderSize = 0
        Me.sDefaultBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sDefaultBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sDefaultBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sDefaultBrowser.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sDefaultBrowser.Image = CType(resources.GetObject("sDefaultBrowser.Image"), System.Drawing.Image)
        Me.sDefaultBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sDefaultBrowser.Location = New System.Drawing.Point(0, 50)
        Me.sDefaultBrowser.Name = "sDefaultBrowser"
        Me.sDefaultBrowser.Size = New System.Drawing.Size(90, 35)
        Me.sDefaultBrowser.TabIndex = 55
        Me.sDefaultBrowser.Text = "Défaut"
        Me.sDefaultBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sDefaultBrowser.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(270, 50)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Navigateur internet"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pSave
        '
        Me.pSave.Controls.Add(Me.Label15)
        Me.pSave.Controls.Add(Me.sAutoSave)
        Me.pSave.Controls.Add(Me.Label1)
        Me.pSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSave.Location = New System.Drawing.Point(0, 0)
        Me.pSave.Name = "pSave"
        Me.pSave.Size = New System.Drawing.Size(140, 85)
        Me.pSave.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(58, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 35)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "minutes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sAutoSave
        '
        Me.sAutoSave.BackColor = System.Drawing.SystemColors.Window
        Me.sAutoSave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sAutoSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.sAutoSave.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.sAutoSave.Location = New System.Drawing.Point(0, 50)
        Me.sAutoSave.Name = "sAutoSave"
        Me.sAutoSave.ReadOnly = True
        Me.sAutoSave.Size = New System.Drawing.Size(58, 35)
        Me.sAutoSave.TabIndex = 37
        Me.sAutoSave.Text = "60"
        Me.sAutoSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 50)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Sauvegarde automatique"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sPanelSum
        '
        Me.sPanelSum.BackColor = System.Drawing.SystemColors.Menu
        Me.sPanelSum.Controls.Add(Me.sSerieSum)
        Me.sPanelSum.Controls.Add(Me.Label12)
        Me.sPanelSum.Controls.Add(Me.sEpSum)
        Me.sPanelSum.Controls.Add(Me.Label8)
        Me.sPanelSum.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPanelSum.Location = New System.Drawing.Point(15, 200)
        Me.sPanelSum.Name = "sPanelSum"
        Me.sPanelSum.Size = New System.Drawing.Size(570, 35)
        Me.sPanelSum.TabIndex = 61
        '
        'sSerieSum
        '
        Me.sSerieSum.BackColor = System.Drawing.SystemColors.Window
        Me.sSerieSum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sSerieSum.Dock = System.Windows.Forms.DockStyle.Left
        Me.sSerieSum.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.sSerieSum.Location = New System.Drawing.Point(435, 0)
        Me.sSerieSum.Name = "sSerieSum"
        Me.sSerieSum.ReadOnly = True
        Me.sSerieSum.Size = New System.Drawing.Size(135, 35)
        Me.sSerieSum.TabIndex = 39
        Me.sSerieSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(285, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(150, 35)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Nombre de série"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sEpSum
        '
        Me.sEpSum.BackColor = System.Drawing.SystemColors.Window
        Me.sEpSum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sEpSum.Dock = System.Windows.Forms.DockStyle.Left
        Me.sEpSum.Font = New System.Drawing.Font("Palatino Linotype", 19.0!, System.Drawing.FontStyle.Bold)
        Me.sEpSum.Location = New System.Drawing.Point(150, 0)
        Me.sEpSum.Name = "sEpSum"
        Me.sEpSum.ReadOnly = True
        Me.sEpSum.Size = New System.Drawing.Size(135, 35)
        Me.sEpSum.TabIndex = 37
        Me.sEpSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(150, 35)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Nombre d'épisode"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(15, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(570, 35)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Statistiques"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'genreChart
        '
        ChartArea4.Name = "ChartArea1"
        Me.genreChart.ChartAreas.Add(ChartArea4)
        Me.genreChart.Dock = System.Windows.Forms.DockStyle.Top
        Me.genreChart.Location = New System.Drawing.Point(15, 245)
        Me.genreChart.Name = "genreChart"
        Me.genreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.genreChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.SystemColors.ActiveCaption}
        Series4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX
        Series4.ChartArea = "ChartArea1"
        Series4.Font = New System.Drawing.Font("Palatino Linotype", 6.0!)
        Series4.IsVisibleInLegend = False
        Series4.IsXValueIndexed = True
        Series4.Name = "GenderSeries"
        Series4.SmartLabelStyle.MaxMovingDistance = 5.0R
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32
        Series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32
        Me.genreChart.Series.Add(Series4)
        Me.genreChart.Size = New System.Drawing.Size(570, 115)
        Me.genreChart.TabIndex = 64
        Me.genreChart.TabStop = False
        '
        'sReturn
        '
        Me.sReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sReturn.FlatAppearance.BorderSize = 0
        Me.sReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sReturn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.sReturn.Image = CType(resources.GetObject("sReturn.Image"), System.Drawing.Image)
        Me.sReturn.Location = New System.Drawing.Point(3, 3)
        Me.sReturn.Name = "sReturn"
        Me.sReturn.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.sReturn.Size = New System.Drawing.Size(25, 25)
        Me.sReturn.TabIndex = 55
        Me.sReturn.UseVisualStyleBackColor = False
        '
        'SettingsInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.genreChart)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.sPanelSum)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.sReturn)
        Me.Controls.Add(Me.sPanelSetting)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.sTitle)
        Me.Name = "SettingsInterface"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Size = New System.Drawing.Size(600, 375)
        Me.sPanelSetting.ResumeLayout(False)
        Me.pDB.ResumeLayout(False)
        Me.pNav.ResumeLayout(False)
        Me.pSave.ResumeLayout(False)
        Me.pSave.PerformLayout()
        Me.sPanelSum.ResumeLayout(False)
        Me.sPanelSum.PerformLayout()
        CType(Me.genreChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sTitle As System.Windows.Forms.Label
    Friend WithEvents sPanelSetting As System.Windows.Forms.Panel
    Friend WithEvents sReturn As System.Windows.Forms.Button
    Friend WithEvents sPanelSum As System.Windows.Forms.Panel
    Friend WithEvents sSerieSum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents sEpSum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pSave As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pDB As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pNav As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sAutoSave As System.Windows.Forms.TextBox
    Friend WithEvents sDatabaseChange As System.Windows.Forms.Button
    Friend WithEvents sUpdateBrowser As System.Windows.Forms.Button
    Friend WithEvents sOtherBrowser As System.Windows.Forms.Button
    Friend WithEvents sDefaultBrowser As System.Windows.Forms.Button
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents genreChart As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
