﻿Public Class MenuInterface
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

    ' Le constructeur est Private pour que l'on ne puisse pas faire de New SaveInterface
    Private Sub New()
        InitializeComponent()
        Me.Left = -1 * Me.Width
    End Sub

    ' Event
    Public Event saveEvent()
    Public Event newEvent()
    Public Event loadEvent()
    Public Event exitEvent()

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

    Public Sub menuOpen()
        mode = AnimationMode.Open
        timerAnimation.Start()
    End Sub

    Public Sub menuClose()
        mode = AnimationMode.Close
        timerAnimation.Start()
    End Sub

    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick

        If (mode = AnimationMode.Open) Then
            If (Me.Left = 0) Then
                timerAnimation.Stop()
            Else
                Me.Left += 30 'en fct° de la taille

            End If
        ElseIf (mode = AnimationMode.Close) Then
            If (Me.Left = -1 * Me.Width) Then
                timerAnimation.Stop()
            Else
                Me.Left -= 30 '
            End If
        Else
            timerAnimation.Stop()
        End If

    End Sub

    Public Property Title() As String
        Get
            Return mTitle.Text
        End Get
        Set(ByVal value As String)
            mTitle.Text = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuClose()
    End Sub

    Private Sub newClick(sender As Object, e As EventArgs) Handles mNew.Click
        RaiseEvent newEvent()
    End Sub
    Private Sub saveClick(sender As Object, e As EventArgs) Handles mSave.Click
        RaiseEvent saveEvent()
    End Sub
    Private Sub loadClick(sender As Object, e As EventArgs) Handles mLoad.Click
        RaiseEvent loadEvent()
    End Sub
    Private Sub signinClick(sender As Object, e As EventArgs) Handles mSignin.Click

    End Sub
    Private Sub infoClick(sender As Object, e As EventArgs) Handles mInfo.Click

    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles mExit.Click
        RaiseEvent exitEvent()
    End Sub

End Class