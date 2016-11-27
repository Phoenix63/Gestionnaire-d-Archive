Public Class Anime

    ' Necessary
    Private _nom As String
    Private _lien As String
    Private _episode As Integer
    Private _date As Date
    ' Optionnal
    Private _genre As String
    Private _commentaire As String
    Private _note As Integer
    Private _follow As Boolean
    Private _smartLink As Boolean
    Private _finished As Boolean
    ' Constant
    Public Const MODE_UPDATE As String = "UPDATE"
    Public Const MODE_INSERT As String = "INSERT"
    Public Const FORMAT As String = "d/M/yyyy"
    Public Const SEPARATOR As String = "=#~GA~#="

#Region "Constructor"
    Public Sub New(ByVal nom As String, ByVal lien As String, ByVal episode As Integer, ByVal mDate As Date,
                   Optional genre As String = "", Optional commentaire As String = "", Optional note As Integer = 0,
                   Optional follow As Boolean = False, Optional smartLink As Boolean = False, Optional finished As Boolean = False)

        Me._nom = nom
        Me._lien = lien
        Me._episode = episode
        Me._date = mDate
        Me._genre = genre
        Me._commentaire = commentaire
        Me._note = note
        Me._follow = follow
        Me._smartLink = smartLink
        Me._finished = finished

    End Sub
#End Region

#Region "Getter"
    Public Function getNom() As String
        Return Me._nom
    End Function
    Public Function getLien() As String
        Return Me._lien
    End Function
    Public Function getEpisode() As Integer
        Return Me._episode
    End Function
    Public Function getDate() As Date
        Return Me._date
    End Function
    Public Function getGenre() As String
        Return Me._genre
    End Function
    Public Function getCommentaire() As String
        Return Me._commentaire
    End Function
    Public Function getNote() As Integer
        Return Me._note
    End Function
    Public Function getFollow() As Boolean
        Return Me._follow
    End Function
    Public Function getSmartLink() As Boolean
        Return Me._smartLink
    End Function
    Public Function getFinished() As Boolean
        Return Me._finished
    End Function
#End Region

#Region "Setter"
    Public Sub setEpisode(ByVal value As Integer)
        Me._episode = value
    End Sub
#End Region

#Region "Methode"

#Region "Sql Methode"
    Public Function sqlSerialize(ByVal mode As String, ByVal datatable As String) As String

        ' Return the sql query for database's name
        Select Case (mode)
            Case Anime.MODE_INSERT
                Return "INSERT INTO " & datatable & " " & sqlSerializeInsert()
            Case Anime.MODE_UPDATE
                Return sqlSerializeUpdate()
            Case Else
                Return ""
        End Select

    End Function
    Private Function sqlSerializeInsert() As String

        Return "(Nom, Url, Genre, Episode, Date, Note, Follow, SmartLink, Commentaire, Fini) VALUES ('" & _
                                getNom() & "', '" & _
                                getLien() & "', '" & _
                                getGenre() & "', '" & _
                                getEpisode() & "', '" & _
                                getDate().ToString(Anime.FORMAT) & "', '" & _
                                getNote() & "', '" & _
                                If(getFinished(), 0, If(getFollow(), 1, 0)) & "', '" & _
                                If(getSmartLink(), 1, 0) & "', '" & _
                                getCommentaire().Replace("'", "''") & "', '" & _
                                If(getFinished(), 1, 0) & "')"

    End Function
    Private Function sqlSerializeUpdate() As String

        Return "Nom = '" & getNom() & "', " & _
                "Url = '" & getLien() & "', " & _
                "Genre = '" & getGenre() & "', " & _
                "Episode = '" & getEpisode() & "', " & _
                "Date = '" & getDate().ToString(Anime.FORMAT) & "', " & _
                "Note = '" & getNote() & "', " & _
                "Follow = '" & If(getFinished(), 0, If(getFollow(), 1, 0)) & "', " & _
                "SmartLink = '" & If(getFinished(), 0, If(getSmartLink(), 1, 0)) & "', " & _
                "Commentaire = '" & getCommentaire().Replace("'", "''") & "', " & _
                "Fini = '" & If(getFinished(), 1, 0) & "' " & _
                "WHERE Nom = '" & getNom() & "'"

    End Function
