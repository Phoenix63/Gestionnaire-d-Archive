Imports System.ComponentModel

Public Class StarRanking
    Inherits UserControl

    Private Class Star

        Private _active As Boolean
        Private _pic As PictureBox

        Public Sub New(ByVal n As Integer, Optional ByVal active As Boolean = False)

            _active = active

            _pic = New PictureBox
            With _pic
                .Name = "star"
                .Tag = n
                .Size = New Point(STAR_SIZE, STAR_SIZE)
                .Location = New Point((n - 1) * 35, 0)
                .Cursor = Cursors.Hand
                .BorderStyle = Windows.Forms.BorderStyle.None
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BringToFront()
                .Image = IIf(_active, _activeStar, _inactiveStar)
            End With

        End Sub

        Public Property Active As Boolean
            Get
                Return _active
            End Get
            Set(value As Boolean)
                _active = value
                _pic.Image = IIf(_active, _activeStar, _inactiveStar)
            End Set
        End Property
        Public ReadOnly Property Image As PictureBox
            Get
                Return _pic
            End Get
        End Property

    End Class

    ' Enum
    Private Enum StarRankingState
        Active
        Inactive
    End Enum

    ' Constant
    ' @STAR_SIZE :     picture's size in square pixel
    Private Const STAR_SIZE As UInteger = 35

    ' Variable
    ' @_inactiveStar : image for unselected star
    Private Shared _inactiveStar As Bitmap = New Bitmap(My.Resources.inactivestar)
    ' @_activeStar :   image for selected star
    Private Shared _activeStar As Bitmap = New Bitmap(My.Resources.activestar)
    ' @_rank :         number of selected star
    Private _rank As UInteger = 1
    ' @_lastRank :     last number of selected star before an update
    Private _lastRank As UInteger = 1
    ' @_maxRank :      number of max stars
    Private _maxRank As UInteger = 5
    ' @_starList :     list of star
    Private _starList As List(Of Star) = New List(Of Star)

    ' Outer event
    Public Event rankChanged(value As UInteger)
    ' Inner event
    Private Event updateRank(value As UInteger)
    Private Event updateInactiveStar(value As Bitmap)
    Private Event updateActiveStar(value As Bitmap)

    Public Sub New()

        InitializeComponent()

        Me._starList.Add(New Star(1, True))
        Me._starList.Add(New Star(2))
        Me._starList.Add(New Star(3))
        Me._starList.Add(New Star(4))
        Me._starList.Add(New Star(5))

        Debug.Assert(Me._starList.Count > 0)

        For Each star In Me._starList
            AddHandler star.Image.Click, AddressOf star_Click
            Me.Controls.Add(star.Image)
        Next

        AddHandler updateInactiveStar, AddressOf updateInactiveStarValue
        AddHandler updateActiveStar, AddressOf updateActiveStarValue
        AddHandler updateRank, AddressOf updateRankValue

    End Sub

#Region " Property "
    <Description("Change the rank value, it have to be between 1 and 5.")>
    Public Property Rank() As Integer
        Get
            Return _rank
        End Get
        Set(value As Integer)
            If (value <= _maxRank) Then
                If (value > 0) Then
                    RaiseEvent updateRank(value)
                Else
                    RaiseEvent updateRank(1)
                End If
            ElseIf (_rank <> _maxRank) Then
                RaiseEvent updateRank(_maxRank)
            End If
        End Set
    End Property
    <Description("Change the picture when the stars are inactive.")>
    Public Property InactiveStar() As Bitmap
        Get
            Return _inactiveStar
        End Get
        Set(value As Bitmap)
            RaiseEvent updateInactiveStar(value)
        End Set
    End Property
    <Description("Change the picture when the stars are active.")>
    Public Property ActiveStar() As Bitmap
        Get
            Return _activeStar
        End Get
        Set(value As Bitmap)
            RaiseEvent updateActiveStar(value)
        End Set
    End Property
#End Region

#Region " ClickHandler "
    Private Sub star_Click(sender As Object, e As EventArgs)

        If TypeOf sender Is PictureBox Then
            If CInt(sender.tag) <> _lastRank Then

                RaiseEvent updateRank(CInt(sender.tag))
                RaiseEvent rankChanged(Me._rank)

            End If
        End If

    End Sub
#End Region

#Region " EventHandler "
    Private Sub updateActivePicture()

        Debug.Assert(Me._starList.Count > 0)

        For i = 0 To CInt(Me._rank) - 1

            Me._starList.Item(i).Active = True

        Next

    End Sub
    Private Sub updateInactivePicture()

        Debug.Assert(Me._starList.Count >= CInt(Me._rank))

        For i = CInt(Me._rank) To CInt(Me._maxRank) - 1

            Me._starList.Item(i).Active = False

        Next

    End Sub
    Private Sub updateStarValue(value As Bitmap, state As StarRankingState)

        Select Case state

            Case StarRankingState.Active
                _activeStar = value
                updateActivePicture()

            Case StarRankingState.Inactive
                _inactiveStar = value
                updateInactivePicture()

        End Select

    End Sub
    Private Sub updateInactiveStarValue(value As Bitmap)
        updateStarValue(value, StarRankingState.Inactive)
    End Sub
    Private Sub updateActiveStarValue(value As Bitmap)
        updateStarValue(value, StarRankingState.Active)
    End Sub
    Private Sub updateRankValue(value As UInteger)

        Me._rank = value
        Me._lastRank = value

        updateActivePicture()
        updateInactivePicture()

    End Sub
#End Region

End Class
