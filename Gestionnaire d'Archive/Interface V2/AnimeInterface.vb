Public Class AnimeInterface
    Inherits UserControl

    Private _anime As Anime = Nothing
    Private aFilter As AnimeFilter = Nothing
    Private onUpdate As Boolean = False

    Public Sub New()

        'NOTE: A supprimer à la fin
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent

    End Sub
    Public Sub New(ByVal anime As Anime)

        Me.New()

        _anime = anime
        updateDisplay()

    End Sub

    Private Sub updateDisplay()

        Dim pictPath As String
        pictPath = Application.StartupPath + "/PICTURES/" + _anime.getNom() + ".png"

        aTitle.Text = _anime.getNom()
        aRank.Rank = Math.Min(Math.Max(0, _anime.getNote()), 5)
        If (System.IO.File.Exists(pictPath)) Then aPicture.Image = New Bitmap(pictPath)
        deserializeGenre(_anime.getGenre())

    End Sub
    Private Sub deserializeGenre(ByVal str As String)

        Dim items As New List(Of AnimeFilter.Item)

        Dim strSplitted As String() = Nothing
        strSplitted = Split(str, ";")

        Debug.Assert(Not strSplitted Is Nothing, "Genre vide")

        For Each s In strSplitted
            items.Add(New AnimeFilter.Item(s, True))
        Next

        aFilter = New AnimeFilter(items)
        aFilter.Location = New Point(265, 115)
        aFilter.Width = 320
        aFilter.Enabled = False
        Me.Controls.Add(aFilter)

    End Sub
    Private Sub aReturn_Click(sender As Object, e As EventArgs) Handles aReturn.Click
        Me.Parent.Controls.Remove(Me)
        Dispose()
    End Sub

    Private Sub starRanking_rankChanged(value As UInteger) Handles aRank.rankChanged
        MsgBox("Nouveau classement : " & value)
    End Sub

    Private Sub aModifier_Click(sender As Object, e As EventArgs) Handles aModifier.Click

        If Not onUpdate Then
            onUpdate = True
            sender.Text = "Valider"

            aRank.Enabled = True
            aFilter.Enabled = True
        Else
            onUpdate = False
            sender.Text = "Modifier"

            aRank.Enabled = False
            aFilter.Enabled = False
        End If

    End Sub

End Class
