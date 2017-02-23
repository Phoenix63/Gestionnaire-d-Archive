Public Class NewAnimeInterface
    Inherits UserControl

    ' Outer Event
    Public Event newAnimeEvent(anime As Anime)

    Public Sub New()

        InitializeComponent()
        Me.BackColor = Color.Transparent

    End Sub
    Private Sub AnimeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nFilter.fillItemList("", ";")
    End Sub

#Region " Functions "
    Private Function checkTextboxChange(sender As TextBox) As Boolean

        Dim ret As Boolean = True

        If (sender.TextLength > 0) Then

            sender.BackColor = Color.FromName("Control")

            If (sender.Equals(nEpisode)) Then
                If Not IsNumeric(sender.Text) Then
                    sender.BackColor = Color.FromArgb(200, 25, 25)
                    ret = False
                End If
            End If

        Else
            sender.BackColor = Color.FromArgb(200, 25, 25)
            ret = False
        End If

        Return ret

    End Function
    Private Function checkChange() As Boolean

        Dim ret As Boolean = True
        Dim changeList() As Object = {nTitle, nEpisode, nLienModifiable}

        For Each e In changeList
            If Not checkTextboxChange(e) Then ret = False
        Next

        Return ret

    End Function
    Private Sub clear()

        nTitle.Clear()
        nEpisode.Clear()
        nRank.Rank = 1
        nFilter = New AnimeFilter("", ";")
        nDate.Value = Date.Now
        nLienModifiable.Clear()
        nCommentaire.Clear()
        nSmartLink.Checked = False
        nFollow.Checked = False
        nFinish.Checked = False

        nTitle.BackColor = Color.FromName("Control")
        nEpisode.BackColor = Color.FromName("Control")
        nLienModifiable.BackColor = Color.FromName("Control")

    End Sub
#End Region

#Region " Handler "
    Private Sub nReturn_Click(sender As Object, e As EventArgs) Handles nReturn.Click
        Me.Parent.Controls.Remove(Me)
        Dispose()
    End Sub
    Private Sub nAjouter_Click(sender As Object, e As EventArgs) Handles nAjouter.Click

        If (Not checkChange()) Then Exit Sub

        Dim anime As Anime
        anime = New Anime(
            nom:=nTitle.Text,
            lien:=nLienModifiable.Text,
            episode:=CInt(nEpisode.Text),
            mDate:=nDate.Value,
            genre:=nFilter.getActiveItem(),
            commentaire:=nCommentaire.Text,
            note:=nRank.Rank,
            smartLink:=nSmartLink.Checked,
            follow:=nFollow.Checked,
            finished:=nFinish.Checked
        )

        'TODO:
        'Check qu'il n'existe pas
        'Lancer le script pour vérifier si il y a une image sur le serveur
        'Script retourne soit
        '{num: 1, name: "blablabla.blabla"} si l'image est présente sur le serveur
        '{num: -1, name: "null"} sinon et le serveur lance le programme pour trouver l'image

        RaiseEvent newAnimeEvent(anime)
        clear()

    End Sub
    Private Sub nDimiss_Click(sender As Object, e As EventArgs) Handles nDimiss.Click
        clear()
    End Sub
    Private Sub form_TextChanged(sender As Object, e As EventArgs) Handles nTitle.TextChanged, nEpisode.TextChanged, nLienModifiable.TextChanged
        nAjouter.Enabled = checkTextboxChange(sender)
    End Sub
    Private Sub nSmartLink_CheckedChanged(sender As Object, e As EventArgs) Handles nSmartLink.CheckedChanged
        If sender.checked Then
            MsgBox("Afin de pouvoir utiliser la reconnaissance de lien de manière intelligente, " & vbCrLf & _
                   "il est nécessaire que vous mettiez le lien du première épisode." & vbCrLf & vbCrLf & _
                   "Exemple :" & vbCrLf & _
                   "http://monsite.fr/mon-anime" & vbCrLf & _
                   "Doit devenir :" & vbCrLf & _
                   "http://monsite.fr/mon-anime-episode-01" & vbCrLf & _
                   "Si 'mon-anime-episode-01' est le lien de l'épisode 1",
                   MsgBoxStyle.Information,
                   "Information sur le fonctionnement")
        End If
    End Sub
#End Region

End Class
