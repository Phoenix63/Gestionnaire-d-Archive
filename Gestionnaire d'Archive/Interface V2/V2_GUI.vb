Imports System.Windows.Forms.Integration
Imports System.Threading
Imports Shader

Public Class V2_GUI
    Inherits Form

    Private sInterface As SaveInterface = Nothing
    Private WithEvents mInterface As MenuInterface = Nothing
    Private WithEvents rInterface As RechercherInterface = Nothing
    Private WithEvents aInterface As AnimeInterface = Nothing
    Private WithEvents nInterface As NewAnimeInterface = Nothing

    Private WithEvents shader As ShaderScreen = New ShaderScreen()

    Private sqlCo As SqlConnection
    Public Shared data As DataSet = New DataSet()

#Region " Main Functions "
    Private Sub V2_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.title.Text = Me.Text

        databaseInitialization()
        fillData()

        MyBase.Controls.Add(shader)
        With shader
            .Size = New Point(450, 375)
            .Zone = New Point(Me.Location.X + 150, Me.Location.Y + 25)
            .Location = New Point(150, 25)
            .Alpha = 30
            .BringToFront()
        End With

        rInterface = New RechercherInterface()
        pContainer.Controls.Add(rInterface)
        rInterface.SendToBack()

    End Sub
    Private Sub V2_Test_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        If Not sInterface Is Nothing Then sInterface.Dispose()
        If Not mInterface Is Nothing Then mInterface.Dispose()
        If Not rInterface Is Nothing Then rInterface.Dispose()
        If Not aInterface Is Nothing Then aInterface.Dispose()
        If Not shader Is Nothing Then shader.Dispose()

        If Me.sqlCo.State.Equals(ConnectionState.Open) Then
            databaseClose()
            Me.sqlCo.Dispose()
        End If

    End Sub
#End Region

#Region " DB Function "
    Private isFirstCommit As Boolean = True
    Private Sub databaseInitialization()

        Dim retryCount As Integer = 5
        Dim connectError As Boolean = True

        While connectError And (retryCount > 0)

            Try
                Me.sqlCo = New SqlConnection("Data Source=(LocalDB)\v11.0;" _
                                          & "AttachDbFilename=|DataDirectory|\DataBase.mdf;" _
                                          & "Integrated Security=True;" _
                                          & "ApplicationIntent=ReadWrite;" _
                                          & "Connect Timeout=30;" _
                                          & "ConnectRetryCount=5")
                connectError = False
            Catch ex As Exception
                retryCount -= 1
                Threading.Thread.Sleep(1000)
            End Try

        End While

        If retryCount = 0 Then
            MsgBox("Veuillez relancer le programme, la base de donnée n'a pas pu être join lors de cette instance",
                   MsgBoxStyle.Critical + MsgBoxStyle.Information,
                   "Erreur au chargement des données")
            Close()
        End If

    End Sub
    Private Sub databaseOpen()

        Try
            If Me.sqlCo.State = ConnectionState.Closed Then Me.sqlCo.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur au chargement de la base de donnée")
            Throw New Exception("Error on databaseOpen()")
        End Try

    End Sub
    Private Sub databaseClose()

        Me.sqlCo.Close()

    End Sub
    Private Sub databaseExecute(ByVal Commande As SqlCommand)

        Try
            Commande.ExecuteNonQuery()
            Commande.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur à l'exécution sur la base de donnée")
            Throw New Exception("Error on databaseExecute()")
        End Try

    End Sub
    Private Sub fillData()

        If isFirstCommit Then
            'MsgBox("Commiting")
            'databaseCommit()
            isFirstCommit = False
        End If

        Try

            databaseOpen()

            Dim req As String = "SELECT * FROM data"
            Dim command As New SqlCommand(req, sqlCo)
            Dim adaptator As New SqlDataAdapter(command)

            adaptator.Fill(data, "data")

            databaseClose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try

    End Sub
    Public Shared Function isNameExist(ByVal name As String)

        Dim table As DataTable = data.Tables("data")
        Dim row() As DataRow = table.Select("Nom = '" & name & "'")

        Return If(row.Length <> 0, True, False)

    End Function

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

        Dim shaderThread As Thread = New Thread(AddressOf shader.picUpdate)
        shaderThread.IsBackground = True
        shaderThread.Start()

        mInterface.menuOpen()

    End Sub
    Private Sub V2_GUI_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        shader.Zone = New Point(Me.Location.X + 150, Me.Location.Y + 25)
    End Sub
    Private Sub shader_Click() Handles shader.Clicked
        mInterface.menuClose()
    End Sub
#End Region

#Region " MenuEvent Handler "
    Private Sub newAnime() Handles mInterface.newEvent

        If Not nInterface Is Nothing Then
            pContainer.Controls.Remove(nInterface)
            nInterface.Dispose()
        End If

        nInterface = New NewAnimeInterface()

        pContainer.Controls.Add(nInterface)
        nInterface.BringToFront()

    End Sub
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
    Private Sub shader_fadeout() Handles mInterface.menuCloseEvent
        shader.Visible = False
    End Sub
#End Region

#Region " RechercheEvent Handler "
    Private Sub loadAnime(anime As Anime) Handles rInterface.loadAnimeEvent

        If Not aInterface Is Nothing Then
            pContainer.Controls.Remove(aInterface)
            aInterface.Dispose()
        End If

        Debug.Assert(Not anime Is Nothing)
        aInterface = New AnimeInterface(anime)

        pContainer.Controls.Add(aInterface)
        aInterface.BringToFront()

    End Sub
#End Region

#Region " UpdateAnimeEvent Handler "

#Region " NewAnimeInterfaceEvent Handler "
    Private Sub addAnime(anime As Anime) Handles nInterface.newAnimeEvent



    End Sub
#End Region

#Region " AnimeInterfaceEvent Handler "
    Private Sub updateAnime(anime As Anime) 'handles aInterface.updateAnimeEvent

    End Sub
#End Region

#End Region

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, title.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub

#End Region

End Class