#End Region

#Region "File Methode"
    Public Function fileSerialize() As String

        '
        ' Serialize the class into a string parsable by fileDeserialize() methode
        '

        Return "Nom" & SEPARATOR & getNom() & vbCrLf _
             & "Lien" & SEPARATOR & getLien() & vbCrLf _
             & "Episode" & SEPARATOR & getEpisode() & vbCrLf _
             & "Date" & SEPARATOR & getDate().ToString(Anime.FORMAT) & vbCrLf _
             & "Genre" & SEPARATOR & getGenre() & vbCrLf _
             & "Commentaire" & SEPARATOR & getCommentaire() & vbCrLf _
             & "Note" & SEPARATOR & getNote()

    End Function
    Public Function fileFullSerialize() As String

        '
        ' Serialize all the class into a string parsable by fileDeserialize() methode
        '

        Return fileSerialize() & vbCrLf _
             & "Follow" & SEPARATOR & getFollow() & vbCrLf _
             & "SmartLink" & SEPARATOR & getSmartLink() & vbCrLf _
             & "Finished" & SEPARATOR & getFinished()

    End Function
    Public Shared Function fileDeserialize(ByVal file As String) As Anime

        '
        ' Return an instance of Anime class from file serialized by fileSerialize() methode
        '

        Dim fileCut As String() = Split(file, vbCrLf)
        Dim extractedFile(fileCut.Length) As String
        Dim i As Integer = 0
        Dim ret As Anime = Nothing

        For Each line In fileCut

            Dim buff As String() = Split(line, SEPARATOR)

            If (buff.Length = 2) Then
                extractedFile(i) = buff(1).Replace(";", "") 'Sql Secure Command
            Else
                Throw New Exception
            End If

            i += 1

        Next

        Select Case i
            Case 4
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3))
                Exit Select
            Case 5
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4))
                Exit Select
            Case 6
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4), extractedFile(5))
                Exit Select
            Case 7
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4), extractedFile(5), Integer.Parse(extractedFile(6)))
                Exit Select
            Case 8
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4), extractedFile(5), Integer.Parse(extractedFile(6)), Boolean.Parse(extractedFile(7)))
                Exit Select
            Case 9
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4), extractedFile(5), Integer.Parse(extractedFile(6)), Boolean.Parse(extractedFile(7)),
                                Boolean.Parse(extractedFile(8)))
                Exit Select
            Case 10
                ret = New Anime(extractedFile(0), extractedFile(1), Integer.Parse(extractedFile(2)), extractedFile(3),
                                extractedFile(4), extractedFile(5), Integer.Parse(extractedFile(6)), Boolean.Parse(extractedFile(7)),
                                Boolean.Parse(extractedFile(8)), Boolean.Parse(extractedFile(9)))
                Exit Select
        End Select

        Return ret

    End Function
#End Region

    Public Sub nextEpisode()
        Me.setEpisode(Me.getEpisode() + 1)
    End Sub
    Public Function toArray() As Object()

        Return {Me.getNom(), Me.getLien(), Me.getGenre(), Me.getEpisode(), Me.getDate().ToString(Anime.FORMAT),
                Me.getNote(), Me.getFollow(), Me.getSmartLink(), Me.getCommentaire(), Me.getFinished()}

    End Function

#End Region

    Public Overloads Function Equals(obj As Anime) As Boolean

        Return Me._nom.Equals(obj.getNom()) And
               Me._lien.Equals(obj.getLien()) And
               Me._episode.Equals(obj.getEpisode()) And
               Me._date.Equals(obj.getDate()) And
               Me._genre.Equals(obj.getGenre()) And
               Me._commentaire.Equals(obj.getCommentaire()) And
               Me._note.Equals(obj.getNote()) And
               Me._follow.Equals(obj.getFollow()) And
               Me._smartLink.Equals(obj.getSmartLink()) And
               Me._finished.Equals(obj.getFinished())

    End Function

End Class
