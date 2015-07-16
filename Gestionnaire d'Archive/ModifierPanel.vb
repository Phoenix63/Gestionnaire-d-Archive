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

        Me._nom.Text = anime.getNom()
        Me._lien.Text = anime.getLien()
        Me._episode.Text = anime.getEpisode()
        Me._genre.Text = anime.getGenre()
        Me._date.Value = anime.getDate().ToString(anime.FORMAT)
        Me._note.Value = anime.getNote()
        Me._commentaire.Text = anime.getCommentaire()
        Me._follow.Checked = anime.getFollow()
        Me._smartLink.Checked = anime.getSmartLink()
        Me._finished.Checked = anime.getFinished()

    End Sub
    Public Overrides Function _checkSmartLink() As Boolean
        Return MyBase._checkSmartLink() And Not Me._anime.getSmartLink()
    End Function
#End Region

#Region "Handler"
    Protected Overrides Sub _click(sender As Object, e As EventArgs)

        If (_checkNecessaryEntries()) Then

            Dim anime As Anime = getInfo()
            Dim row As DataRow = Main.dataSet.Tables("data").Select("Nom = '" & Me._anime.getNom() & "'")(0)

            row.BeginEdit()
            row(1) = anime.getNom()
            row(2) = anime.getLien()
            row(3) = anime.getGenre()
            row(4) = anime.getEpisode()
            row(5) = anime.getDate().ToString(anime.FORMAT)
            row(6) = anime.getNote()
            row(7) = If(anime.getFollow(), "1", "0")
            row(8) = If(anime.getSmartLink(), "1", "0")
            row(9) = anime.getCommentaire()
            row(10) = If(anime.getFinished(), "1", "0")
            row.EndEdit()

            If sender.Equals(Me._validerFermer) Then Main.loadMenu(anime)

        End If

    End Sub
#End Region

End Class
