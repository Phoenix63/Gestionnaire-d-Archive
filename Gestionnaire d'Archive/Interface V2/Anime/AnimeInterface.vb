Public Class AnimeInterface
    Inherits UserControl

    Private sInterface As SaveInterface = Nothing
    Private _anime As Anime = Nothing
    Private _animeUpdated As Anime = Nothing
    Private onUpdate As Boolean = False

    Private Const COMMENTAIRE_TOP_WITHOUT_FOLLOW As Integer = 240
    Private Const COMMENTAIRE_TOP_WITH_FOLLOW As Integer = 270
    Private Const COMMENTAIRE_HEIGHT_WITHOUT_FOLLOW As Integer = 75
    Private Const COMMENTAIRE_HEIGHT_WITH_FOLLOW As Integer = 45

    Public Sub New(ByVal anime As Anime)

        InitializeComponent()
        Me.BackColor = Color.Transparent
        _anime = anime

    End Sub

    Private Sub AnimeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub

#Region " Display "
    Private Sub display()

        aTitle.Text = _anime.getNom()
        displayPicture(_anime.getNom())

        aEpisode.Text = _anime.getEpisode()
        aRank.Rank = Math.Min(Math.Max(1, _anime.getNote()), 5)

        aFilter.fillItemList(_anime.getGenre(), ";")

        Debug.Assert(_anime.getDate().ToString(aDate.CustomFormat) = New Date(2016, 10, 19).ToString(aDate.CustomFormat))
        aDate.Value = _anime.getDate()
        Debug.Assert(aDate.Value.ToString(aDate.CustomFormat) = _anime.getDate().ToString(aDate.CustomFormat))

        aLien.Text = _anime.getLien()
        aLienModifiable.Text = aLien.Text()

        displayFollowLabel()
        displaySmartLink()

        aCommentaire.Text = _anime.getCommentaire()

        aSmartLink.Checked = _anime.getSmartLink()
        aFollow.Checked = _anime.getFollow()
        aFinish.Checked = _anime.getFinished()

        updateDisplay()

    End Sub
    Private Sub updateDisplay()

        aTitle.Enabled = onUpdate
        aTitle.Cursor = IIf(onUpdate, Cursors.IBeam, Cursors.Default)

        aEpisode.Enabled = onUpdate
        aEpisode.Cursor = IIf(onUpdate, Cursors.IBeam, Cursors.Default)
        aRank.Enabled = onUpdate

        aFilter.Active = onUpdate

        aDate.Enabled = onUpdate

        aLien.Visible = Not onUpdate
        aLienModifiable.Visible = onUpdate

        aFollowLabel.Visible = aFollow.Checked

        If (Not aFollow.Checked) Then
            aCommentaire.Height = COMMENTAIRE_HEIGHT_WITHOUT_FOLLOW
            aCommentaire.Top = COMMENTAIRE_TOP_WITHOUT_FOLLOW
        Else
            aCommentaire.Height = COMMENTAIRE_HEIGHT_WITH_FOLLOW
            aCommentaire.Top = COMMENTAIRE_TOP_WITH_FOLLOW
        End If
        aCommentaire.ReadOnly = Not onUpdate

        aSmartLink.Visible = onUpdate
        aFollow.Visible = onUpdate
        aFinish.Visible = onUpdate

        aNext.Visible = Not onUpdate
        aCloturer.Visible = Not onUpdate

        aModifier.Text = IIf(onUpdate, "Valider", "Modifier")

    End Sub
    Private Sub displayPicture(name As String)

        Dim pictPath As String
        pictPath = Application.StartupPath + "\PICTURES\" + name.ToLowerInvariant() + ".png"

        If (System.IO.File.Exists(pictPath)) Then
            aPicture.Image = New Bitmap(pictPath)
        Else
            aPicture.Image = My.Resources.defaultPic
        End If

    End Sub
    Private Sub displayFollowLabel()
        If _anime.getFollow() Then
            aFollowLabel.Text = createFollowMessage()
        End If
    End Sub
    Private Sub displaySmartLink()
        If _anime.getSmartLink() Then
            aLien.Text = createSmartLinkMessage()
        End If
    End Sub
#End Region

