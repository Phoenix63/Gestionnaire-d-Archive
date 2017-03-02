Imports System.Threading

Public Class RechercherInterface
    Inherits UserControl

    ' Outer Event
    Public Event LoadAnimeEvent(anime As Anime)
    Public Event AnimeChanged(anime As Anime)
    Public Event HistoryUpdated()

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent
        Me.Refresh()

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
    Private Sub rReturn_Click(sender As Object, e As EventArgs) Handles rReturn.Click

        Me.Visible = False
        RaiseEvent HistoryUpdated()

    End Sub
    Public Sub loadAnime(anime As Anime) Handles slider.loadAnimeEvent
        RaiseEvent LoadAnimeEvent(anime)
    End Sub
    Private Sub filterBuilt(ByVal value As String, out As Boolean) Handles searchFilter.FilterBuilt
        loadWithFilter(value, out)
    End Sub
#End Region


End Class
