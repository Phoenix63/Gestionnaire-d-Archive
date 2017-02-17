Public Class RechercherInterface
    Inherits UserControl

    Private oldFilter As String = ""
    Private oldOut As Boolean = False
    Private animeList As List(Of Anime) = New List(Of Anime)

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
        loadWithFilter("", False)
    End Sub

    Public Sub updateNameList()
        searchFilter.updateNameList()
    End Sub
    Public Sub reloadWithFilter()
        If InvokeRequired Then
            MyBase.BeginInvoke(
                Sub() loadWithFilter(oldFilter, oldOut)
            )
        End If
    End Sub
    Public Sub loadWithFilter(ByVal filter As String, ByVal out As Boolean)

        oldFilter = filter
        oldOut = out

        Dim view As DataView = New DataView(V2_GUI.data.Tables("data"))
        view.Sort() = "Nom ASC"
        view.RowFilter() = filter

        Dim table As DataTable = view.ToTable

        Me.animeList.Clear()

        If table.Rows.Count = 0 Then
            slider.displayAny()
        Else
            Try

                table.BeginLoadData()

                Select Case out
                    Case True

                        For Each line As DataRow In table.Rows

                            Dim a As Anime = New Anime(line)
                            Dim diff As Integer = DateDiff(DateInterval.Day, a.DateSortie(), Now.Date, FirstDayOfWeek.Monday)
                            Dim nb As Integer = 1 + Math.Floor(diff / 7) 'Nb d'épisode depuis le début
                            If ((7 * (a.Episode() - 1)) - (diff Mod 7) - (7 * (nb - 1)) <= 0) Then
                                Me.animeList.Add(a)
                            End If
                        Next

                    Case Else
                        For Each line As DataRow In table.Rows
                            Me.animeList.Add(New Anime(line))
                        Next
                End Select

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
    Private Sub filterBuilt(ByVal value As String, out As Boolean) Handles searchFilter.FilterBuilt
        loadWithFilter(value, out)
    End Sub

End Class
