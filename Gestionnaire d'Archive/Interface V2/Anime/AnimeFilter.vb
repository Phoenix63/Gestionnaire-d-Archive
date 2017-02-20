Imports System.Collections.Generic
Public Class AnimeFilter
    Inherits UserControl

    Public Shared ReadOnly ITEM_LIST_ENUM As String() = {
        "Action",
        "Amour et Amitié",
        "Aventure",
        "Combats et Arts Martiaux",
        "Comédie",
        "Cyber et Mecha",
        "Drame",
        "Ecchi",
        "Erotique",
        "Enigme et Policier",
        "Fantastique",
        "Fantasy",
        "Historique",
        "Horreur",
        "Magical girls",
        "Mystère",
        "Psychologique",
        "Romance",
        "School Life",
        "Science fiction",
        "Seinen",
        "Shôjo",
        "Shôjo-Ai",
        "Shônen",
        "Slice of Lice",
        "Sport",
        "Surnaturel",
        "Thriller",
        "Yaoi",
        "Yuri"
    }

    Private Class Item
        Inherits Label

        Private _selectable As Boolean = False
        Private _active As Boolean = False
        Private color_active As Color = Color.FromName("ActiveCaption")
        Private color_inactive As Color = Color.FromName("GradientInactiveCaption")

        Public Sub New(ByVal value As String, Optional ByVal active As Boolean = False)

            _active = active

            With Me
                .Text = value
                .Height = 25
                .AutoSize = True
                .Margin = New Padding(3)
                .Padding = New Padding(2)
                .Cursor = IIf(_selectable, Cursors.Hand, Cursors.Default)
                .BackColor = IIf(active, color_active, color_inactive)
                .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                .TextAlign = HorizontalAlignment.Center
            End With

            AddHandler Me.Click, AddressOf filterClick

        End Sub

#Region " Property "
        Public Property Selectable() As Boolean
            Get
                Return _selectable
            End Get
            Set(value As Boolean)

                If _selectable <> value Then
                    _selectable = value
                    If _selectable Then Cursor = Cursors.Hand Else Cursor = Cursors.Default
                End If

            End Set
        End Property
        Public ReadOnly Property Active() As Boolean
            Get
                Return _active
            End Get
        End Property
#End Region

#Region " Handler "
        Private Sub filterClick(sender As Object, e As EventArgs)

            If _selectable Then
                If Not _active Then _active = True Else _active = False
                Me.BackColor = IIf(_active, color_active, color_inactive)
            End If

        End Sub
#End Region     

    End Class

    Private itemList As New List(Of Item)
    Private _active As Boolean = False
    Private Const _separator As String = ";"

    ' Inner Event
    Private Event ActiveChanged(value As Boolean)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.MinimumSize = New Point(MyBase.Width, 54)
        Me.MaximumSize = New Point(0, 54)
        Me.AutoScrollOffset = New Point(0, 25)

    End Sub
    Public Sub New(ByVal gender As String, ByVal separator As String)

        Me.New()
        fillItemList(gender, separator)

    End Sub

#Region " Property "
    Public Property Active() As Boolean
        Get
            Return _active
        End Get
        Set(value As Boolean)
            If (value <> _active) Then RaiseEvent ActiveChanged(value)
        End Set
    End Property
    Public ReadOnly Property Separator() As String
        Get
            Return _separator
        End Get
    End Property
#End Region

#Region " Handler "
    Private Sub activeChange(value As Boolean) Handles Me.ActiveChanged

        _active = value
        showItem()

    End Sub
    Dim scrollPosition As Point = New Point(0, 0)
    Private Sub scrollByWheel(sender As Object, e As MouseEventArgs) Handles fContainer.MouseWheel

        Dim vScrollPosition As Integer
        vScrollPosition = scrollPosition.Y
        vScrollPosition -= Math.Sign(e.Delta) * 25
        vScrollPosition = Math.Max(0, vScrollPosition)
        vScrollPosition = Math.Min(vScrollPosition, sender.DisplayRectangle.Height - sender.Height)
        scrollPosition.Y = vScrollPosition

        sender.AutoScrollPosition = New Point(sender.AutoScrollPosition.X, vScrollPosition)
        sender.Invalidate()

    End Sub
#End Region

    Public Sub fillItemList(ByVal gender As String, ByVal separator As String)

        If itemList.Count = 0 Then

            'If _separator Is Nothing Then _separator = separator

            Dim item As Item
            Dim strSplitted As String() = Split(gender, separator)

            Debug.Assert(Not strSplitted Is Nothing, "Genre vide")

            For Each i In ITEM_LIST_ENUM
                item = IIf(strSplitted.Contains(i), New Item(i, True), New Item(i))
                itemList.Add(item)
            Next

            showItem()

        End If

    End Sub
    Public Function getActiveItem() As String

        Dim ret As String = ""

        For Each i In itemList
            If i.Active Then
                If ret <> "" Then
                    ret += _separator
                End If
                ret += i.Text
            End If
        Next

        Return ret

    End Function
    Private Shared Function CompareItemByActive(ByVal x As Item, ByVal y As Item) As Integer

        If x Is Nothing Then
            If y Is Nothing Then
                Return 0
            Else
                Return -1
            End If
        ElseIf y Is Nothing Then
            Return 1
        Else
            Dim ret As Integer

            If x.Active = y.Active Then
                ret = 0
            ElseIf x.Active Then
                ret = -1
            ElseIf y.Active Then
                ret = 1
            End If

            If ret <> 0 Then
                Return ret
            Else
                Return x.Text.CompareTo(y.Text)
            End If
        End If

    End Function
    Private Sub showItem()

        fContainer.Controls.Clear()

        itemList.Sort(AddressOf CompareItemByActive)
        For Each i In itemList
            i.Selectable = _active
            fContainer.Controls.Add(i)
        Next

    End Sub

End Class
