Public Class RechercherInterface
    Inherits UserControl

    ' Outer Event
    Public Event LoadAnimeEvent(anime As Anime)
    Public Event AnimeChanged(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent

    End Sub
    Private Sub RechercherInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadWithFilter("", False)
    End Sub

#Region " Function "
    Public Sub updateNameList()
        searchFilter.updateNameList()
    End Sub
    Public Sub loadWithFilter(ByVal filter As String, ByVal out As Boolean)
        slider.loadWithFilter(filter, out)
    End Sub
    Public Sub reloadSlider()
        slider.reloadWithFilter()
    End Sub
#End Region

#Region " Handler "
    Public Sub loadAnime(anime As Anime) Handles slider.loadAnimeEvent
        RaiseEvent LoadAnimeEvent(anime)
    End Sub
    Private Sub filterBuilt(ByVal value As String, out As Boolean) Handles searchFilter.FilterBuilt
        loadWithFilter(value, out)
    End Sub
#End Region

End Class
