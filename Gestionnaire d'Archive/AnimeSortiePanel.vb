Imports System.Data.SqlClient

Public Class AnimeSortiePanel
    Inherits AnimePanel

    Public Sub New(form As Form)

        MyBase.New(form)

        Me._subtitle.Text = "Animé sortie"
        Me._subtitle.ForeColor = Color.Purple

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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

End Class
