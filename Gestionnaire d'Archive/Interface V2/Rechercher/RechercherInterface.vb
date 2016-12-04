Public Class RechercherInterface
    Inherits UserControl

    ' Outer Event
    Public Event loadAnimeEvent(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As New Anime("Tokyo Ghoul",
                           "test",
                           16,
                           New Date(2016, 10, 19),
                           "Action;Combats et Arts Martiaux;Shônen",
                           note:=5)
        RaiseEvent loadAnimeEvent(a)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim a As List(Of Anime) = New List(Of Anime)
        a.Add(New Anime("Tokyo Ghoul", "test", 16, New Date(2016, 10, 19), "Action;Combats et Arts Martiaux;Shônen", note:=5))
        a.Add(New Anime("Toto", "test", 15, New Date(2016, 10, 19), "Action;Combats et Arts Martiaux;Shônen", note:=5))

        slider.addAnime(a)
        slider.fillAnimeCard()
        slider.displayIndex()

    End Sub

    Public Sub loadAnime(anime As Anime) Handles slider.loadAnimeEvent
        RaiseEvent loadAnimeEvent(anime)
    End Sub

End Class
