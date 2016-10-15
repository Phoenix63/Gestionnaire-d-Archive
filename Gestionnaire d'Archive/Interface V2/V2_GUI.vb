Public Class V2_GUI
    Inherits Form

    Private sInterface As SaveInterface = Nothing
    Private WithEvents mInterface As MenuInterface = Nothing
    Private WithEvents rInterface As RechercherInterface = Nothing
    Private WithEvents aInterface As AnimeInterface = Nothing

#Region " Main Functions "
    Private Sub V2_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.title.Text = Me.Text

        rInterface = New RechercherInterface()
        pContainer.Controls.Add(rInterface)
        rInterface.SendToBack()

    End Sub
    Private Sub V2_Test_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        If Not sInterface Is Nothing Then sInterface.Dispose()
        If Not mInterface Is Nothing Then mInterface.Dispose()
        If Not rInterface Is Nothing Then rInterface.Dispose()
        If Not aInterface Is Nothing Then aInterface.Dispose()

    End Sub
#End Region

#Region " Header "
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        appExit()
    End Sub
    Private Sub bt_reduce_Click(sender As Object, e As EventArgs) Handles bt_reduce.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub bt_menu_Click(sender As Object, e As EventArgs) Handles bt_menu.Click

        If mInterface Is Nothing Then
            mInterface = MenuInterface.GetInstance()
            mInterface.Title = "Menu"
            Me.Controls.Add(mInterface)
            mInterface.BringToFront()
        End If

        mInterface.menuOpen()

    End Sub
#End Region

#Region " MenuEvent Handler "
    Private Sub save() Handles mInterface.saveEvent

        If sInterface Is Nothing Then
            sInterface = SaveInterface.GetInstance()
            sInterface.Location = New System.Drawing.Point((Me.Width / 2) - (sInterface.Width / 2), (Me.Height / 2) - (sInterface.Height / 2))
            Me.Controls.Add(sInterface)
            sInterface.BringToFront()
        End If

        sInterface.startAnimation()

    End Sub
    Private Sub appExit() Handles mInterface.exitEvent
        Close()
    End Sub
#End Region

#Region " RechercheEvent Handler "
    Private Sub loadAnime(anime As Anime) Handles rInterface.loadAnimeEvent

        If Not aInterface Is Nothing Then
            pContainer.Controls.Remove(aInterface)
            aInterface.Dispose()
        End If

        If Not anime Is Nothing Then
            aInterface = New AnimeInterface(anime)
        Else
            aInterface = New AnimeInterface()
        End If
        pContainer.Controls.Add(aInterface)
        aInterface.BringToFront()

    End Sub
#End Region

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles title.MouseDown, MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles title.MouseMove, MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles title.MouseUp, MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub

#End Region

End Class