Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Main

    Private Const SET_X As Integer = 495
    Private Const SET_Y As Integer = 345
    Private Const ANIME_X As Integer = 495
    Private Const ANIME_Y As Integer = 157

    Private sqlCo As SqlConnection

    Public dataSet As DataSet = New DataSet()

    Private _startPanel As BasePanel
    Public _basePanel As BasePanel

    Private firstCommit As Boolean = True
    Private trial As Boolean = True

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                   "Erreur du lancement de l'application")
            Close()
        End If

        initialize()

    End Sub
    Private Sub Main_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        displayClosing()
        commitDataSet()

    End Sub

#Region "MaJ Logiciel"
    Private Sub check()

        If (Dir(Application.StartupPath & "\Uplauncher GA.new") <> "") Then

            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Uplauncher GA.exe")
            My.Computer.FileSystem.RenameFile(Application.StartupPath & "\Uplauncher GA.new", "Uplauncher GA.exe")

        End If

    End Sub
#End Region

#Region "Trial"
    Private Sub signIn()

        Dim name As String = ""
        Dim code As String = ""
        Dim valide As MsgBoxResult = MsgBoxResult.No

        While valide = vbNo
            name = InputBox("Entrez le nom : ", "Enregistrement")
            If name = "" Then Return
            code = InputBox("Entrez le code : ")
            If code = "" Then Return
            valide = MsgBox("Enregistrement de Gestionnaire d'Archive sous le nom de " & name & vbCrLf & "Avec le code d'enregistrement " & code & vbCrLf & vbCrLf & "Les informations saisies sont-elles correctes ?", vbYesNoCancel, "Enregistrement")
            If valide = MsgBoxResult.Cancel Then Return
        End While

        If (Not checkTrial(name, code)) Then
            My.Settings.NOM = name
            My.Settings.CODE = code
            menuSignIn.Visible = False
            InfoMenu.Visible = True
            trial = False
            MsgBox("Merci de vous être enregistré(e) sur Gestionnaire d'Archive")
        End If

    End Sub
    Private Function checkTrial(ByVal name_t As String, ByVal code_t As String)

        Dim code() As String
        Dim value As UInteger = 0

        If name_t = "######||######" And code_t = "######||######" Or name_t = "" And code_t = "" Then Return True

        code = Split(code_t, "-")
        For i = 0 To code.Length - 1
            value += valueOf(code(i))
        Next

        If value * 255 = 19125 Then
            trial = False
            Return False
        Else
            MsgBox("Code d'enregistrement incorrecte, veuillez vous re-enregistrer ultérieurement")
            Return True
        End If

    End Function
    Private Function numberLength(ByVal nb As ULong)

        Dim length As ULong = 0

        While (nb / 10) <> 0
            nb = nb / 10
            length += 1
        End While

        Return length

    End Function
    Private Function valueOf(ByVal val As ULong)

        If val = 0 Then Return 0

        Dim valeur As ULong = val
        Dim length As ULong = numberLength(val)
        Dim ret As ULong = 0
        Dim i As ULong = 0

        While i < length
            ret += valeur Mod 10
            valeur = valeur / 10
            i += 1
        End While

        Return ret

    End Function
#End Region

