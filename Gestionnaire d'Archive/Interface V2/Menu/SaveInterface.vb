Public Class SaveInterface
    '
    ' Cette class est ThreadSafe
    ' Composant utilisateur de l'interface de sauvegarde
    '

    ' Variable locale pour stocker une référence vers l'instance
    Private Shared instance As SaveInterface = Nothing
    Private Shared ReadOnly mylock As New Object()

    ' Le constructeur est Private pour que l'on ne puisse pas faire de New SaveInterface
    Private Sub New()
        InitializeComponent()
        Me.BringToFront()
        Me.Visible = False
    End Sub
    ' La méthode GetInstance doit être Shared <=> Static
    Public Shared Function GetInstance() As SaveInterface

        SyncLock (mylock)
            ' Si pas d'instance existante on en crée une...
            If instance Is Nothing Then
                instance = New SaveInterface
            End If

            ' On retourne l'instance de SaveInterface
            Return instance
        End SyncLock

    End Function

#Region " Function "
    Public Sub startAnimation()
        Me.Visible = True
    End Sub
    Public Sub endAnimation()
        Me.Visible = False
    End Sub
#End Region

End Class
