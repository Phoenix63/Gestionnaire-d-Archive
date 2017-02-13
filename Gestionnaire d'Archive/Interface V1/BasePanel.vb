Public Class BasePanel
    Inherits Panel

    Public Const DEFAULT_HEIGHT As Integer = 101
    Public Const DEFAULT_WIDTH As Integer = 480
    Public Const MY_HEIGHT As Integer = 281
    Public Const MY_WIDTH As Integer = 480
    Public Const ANIME_HEIGHT As Integer = 200
    Public Const ANIME_WIDTH As Integer = 480
    Public Const UNDER_MENU As Integer = 24

    Public _anime As Anime

    Public _title As Label
    Public _subtitle As Label

    Public Sub New(ByRef form As Form)

        MyBase.Width = DEFAULT_WIDTH
        MyBase.Height = DEFAULT_HEIGHT
        MyBase.Location = New Point(0, UNDER_MENU)
        MyBase.BackColor = Color.White

        Me.Parent = form

        '
        ' Title
        '
        Me._title = New Label()
        With _title
            .AutoSize = True
            .Font = New Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Location = New Point(160, 20)
            .Name = "title"
            .Size = New Size(150, 50)
            .TabIndex = 1
            .Text = "Archive"
        End With
        '
        ' Subtitle
        '
        Me._subtitle = New Label()
        With _subtitle
            .AutoSize = True
            .Font = New Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Location = New Point(250, 25)
            .Name = "subtitle"
            .Size = New Size(145, 25)
            .TabIndex = 2
            .Text = ""
        End With

        '
        ' Ajout des forms
        '
        Me.Controls.Add(Me._title)
        Me.Controls.Add(Me._subtitle)

        form.Controls.Add(Me)

    End Sub

End Class
