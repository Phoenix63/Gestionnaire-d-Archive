Imports System.Windows.Forms.Integration
Imports System.Threading
Imports Shader
Imports System.IO

Public Class V2_GUI
    Inherits Form

    Private sInterface As SaveInterface = Nothing
    Private WithEvents settingsInterface As SettingsInterface = Nothing
    Private WithEvents mInterface As MenuInterface = Nothing
    Private WithEvents rInterface As RechercherInterface = Nothing
    Private WithEvents aInterface As AnimeInterface = Nothing
    Private WithEvents nInterface As NewAnimeInterface = Nothing

    Private WithEvents shader As ShaderScreen = New ShaderScreen()

    Private Const sqlPath As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DataBase.mdf;" _
                                    & "Integrated Security=True;ApplicationIntent=ReadWrite;" _
                                    & "Connect Timeout=30;ConnectRetryCount=5"
    Private sqlCo As SqlConnection
    Private historyList As New List(Of Anime)
    Private ConsoleOut As TextWriter = Console.Out
    Private Logger As StreamWriter = New StreamWriter("report.log", True)
    Public Shared data As DataSet = New DataSet("data")
    Public Shared nameList As List(Of String) = New List(Of String)

#Region " Main Functions "
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    Private Sub V2_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False

        Me.title.Text = Me.Text

#If Not Debug Then
        Console.SetOut(Logger)
