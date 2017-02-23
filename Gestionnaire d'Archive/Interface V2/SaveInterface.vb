Public Class SaveInterface
    '
    ' Cette class est ThreadSafe
    ' Composant utilisateur de l'interface de sauvegarde
    '

    ' Variable locale pour stocker une référence vers l'instance
    Private Shared instance As SaveInterface = Nothing
    Private Shared ReadOnly mylock As New Object()
    Private animateTickCount As Integer = 0

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
        MyBase.Invoke(
            Sub()
                Me.Visible = True
                animateTickCount = 0
                timerAnimation.Start()
            End Sub
        )
    End Sub
    Public Sub endAnimation()
        MyBase.Invoke(
            Sub()
                Me.Visible = False
                timerAnimation.Stop()
            End Sub
        )
    End Sub
#End Region

#Region " Handler "
    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick

        If (animateTickCount Mod 4 = 0) Then
            animateTickCount = 0
            saveText.Text = ""
        Else
            saveText.Text += ". "
        End If
        animateTickCount += 1

    End Sub
#End Region

End Class
