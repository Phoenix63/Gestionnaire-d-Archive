Public Class AnimeCard
    Inherits UserControl

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Width = cardFont.Width
        Me.Height = cardFont.Height

    End Sub
    Private Sub AnimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
