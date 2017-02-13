Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public MustInherit Class AnimePanel
    Inherits BasePanel

    Public dataSet As DataSet
    Public dataView As New DataView

    Public _animeList As ComboBox
    Private _nom As GroupBox
    Private _lien As LinkLabel
    Private _episode As Label, _genre As Label, _date As Label
    Private _note As Label, _commentaire As Label, _follow As Label
    Private _add As Button, _share As Button

    Public Sub New(form As Form)

        MyBase.New(form)

        Me.Width = BasePanel.MY_WIDTH
        Me.Height = BasePanel.MY_HEIGHT

        setMenuEditionEnabled(False)
        buildPanel()
        linkPanelFunction()
        setDataView()
        updateList()

    End Sub

#Region "Build function"
    Private Sub buildPanel()

        '
        ' Title
        '
        With MyBase._title
            .Location = New Point(80, 5)
            .Text = "Archive :"
        End With
        '
        ' Subtitle
        '
        With MyBase._subtitle
            .Text = "animé"
        End With
        '
        ' ComboBox
        '
        Me._animeList = New ComboBox()
        With _animeList
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .FormattingEnabled = True
            .Location = New Point(10, 65)
            .Name = "animeList"
            .Size = New Point(460, 20)
            .TabIndex = 3
        End With
        '
        ' Nom
        '
        Me._nom = New GroupBox()
        With _nom
            .Location = New Point(10, 95)
            .Name = "nom"
            .Size = New Point(460, 180)
            .TabStop = False
            .Text = "#Nom"
            .Visible = False
            .TabIndex = 4
        End With
        '
        ' Lien
        '
        Dim lblLien As Label = New Label()
        With lblLien
            .AutoSize = True
            .Location = New Point(6, 18)
            .Name = "lblLien"
            .Size = New Point(33, 13)
            .Text = "Lien :"
            .TabIndex = 0
        End With
        '
        Me._lien = New LinkLabel()
        With _lien
            .AutoEllipsis = True
            .ContextMenuStrip = Main.urlClick
            .LinkBehavior = LinkBehavior.HoverUnderline
            .Location = New Point(40, 19)
            .Name = "lien"
            .Size = New Point(410, 13)
            .TabStop = True
            .Text = "http://..."
            .UseCompatibleTextRendering = True
            .TabIndex = 0
        End With
        '
        ' Episode
        '
        Dim lblEpisode As Label = New Label()
        With lblEpisode
            .AutoSize = True
            .Location = New Point(6, 39)
            .Name = "lblEpisode"
            .Size = New Point(33, 13)
            .Text = "Episode :"
            .TabIndex = 0
        End With
        '
        Me._episode = New Label()
        With _episode
            .AutoSize = True
            .Location = New Point(54, 39)
            .Name = "episode"
            .Size = New Point(31, 13)
            .Text = "1"
            .TabIndex = 0
        End With
        '
        ' Add
        '
        Me._add = New Button
        With _add
            .Location = New Point(90, 36)
            .Name = "nextEp"
            .Size = New Point(20, 20)
            .Text = "+"
            .UseVisualStyleBackColor = True
            .TabIndex = 0
        End With
        '
        ' Share
        '
        Me._share = New Button()
        With _share
            .Location = New Point(402, 37)
            .Name = "share"
            .Size = New Point(53, 21)
            .Text = "Share"
            .UseVisualStyleBackColor = True
            .Visible = True
            .TabIndex = 0
        End With
        '
        ' Follow
        '
        Me._follow = New Label()
        With _follow
            .AutoSize = True
            .Location = New Point(127, 39)
            .Name = "follow"
            .Size = New Point(75, 13)
            .Text = ""
            .TabIndex = 0
        End With
        '
        ' About
        '
        Dim about As GroupBox = New GroupBox()
        With about
            .Location = New Point(6, 57)
            .Name = "about"
            .Size = New Point(448, 118)
            .TabStop = False
            .Text = "A propos :"
            .TabIndex = 0
        End With
        '
        ' Genre
        '
        Dim lblGenre As Label = New Label()
        With lblGenre

            .AutoSize = True
            .Location = New Point(6, 18)
            .Name = "lblGenre"
            .Size = New Point(42, 13)
            .Text = "Genre :"
            .TabIndex = 0
        End With
        '
        Me._genre = New Label()
        With _genre
            .AutoEllipsis = True
            .Location = New Point(49, 18)
            .Name = "genre"
            .Size = New Point(395, 13)
            .Text = "Action Mecha ..."
            .TabIndex = 0
        End With
        '
        ' Date
        '
        Dim lblDate As Label = New Label()
        With lblDate
            .AutoSize = True
            .Location = New Point(6, 35)
            .Name = "lblDate"
            .Size = New Point(42, 13)
            .Text = "Date sortie :"
            .TabIndex = 0
        End With
        '
        Me._date = New Label()
        With _date
            .AutoSize = True
            .Location = New Point(70, 35)
            .Name = "date"
            .Size = New Point(31, 13)
            .Text = "09/07/2015"
            .TabIndex = 0
        End With
        '
        ' Note
        '
        Dim lblNote As Label = New Label()
        With lblNote
            .AutoSize = True
            .Location = New Point(6, 52)
            .Name = "lblNote"
            .Size = New Point(42, 13)
            .Text = "Note :"
            .TabIndex = 0
        End With
        '
        Me._note = New Label()
        With _note
            .AutoSize = True
            .Location = New Point(42, 52)
            .Name = "note"
            .Size = New Point(24, 13)
            .Text = "5/5"
            .TabIndex = 0
        End With
        '
        ' Commentaire
        '
        Dim lblCommentaire As Label = New Label()
        With lblCommentaire
            .AutoSize = True
            .Location = New Point(6, 69)
            .Name = "lblCommentaire"
            .Size = New Point(74, 13)
            .Text = "Commentaire :"
            .TabIndex = 0
        End With
        '
        Me._commentaire = New Label()
        With _commentaire
            .AutoEllipsis = True
            .Location = New Point(79, 69)
            .Name = "commentaire"
            .Size = New Point(365, 45)
            .Text = "Mon commentaire !"
            .TabIndex = 0
        End With

        Me._nom.Controls.Add(Me._lien)
        Me._nom.Controls.Add(lblLien)
        Me._nom.Controls.Add(Me._episode)
        Me._nom.Controls.Add(lblEpisode)
        Me._nom.Controls.Add(Me._add)
        Me._nom.Controls.Add(Me._share)
        Me._nom.Controls.Add(Me._follow)
        Me._nom.Controls.Add(about)
        about.Controls.Add(Me._genre)
        about.Controls.Add(lblGenre)
        about.Controls.Add(Me._date)
        about.Controls.Add(lblDate)
        about.Controls.Add(Me._note)
        about.Controls.Add(lblNote)
        about.Controls.Add(Me._commentaire)
        about.Controls.Add(lblCommentaire)
        Me.Controls.Add(_animeList)
        Me.Controls.Add(_nom)

    End Sub
    Private Sub linkPanelFunction()

        AddHandler Main.urlCopy.Click, AddressOf _copyClick
        AddHandler Me._lien.LinkClicked, AddressOf _lienClick
        AddHandler Me._animeList.SelectedIndexChanged, AddressOf _listSelectedIndexChanged
        AddHandler Me._animeList.Validated, AddressOf _listValidated
        AddHandler Me._share.Click, AddressOf _shareClick
        AddHandler Me._add.Click, AddressOf _nextEpsiodeClick

    End Sub
