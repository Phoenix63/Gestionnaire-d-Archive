Imports System.IO
Imports System.Threading

Public Class AnimeInterface
    Inherits UserControl

    Private _anime As Anime = Nothing
    Private _separator As String = Nothing
    Private onUpdate As Boolean = False

    Private Const COMMENTAIRE_TOP_WITHOUT_FOLLOW As Integer = 240
    Private Const COMMENTAIRE_TOP_WITH_FOLLOW As Integer = 270
    Private Const COMMENTAIRE_HEIGHT_WITHOUT_FOLLOW As Integer = 75
    Private Const COMMENTAIRE_HEIGHT_WITH_FOLLOW As Integer = 45

    ' Outer Event
    Public Event AnimeUpdated(anime As Anime)
    Public Event PictureUpdated()

    Public Sub New(ByRef anime As Anime)

        InitializeComponent()
        Me.BackColor = Color.Transparent
        _anime = anime

        If Split(_anime.Genre(), "; ").Count > 1 Then
            _separator = "; "
        ElseIf Split(_anime.Genre(), ", ").Count > 1 Then
            _separator = ", "
        ElseIf Split(_anime.Genre(), ",").Count > 1 Then
            _separator = ","
        Else
            _separator = ";"
        End If

        Console.WriteLine("LOG: genre = " & anime.Genre())
        Console.Write("LOG: (" & _separator & "): ")
        For Each e In _anime.Genre().Split(_separator)
            Console.Write(e & _separator)
        Next
        Console.WriteLine()

    End Sub
    Private Sub AnimeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        display()
        AddHandler aSmartLink.CheckedChanged, AddressOf aSmartLink_CheckedChanged

    End Sub

