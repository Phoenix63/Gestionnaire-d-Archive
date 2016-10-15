Public Class AnimeInterface

    Private _anime As Anime = Nothing

    Public Sub New()

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

    End Sub

    Private Sub aReturn_Click(sender As Object, e As EventArgs) Handles aReturn.Click
        Me.Parent.Controls.Remove(Me)
        Dispose()
    End Sub

    Private Sub starRanking_rankChanged(value As UInteger) Handles aRank.rankChanged
        MsgBox("Nouveau classement : " & value)
    End Sub

End Class
