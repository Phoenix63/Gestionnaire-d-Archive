Public Class SaveInterface
    Inherits Form
    '
    ' Cette class est ThreadSafe
    ' Composant utilisateur de l'interface de sauvegarde
    '

    ' Variable locale pour stocker une référence vers l'instance
    Private Shared instance As SaveInterface = Nothing
    Private Shared ReadOnly mylock As New Object()

    Private elapsedTime As Long = 0
    Private isEndable As Boolean = False

    Public Const MIN_ELAPSED_TIME_REQUIRED = 10 '10 tick => 100ms/tick

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
        timeOutStart()
    End Sub
    Public Sub endAnimation()
        isEndable = True
    End Sub
#End Region

    Private Sub timeOutStart()
        elapsedTime = 0
        isEndable = False
        timeOut.Start()
    End Sub

    Private Sub timeOut_Tick(sender As Object, e As EventArgs) Handles timeOut.Tick
        elapsedTime += 1
        If (elapsedTime > MIN_ELAPSED_TIME_REQUIRED And isEndable) Then
            Me.Visible = False
            timeOut.Stop()
        End If
    End Sub

End Class
