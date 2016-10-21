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

    Private Sub aReturn_Click(sender As Object, e As EventArgs) Handles rLoad.Click
        RaiseEvent loadAnimeEvent(Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As New Anime("Tokyo Ghoul",
                           "test",
                           1,
                           Date.Now,
                           "Action;Combats et Arts Martiaux;Shônen",
                           note:=5)
        RaiseEvent loadAnimeEvent(a)

    End Sub
End Class
