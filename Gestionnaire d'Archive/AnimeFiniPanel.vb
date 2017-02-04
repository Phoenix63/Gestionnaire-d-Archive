Imports System.Data.SqlClient

Public Class AnimeFiniPanel
    Inherits AnimePanel

    Public Sub New(form As Form)

        MyBase.New(form)

        Me._subtitle.Text = "Animé terminé"
        Me._subtitle.ForeColor = Color.LightBlue

        Me.Controls.Item("nom").Controls.RemoveByKey("nextEp")

    End Sub
    Public Sub New(form As Form, anime As Anime)

        Me.New(form)

        If (anime.Finished()) Then

            Me._animeList.Text = anime.Nom()
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
            Me.dataView.RowFilter() = "Fini = '1'"
            Me.dataView.Sort() = "Nom ASC"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

End Class
