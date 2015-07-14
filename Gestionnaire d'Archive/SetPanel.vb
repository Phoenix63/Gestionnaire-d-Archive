Imports System.Text.RegularExpressions

Public Class SetPanel
    Inherits BasePanel

    Public _nom As TextBox, _genre As TextBox
    Public _lien As TextBox, _episode As TextBox
    Public _date As DateTimePicker
    Public _note As NumericUpDown, _commentaire As TextBox
    Public _smartLink As CheckBox, _follow As CheckBox, _finished As CheckBox
    Public _valider As Button, _validerFermer As Button

#Region "Constructor"
    Public Sub New(ByRef form As Form)

        MyBase.New(form)

        Me.Width = BasePanel.MY_WIDTH
        Me.Height = BasePanel.MY_HEIGHT

        buildPanel()
        linkPanelFunction()

    End Sub
#End Region

#Region "Build Function"
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
            .Text = "set"
        End With
        '
        ' Nom
        '
        Dim lblNom As Label = New Label()
        With lblNom
            .AutoSize = True
            .Location = New Point(10, 70)
            .Name = "lblNom"
            .Size = New Point(42, 13)
            .Text = "* Nom :"
            .TabIndex = 15
        End With
        '
        Me._nom = New TextBox()
        With _nom
            .Location = New Point(53, 67)
            .Name = "nom"
            .Size = New Point(250, 20)
            .TabIndex = 3
        End With
        '
        ' Genre
        '
        Dim lblGenre As Label = New Label()
        With lblGenre
            .AutoSize = True
            .Location = New Point(325, 70)
            .Name = "lblGenre"
            .Size = New Point(42, 13)
            .Text = "Genre :"
            .TabIndex = 16
        End With
        '
        Me._genre = New TextBox()
        With _genre
            .Location = New Point(368, 67)
            .Name = "genre"
            .Size = New Point(100, 20)
            .TabIndex = 4
        End With
        '
        ' Lien
        '
        Dim lblLien As Label = New Label()
        With lblLien
            .AutoSize = True
            .Location = New Point(10, 105)
            .Name = "lblLien"
            .Size = New Point(42, 13)
            .Text = "* Lien :"
            .TabIndex = 17
        End With
        '
        Me._lien = New TextBox()
        With _lien
            .Location = New Point(53, 102)
            .Name = "lien"
            .Size = New Point(250, 20)
            .TabIndex = 5
        End With
        '
        ' Episode
        '
        Dim lblEpisode As Label = New Label()
        With lblEpisode
            .AutoSize = True
            .Location = New Point(317, 105)
            .Name = "lblEpisode"
            .Size = New Point(42, 13)
            .Text = "* Episode :"
            .TabIndex = 18
        End With
        '
        Me._episode = New TextBox()
        With _episode
            .Location = New Point(375, 102)
            .Name = "episode"
            .Size = New Point(93, 20)
            .TabIndex = 6
        End With
        '
        ' Date
        '
        Dim lblDate As Label = New Label()
        With lblDate
            .AutoSize = True
            .Location = New Point(10, 140)
            .Name = "lblDate"
            .Size = New Point(42, 13)
            .Text = "* Date :"
            .TabIndex = 19
        End With
        '
        Me._date = New DateTimePicker()
        With _date
            .CustomFormat = ""
            .Format = DateTimePickerFormat.Custom
            .Location = New Point(53, 137)
            .Name = "date"
            .Size = New Point(250, 20)
            .TabIndex = 7
            .Value = Date.Now
        End With
        '
        ' Note
        '
        Dim lblNote As Label = New Label()
        With lblNote
            .AutoSize = True
            .Location = New Point(325, 140)
            .Name = "lblNote"
            .Size = New Point(42, 13)
            .Text = "Note :"
            .TabIndex = 20
        End With
        '
        Me._note = New NumericUpDown()
        With _note
            .Location = New Point(375, 137)
            .Name = "note"
            .RightToLeft = Windows.Forms.RightToLeft.No
            .Size = New Point(35, 20)
            .TabIndex = 8
            .TextAlign = HorizontalAlignment.Center
            .UpDownAlign = LeftRightAlignment.Left
            .Maximum = 5
        End With
        '
        Dim sep As Label = New Label
        With sep
            .AutoSize = True
            .Location = New Point(415, 140)
            .Name = "sep"
            .Size = New Point(42, 13)
            .Text = "/"
            .TabIndex = 21
        End With
        '
        Dim tmp As TextBox = New TextBox()
        With tmp
            .Location = New Point(430, 137)
            .Name = "tmp"
            .Size = New Point(37, 20)
            .Text = "5"
            .Enabled = False
            .TabIndex = 9
        End With
        '
        ' Commentaire
        '
        Dim lblCommentaire As Label = New Label()
        With lblCommentaire
            .AutoSize = True
            .Location = New Point(17, 175)
            .Name = "lblCommentaire"
            .Size = New Point(75, 13)
            .Text = "Commentaire :"
            .TabIndex = 22
        End With
        '
        Me._commentaire = New TextBox()
        With _commentaire
            .Location = New Point(92, 172)
            .Multiline = True
            .Name = "commentaire"
            .Size = New Point(375, 60)
            .TabIndex = 10
        End With
        '
        ' SmartLink
        '
        Me._smartLink = New CheckBox()
        With _smartLink
            .AutoSize = True
            .Location = New Point(15, 250)
            .Name = "smartLink"
            .Size = New Point(93, 17)
            .Text = "Lien intelligent"
            .UseVisualStyleBackColor = True
            .TabIndex = 11
        End With
        '
        ' Follow
        '
        Me._follow = New CheckBox()
        With _follow
            .AutoSize = True
            .Location = New Point(115, 250)
            .Name = "follow"
            .Size = New Point(134, 17)
            .Text = "Suivre chaque semaine"
            .UseVisualStyleBackColor = True
            .TabIndex = 12
        End With
        '
        ' SmartLink
        '
        Me._finished = New CheckBox()
        With _finished
            .AutoSize = True
            .Location = New Point(255, 250)
            .Name = "finished"
            .Size = New Point(64, 17)
            .Text = "Terminé"
            .UseVisualStyleBackColor = True
            .TabIndex = 12
        End With
        '
        ' Valider
        '
        Me._valider = New Button()
        With _valider
            .Location = New Point(323, 247)
            .Name = "valider"
            .Size = New Point(47, 23)
            .Text = "Valider"
            .UseVisualStyleBackColor = True
            .TabIndex = 13
        End With
        '
        ' Valider & Fermer
        '
        Me._validerFermer = New Button()
        With _validerFermer
            .Location = New Point(373, 247)
            .Name = "validerFermer"
            .Size = New Point(95, 23)
            .Text = "Valider et Fermer"
            .UseVisualStyleBackColor = True
            .TabIndex = 14
        End With

        Me.Controls.Add(Me._nom)
        Me.Controls.Add(lblNom)
        Me.Controls.Add(Me._genre)
        Me.Controls.Add(lblGenre)
        Me.Controls.Add(Me._lien)
        Me.Controls.Add(lblLien)
        Me.Controls.Add(Me._episode)
        Me.Controls.Add(lblEpisode)
        Me.Controls.Add(Me._date)
        Me.Controls.Add(lblDate)
        Me.Controls.Add(Me._note)
        Me.Controls.Add(lblNote)
        Me.Controls.Add(sep)
        Me.Controls.Add(tmp)
        Me.Controls.Add(Me._commentaire)
        Me.Controls.Add(lblCommentaire)
        Me.Controls.Add(Me._smartLink)
        Me.Controls.Add(Me._follow)
        Me.Controls.Add(Me._finished)
        Me.Controls.Add(Me._valider)
        Me.Controls.Add(Me._validerFermer)

    End Sub
    Private Sub linkPanelFunction()

        AddHandler Me._nom.TextChanged, AddressOf _textChanged
        AddHandler Me._lien.TextChanged, AddressOf _textChanged
        AddHandler Me._episode.TextChanged, AddressOf _textChanged
        AddHandler Me._valider.Click, AddressOf _click
        AddHandler Me._validerFermer.Click, AddressOf _click
        AddHandler Me._smartLink.CheckedChanged, AddressOf _smartLinkCheckedChanged

    End Sub
