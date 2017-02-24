Public Class AnimeSlider
    Inherits UserControl

    Private oldFilter As String = ""
    Private oldOut As Boolean = False
    Private oldIndex As Integer = 0

    Private index As Integer = 0
    Private cardList As List(Of AnimeCard) = New List(Of AnimeCard)

    ' Outer Event
    Public Event loadAnimeEvent(anime As Anime)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Size = slider.Size

    End Sub

#Region " Fill "
    Public Sub addAnime(anime As Anime)
        If Not anime Is Nothing Then
            Dim aCard As AnimeCard = New AnimeCard(anime)
            AddHandler aCard.loadAnimeEvent, AddressOf loadAnime
            cardList.Add(aCard)
        End If
    End Sub
    Public Sub addAnime(animeList As List(Of Anime))
        If Not animeList Is Nothing Then
            For Each a In animeList
                addAnime(a)
            Next
        End If
    End Sub
    Private Delegate Sub dFillWithFilter(ByVal filter As String, ByVal out As Boolean, i As Integer)
    Private Sub fillWithFilter(ByVal filter As String, ByVal out As Boolean, Optional i As Integer = 0)

        oldFilter = filter
        oldOut = out
        index = i

        Dim view As DataView = New DataView(V2_GUI.data.Tables("data"))
        view.Sort() = "Nom ASC"
        view.RowFilter() = filter

        Dim table As DataTable = view.ToTable

        If table.Rows.Count = 0 Then
            displayAny()
        Else
            Console.WriteLine("LOG: start processing")
            fillWithFilterProcessing(table, out)
            Console.WriteLine("LOG: end processing")
        End If

    End Sub
    Private Sub fillWithFilterProcessing(ByVal table As DataTable, ByVal out As Boolean)

        Try
            table.BeginLoadData()
            Select Case out
                Case True
                    Console.WriteLine("LOG: processing. . .")
                    For Each line As DataRow In table.Rows
                        Dim a As Anime = New Anime(line)
                        Dim diff As Integer = DateDiff(DateInterval.Day, a.DateSortie(), Now.Date, FirstDayOfWeek.Monday)
                        Dim nb As Integer = 1 + Math.Floor(diff / 7) 'Nb d'épisode depuis le début
                        If ((7 * (a.Episode() - 1)) - (diff Mod 7) - (7 * (nb - 1)) <= 0) Then
                            addAnime(a)
                        End If
                    Next

                Case Else
                    Console.WriteLine("LOG: processing. . .")
                    For Each line As DataRow In table.Rows
                        addAnime(New Anime(line))
                    Next
            End Select
            table.EndLoadData()

        Catch ex As Exception
            Console.WriteLine("LOG: fillAnimeList - " & ex.Message)
        End Try

    End Sub
    Public Sub loadWithFilter(ByVal filter As String, ByVal out As Boolean, Optional i As Integer = 0)

        If Not worker.IsBusy Then

            oldFilter = filter
            oldOut = out
            oldIndex = i
            clearScreen()
            loading.Visible = True

            worker.RunWorkerAsync()

        End If

    End Sub
    Public Sub reloadWithFilter()
        loadWithFilter(oldFilter, oldOut, oldIndex)
    End Sub
    Private Delegate Sub dFillCardList()
    Private Sub fillCardList()

        'location y : 10
        'location x : 30 + 120 * pos + 10 * pos
        Dim i As Integer

        For i = 0 To cardList.Count - 1

            Dim aCard As AnimeCard = cardList.Item(i)
            aCard.Location = New Point(30 + (120 * (i Mod 4)) + (10 * (i Mod 4)), 10)
            aCard.Visible = False
            slider.Controls.Add(aCard)
            aCard.BringToFront()

        Next

    End Sub
#End Region

#Region " Display "
    Public Sub displayAnime()

        cardList.Reverse()
        fillCardList()
        displayIndex()

    End Sub
    Private Sub displayAny()
        clearScreen()
        Me.noResponse.Visible = True
    End Sub
    Private Sub displayIndex(Optional state As Boolean = True)
        Dim i As Integer
        For i = index * 4 To Math.Min(cardList.Count, index * 4 + 4) - 1
            cardList.Item(i).Visible = state
        Next
    End Sub
    Private Sub displaySlider()
        If cardList.Count <= (index + 1) * 4 Then sliderRight.Visible = False Else sliderRight.Visible = True
        If index > 0 Then sliderLeft.Visible = True Else sliderLeft.Visible = False
    End Sub
    Public Sub clearScreen()

        index = 0
        For Each e In cardList
            slider.Controls.Remove(e)
        Next
        Me.noResponse.Visible = False
        cardList.Clear()
        displaySlider()

    End Sub
#End Region

#Region " Handler "
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
    Private Sub worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork

        fillWithFilter(oldFilter, oldOut, oldIndex)

    End Sub
    Private Sub worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles worker.RunWorkerCompleted

        fillCardList()
        displaySlider()
        displayIndex()
        loading.Visible = False

    End Sub
    Private Sub loadAnime(anime As Anime)
        oldIndex = index
        RaiseEvent loadAnimeEvent(anime)
    End Sub
#End Region

End Class
