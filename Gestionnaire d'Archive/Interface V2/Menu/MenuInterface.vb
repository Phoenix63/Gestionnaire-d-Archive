Imports System.ComponentModel

Public Class MenuInterface
    Inherits UserControl
    '
    ' Cette class est ThreadSafe
    ' Composant utilisateur de l'interface de sauvegarde
    '

    Enum AnimationMode
        Open
        Close
    End Enum

    ' Variable locale pour stocker une référence vers l'instance
    Private Shared instance As MenuInterface = Nothing
    Private Shared ReadOnly mylock As New Object()
    Private mode As AnimationMode = AnimationMode.Open

    ' Outer Event
    Public Event NewEvent()
    Public Event SaveEvent()
    Public Event LoadEvent()
    Public Event SigninEvent()
    Public Event SettingsEvent()
    Public Event InfoEvent()
    Public Event ExitEvent()
    Public Event MenuClosingEvent()

    ' Le constructeur est Private pour que l'on ne puisse pas faire de New SaveInterface
    Private Sub New()

        InitializeComponent()
        Me.Left = -1 * Me.Width

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, False)
        Me.BackColor = Color.FromArgb(10, Color.Silver)

    End Sub
    ' La méthode GetInstance doit être Shared <=> Static
    Public Shared Function GetInstance() As MenuInterface

        SyncLock (mylock)
            ' Si pas d'instance existante on en crée une...
            If instance Is Nothing Then
                instance = New MenuInterface
            End If

            ' On retourne l'instance de SaveInterface
            Return instance
        End SyncLock

    End Function

#Region " Property "
    <Description("Change the menu's title.")>
    Property Title() As String
        Get
            Return mTitle.Text
        End Get
        Set(ByVal value As String)
            mTitle.Text = value
        End Set
    End Property
#End Region

#Region " Function "
    Public Sub menuOpen()
        mode = AnimationMode.Open
        timerAnimation.Start()
    End Sub
    Public Sub menuClose()
        RaiseEvent MenuClosingEvent()
        mode = AnimationMode.Close
        timerAnimation.Start()
    End Sub
#End Region

#Region " Handler "
    Private Sub newClick(sender As Object, e As EventArgs) Handles mNew.Click
        RaiseEvent NewEvent()
        menuClose()
    End Sub
    Private Sub saveClick(sender As Object, e As EventArgs) Handles mSave.Click
        RaiseEvent SaveEvent()
        menuClose()
    End Sub
    Private Sub loadClick(sender As Object, e As EventArgs) Handles mLoad.Click
        RaiseEvent LoadEvent()
        menuClose()
    End Sub
    Private Sub signinClick(sender As Object, e As EventArgs) Handles mSignin.Click
        RaiseEvent SigninEvent()
        menuClose()
    End Sub
    Private Sub settingsClick(sender As Object, e As EventArgs) Handles mSettings.Click
        RaiseEvent SettingsEvent()
        menuClose()
    End Sub
    Private Sub infoClick(sender As Object, e As EventArgs) Handles mInfo.Click
        RaiseEvent InfoEvent()
        menuClose()
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles mExit.Click
        RaiseEvent ExitEvent()
        menuClose()
    End Sub
    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick

        If (mode = AnimationMode.Open) Then
            If (Me.Left = 0) Then
                timerAnimation.Stop()
            Else
                Me.Left = Math.Min(Me.Left + Math.Exp(3.5 + 1 * (Math.Abs(Me.Left) / Me.Width)), 0)
            End If
        ElseIf (mode = AnimationMode.Close) Then
            If (Me.Left = -1 * Me.Width) Then
                timerAnimation.Stop()
            Else
                Me.Left = Math.Max(Me.Left - Math.Exp(3.5 + 1 * (Math.Abs(Me.Left) / Me.Width)), -1 * Me.Width)
            End If
        Else
            timerAnimation.Stop()
        End If

    End Sub
#End Region

End Class
