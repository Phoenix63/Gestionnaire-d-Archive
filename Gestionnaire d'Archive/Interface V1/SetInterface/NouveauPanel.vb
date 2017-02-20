Public Class NouveauPanel
    Inherits SetPanel

    Public Sub New(form As Form)

        MyBase.New(form)

        Me._subtitle.Text = "Ajouter un animé"
        Me._subtitle.ForeColor = Color.Red

    End Sub

#Region "Methode"
#End Region

#Region "Handler"
    Protected Overrides Sub _click(sender As Object, e As EventArgs)

        If (_checkNecessaryEntries()) Then

            _anime = getInfo()

            If (Main.isDuplicateAnime(_anime)) Then
                MsgBox("L'animé existe déjà dans la base de donnée", MsgBoxStyle.Critical, "Duplication de l'animé")
                Return
            End If

            Dim table As DataTable = Main.dataSet.Tables("data")
            Dim row As DataRow = table.NewRow()

            row.BeginEdit()
            row(1) = _anime.Nom()
            row(2) = _anime.Lien()
            row(3) = _anime.Genre()
            row(4) = _anime.Episode()
            row(5) = _anime.DateSortie().ToString(Anime.FORMAT)
            row(6) = _anime.Note()
            row(7) = If(_anime.Follow(), "1", "0")
            row(8) = If(_anime.SmartLink(), "1", "0")
            row(9) = _anime.Commentaire()
            row(10) = If(_anime.Finished(), "1", "0")
            row.EndEdit()

            table.Rows.Add(row)

            If sender.Equals(Me._validerFermer) Then
                Main.Size = New Point(495, 150)
                Main.Controls.Remove(Main._basePanel)
            End If

            clearEntries()

        End If

    End Sub
#End Region

End Class
