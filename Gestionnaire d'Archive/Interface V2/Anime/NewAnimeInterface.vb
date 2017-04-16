﻿Public Class NewAnimeInterface
    Inherits UserControl

    ' Outer Event
    Public Event newAnimeEvent(anime As Anime)
    Public Event loadAnimeEvent(anime As Anime)

    Public Sub New()

        InitializeComponent()
        Me.BackColor = Color.Transparent

    End Sub
    Private Sub AnimeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nFilter.fillItemList("", ";")
    End Sub

#Region " Functions "
    Private Function isValidTextbox(sender As TextBox) As Boolean

        Dim ret As Boolean = True
        sender.BackColor = Color.FromName("Control")

        If (sender.TextLength > 0) Then
            If (sender.Equals(nEpisode)) Then
                If Not IsNumeric(sender.Text) Then ret = False
            End If
            If (sender.Equals(nTitle)) Then
                If V2_GUI.isNameExist(nTitle.Text) Then ret = False
            End If
        Else
            ret = False
        End If

        If (Not ret) Then sender.BackColor = Color.FromArgb(200, 25, 25)
        Return ret

    End Function
    Private Function isValidChangment() As Boolean

        Dim ret As Boolean = True
        Dim changeList() As Object = {nTitle, nEpisode, nLienModifiable}

        For Each e In changeList
            If Not isValidTextbox(e) Then ret = False
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

        If (Not isValidChangment()) Then Exit Sub

        Dim anime As Anime
        anime = New Anime(
            nom:=nTitle.Text,
            lien:=nLienModifiable.Text,
            episode:=CInt(nEpisode.Text),
            mDate:=nDate.Value,
            genre:=nFilter.getActiveItem(),
            commentaire:=nCommentaire.Text,
            note:=nRank.Rank,
            smartLink:=IIf(nFinish.Checked, False, nSmartLink.Checked),
            follow:=IIf(nFinish.Checked, False, nFollow.Checked),
            finished:=nFinish.Checked
        )

        'TODO:
        'Lancer le script pour vérifier si il y a une image sur le serveur
        'Script retourne soit
        '{num: 1, name: "blablabla.blabla"} si l'image est présente sur le serveur
        '{num: -1, name: "null"} sinon et le serveur lance le programme pour trouver l'image

        RaiseEvent newAnimeEvent(anime)

        Dim infobox As DialBox = New DialBox("Voulez vous afficher la série ?", mode:=DialBox.BoxMode.ModeYesNo)
        Dim res As DialogResult = infobox.ShowDialog()
        Console.WriteLine("LOG: newAnime: " & res)
        If (res.Equals(DialogResult.Yes)) Then
            RaiseEvent loadAnimeEvent(anime)
        End If
        clear()

    End Sub
    Private Sub nDimiss_Click(sender As Object, e As EventArgs) Handles nDimiss.Click
        clear()
    End Sub
    Private Sub form_TextChanged(sender As Object, e As EventArgs) Handles nTitle.TextChanged, nEpisode.TextChanged, nLienModifiable.TextChanged
        nAjouter.Enabled = isValidTextbox(sender)
    End Sub
    Private Sub nSmartLink_CheckedChanged(sender As Object, e As EventArgs) Handles nSmartLink.CheckedChanged
        If sender.checked Then
            Dim box As DialBox = New DialBox("Afin de pouvoir utiliser la reconnaissance de lien de manière intelligente, il est nécessaire de mettre le lien du première épisode." & vbCrLf & vbCrLf & _
                                            "http://monsite.fr/ma-serie" & vbCrLf & _
                                            "Doit devenir :" & vbCrLf & _
                                            "http://monsite.fr/ma-serie-episode-01" & vbCrLf & _
                                            "Si 'ma-serie-episode-01' est le lien de l'épisode 1",
                                            "Information sur le fonctionnement",
                                            DialBox.BoxMode.ModeInformation)
            box.ShowDialog()
        End If
    End Sub
#End Region

End Class
