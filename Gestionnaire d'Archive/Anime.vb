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
    Public Sub New(ByVal dbRow As DataRow)

        Me._nom = dbRow("Nom")
        Me._lien = dbRow("Url")
        Me._episode = Integer.Parse(dbRow("Episode"))
        Me._date = dbRow("Date")
        Me._genre = dbRow("Genre")
        Me._commentaire = dbRow("Commentaire")
        Me._note = Integer.Parse(dbRow("Note"))
        Me._follow = If(dbRow("Follow").ToString() = "1", True, False)
        Me._smartLink = If(dbRow("SmartLink").ToString() = "1", True, False)
        Me._finished = If(dbRow("Fini").ToString() = "1", True, False)

    End Sub
#End Region

#Region " Property "
    Public Property Nom() As String
        Get
            Return Me._nom
        End Get
        Set(value As String)
            Me._nom = value
        End Set
    End Property
    Public Property Lien() As String
        Get
            Return Me._lien
        End Get
        Set(value As String)
            Me._lien = value
        End Set
    End Property
    Public Property Episode() As Integer
        Get
            Return Me._episode
        End Get
        Set(value As Integer)
            Me._episode = value
        End Set
    End Property
    Public Property DateSortie() As Date
        Get
            Return Me._date
        End Get
        Set(value As Date)
            Me._date = value
        End Set
    End Property
    Public Property Genre() As String
        Get
            Return Me._genre
        End Get
        Set(value As String)
            Me._genre = value
        End Set
    End Property
    Public Property Commentaire() As String
        Get
            Return Me._commentaire
        End Get
        Set(value As String)
            Me._commentaire = value
        End Set
    End Property
    Public Property Note() As Integer
        Get
            Return Me._note
        End Get
        Set(value As Integer)
            Me._note = value
        End Set
    End Property
    Public Property Follow() As Boolean
        Get
            Return Me._follow
        End Get
        Set(value As Boolean)
            Me._follow = value
        End Set
    End Property
    Public Property SmartLink() As Boolean
        Get
            Return Me._smartLink
        End Get
        Set(value As Boolean)
            Me._smartLink = value
        End Set
    End Property
    Public Property Finished() As Boolean
        Get
            Return Me._finished
        End Get
        Set(value As Boolean)
            Me._finished = value
        End Set
    End Property
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
                                Nom() & "', '" & _
                                Lien() & "', '" & _
                                Genre() & "', '" & _
                                Episode() & "', '" & _
                                DateSortie().ToString(Anime.FORMAT) & "', '" & _
                                Note() & "', '" & _
                                If(Finished(), 0, If(Follow(), 1, 0)) & "', '" & _
                                If(SmartLink(), 1, 0) & "', '" & _
                                Commentaire().Replace("'", "''") & "', '" & _
                                If(Finished(), 1, 0) & "')"

    End Function
    Private Function sqlSerializeUpdate() As String

        Return "Nom = '" & Nom() & "', " & _
                "Url = '" & Lien() & "', " & _
                "Genre = '" & Genre() & "', " & _
                "Episode = '" & Episode() & "', " & _
                "Date = '" & DateSortie().ToString(Anime.FORMAT) & "', " & _
                "Note = '" & Note() & "', " & _
                "Follow = '" & If(Finished(), 0, If(Follow(), 1, 0)) & "', " & _
                "SmartLink = '" & If(Finished(), 0, If(SmartLink(), 1, 0)) & "', " & _
                "Commentaire = '" & Commentaire().Replace("'", "''") & "', " & _
                "Fini = '" & If(Finished(), 1, 0) & "' " & _
                "WHERE Nom = '" & Nom() & "'"

    End Function
#End Region

#Region "File Methode"
    Public Function fileSerialize() As String

        '
        ' Serialize the class into a string parsable by fileDeserialize() methode
        '

        Return "Nom" & SEPARATOR & Nom() & vbCrLf _
             & "Lien" & SEPARATOR & Lien() & vbCrLf _
             & "Episode" & SEPARATOR & Episode() & vbCrLf _
             & "Date" & SEPARATOR & DateSortie().ToString(Anime.FORMAT) & vbCrLf _
             & "Genre" & SEPARATOR & Genre() & vbCrLf _
             & "Commentaire" & SEPARATOR & Commentaire() & vbCrLf _
             & "Note" & SEPARATOR & Note()

    End Function
    Public Function fileFullSerialize() As String

        '
        ' Serialize all the class into a string parsable by fileDeserialize() methode
        '

        Return fileSerialize() & vbCrLf _
             & "Follow" & SEPARATOR & Follow() & vbCrLf _
             & "SmartLink" & SEPARATOR & SmartLink() & vbCrLf _
             & "Finished" & SEPARATOR & Finished()

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
        Me.Episode = Me.Episode() + 1
    End Sub
    Public Function toArray() As Object()

        Return {Me.Nom(), Me.Lien(), Me.Genre(), Me.Episode(), Me.DateSortie().ToString(Anime.FORMAT),
                Me.Note(), Me.Follow(), Me.SmartLink(), Me.Commentaire(), Me.Finished()}

    End Function

#End Region

    Public Overloads Function Equals(obj As Anime) As Boolean

        Return Me._nom.Equals(obj.Nom()) And
               Me._lien.Equals(obj.Lien()) And
               Me._episode.Equals(obj.Episode()) And
               Me._date.Equals(obj.DateSortie()) And
               Me._genre.Equals(obj.Genre()) And
               Me._commentaire.Equals(obj.Commentaire()) And
               Me._note.Equals(obj.Note()) And
               Me._follow.Equals(obj.Follow()) And
               Me._smartLink.Equals(obj.SmartLink()) And
               Me._finished.Equals(obj.Finished())

    End Function

End Class
