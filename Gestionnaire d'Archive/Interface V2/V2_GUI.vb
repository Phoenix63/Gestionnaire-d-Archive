Imports System.Windows.Forms.Integration
Imports System.Threading
Imports Shader
Imports System.IO

Public Class V2_GUI
    Inherits Form

    Private sInterface As SaveInterface = Nothing
    Private settingsInterface As SettingsInterface = Nothing
    Private WithEvents mInterface As MenuInterface = Nothing
    Private WithEvents rInterface As RechercherInterface = Nothing
    Private WithEvents aInterface As AnimeInterface = Nothing
    Private WithEvents nInterface As NewAnimeInterface = Nothing

    Private WithEvents shader As ShaderScreen = New ShaderScreen()

    Private sqlCo As SqlConnection
    Private historyList As New List(Of Anime)
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

        loadHistory()
        displayHistory()

    End Sub
    Private Sub V2_Test_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        If (aInterface IsNot Nothing) Then
            If (aInterface.isUpdated) Then addHistory(aInterface.Anime)
        End If

        fillData()
        saveHistory()
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

        Console.WriteLine("------Session ended: {0}------", System.DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss"))
        Console.WriteLine()
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
    Private Sub doLoad() Handles mInterface.LoadEvent

        If Not aInterface Is Nothing Then aInterface.Dispose()
        loadSearchInterface()
        rInterface.loadWithFilter("", False)

    End Sub
    Private Sub doSave() Handles mInterface.SaveEvent

        Console.WriteLine("Saving...")
        tick = 0

        If sInterface Is Nothing Then
            sInterface = SaveInterface.GetInstance()
            sInterface.Location = New System.Drawing.Point((Me.Width / 2) - (sInterface.Width / 2), (Me.Height / 2) - (sInterface.Height / 2))
            Me.Controls.Add(sInterface)
            sInterface.BringToFront()
        End If

        sInterface.startAnimation()
        fillData()
        sInterface.endAnimation()

    End Sub
    Private Sub doSignin() Handles mInterface.SigninEvent
        'Not implemented
    End Sub
    Private Sub doSettings() Handles mInterface.SettingsEvent

        If Not settingsInterface Is Nothing Then
            pContainer.Controls.Remove(settingsInterface)
            settingsInterface.Dispose()
        End If

        settingsInterface = New SettingsInterface()
        pContainer.Controls.Add(settingsInterface)
        settingsInterface.BringToFront()

    End Sub
    Private Sub doInfo() Handles mInterface.InfoEvent

        Dim infobox As DialBox = New DialBox("Gestionnaire d'Archive" & vbCrLf & _
                                             "Application pour la gestion de série." & vbCrLf & vbCrLf & _
                                             "Si une erreur survient, contactez le support en joignant le fichier 'report.log'" & vbCrLf & vbCrLf & _
                                             "Version 2.2.3 (beta)", Me.Text)

        Console.WriteLine("LOG: info: " & infobox.ShowDialog())

    End Sub
    Private Sub doAppExit() Handles mInterface.ExitEvent
        Close()
    End Sub
    Private Sub doShaderFadeout() Handles mInterface.MenuClosingEvent
        shader.Visible = False
    End Sub
#End Region

#Region " RechercheEvent Handler "
    Private Sub loadAnime(anime As Anime) Handles rInterface.LoadAnimeEvent, history.loadAnimeEvent, nInterface.loadAnimeEvent

        If Not aInterface Is Nothing Then
            pContainer.Controls.Remove(aInterface)
            aInterface.Dispose()
        End If

        aInterface = New AnimeInterface(anime)

        pContainer.Controls.Add(aInterface)
        aInterface.BringToFront()

    End Sub
#End Region

#Region " AnimeInterfaceEvent Handler "
    Private Sub animeUpdated(anime As Anime) Handles aInterface.AnimeUpdated

        If anime IsNot Nothing Then addHistory(anime)
        doSave()
        sliderUpdate()

    End Sub
    Private Sub animeDeleted(anime As Anime) Handles aInterface.AnimeDeleted

        Dim currentID As Integer = CInt(data.Tables("data").Select("Nom = '" & anime.Nom() & "'")(0).Item("Id"))
        For Each e In historyList.ToList
            Dim hID As Integer = CInt(data.Tables("data").Select("Nom = '" & e.Nom() & "'")(0).Item("Id"))
            If (currentID.Equals(hID)) Then historyList.Remove(e)
        Next
        sliderUpdate()

    End Sub
    Private Sub sliderUpdate() Handles aInterface.PictureUpdated

        If (Not rInterface Is Nothing) Then
            Console.WriteLine("LOG: reloadSlider")
            rInterface.reloadSlider()
        Else
            displayHistory()
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
    Private timeout As Integer = My.Settings.AUTO_SAVE 'minute
    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        tick += 1
        If (tick = timeout) Then
            tick = 0
            doSave()
        End If
    End Sub
#End Region

#Region " Accueil "
    Private Sub loadHistory()

        'HACK
        For i As Integer = 1 To 4
            Dim path As String = Application.StartupPath & "\data.ga" & i
            If (Dir(path) <> "") Then
                historyList.Add(Anime.fileDeserialize(My.Computer.FileSystem.ReadAllText(path)))
            End If
        Next i

    End Sub
    Private Sub saveHistory()

        'HACK
        For i As Integer = 1 To Math.Min(historyList.Count, 4)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data.ga" & i,
                                                historyList(i - 1).fileFullSerialize(),
                                                False)
        Next i

    End Sub
    Private Sub addHistory(anime As Anime)

        Dim currentID As Integer = CInt(data.Tables("data").Select("Nom = '" & anime.Nom() & "'")(0).Item("Id"))
        For Each e In historyList.ToList
            Dim hID As Integer = CInt(data.Tables("data").Select("Nom = '" & e.Nom() & "'")(0).Item("Id"))
            If (currentID.Equals(hID)) Then historyList.Remove(e)
        Next
        historyList.Add(anime)

    End Sub
    Private Sub displayHistory() Handles rInterface.HistoryUpdated

        history.clearScreen()
        history.addAnime(historyList)
        Console.WriteLine("LOG: loading history")
        history.displayAnime()
        Console.WriteLine("LOG: displaying history")

    End Sub
    Private Sub loadSearchInterface()

        pAccueil.Visible = False
        If rInterface Is Nothing Then
            rInterface = New RechercherInterface()
            pContainer.Controls.Add(rInterface)
            rInterface.SendToBack()
        End If
        rInterface.Visible = True
        pAccueil.SendToBack()
        pAccueil.Visible = True

    End Sub
    Private Sub quickOut_Click(sender As Object, e As EventArgs) Handles quickOut.Click
        loadSearchInterface()
        rInterface.loadWithFilter("Fini = '0' AND Follow = '1'", True)
    End Sub
    Private Sub quickCurrent_Click(sender As Object, e As EventArgs) Handles quickCurrent.Click
        loadSearchInterface()
        rInterface.loadWithFilter("Fini = '0'", False)
    End Sub
    Private Sub quickEnded_Click(sender As Object, e As EventArgs) Handles quickEnded.Click
        loadSearchInterface()
        rInterface.loadWithFilter("Fini = '1'", False)
    End Sub
#End Region

End Class