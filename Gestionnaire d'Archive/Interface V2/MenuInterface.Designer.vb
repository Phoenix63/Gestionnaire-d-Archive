<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInterface
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
        Me.lb01 = New System.Windows.Forms.Label()
        Me.bt01 = New System.Windows.Forms.Button()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb01
        '
        Me.lb01.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb01.Font = New System.Drawing.Font("Myriad Web Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb01.Location = New System.Drawing.Point(0, 0)
        Me.lb01.Name = "lb01"
        Me.lb01.Size = New System.Drawing.Size(150, 40)
        Me.lb01.TabIndex = 0
        Me.lb01.Text = "Label1"
        Me.lb01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt01
        '
        Me.bt01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bt01.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bt01.FlatAppearance.BorderSize = 0
        Me.bt01.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt01.Location = New System.Drawing.Point(0, 40)
        Me.bt01.Name = "bt01"
        Me.bt01.Size = New System.Drawing.Size(150, 25)
        Me.bt01.TabIndex = 8
        Me.bt01.Text = "Sauvegarder"
        Me.bt01.UseVisualStyleBackColor = False
        '
        'timerAnimation
        '
        Me.timerAnimation.Interval = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt01)
        Me.Controls.Add(Me.lb01)
        Me.Name = "MenuInterface"
        Me.Size = New System.Drawing.Size(150, 400)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb01 As System.Windows.Forms.Label
    Friend WithEvents bt01 As System.Windows.Forms.Button
    Private WithEvents timerAnimation As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
