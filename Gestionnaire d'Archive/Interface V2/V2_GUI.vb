Imports System.Windows.Forms.Integration
Imports System.Threading
Imports Shader
Imports System.IO

Public Class V2_GUI
    Inherits Form

    Private sInterface As SaveInterface = Nothing
    Private WithEvents mInterface As MenuInterface = Nothing
    Private WithEvents rInterface As RechercherInterface = Nothing
    Private WithEvents aInterface As AnimeInterface = Nothing
    Private WithEvents nInterface As NewAnimeInterface = Nothing

    Private WithEvents shader As ShaderScreen = New ShaderScreen()

    Private sqlCo As SqlConnection
    Private ConsoleOut As TextWriter = Console.Out
    Private Logger As StreamWriter = New StreamWriter("report.log", True)
    Public Shared data As DataSet = New DataSet("data")
    Public Shared nameList As List(Of String) = New List(Of String)

#Region " Main Functions "
    Private Sub V2_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False

        Me.title.Text = Me.Text

        Console.SetOut(Logger)
        Console.WriteLine("------New Session: {0}------", System.DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss"))

        If (Dir(Application.StartupPath & "\Uplauncher GA.new") <> "") Then

            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Uplauncher GA.exe")
            My.Computer.FileSystem.RenameFile(Application.StartupPath & "\Uplauncher GA.new", "Uplauncher GA.exe")

        End If

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

        AutoSave.Start()

        rInterface = New RechercherInterface()
        pContainer.Controls.Add(rInterface)
        rInterface.SendToBack()

    End Sub
    Private Sub V2_Test_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        fillData()
        My.Settings.Save()

        If Not sInterface Is Nothing Then sInterface.Dispose()
        If Not mInterface Is Nothing Then mInterface.Dispose()
        If Not rInterface Is Nothing Then rInterface.Dispose()
        If Not aInterface Is Nothing Then aInterface.Dispose()
        If Not shader Is Nothing Then shader.Dispose()

        If Me.sqlCo.State.Equals(ConnectionState.Open) Then
            databaseClose()
            Me.sqlCo.Dispose()
        End If

        Logger.Close()
        Console.SetOut(ConsoleOut)

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

        Console.WriteLine("LOG: filling...")

        Try

            databaseOpen()

            If Not isFirstCommit Then commitData() Else isFirstCommit = False

            Dim adaptater As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM data", sqlCo)

            data.Clear()
            adaptater.Fill(data, "data")

            databaseClose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try

        updateNameList()
        If (Not rInterface Is Nothing) Then rInterface.updateNameList()

    End Sub
    Private Sub commitData()

        Console.WriteLine("LOG: commiting...")

        Try

            Dim table As DataTable = data.Tables("data")
            Dim adaptator = New SqlDataAdapter("SELECT * FROM data", sqlCo)
            Dim cmdBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptator)

            adaptator.AcceptChangesDuringUpdate() = True
            adaptator.DeleteCommand = cmdBuild.GetDeleteCommand(True)
            adaptator.UpdateCommand = cmdBuild.GetUpdateCommand(True)
            adaptator.InsertCommand = cmdBuild.GetInsertCommand(True)

            Console.WriteLine("LOG: updated row = " & adaptator.Update(data, "data").ToString())

            cmdBuild.Dispose()
            adaptator.Dispose()

        Catch ex As Exception
            Console.WriteLine("Commit: " & ex.Message)
        End Try

    End Sub
    Public Shared Sub updateNameList()

        Dim table As DataTable = data.Tables("data")
        Dim row() As DataRow = table.Select("")

        nameList.Clear()
        For Each r As DataRow In row
            nameList.Add(r.Item("Nom").ToString())
        Next

    End Sub
    Public Shared Function isNameExist(ByVal name As String)

        Dim table As DataTable = data.Tables("data")
        Dim row() As DataRow = table.Select("Nom = '" & name & "'")

        Return If(row.Length > 0, True, False)

    End Function

#End Region

#Region " Header "
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        doAppExit()
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
    Private Sub doNewAnimeInterface() Handles mInterface.NewEvent

        If Not nInterface Is Nothing Then
            pContainer.Controls.Remove(nInterface)
            nInterface.Dispose()
        End If

        nInterface = New NewAnimeInterface()

        pContainer.Controls.Add(nInterface)
        nInterface.BringToFront()

    End Sub
    Private Async Sub doSave() Handles mInterface.SaveEvent

        Console.WriteLine("Saving...")
        tick = 0

        If sInterface Is Nothing Then
            sInterface = SaveInterface.GetInstance()
            sInterface.Location = New System.Drawing.Point((Me.Width / 2) - (sInterface.Width / 2), (Me.Height / 2) - (sInterface.Height / 2))
            Me.Controls.Add(sInterface)
            sInterface.BringToFront()
        End If

        sInterface.startAnimation()

        ' Do save
        Await Task.Run(
             Sub()
                 fillData()
                 sliderUpdate()
             End Sub
        )

        sInterface.endAnimation()

    End Sub
    Private Sub doLoad() Handles mInterface.LoadEvent
        'Not implemented
    End Sub
    Private Sub doSignin() Handles mInterface.SigninEvent
        'Not implemented
    End Sub
    Private Sub doSettings() Handles mInterface.SettingsEvent
        'Not implemented
    End Sub
    Private Sub doInfo() Handles mInterface.InfoEvent
        'Not implemented
    End Sub
    Private Sub doAppExit() Handles mInterface.ExitEvent
        Close()
    End Sub
    Private Sub doShaderFadeout() Handles mInterface.MenuClosingEvent
        shader.Visible = False
    End Sub
#End Region

#Region " RechercheEvent Handler "
    Private Sub loadAnime(anime As Anime) Handles rInterface.LoadAnimeEvent

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

#Region " AnimeInterfaceEvent Handler "
    Private Sub animeUpdated() Handles aInterface.AnimeUpdated
        doSave()
    End Sub
    Private Sub sliderUpdate() Handles aInterface.PictureUpdated

        If (Not rInterface Is Nothing) Then
            Console.WriteLine("LOG: reloadSlider")
            rInterface.reloadSlider()
        End If

    End Sub
#End Region

#Region " NewAnimeInterfaceEvent Handler "
    Private Sub addAnime(anime As Anime) Handles nInterface.newAnimeEvent

        Console.WriteLine("LOG: Adding...")

        Dim row As DataRow = data.Tables("data").NewRow()
        row.BeginEdit()
        row(1) = anime.Nom()
        row(2) = anime.Lien()
        row(3) = anime.Genre()
        row(4) = anime.Episode()
        row(5) = anime.DateSortie().ToString(anime.FORMAT)
        row(6) = anime.Note()
        row(7) = If(anime.Follow(), "1", "0")
        row(8) = If(anime.SmartLink(), "1", "0")
        row(9) = anime.Commentaire()
        row(10) = If(anime.Finished(), "1", "0")
        row.EndEdit()

        data.Tables("data").Rows.Add(row)

        fillData()

    End Sub
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

#Region " AutoSave Function "
    Private tick As Integer = 0
    Private Const timeout As Integer = 1 'minute
    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        tick += 1
        If (tick = timeout) Then
            tick = 0
            doSave()
        End If
    End Sub
#End Region

End Class