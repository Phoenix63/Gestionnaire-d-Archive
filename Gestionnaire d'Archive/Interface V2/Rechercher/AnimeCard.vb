Imports System.IO

Public Class AnimeCard
    Inherits UserControl

    Private _anime As Anime = Nothing

    ' Outer Event
    Public Event loadAnimeEvent(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Width = cardFont.Width
        Me.Height = cardFont.Height

    End Sub
    Public Sub New(anime As Anime)

        Me.New()
        _anime = anime

    End Sub
    Private Sub AnimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pictPath As String
        Dim pictFound As Boolean = False
        Dim exts() As String = {".png", ".jpg", ".bmp"}
        Dim formalizedName As String = ""

        formalizedName = _anime.Nom().Replace(":", "") _
                                     .Replace("\", "") _
                                     .Replace("/", "") _
                                     .Replace("*", "") _
                                     .Replace("?", "") _
                                     .Replace(">", "") _
                                     .Replace("<", "") _
                                     .Replace("|", "") _
                                     .Replace(Chr(34), "") ' guillemet

        pictPath = Application.StartupPath & "\PICTURES\" & formalizedName
        For Each ext In exts
            If (System.IO.File.Exists(pictPath & ext)) Then
                pictPath = pictPath & ext
                pictFound = True
                Exit For
            End If
        Next

        If (pictFound) Then
            Dim pic As FileStream = New FileStream(pictPath, FileMode.Open)
            cardFont.Image = Image.FromStream(pic)
            pic.Close()
            pic.Dispose()
        Else
            cardFont.Image = My.Resources.defaultPic
        End If

        cardName.Text = _anime.Nom()

        tip.SetToolTip(cardFont, _anime.Nom())
        tip.SetToolTip(cardName, _anime.Nom())

    End Sub

#Region " Handler "
    Private Sub cardFont_MouseEnter(sender As Object, e As EventArgs) Handles cardFont.MouseEnter, cardName.MouseEnter

        cardFont.Location = New Point(1, 1)
        cardFont.Size = New Point(118, 198)
        cardName.Location = New Point(1, 165)
        cardName.Size = New Point(118, 23)

    End Sub
    Private Sub cardFont_MouseLeave(sender As Object, e As EventArgs) Handles cardFont.MouseLeave, cardName.MouseLeave

        cardFont.Location = New Point(0, 0)
        cardFont.Size = New Point(120, 200)
        cardName.Location = New Point(0, 165)
        cardName.Size = New Point(120, 23)

    End Sub
    Private Sub cardFont_MouseDown(sender As Object, e As MouseEventArgs) Handles cardFont.MouseDown, cardName.MouseDown
        Me.BackColor = Color.Blue
    End Sub
    Private Sub cardFont_MouseUp(sender As Object, e As MouseEventArgs) Handles cardFont.MouseUp
        Me.BackColor = Color.CornflowerBlue
    End Sub
    Private Sub cardFont_Click(sender As Object, e As EventArgs) Handles cardName.Click, cardFont.Click
        RaiseEvent loadAnimeEvent(_anime)
    End Sub
#End Region

End Class
