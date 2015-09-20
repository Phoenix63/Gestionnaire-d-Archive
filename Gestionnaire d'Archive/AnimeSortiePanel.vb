Imports System.Data.SqlClient

Public Class AnimeSortiePanel
    Inherits AnimePanel

    Public Sub New(form As Form)

        MyBase.New(form)

        Me._subtitle.Text = "Animé sortie"
        Me._subtitle.ForeColor = Color.Purple

    End Sub
    Public Sub New(form As Form, anime As Anime)

        Me.New(form)

        If (Not anime.getFinished()) Then

            Me._animeList.Text = anime.getNom()
            Me._animeList.SelectedIndex = Me._animeList.FindString(Me._animeList.Text)

        End If

    End Sub

#Region "Methode"
    Protected Overrides Sub setDataView()

        dataView.Dispose()
        _animeList.Items.Clear()
        _animeList.Text = ""

        Dim dataTable As DataTable = Main.dataSet.Tables("data")

        Try

            Me.dataView = New DataView(dataTable)
            Me.dataView.RowFilter() = "Fini = '0' And Follow = '1'"
            Me.dataView.Sort() = "Nom ASC"

            Dim filter As String = ""

            For Each line As DataRowView In Me.dataView

                Dim animeTemp As Anime = New Anime(
                                            line("Nom"),
                                            line("Url"),
                                            Integer.Parse(line("Episode")),
                                            line("Date"),
                                            line("Genre"),
                                            line("Commentaire"),
                                            Integer.Parse(line("Note")),
                                            If(line("Follow") = "1", True),
                                            If(line("SmartLink") = "1", True),
                                            If(line("Fini") = "1", True))

                Dim dateNow As Date = Now.Date
                Dim dateCmp As Date = animeTemp.getDate()
                Dim diff As Integer = DateDiff(DateInterval.Day, dateCmp, dateNow, FirstDayOfWeek.Monday)
                Dim ep As Integer = animeTemp.getEpisode()

                Dim nbEp As Integer = 1 + Math.Floor(diff / 7) 'Nb d'épisode depuis le début de l'animé
                Dim nextEp As Integer = (7 * (ep - 1)) - (diff Mod 7) - (7 * (nbEp - 1)) 'Prochain ep dans

                'L'animé n'est pas encore sorti, on le supprime de la view
                If nextEp > 0 Then
                    filter += " And Nom <> '" & animeTemp.getNom & "'"
                End If

            Next

            Me.dataView.RowFilter() = "Fini = '0' And Follow = '1'" & filter

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

End Class
