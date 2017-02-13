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

    ' Le constructeur est Private pour que l'on ne puisse pas faire de New SaveInterface
    Private Sub New()

        InitializeComponent()
        Me.Left = -1 * Me.Width

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, False)
        Me.BackColor = Color.FromArgb(10, Color.Silver)

    End Sub

    ' Outer Event
    Public Event saveEvent()
    Public Event newEvent()
    Public Event loadEvent()
    Public Event exitEvent()
    Public Event menuCloseEvent()

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
        RaiseEvent menuCloseEvent()
        mode = AnimationMode.Close
        timerAnimation.Start()
    End Sub
    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick

        Me.Invalidate(New Rectangle(New Point(150, 0), New Point(450, 400)), True)

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

    <Description("Change the menu's title.")>
    Property Title() As String
        Get
            Return mTitle.Text
        End Get
        Set(ByVal value As String)
            mTitle.Text = value
        End Set
    End Property

#Region " Menu Handler "
    Private Sub closeClick(sender As Object, e As EventArgs) Handles mClose.Click
        menuClose()
    End Sub
    Private Sub newClick(sender As Object, e As EventArgs) Handles mNew.Click
        menuClose()
        RaiseEvent newEvent()
    End Sub
    Private Sub saveClick(sender As Object, e As EventArgs) Handles mSave.Click
        menuClose()
        RaiseEvent saveEvent()
    End Sub
    Private Sub loadClick(sender As Object, e As EventArgs) Handles mLoad.Click
        menuClose()
        RaiseEvent loadEvent()
    End Sub
    Private Sub signinClick(sender As Object, e As EventArgs) Handles mSignin.Click
        menuClose()
    End Sub
    Private Sub infoClick(sender As Object, e As EventArgs) Handles mInfo.Click
        menuClose()
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles mExit.Click
        menuClose()
        RaiseEvent exitEvent()
    End Sub
    Private Sub MenuInterface_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        menuClose()
    End Sub
#End Region

    '#Region " Make background transparent "
    '    Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '        Get
    '            Dim cp As CreateParams = MyBase.CreateParams
    '            cp.ExStyle = cp.ExStyle Or &H20
    '            Return cp
    '        End Get
    '    End Property
    '    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
    '        ' call MyBase.OnPaintBackground(e) only if the backColor is not Color.Transparent
    '        If Me.BackColor <> Color.Transparent Then
    '            MyBase.OnPaintBackground(e)
    '        End If
    '    End Sub
    '#End Region

End Class
