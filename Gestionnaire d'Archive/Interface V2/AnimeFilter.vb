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

    Public Class Item
        Inherits Label

        Private selected As Boolean = False
        Private color_active As Color = Color.FromName("ActiveCaption")
        Private color_inactive As Color = Color.FromName("GradientInactiveCaption")

        Public Sub New(ByVal value As String, Optional ByVal selected As Boolean = False)

            Me.selected = selected

            With Me
                .Text = value
                .Height = 25
                .AutoSize = True
                .Margin = New Padding(3)
                .Cursor = Cursors.Hand
                .BackColor = IIf(selected, color_active, color_inactive)
                .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                .TextAlign = HorizontalAlignment.Center
            End With

            AddHandler Me.Click, AddressOf filterClick

        End Sub

        Public ReadOnly Property Active() As Boolean
            Get
                Return selected
            End Get
        End Property
        Private Sub filterClick(sender As Object, e As EventArgs)

            If Not selected Then selected = True Else selected = False
            Me.BackColor = IIf(selected, color_active, color_inactive)

        End Sub
        Public Overloads Function Equals(item As Item) As Boolean
            If Me.Text.Equals(item.Text) Then Return True Else Return False
        End Function

    End Class

    Private itemList As New List(Of Item)

    Public Sub New(ByVal items As List(Of Item))

        InitializeComponent()

        itemList = items

        Dim item As Item
        Dim toAdd As Boolean = True
        For Each i In ITEM_LIST_ENUM

            toAdd = True
            item = New Item(i)
            For Each e In itemList
                If e.Equals(item) Then
                    toAdd = False
                    Exit For
                End If
            Next
            If toAdd Then
                itemList.Add(item)
            End If

        Next

        showSelected()

    End Sub

    Private Sub AnimeFilter_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged

        fContainer.Controls.Clear()
        If Not MyBase.Enabled Then
            showSelected()
        Else
            showAll()
        End If

    End Sub
    Private Sub showSelected()

        Dim sumWidth As Integer = 0

        For Each i In itemList
            If i.Active Then
                fContainer.Controls.Add(i)
                sumWidth += i.Width
            End If
        Next

        resizeFilter(sumWidth)

    End Sub
    Private Sub showAll()

        Dim sumWidth As Integer = 0

        For Each i In itemList
            fContainer.Controls.Add(i)
            sumWidth += i.Width
        Next

        resizeFilter(sumWidth)

    End Sub
    Private Sub resizeFilter(ByVal sumWidth As Integer)

        Dim heightMax As Integer = 0

        heightMax = 25 * (Math.Ceiling(sumWidth / MyBase.Width))
        Me.MinimumSize = New Point(MyBase.Width, 25)
        Me.MaximumSize = New Point(0, 67)
        Me.Height = heightMax

    End Sub

End Class
