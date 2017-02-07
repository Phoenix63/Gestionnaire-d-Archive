﻿Public Class RechercherInterface
    Inherits UserControl

    Dim view As DataView
    Private animeList As List(Of Anime) = New List(Of Anime)

    ' Outer Event
    Public Event loadAnimeEvent(anime As Anime)

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

        Dim table As DataTable = View.ToTable

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

    End Sub
    Private Sub displayAnime()

        slider.clearAnime()
        slider.addAnime(Me.animeList)
        slider.fillAnimeCard()
        slider.displayIndex()

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loadWithFilter("Fini = '1'")
    End Sub

End Class
