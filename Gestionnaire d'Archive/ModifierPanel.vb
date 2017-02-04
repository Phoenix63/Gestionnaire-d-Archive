Public Class ModifierPanel
    Inherits SetPanel

    Public Sub New(form As Form)

        MyBase.New(form)

        Me._subtitle.Text = "Modification"
        Me._subtitle.ForeColor = Color.Chocolate

    End Sub
    Public Sub New(form As Form, anime As Anime)

        Me.New(form)

        Me._anime = anime
        setInfo(anime)

    End Sub

#Region "Methode"
    Private Sub setInfo(anime As Anime)

        Me._nom.Text = anime.Nom()
        Me._lien.Text = anime.Lien()
        Me._episode.Text = anime.Episode()
        Me._genre.Text = anime.Genre()
        Me._date.Value = anime.DateSortie().ToString(anime.FORMAT)
        Me._note.Value = anime.Note()
        Me._commentaire.Text = anime.Commentaire()
        Me._follow.Checked = anime.Follow()
        Me._smartLink.Checked = anime.SmartLink()
        Me._finished.Checked = anime.Finished()

    End Sub
    Public Overrides Function _checkSmartLink() As Boolean
        Return MyBase._checkSmartLink() And Not Me._anime.SmartLink()
    End Function
#End Region

#Region "Handler"
    Protected Overrides Sub _click(sender As Object, e As EventArgs)

        If (_checkNecessaryEntries()) Then

            Dim anime As Anime = getInfo()
            Dim row As DataRow = Main.dataSet.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)

            row.BeginEdit()
            row(1) = anime.Nom()
            row(2) = anime.Lien()
            row(3) = anime.Genre()
            row(4) = anime.Episode()
            row(5) = anime.DateSortie().ToString(anime.FORMAT)
            row(6) = anime.Note()
            row(7) = If(anime.Follow(), "1", "0")
            row(8) = If(anime.SmartLink(), "1", "0")
            row(9) = anime.Commentaire()
            row(10) = If(anime.Finished(), "1", "0")
            row.EndEdit()

            If sender.Equals(Me._validerFermer) Then Main.loadMenu(anime)

        End If

    End Sub
#End Region

End Class