#Region " Display "
    Private Sub display()

        aTitle.Text = _anime.Nom()
        displayPicture(_anime.Nom())

        aEpisode.Text = _anime.Episode()
        aRank.Rank = Math.Min(Math.Max(1, _anime.Note()), 5)

        aFilter.fillItemList(_anime.Genre(), _separator)

        aDate.Value = _anime.DateSortie()
        Debug.Assert(aDate.Value.ToString(aDate.CustomFormat) = _anime.DateSortie().ToString(aDate.CustomFormat))

        aLien.Text = _anime.Lien()
        aLienModifiable.Text = aLien.Text()

        displayFollowLabel()
        displaySmartLink()

        aCommentaire.Text = _anime.Commentaire()

        aSmartLink.Checked = _anime.SmartLink()
        aFollow.Checked = _anime.Follow()
        aFinish.Checked = _anime.Finished()

        TipLink.SetToolTip(aLien, aLien.Text)
        TipLink.SetToolTip(aLienModifiable, aLienModifiable.Text)
        TipLink.SetToolTip(aTitle, aTitle.Text)

        updateDisplay()

    End Sub
    Private Sub updateDisplay()

        aTitle.ReadOnly = Not onUpdate
        aTitle.Cursor = IIf(onUpdate, Cursors.IBeam, Cursors.Default)

        lbEpisode.Text = IIf(onUpdate, "* Episode :", "Epsiode :")
        aEpisode.Enabled = onUpdate
        aEpisode.Cursor = IIf(onUpdate, Cursors.IBeam, Cursors.Default)
        aRank.Enabled = onUpdate

        aFilter.Active = onUpdate

        lbDate.Text = IIf(onUpdate, "* Date de sortie de la série :", "Date de sortie de la série :")
        aDate.Enabled = onUpdate

        lbLien.Text = IIf(onUpdate, "* Lien :", "Lien :")
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

        aDimiss.Visible = onUpdate

        aNext.Visible = Not onUpdate
        aSupprimer.Visible = Not onUpdate
        aCloturer.Visible = Not onUpdate

        If aFinish.Checked Then
            aCloturer.Image = My.Resources.ic_unclose
            tip.SetToolTip(aCloturer, "Faire passer la série de l'état fini à l'état en cours")
        Else
            aCloturer.Image = My.Resources.ic_close
            tip.SetToolTip(aCloturer, "Faire passer la série de l'état en cours à l'état fini")
        End If

        If onUpdate Then
            aModifier.Image = My.Resources.ic_editok
            tip.SetToolTip(aModifier, "Valider")
        Else
            aModifier.Image = My.Resources.ic_edit
            tip.SetToolTip(aModifier, "Modifier")
        End If

    End Sub
    Private Sub displayPicture(name As String)

        Dim pictPath As String
        Dim pictFound As Boolean = False
        Dim exts() As String = {".jpg", ".png", ".bmp"}
        Dim formalizedName As String = ""

        formalizedName = name.Replace(":", "") _
                             .Replace("\", "") _
                             .Replace("/", "") _
                             .Replace("*", "") _
                             .Replace("?", "") _
                             .Replace(">", "") _
                             .Replace("<", "") _
                             .Replace("|", "") _
                             .Replace(Chr(34), "") ' guillemet

        pictPath = Application.StartupPath & "\PICTURES\" & formalizedName
        For Each ext In exts
            If (System.IO.File.Exists(pictPath & ext)) Then
                pictPath = pictPath & ext
                pictFound = True
                Exit For
            End If
        Next

        If (pictFound) Then
            Dim pic As FileStream = New FileStream(pictPath, FileMode.Open)
            aPicture.Image = Image.FromStream(pic)
            pic.Close()
            pic.Dispose()
        Else
            aPicture.Image = My.Resources.defaultPic
            'TODO: lancer recherche d'image sur serveur avec le nom de l'animé
        End If

    End Sub
    Private Sub displayFollowLabel()
        If _anime.Follow() Then
            aFollowLabel.Text = createFollowMessage()
        End If
    End Sub
    Private Sub displaySmartLink()
        If _anime.SmartLink() Then
            aLien.Text = createSmartLinkMessage()
        End If
    End Sub
#End Region

#Region " Functions "
    Private Function createFollowMessage() As String

        Dim ret As String
        Dim dateNow As Date = Now.Date
        Dim dateCmp As Date = _anime.DateSortie()
        Dim diff As Integer = DateDiff(DateInterval.Day, dateCmp, dateNow, FirstDayOfWeek.Monday) 'Date de sortie de l'animé - Date actuelle
        Dim ep As Integer = _anime.Episode()
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

        Dim link As String = _anime.Lien()

        Dim localRegex As New System.Text.RegularExpressions.Regex("^[A-Z]:\\")
        Dim dirPath As String = IO.Path.GetDirectoryName(link)
        Dim filePath As String = IO.Path.GetFileName(link)

        If checkPath(filePath, "001") Then
            filePath = filePath.Replace("001", normalize(3, _anime.Episode()))
        ElseIf checkPath(filePath, "01") Then
            filePath = filePath.Replace("01", normalize(2, _anime.Episode()))
        ElseIf link.Contains("episode-") Then

            Dim epIndex As Integer, i As Integer
            Dim newLink As String

            newLink = ""
            epIndex = link.LastIndexOf("episode-") + 7

            For i = 0 To epIndex
                newLink += link(i)
            Next

            newLink += "" & Me._anime.Episode()
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
    Private Function normalizeName(ByVal name As String) As String

        Dim formalizedName As String = ""

        formalizedName = name.Replace(":", "").Replace("\", "").Replace("/", "").Replace("*", "").Replace("?", "") _
                                     .Replace(">", "").Replace("<", "").Replace("|", "").Replace(Chr(34), "")

        Return formalizedName

    End Function
#End Region

#Region " Validating constraint function "
    Private titleTemp As String
    Private Function validateTextbox(sender As TextBox) As Boolean

        Dim ret As Boolean = True

        If (sender.TextLength > 0) Then

            sender.BackColor = Color.FromName("Control")

            If (sender.Equals(aEpisode)) Then
                If Not IsNumeric(sender.Text) Then
                    sender.BackColor = Color.FromArgb(200, 25, 25)
                    ret = False
                End If
            ElseIf (sender.Equals(aTitle)) Then
                If V2_GUI.isNameExist(aTitle.Text) And titleTemp <> "" And aTitle.Text <> titleTemp Then
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
#End Region

#Region " Handler "
    Private aChanged As Boolean = False
    Private picChanged As Boolean = False
    Private genreTemp As String = ""
    Private Sub aReturn_Click(sender As Object, e As EventArgs) Handles aReturn.Click

        Me.Visible = False

        If (picChanged And Not aChanged) Then RaiseEvent PictureUpdated()
        If (aChanged) Then RaiseEvent AnimeUpdated(_anime)
        'Me.Refresh()

        Me.Parent.Controls.Remove(Me)
        Dispose()

    End Sub
    Private Sub next_Click(sender As Object, e As EventArgs) Handles aNext.Click

        Dim row As DataRow = V2_GUI.data.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)

        _anime.nextEpisode()
        Try

            row.BeginEdit()
            row(4) = _anime.Episode()
            row.EndEdit()

            If (row.RowState = DataRowState.Modified) Then aChanged = True
            Console.WriteLine("Id: {0}" & vbTab & "FirstName: {1}" & vbTab & "RowState: {2}", row(0).ToString(), row(1).ToString(), row.RowState.ToString())

        Catch ex As Exception
            Console.WriteLine("Next: " & ex.Message)
        End Try
        display()

    End Sub
    Private Sub aModifier_Click(sender As Object, e As EventArgs) Handles aModifier.Click

        If onUpdate Then

            ' On verifie que les box sont valide
            For Each item In {aTitle, aEpisode, aLienModifiable}
                If Not validateTextbox(item) Then Exit Sub
            Next

            Dim _animeUpdated As Anime = New Anime(
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

            If (Not _anime.Equals(_animeUpdated)) Then

                Dim row As DataRow = V2_GUI.data.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)

                Try

                    row.BeginEdit()
                    If Not _anime.Nom().Equals(_animeUpdated.Nom()) Then

                        For Each ext As String In {".png", ".jpg", ".bmp"}

                            Dim currPath As String = Application.StartupPath & "\PICTURES\" & _anime.Nom() & ext
                            Dim destPath As String = Application.StartupPath & "\PICTURES\" & _animeUpdated.Nom() & ext

                            If Not System.IO.File.Exists(currPath) Then Continue For
                            If System.IO.File.Exists(destPath) Then System.IO.File.Delete(destPath)
                            My.Computer.FileSystem.RenameFile(currPath, _animeUpdated.Nom() & ext)

                        Next
                        _anime.Nom = _animeUpdated.Nom()
                        displayPicture(_anime.Nom())
                        row(1) = _anime.Nom()

                    End If
                    If Not _anime.Episode().Equals(_animeUpdated.Episode()) Then
                        _anime.Episode = _animeUpdated.Episode()
                        row(4) = _anime.Episode()
                    End If
                    If Not _anime.Note().Equals(_animeUpdated.Note()) Then
                        _anime.Note = _animeUpdated.Note()
                        row(6) = _anime.Note()
                    End If
                    If Not _anime.Genre().Equals(_animeUpdated.Genre()) Then
                        _anime.Genre = _animeUpdated.Genre()
                        row(3) = _anime.Genre()
                    End If
                    If Not _anime.DateSortie().Equals(_animeUpdated.DateSortie()) Then
                        _anime.DateSortie = _animeUpdated.DateSortie()
                        row(5) = _anime.DateSortie().ToString(Anime.FORMAT)
                    End If
                    If Not _anime.Lien().Equals(_animeUpdated.Lien()) Then
                        _anime.Lien = _animeUpdated.Lien()
                        aLien.Text = _animeUpdated.Lien()
                        row(2) = _anime.Lien()
                    End If
                    If Not _anime.Commentaire().Equals(_animeUpdated.Commentaire()) Then
                        _anime.Commentaire = _animeUpdated.Commentaire()
                        row(9) = _anime.Commentaire()
                    End If
                    If Not _anime.SmartLink().Equals(_animeUpdated.SmartLink()) Then
                        _anime.SmartLink = _animeUpdated.SmartLink()
                        row(8) = If(_anime.SmartLink(), "1", "0")
                    End If
                    If Not _anime.Follow().Equals(_animeUpdated.Follow()) Then
                        _anime.Follow = _animeUpdated.Follow()
                        row(7) = If(_anime.Follow(), "1", "0")
                    End If
                    If Not _anime.Finished().Equals(_animeUpdated.Finished()) Then
                        _anime.Finished = _animeUpdated.Finished()
                        row(10) = If(_anime.Finished(), "1", "0")
                    End If
                    row.EndEdit()

                    If (row.RowState = DataRowState.Modified) Then aChanged = True
                    Console.WriteLine("Id: {0}" & vbTab & "FirstName: {1}" & vbTab & "RowState: {2}", row(0).ToString(), row(1).ToString(), row.RowState.ToString())

                Catch ex As Exception
                    Console.WriteLine("Edit: " & ex.Message)
                End Try

            End If

        Else
            titleTemp = aTitle.Text
            genreTemp = aFilter.getActiveItem()
        End If

        onUpdate = Not onUpdate
        display()

    End Sub
    Private Sub aDimiss_Click(sender As Object, e As EventArgs) Handles aDimiss.Click

        aFilter.fillItemList(genreTemp, ";")
        onUpdate = Not onUpdate
        display()

    End Sub
    Private Sub form_TextChanged(sender As Object, e As EventArgs) Handles aTitle.TextChanged, aEpisode.TextChanged, aLienModifiable.TextChanged
        aModifier.Enabled = validateTextbox(sender)
    End Sub
    Private Sub aSmartLink_CheckedChanged(sender As Object, e As EventArgs)
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
    Private Sub aSupprimer_Click(sender As Object, e As EventArgs) Handles aSupprimer.Click

        Dim resp As MsgBoxResult
        resp = MsgBox("La suppression sera définitive, voulez-vous continuer ?", vbYesNo, "Suppression")
        If (resp = MsgBoxResult.Yes) Then

            Dim row As DataRow = V2_GUI.data.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)

            Try

                row.BeginEdit()
                row.Delete()
                row.EndEdit()

                If (row.RowState = DataRowState.Deleted) Then aChanged = True
                Console.WriteLine("Id: {0}" & vbTab & "FirstName: {1}" & vbTab & "RowState: {2}", row(0).ToString(), row(1).ToString(), row.RowState.ToString())

            Catch ex As Exception
                Console.WriteLine("Supprmier: " & ex.Message)
            End Try

            aReturn_Click(sender, e)

        End If

    End Sub
    Private Sub aCloturer_Click(sender As Object, e As EventArgs) Handles aCloturer.Click

        _anime.Finished = Not _anime.Finished()
        aFinish.Checked = _anime.Finished()

        Dim row As DataRow = V2_GUI.data.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)

        Try

            row.BeginEdit()
            row(10) = If(_anime.Finished(), "1", "0")
            row.EndEdit()

            If (row.RowState = DataRowState.Modified) Then aChanged = True
            Console.WriteLine("Id: {0}" & vbTab & "FirstName: {1}" & vbTab & "RowState: {2}", row(0).ToString(), row(1).ToString(), row.RowState.ToString())

        Catch ex As Exception
            Console.WriteLine("Cloturer: " & ex.Message)
        End Try

        If Not _anime.Finished Then
            'aCloturer.Text = "Cloturer"
            aCloturer.Image = My.Resources.ic_close
            'aCloturer.Width = 93
        Else
            'aCloturer.Text = "Décloturer"
            aCloturer.Image = My.Resources.ic_unclose
            'aCloturer.Width = 103
        End If

    End Sub
    Private Sub changePicture_Click(sender As Object, e As EventArgs) Handles changePicture.Click

        Dim dialbox As OpenFileDialog = New OpenFileDialog()
        dialbox.ValidateNames = True
        dialbox.Title = "Changer l'image de la série"
        dialbox.CheckFileExists = True
        dialbox.Multiselect = False
        dialbox.DefaultExt = "png"
        dialbox.Filter = "Fichiers Image (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png"
        dialbox.FilterIndex = 1

        Dim result As DialogResult = dialbox.ShowDialog()

        If result.Equals(DialogResult.Cancel) Then Exit Sub

        Dim EXT_LENGTH As Integer = 4 '.xyz
        Dim dir As String = Application.StartupPath & "\PICTURES\"
        Dim pic As FileStream = New FileStream(dialbox.FileName, FileMode.Open)
        Dim picToSave As Bitmap = Image.FromStream(pic)
        Dim dest As String = dir & normalizeName(_anime.Nom()).ToLowerInvariant() & ".png"

        Console.WriteLine("LOG: dir=" & dir & " exist? " & System.IO.Directory.Exists(dir))

        If Not System.IO.Directory.Exists(dir) Then System.IO.Directory.CreateDirectory(dir)

        Console.WriteLine("LOG: checking file")
        For Each file In System.IO.Directory.GetFiles(dir, normalizeName(_anime.Nom()) & ".*", IO.SearchOption.TopDirectoryOnly)
            Console.WriteLine(file & " => deleted")
            System.IO.File.Delete(file)
        Next

        picChanged = True
        picToSave.Save(dest)
        Console.WriteLine("LOG: pic saved")

        pic.Close()
        pic.Dispose()

        display()

    End Sub
    Private Sub deletePicture_Click(sender As Object, e As EventArgs) Handles deletePicture.Click

        If aPicture.Image.Equals(My.Resources.defaultPic) Then Exit Sub

        picChanged = True

        Dim dir As String = Application.StartupPath & "\PICTURES\"
        For Each file In System.IO.Directory.GetFiles(dir, normalizeName(_anime.Nom()) & ".*", IO.SearchOption.TopDirectoryOnly)
            System.IO.File.Delete(file)
        Next
        display()

    End Sub
#End Region

End Class