#Region " Functions "
    Private Function createFollowMessage() As String

        Dim ret As String
        Dim dateNow As Date = Now.Date
        Dim dateCmp As Date = _anime.getDate()
        Dim diff As Integer = DateDiff(DateInterval.Day, dateCmp, dateNow, FirstDayOfWeek.Monday) 'Date de sortie de l'animé - Date actuelle
        Dim ep As Integer = _anime.getEpisode()
        Dim nbEp As Integer = 1 + Math.Floor(diff / 7) 'Nb d'épisode depuis le début de l'animé
        Dim nextEp As Integer = (7 * (ep - 1)) - (diff Mod 7) - (7 * (nbEp - 1)) 'Prochain ep dans

        If (nextEp > 0) Then 'Sort dans
            ret = "L'épisode sort dans " & nextEp & _
                If(nextEp = 1, " jour", " jours")
        ElseIf (nextEp < 0) Then 'Jours en retard
            ret = "L'épisode est sortie il y a " & Math.Abs(nextEp) & _
                If(nextEp = -1, " jour", " jours")
        Else 'Sortie aujourd'hui
            ret = "L'épisode sort aujourd'hui"
        End If

        Return ret

    End Function
    'TODO: A revoir
    Private Function createSmartLinkMessage() As String

        Dim link As String = _anime.getLien()

        Dim localRegex As New System.Text.RegularExpressions.Regex("^[A-Z]:\\")
        Dim dirPath As String = IO.Path.GetDirectoryName(link)
        Dim filePath As String = IO.Path.GetFileName(link)

        If checkPath(filePath, "001") Then
            filePath = filePath.Replace("001", normalize(3, _anime.getEpisode()))
        ElseIf checkPath(filePath, "01") Then
            filePath = filePath.Replace("01", normalize(2, _anime.getEpisode()))
        ElseIf link.Contains("episode-") Then

            Dim epIndex As Integer, i As Integer
            Dim newLink As String

            newLink = ""
            epIndex = link.LastIndexOf("episode-") + 7

            For i = 0 To epIndex
                newLink += link(i)
            Next

            newLink += "" & Me._anime.getEpisode()
            i = epIndex + 1

            While link(i) <> "-" Or i = link.Length
                i += 1
            End While

            If i <> link.Length Then
                For j = i To link.Length - 1
                    newLink += link(j)
                Next
            End If

            Return newLink

        End If

        'Si le lien est en local
        If localRegex.IsMatch(link) Then
            link = dirPath + "\" + filePath
        ElseIf dirPath = "" Then
            link = filePath
        Else
            link = dirPath.Replace(":\", "://").Replace("\", "/") + "/" + filePath
        End If

        Return link

    End Function
    Private Function checkPath(ByVal path As String, ByVal str As String)

        Dim ret As Boolean = False

        If (path.Length > 0) Then
            If (path.Contains(str)) Then
                If (path.IndexOf(str) = path.LastIndexOf(str)) Then ret = True
            End If
        End If

        Return ret

    End Function
    Private Function normalize(ByVal length As Integer, ByVal value As Integer) As String

        Dim ret As String = value.ToString()

        While (ret.Length < length)
            ret = "0" + ret
        End While

        Return ret

    End Function
#End Region

#Region " Validating function "
    Private Function checkTextboxChange(sender As TextBox) As Boolean

        Dim ret As Boolean = True

        If (sender.TextLength > 0) Then

            sender.BackColor = Color.FromName("Control")

            If (sender.Equals(aEpisode)) Then
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

        Dim changeList() As Object = {aTitle, aEpisode, aLienModifiable}

        For Each e In changeList
            If Not checkTextboxChange(e) Then Return False
        Next

        Return True

    End Function
#End Region

#Region " Handler "
    Private Sub aReturn_Click(sender As Object, e As EventArgs) Handles aReturn.Click
        Me.Parent.Controls.Remove(Me)
        Dispose()
    End Sub
    Private Sub next_Click(sender As Object, e As EventArgs) Handles aNext.Click
        _anime.nextEpisode()
        aEpisode.Text = _anime.getEpisode()
    End Sub
    Private Sub aModifier_Click(sender As Object, e As EventArgs) Handles aModifier.Click

        If onUpdate Then

            If (Not checkChange()) Then Exit Sub

            _animeUpdated = New Anime(
                nom:=aTitle.Text,
                lien:=aLienModifiable.Text,
                episode:=CInt(aEpisode.Text),
                mDate:=aDate.Value,
                genre:=aFilter.getActiveItem(),
                commentaire:=aCommentaire.Text,
                note:=aRank.Rank,
                smartLink:=aSmartLink.Checked,
                follow:=aFollow.Checked,
                finished:=aFinish.Checked
            )

            If Not _anime.Equals(_animeUpdated) Then

                aLien.Text = _animeUpdated.getLien()
                If Not _anime.getNom().Equals(_animeUpdated.getNom()) Then
                    displayPicture(_animeUpdated.getNom())
                End If

                'NOTE: Mettre à jours l'animé dans la db
                _anime = _animeUpdated
                displayFollowLabel()
                displaySmartLink()

            End If

        End If

        onUpdate = Not onUpdate
        updateDisplay()

    End Sub
    Private Sub form_TextChanged(sender As Object, e As EventArgs) Handles aTitle.TextChanged, aEpisode.TextChanged, aLienModifiable.TextChanged
        aModifier.Enabled = checkTextboxChange(sender)
    End Sub
    Private Sub aSmartLink_CheckedChanged(sender As Object, e As EventArgs) Handles aSmartLink.CheckedChanged
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
    Private Sub lien_Click(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles aLien.LinkClicked

        If (e.Button = Windows.Forms.MouseButtons.Left) Then

            Dim url As String
            Dim localRegex As New System.Text.RegularExpressions.Regex("^[A-Z]:\\")
            Dim webRegex As New System.Text.RegularExpressions.Regex("^http://")

            'If Me._lien.Text.Contains("http://") Or Me._lien.Text.Contains(":\") Then 'C'est un url vers le web ou local
            If webRegex.IsMatch(aLien.Text) Or localRegex.IsMatch(aLien.Text) Then
                url = aLien.Text
            Else 'Par défaut on considère que c'est un url vers le web
                url = "http://" & aLien.Text
            End If

            If (Main.DefautToolStripMenuItem.Checked) Then 'On utilise le browser par défaut
                Process.Start(url)
            Else 'Sinon il y a un autre browser renseigné, on vérifie son existance sinon on lance par défaut

                Dim launcher As String = Main.AutreToolStripMenuItem.Tag 'Tag contient tout le chemin et Text que le nom
                Dim exect As String = IO.Path.GetFileName(launcher)
                If (Dir(launcher.Replace("/", "\")) <> "") Then 'Le fichier existe, mais on ne garanti pas qu'il soit un client web
                    Try
                        Process.Start(exect, url)
                    Catch ex As Exception
                        Process.Start(url)
                    End Try
                Else 'Browser par défaut
                    Process.Start(url)
                End If

            End If

        End If

    End Sub
#End Region

End Class
