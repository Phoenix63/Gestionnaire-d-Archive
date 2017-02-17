Public Class AnimeSlider
    Inherits UserControl

    Private index As Integer = 0
    Private list As List(Of AnimeCard) = Nothing

    Public Event loadAnimeEvent(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Size = slider.Size
        list = New List(Of AnimeCard)

    End Sub

    Public Sub addAnime(anime As Anime)
        If Not anime Is Nothing Then
            Dim aCard As AnimeCard = New AnimeCard(anime)
            AddHandler aCard.loadAnimeEvent, AddressOf loadAnime
            list.Add(aCard)
        End If
    End Sub
    Public Sub addAnime(animeList As List(Of Anime))
        If Not animeList Is Nothing Then
            For Each a In animeList
                addAnime(a)
            Next
        End If
    End Sub

    Public Sub displayAny()
        index = 0
        clearAnime()
        displaySlider()
        Me.noResponse.Visible = True
    End Sub

    Public Sub clearScreen()
        For Each e In list
            slider.Controls.Remove(e)
        Next
        Me.noResponse.Visible = False
    End Sub
    Public Sub clearAnime()
        clearScreen()
        list.Clear()
    End Sub

    Public Sub fillAnimeCard()

        'location y : 10
        'location x : 30 + 120 * pos + 10 * pos
        Dim i As Integer

        index = 0
        clearScreen()
        For i = 0 To list.Count - 1

            Dim aCard As AnimeCard = list.Item(i)
            aCard.Location = New Point(30 + (120 * (i Mod 4)) + (10 * (i Mod 4)), 10)
            aCard.Visible = False
            slider.Controls.Add(aCard)
            aCard.BringToFront()

        Next
        displaySlider()

    End Sub
    Public Sub displayIndex(Optional state As Boolean = True)

        Dim i As Integer
        For i = index * 4 To Math.Min(list.Count, index * 4 + 4) - 1
            list.Item(i).Visible = state
        Next

    End Sub
    Private Sub displaySlider()
        If list.Count <= (index + 1) * 4 Then sliderRight.Visible = False Else sliderRight.Visible = True
        If index > 0 Then sliderLeft.Visible = True Else sliderLeft.Visible = False
    End Sub
    Private Sub slider_Click(value As Integer)

        displayIndex(False)
        index += value
        displayIndex(True)

        displaySlider()

    End Sub
    Private Sub sliderRight_Click(sender As Object, e As EventArgs) Handles sliderRight.Click
        slider_Click(1)
    End Sub
    Private Sub sliderLeft_Click(sender As Object, e As EventArgs) Handles sliderLeft.Click
        slider_Click(-1)
    End Sub

    Public Sub loadAnime(anime As Anime)
        RaiseEvent loadAnimeEvent(anime)
    End Sub

End Class
