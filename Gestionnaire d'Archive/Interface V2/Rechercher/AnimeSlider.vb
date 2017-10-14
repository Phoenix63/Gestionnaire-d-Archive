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

        Console.WriteLine("LOG: looking for fill slider with filter '{0}'", filter)
        If table.Rows.Count = 0 Then
            Console.WriteLine(" => No match")
            displayEmpty()
        Else
            Console.WriteLine(" => Start processing to load data")
            fillWithFilterProcessing(table, out)
            Console.WriteLine(" => End processing")
        End If

    End Sub
    Private Sub fillWithFilterProcessing(ByVal table As DataTable, ByVal out As Boolean)

        Try
            table.BeginLoadData()
            Select Case out
                Case True
                    Console.WriteLine("LOG: loading released file")
                    For Each line As DataRow In table.Rows
                        Dim a As Anime = New Anime(line)
                        Dim diff As Integer = DateDiff(DateInterval.Day, a.DateSortie(), Now.Date, FirstDayOfWeek.Monday)
                        Dim nb As Integer = 1 + Math.Floor(diff / 7) 'Nb d'épisode depuis le début
                        If ((7 * (a.Episode() - 1)) - (diff Mod 7) - (7 * (nb - 1)) <= 0) Then
                            addAnime(a)
                        End If
                    Next

                Case Else
                    Console.WriteLine("LOG: loading normally")
                    For Each line As DataRow In table.Rows
                        addAnime(New Anime(line))
                    Next
            End Select
            table.EndLoadData()

        Catch ex As Exception
            Console.WriteLine("ERR: " & ex.Message)
        End Try

    End Sub
    Public Sub loadWithFilter(ByVal filter As String, ByVal out As Boolean, Optional i As Integer = 0)

        If Not worker.IsBusy Then

            clearSlider()

            oldFilter = filter
            oldOut = out
            oldIndex = i
            loading.Visible = True

            worker.RunWorkerAsync()

        End If

    End Sub
    Public Sub reloadAnimeCard(ByRef anime As Anime)

        For Each card In cardList
            If card.anime.Nom().Equals(anime.Nom) Then
                card.reload()
                Exit For
            End If
        Next

    End Sub
    Public Sub removeAnimeCard(ByRef anime As Anime)

        Dim aCard As AnimeCard = Nothing
        For Each card In cardList
            If card.anime.Nom().Equals(anime.Nom) Then
                aCard = card
                Exit For
            End If
        Next

        If (aCard IsNot Nothing) Then
            If (cardList.Count = 1) Then
                displayEmpty()
            Else
                clearScreen()
                cardList.Remove(aCard)
                index = 0
                displayAnime()
            End If
        End If

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
    Public Sub displayAnime() 'display the current index
        fillCardList()
        displayIndex()
        displaySlider()
    End Sub
    Private Sub displayEmpty() 'display the empty message

        If Me.InvokeRequired Then
            Me.Invoke(Sub() displayEmpty())
        Else
            clearSlider()
            Me.noResponse.Visible = True
        End If

    End Sub
    Private Sub displayIndex(Optional state As Boolean = True) 'set visible state to @state for the current index
        Dim i As Integer
        For i = index * 4 To Math.Min(cardList.Count, index * 4 + 4) - 1
            cardList.Item(i).Visible = state
        Next
    End Sub
    Private Sub displaySlider() 'button
        If cardList.Count <= (index + 1) * 4 Then sliderRight.Visible = False Else sliderRight.Visible = True
        If index > 0 Then sliderLeft.Visible = True Else sliderLeft.Visible = False
    End Sub
    Public Sub clearSlider() 'reset content and clear graphically
        index = 0
        clearScreen()
        cardList.Clear()
        displaySlider()
    End Sub
    Public Sub clearScreen() 'clear graphically
        For Each e In cardList
            slider.Controls.Remove(e)
        Next
        Me.noResponse.Visible = False
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

        If cardList.Count = 1 Then
            Console.WriteLine("LOG: Anime matched => Load directly")
            Dim aCard As AnimeCard = cardList.Item(0)
            RaiseEvent loadAnimeEvent(aCard.anime)
        End If

        fillCardList()
        displayIndex()
        displaySlider()
        loading.Visible = False

    End Sub
    Private Sub loadAnime(anime As Anime)
        oldIndex = index
        RaiseEvent loadAnimeEvent(anime)
    End Sub
#End Region

End Class