#End If
        Console.WriteLine("------New Session: {0}------", System.DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss"))

        If (Dir(Application.StartupPath & "\Uplauncher GA.new") <> "") Then

            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Uplauncher GA.exe")
            My.Computer.FileSystem.RenameFile(Application.StartupPath & "\Uplauncher GA.new", "Uplauncher GA.exe")

        End If

        If (My.Settings.DBCONF = True) Then
            databaseInitialization(My.Settings.DBSTRING)
        Else
            databaseInitialization()
        End If
        fillData()

        MyBase.Controls.Add(shader)
        With shader
            .Size = New Point(450, 375)
            .Zone = New Point(MyBase.Location.X + 150, MyBase.Location.Y + 25)
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

        closeInterface()
        If Not shader Is Nothing Then shader.Dispose()
        If Not mInterface Is Nothing Then mInterface.Dispose()

        Console.WriteLine("------Session ended: {0}------", System.DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss"))
        Console.WriteLine()
        Logger.Close()
        Console.SetOut(ConsoleOut)

    End Sub
    Private Sub closeInterface()

        fillData()
        saveHistory()
        My.Settings.Save()

        If Not sInterface Is Nothing Then sInterface.Dispose()
        sInterface = Nothing
        If Not rInterface Is Nothing Then rInterface.Dispose()
        rInterface = Nothing
        If Not aInterface Is Nothing Then aInterface.Dispose()
        aInterface = Nothing
        If Not settingsInterface Is Nothing Then settingsInterface.Dispose()
        settingsInterface = Nothing

        If Me.sqlCo.State.Equals(ConnectionState.Open) Then
            databaseClose()
            Me.sqlCo.Dispose()
        End If

    End Sub
#End Region

#Region " DB Function "
    Private isFirstCommit As Boolean = True
    Private Sub databaseInitialization(Optional path As String = sqlPath)

        Dim retryCount As Integer = 5
        Dim connectError As Boolean = True

        While connectError And (retryCount > 0)

            Try
                Me.sqlCo = New SqlConnection(path)
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
    Private Function getLocalDatabase(dbName As String, Optional deleteExisting As Boolean = False) As String

        Try
            Dim fillDB As Boolean = False
            Dim path As String = Application.StartupPath
            Dim mdfname As String = IO.Path.Combine(path, dbName & ".mdf")
            Dim ldfname As String = IO.Path.Combine(path, dbName & "_log.ldf")

            If (IO.File.Exists(mdfname) And deleteExisting) Then
                Console.WriteLine("LOG: exist and delete db")
                If (IO.File.Exists(ldfname)) Then IO.File.Delete(ldfname)
                IO.File.Delete(mdfname)
                createDatabase(dbName, mdfname)
                fillDB = True
            ElseIf (Not IO.File.Exists(mdfname)) Then
                Console.WriteLine("LOG: unexist db")
                createDatabase(dbName, mdfname)
                fillDB = True
            End If

            Dim str As String = String.Format("Data Source=(LocalDB)\v11.0;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", dbName, mdfname)

            If (fillDB) Then
                Using con As SqlConnection = New SqlConnection(str)
                    con.Open()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "CREATE TABLE [dbo].[data] (" & _
                                        "[Id]          INT            IDENTITY (1, 1) NOT NULL," & _
                                        "[Nom]         VARCHAR (MAX)  NOT NULL," & _
                                        "[Url]         NVARCHAR (MAX) NOT NULL," & _
                                        "[Genre]       NVARCHAR (MAX) DEFAULT (NULL) NULL," & _
                                        "[Episode]     INT            NOT NULL," & _
                                        "[Date]        NVARCHAR (12)  NOT NULL," & _
                                        "[Note]        INT            DEFAULT ((0)) NULL," & _
                                        "[Follow]      INT            DEFAULT ((0)) NULL," & _
                                        "[SmartLink]   INT            DEFAULT ((0)) NULL," & _
                                        "[Commentaire] NVARCHAR (MAX) DEFAULT (NULL) NULL," & _
                                        "[Fini]        INT            DEFAULT ((0)) NULL," & _
                                        "PRIMARY KEY CLUSTERED ([Id] ASC)" & _
                                     ");"
                    cmd.ExecuteNonQuery()
                End Using
            End If

            Return str

        Catch ex As Exception
            Console.WriteLine("LOG: error in getting localDatabase " & dbName)
            Console.WriteLine("ERROR: " & ex.Message)
            Return ""
        End Try

    End Function
    Private Sub createDatabase(dbName As String, mdfname As String)

        Try
            Dim str As String = "Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(str)
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                detachDatabase(dbName)
                cmd.CommandText = String.Format("CREATE DATABASE {0} ON (NAME = '{0}', FILENAME = '{1}')", dbName, mdfname.Replace("'", "''"))
                cmd.ExecuteNonQuery()
            End Using
            If (IO.File.Exists(mdfname)) Then Console.WriteLine("LOG: created") Else Console.WriteLine("LOG: not created")
        Catch ex As Exception
            Console.WriteLine("LOG: error in creating database " & dbName)
            Console.WriteLine("ERROR: " & ex.Message)
        End Try

    End Sub
    Private Sub detachDatabase(dbName As String)

        Try
            Dim str As String = "Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(str)
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = String.Format("exec sp_detach_db '{0}'", dbName)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("LOG: error in detaching database " & dbName)
            Console.WriteLine("ERROR: " & ex.Message)
        End Try

    End Sub
    Private Sub databaseOpen()

        Try
            If Me.sqlCo.State = ConnectionState.Closed Then Me.sqlCo.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur au chargement de la base de donnée")
            Throw New Exception("Error on databaseOpen()")
            Close()
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
        If sInterface IsNot Nothing Then sInterface.Location = New Point(Me.Location.X + (Me.Width / 2) - (sInterface.Width / 2),
                                                                         Me.Location.Y + (Me.Height / 2) - (sInterface.Height / 2))
    End Sub
    Private Sub shader_Click() Handles Shader.Clicked
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
            sInterface.Location = New Point(Me.Location.X + (Me.Width / 2) - (sInterface.Width / 2),
                                            Me.Location.Y + (Me.Height / 2) - (sInterface.Height / 2))
        End If

        sInterface.BringToFront()
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
                                             "Version " & My.Settings.VERSION, Me.Text)

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

        'doSave()

        If anime IsNot Nothing Then addHistory(anime)
        updateNameList()
        displayHistory()

    End Sub
    Private Sub animeDeleted(anime As Anime) Handles aInterface.AnimeDeleted

        doSave()

        For Each e As Anime In historyList.ToList
            If (e.Nom().Equals(anime.Nom())) Then
                historyList.Remove(e)
                displayHistory()
            End If
        Next
        If (Not rInterface Is Nothing) Then rInterface.removeAnimeCard(anime)

    End Sub
    Private Sub pictureUpdated(anime As Anime) Handles aInterface.PictureUpdated

        If (Not rInterface Is Nothing) Then
            Console.WriteLine("LOG: reload anime card from search interface")
            rInterface.reloadAnimeCard(anime)
        Else
            Console.WriteLine("LOG: reload anime card from history")
            history.reloadAnimeCard(anime)
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

#Region " SettingsInterfaceEvent Handler "
    Private Sub databaseUpdated(origin As Boolean, path As String) Handles SettingsInterface.DatabaseChanged

        closeInterface()
        Console.WriteLine("------Restarted: {0}------", System.DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss"))

        If (origin) Then
            My.Settings.DBCONF = False
        Else
            My.Settings.DBCONF = True
            My.Settings.DBSTRING = getLocalDatabase(path)
        End If

        If (My.Settings.DBCONF = True) Then
            databaseInitialization(My.Settings.DBSTRING)
        Else
            databaseInitialization()
        End If
        fillData()

        history.clearSlider()
        historyList.Clear()
        loadHistory()
        displayHistory()

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
            Dim path As String = Application.StartupPath & "\data" & i & ".hga"
            If (File.Exists(path)) Then
                Dim anime As Anime = anime.fileDeserialize(My.Computer.FileSystem.ReadAllText(path))
                If (isNameExist(anime.Nom())) Then historyList.Add(anime)
            End If
        Next i

    End Sub
    Private Sub saveHistory()

        'HACK
        For i As Integer = 1 To 4
            Dim path As String = Application.StartupPath & "\data" & i & ".hga"
            If (File.Exists(path)) Then File.Delete(path)

            If (i - 1 < historyList.Count) Then
                Dim writer As StreamWriter = File.CreateText(path)
                writer.Write(historyList(i - 1).fileFullSerialize())
                writer.Close()
            End If
        Next i

    End Sub
    Private Sub addHistory(anime As Anime)

        Dim currentID As Integer = CInt(data.Tables("data").Select("Nom = '" & anime.Nom() & "'")(0).Item("Id"))
        For Each e In historyList.ToList
            Dim hID As Integer = CInt(data.Tables("data").Select("Nom = '" & e.Nom() & "'")(0).Item("Id"))
            If (currentID.Equals(hID)) Then historyList.Remove(e)
        Next
        historyList.Add(anime)
        displayHistory()

    End Sub
    Private Sub displayHistory() Handles rInterface.HistoryUpdated

        historyList.Reverse()

        history.clearSlider()
        history.addAnime(historyList)
        Console.WriteLine("LOG: loading history")
        history.displayAnime()
        Console.WriteLine("LOG: displaying history")

        historyList.Reverse()

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