#End Region

#Region "Methode"
    Protected MustOverride Sub setDataView()
    Private Sub updateList()

        For Each line As DataRowView In dataView
            _animeList.Items.Add(line("Nom"))
        Next

    End Sub
    Private Sub updateInfo()

        Me._anime = New Anime(dataView.Item(_animeList.SelectedIndex)("Nom"),
                              dataView.Item(_animeList.SelectedIndex)("Url"),
                              Integer.Parse(dataView.Item(_animeList.SelectedIndex)("Episode")),
                              dataView.Item(_animeList.SelectedIndex)("Date"),
                              dataView.Item(_animeList.SelectedIndex)("Genre"),
                              dataView.Item(_animeList.SelectedIndex)("Commentaire"),
                              Integer.Parse(dataView.Item(_animeList.SelectedIndex)("Note")),
                              If(dataView.Item(_animeList.SelectedIndex)("Follow") = "1", True),
                              If(dataView.Item(_animeList.SelectedIndex)("SmartLink") = "1", True),
                              If(dataView.Item(_animeList.SelectedIndex)("Fini") = "1", True))

        _nom.Text = Me._anime.Nom()
        _lien.Text = smartLink()
        _episode.Text = Me._anime.Episode().ToString()
        _follow.Text = follow()
        _genre.Text = Me._anime.Genre()
        _date.Text = Me._anime.DateSortie().ToString(Anime.FORMAT)
        _note.Text = Me._anime.Note() & "/5"
        _commentaire.Text = Me._anime.Commentaire()

    End Sub
    Public Shared Sub setMenuEditionEnabled(Optional value As Boolean = False)

        If (value) Then
            Main.modifier.Enabled = True
            Main.supprimer.Enabled = True
            Main.cloturer.Enabled = True
        Else
            Main.modifier.Enabled = False
            Main.supprimer.Enabled = False
            Main.cloturer.Enabled = False
        End If

    End Sub
    Private Function smartLink() As String

        Dim link As String = Me._anime.Lien()

        If (Me._anime.SmartLink()) Then

            Dim localRegex As New Regex("^[A-Z]:\\")
            Dim dirPath As String = IO.Path.GetDirectoryName(link)
            Dim filePath As String = IO.Path.GetFileName(link)

            If checkPath(filePath, "001") Then
                filePath = filePath.Replace("001", normalize(3, Me._anime.Episode()))
            ElseIf checkPath(filePath, "01") Then
                filePath = filePath.Replace("01", normalize(2, Me._anime.Episode()))
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
            Else
                link = dirPath.Replace(":\", "://").Replace("\", "/") + "/" + filePath
            End If

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
    Private Function follow() As String

        Dim ret As String = ""

        If _anime.Follow() Then

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

        End If

        Return ret

    End Function
#End Region

#Region "Handler"
    Private Sub _lienClick(sender As Object, e As LinkLabelLinkClickedEventArgs)

        If (e.Button = Windows.Forms.MouseButtons.Left) Then

            Dim url As String
            Dim localRegex As New Regex("^[A-Z]:\\")
            Dim webRegex As New Regex("^http://")

            'If Me._lien.Text.Contains("http://") Or Me._lien.Text.Contains(":\") Then 'C'est un url vers le web ou local
            If webRegex.IsMatch(Me._lien.Text) Or localRegex.IsMatch(Me._lien.Text) Then
                url = Me._lien.Text
            Else 'Par défaut on considère que c'est un url vers le web
                url = "http://" & Me._lien.Text
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
    Private Sub _copyClick(sender As Object, e As EventArgs)
        Clipboard.SetText(Me._lien.Text)
    End Sub
    Private Sub _listSelectedIndexChanged(sender As Object, e As EventArgs)

        Parent.Size = New Point(495, 345)
        _nom.Visible = True
        updateInfo()
        setMenuEditionEnabled(True)

    End Sub
    Private Sub _listValidated(sender As Object, e As EventArgs)
        Me._animeList.SelectedIndex = Me._animeList.FindString(Me._animeList.Text)
    End Sub
    Private Sub _shareClick(sender As Object, e As EventArgs)

        Dim sfd As SaveFileDialog = Main.sfd
        sfd.Title() = "Exportation de l'animé"
        sfd.FileName() = Me._anime.Nom()

        If (sfd.ShowDialog() = DialogResult.OK) Then

            Try
                Main.writeFile(sfd.FileName, Me._anime.fileFullSerialize())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
    Private Sub _nextEpsiodeClick(sender As Object, e As EventArgs)

        Dim row As DataRow = Main.dataSet.Tables("data").Select("Nom = '" & Me._anime.Nom() & "'")(0)
        Me._anime.nextEpisode()

        row.BeginEdit()
        row(4) = Me._anime.Episode()
        row.EndEdit()

        Main.loadMenu(Me._anime)

    End Sub
#End Region

End Class