#Region "Methode"
    Private Sub initialize()

        check()

        If Not (checkTrial(My.Settings.NOM, My.Settings.CODE)) Then
            menuSignIn.Visible = False
            InfoMenu.Visible = True
        End If

        If My.Settings.OTHER_CHECKED Then

            AutreToolStripMenuItem.Checked = True
            DefautToolStripMenuItem.Checked = False
            If Not (My.Settings.BROWSER = "null") Then
                AutreToolStripMenuItem.Tag = My.Settings.BROWSER
                AutreToolStripMenuItem.Text = IO.Path.GetFileNameWithoutExtension(My.Settings.BROWSER)
            End If

        End If

        Me.Size = New Point(495, 150)
        Me._startPanel = New LoadPanel(Me)

        updateDataSet()

        Dim args() As String = My.Application.CommandLineArgs().ToArray
        If args.Length <> 0 Then import(args(0))

        AutoSave.Interval() = 1000 * 60 * 15 '15 minutes
        AutoSave.Start()

        Me.Controls.Remove(Me._startPanel)
        Me._startPanel = New BasePanel(Me)

    End Sub
    Private Sub displayClosing()

        Me.Controls.Remove(Me._basePanel)
        Me.Controls.Remove(Me._startPanel)

        Me.Size = New Point(ANIME_X, ANIME_Y)
        Me._startPanel = New FinalizePanel(Me)

    End Sub
    Private Sub import(ByVal path)

        Dim checkArgs As Boolean = IO.Path.GetExtension(path).Equals(".mga")

        If checkArgs Then

            Dim mAnime As Anime = Anime.fileDeserialize(readFile(path))

            If (isDuplicateAnime(mAnime)) Then
                MsgBox("L'animé est déjà existant dans la base de donnée", MsgBoxStyle.Critical, "Duplication de l'animé")
                Return
            End If

            commitDataSet()

            databaseConnect()
            Dim req As String = mAnime.sqlSerialize(Anime.MODE_INSERT, "data")
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand(req, sqlCo)
            databaseExecute(command)

        End If

    End Sub
    Private Sub updateDataSet()

        If Not firstCommit Then commitDataSet() Else firstCommit = False

        Me.dataSet.Clear()

        Dim req As String = "SELECT * FROM data"
        Dim command As New SqlCommand(req, sqlCo)
        Dim adaptator As New SqlDataAdapter(command)

        databaseConnect()

        Try
            adaptator.Fill(dataSet, "data")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        command.Dispose()
        sqlCo.Close()

    End Sub
    Public Sub commitDataSet()

        Dim dataTable As DataTable = dataSet.Tables("data")
        Dim dataAdapter As New SqlDataAdapter("SELECT * FROM data", sqlCo)
        Dim objCommandBuild As New SqlCommandBuilder(dataAdapter)

        dataAdapter.Update(dataTable.Select(Nothing, Nothing, DataViewRowState.Added))
        Threading.Thread.Sleep(250)

        If TypeOf Me._startPanel Is FinalizePanel Then CType(Me._startPanel, FinalizePanel).nextStep()

        dataAdapter.Update(dataTable.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
        Threading.Thread.Sleep(250)

        If TypeOf Me._startPanel Is FinalizePanel Then CType(Me._startPanel, FinalizePanel).nextStep()

        dataAdapter.Update(dataTable.Select(Nothing, Nothing, DataViewRowState.Deleted))
        Threading.Thread.Sleep(250)

        objCommandBuild.Dispose()
        dataAdapter.Dispose()
        dataTable.Dispose()

    End Sub
    Public Function isDuplicateAnime(ByVal anime As Anime) As Boolean

        Dim table As DataTable = dataSet.Tables("data")
        Dim row() As DataRow = table.Select("Nom = '" & anime.getNom() & "'")

        Return If(row.Length <> 0, True, False)

    End Function
    Private Sub databaseConnect()

        Try
            sqlCo.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub databaseExecute(ByVal Commande As SqlCommand)

        Try
            Commande.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Commande.Dispose()
        sqlCo.Close()

    End Sub
    Public Sub loadMenu(Optional anime As Anime = Nothing)

        Me.Controls.Remove(_basePanel)
        Me.Size = New Point(ANIME_X, ANIME_Y)

        AnimePanel.setMenuEditionEnabled()

        If menuLoadEnCours.Checked Then
            _basePanel = If(anime Is Nothing, New AnimeEnCoursPanel(Me), New AnimeEnCoursPanel(Me, anime))
        Else
            _basePanel = If(anime Is Nothing, New AnimeFiniPanel(Me), New AnimeFiniPanel(Me, anime))
        End If

        _basePanel.BringToFront()

    End Sub
    Private Sub changeBrowser()

        Dim url As String = ""
        Dim fileDial As New OpenFileDialog

        fileDial.FileName = ""
        fileDial.InitialDirectory = "C:\Program File\"
        fileDial.Filter = "Web Client|*.exe"
        fileDial.Title = "Sélectionner le web-client"

        If (fileDial.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            url = fileDial.FileName
            My.Settings.BROWSER = url
            AutreToolStripMenuItem.Tag = url
            AutreToolStripMenuItem.Text = IO.Path.GetFileNameWithoutExtension(url)

        Else

            DefautToolStripMenuItem.Checked = True
            AutreToolStripMenuItem.Checked = False
            My.Settings.OTHER_CHECKED = False

        End If

    End Sub
#End Region

#Region "IO function"
    Public Function readFile(ByVal path As String) As String

        Return My.Computer.FileSystem.ReadAllText(path)

    End Function
    Public Sub writeFile(ByVal path As String, ByVal serializedFile As String)

        My.Computer.FileSystem.WriteAllText(path, serializedFile, False)

    End Sub
#End Region

#Region "Handler"
    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click

        menuLoadEnCours.Checked = False
        menuLoadFini.Checked = False

        Me.Controls.Remove(_basePanel)
        Me.Size = New Point(SET_X, SET_Y)

        _basePanel = New NouveauPanel(Me)
        _basePanel.BringToFront()

        AnimePanel.setMenuEditionEnabled()

    End Sub
    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click

        Me.Controls.Remove(_basePanel)
        Me.Size = New Point(SET_X, SET_Y)

        _basePanel = New ModifierPanel(Me, CType(_basePanel, AnimePanel)._anime)
        _basePanel.BringToFront()

        AnimePanel.setMenuEditionEnabled()

    End Sub
    Private Sub menuLoad_Click(sender As Object, e As EventArgs) Handles menuLoadEnCours.Click, menuLoadFini.Click, menuLoadHebdo.Click

        If Not sender.Checked Then

            Me.Controls.Remove(_basePanel)
            Me.Size = New Point(ANIME_X, ANIME_Y)

            menuLoadEnCours.Checked = False
            menuLoadHebdo.Checked = False
            menuLoadFini.Checked = False
            sender.Checked = True

            cloturer.Text = "Cloturer"

            If sender.Equals(menuLoadEnCours) Then
                _basePanel = New AnimeEnCoursPanel(Me)
            ElseIf sender.Equals(menuLoadHebdo) Then
                _basePanel = New AnimeSortiePanel(Me)
            ElseIf sender.Equals(menuLoadFini) Then
                cloturer.Text = "Décloturer"
                _basePanel = New AnimeFiniPanel(Me)
            End If

            _basePanel.BringToFront()

        End If

    End Sub
    Private Sub cloturer_Click(sender As Object, e As EventArgs) Handles cloturer.Click

        Dim row As DataRow = dataSet.Tables("data").Select("Nom = '" & _basePanel._anime.getNom() & "'")(0)

        row.BeginEdit()
        row(10) = If(sender.text = "Cloturer", "1", "0")
        row.EndEdit()

        loadMenu()

    End Sub
    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click

        Dim row As DataRow = dataSet.Tables("data").Select("Nom = '" & _basePanel._anime.getNom() & "'")(0)
        row.Delete()

        loadMenu()

    End Sub
    Private Sub importer_Click(sender As Object, e As EventArgs) Handles importer.Click

        opf.Title() = "Importation d'un animé"
        opf.FileName() = ""
        opf.Multiselect() = True

        If (opf.ShowDialog() = DialogResult.OK) Then

            For Each file As String In opf.FileNames
                import(file)
            Next

            updateDataSet()

            If (menuLoadEnCours.Checked Or menuLoadFini.Checked) Then

                Dim currentAnime As Anime = _basePanel._anime
                loadMenu(currentAnime)

            End If

        End If

    End Sub
    Private Sub menuSignIn_Click(sender As Object, e As EventArgs) Handles menuSignIn.Click
        signIn()
    End Sub
    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Close()
    End Sub
    Private Sub DefautToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefautToolStripMenuItem.Click

        If (AutreToolStripMenuItem.Checked = True) Then

            DefautToolStripMenuItem.Checked = True
            AutreToolStripMenuItem.Checked = False
            My.Settings.OTHER_CHECKED = False

        End If

    End Sub
    Private Sub AutreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutreToolStripMenuItem.Click

        If (DefautToolStripMenuItem.Checked = True) Then

            AutreToolStripMenuItem.Checked = True
            DefautToolStripMenuItem.Checked = False
            My.Settings.OTHER_CHECKED = True

            If (AutreToolStripMenuItem.Tag = "") Then changeBrowser()

        End If

    End Sub
    Private Sub ModifierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem1.Click
        changeBrowser()
    End Sub
    Private Sub InfoMenu_Click(sender As Object, e As EventArgs) Handles InfoMenu.Click

        MsgBox("Vous êtes enregistré en tant que " & My.Settings.NOM & vbCrLf & "Avec le numéro d'enregistrement " & My.Settings.CODE,
               vbInformation, "Information d'enregistrement")

    End Sub
    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        commitDataSet()
    End Sub
    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        commitDataSet()
    End Sub
#End Region

End Class

