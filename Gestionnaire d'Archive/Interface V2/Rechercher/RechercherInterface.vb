Public Class RechercherInterface
    Inherits UserControl

    Dim view As DataView
    Private animeList As List(Of Anime) = New List(Of Anime)

    ' Outer Event
    Public Event loadAnimeEvent(anime As Anime)
    Public Event animeChanged(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent

        view = New DataView(V2_GUI.data.Tables("data"))
        view.Sort() = "Nom ASC"

    End Sub

    Private Sub RechercherInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadWithFilter("")
    End Sub
    Private Sub loadWithFilter(ByVal filter As String)

        view.RowFilter() = filter

        Dim table As DataTable = view.ToTable

        Me.animeList.Clear()

        If table.Rows.Count = 0 Then
            slider.clearAnime()
            slider.displayAny()
        Else
            Try

                table.BeginLoadData()
                For Each line As DataRow In table.Rows
                    Me.animeList.Add(New Anime(line))
                Next
                table.EndLoadData()

                displayAnime()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub
    Private Sub displayAnime()

        slider.clearAnime()
        slider.addAnime(Me.animeList)
        slider.fillAnimeCard()
        slider.displayIndex()

    End Sub
    Public Sub loadAnime(anime As Anime) Handles slider.loadAnimeEvent
        RaiseEvent loadAnimeEvent(anime)
    End Sub
    Private Sub filterBuilt(ByVal value As String) Handles searchFilter.FilterBuilt
        loadWithFilter(value)
    End Sub

End Class