#End Region

#Region "Handler"
    Private Sub _textChanged(sender As Object, e As EventArgs)

        If TypeOf sender Is TextBox Then

            If sender.Equals(Me._episode) Then
                sender.BackColor = If(isNumber(sender.text) And sender.text <> "", Color.White, Color.Red)
            Else
                sender.BackColor = If(sender.text.length > 0, Color.White, Color.Red)
            End If

        End If

    End Sub
    Protected Overridable Sub _click(sender As Object, e As EventArgs)

        If (_checkNecessaryEntries()) Then
            clearEntries()
            If sender.Equals(Me._validerFermer) Then
                Me.Parent().Size = New Point(495, 150)
                Me.Parent().Controls.Remove(Me)
            End If
        End If

    End Sub
    Private Sub _smartLinkCheckedChanged(sender As Object, e As EventArgs)

        If (_checkSmartLink()) Then
            MsgBox("Afin de pouvoir utiliser la reconnaissance de lien de manière intelligente, il est nécessaire que vous mettiez le lien du première épisode." & vbCrLf & vbCrLf & _
                   "Exemple :" & vbCrLf & _
                   "http://monsite.fr/mon-anime" & vbCrLf & _
                   "Doit devenir :" & vbCrLf & _
                   "http://monsite.fr/mon-anime-episode-01" & vbCrLf & _
                   "Si 'mon-anime-episode-01' est le lien de l'épisode 1", MsgBoxStyle.Information, "Information d'utilisation")
        End If

    End Sub
#End Region

#Region "Methode"
    Public Sub clearEntries()

        Me._nom.Clear()
        Me._lien.Clear()
        Me._episode.Clear()
        Me._genre.Clear()
        Me._commentaire.Clear()
        Me._date.Value = Date.Now
        Me._note.Value = 0
        Me._smartLink.Checked = False
        Me._follow.Checked = False
        Me._finished.Checked = False

        Me._nom.BackColor = Color.White
        Me._lien.BackColor = Color.White
        Me._episode.BackColor = Color.White

    End Sub
    Public Function getInfo() As Anime

        Return New Anime(Me._nom.Text.Replace(";", ""),
                         Me._lien.Text.Replace(";", ""),
                         Integer.Parse(Me._episode.Text),
                         Me._date.Value,
                         Me._genre.Text.Replace(";", ""),
                         Me._commentaire.Text.Replace(";", ""),
                         Me._note.Value,
                         Me._follow.Checked,
                         Me._smartLink.Checked,
                         Me._finished.Checked)

    End Function
    Public Overridable Function _checkNecessaryEntries() As Boolean

        Dim checkList() As Object = {Me._nom, Me._lien, Me._episode}
        Dim ret As Boolean = True

        For Each e In checkList
            _textChanged(e, Nothing)
            If e.BackColor.Equals(Color.Red) Then ret = False
        Next

        Return ret

    End Function
    Public Overridable Function _checkSmartLink() As Boolean
        Return Me._smartLink.Checked
    End Function
#End Region

#Region "Function"
    Public Shared Function isNumber(ByVal str As String) As Boolean

        Dim regex As Regex = New Regex("^\d*$")
        Return regex.IsMatch(str)

    End Function
#End Region

End Class
