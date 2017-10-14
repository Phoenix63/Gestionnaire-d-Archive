Imports System.Windows.Forms.DataVisualization.Charting

Public Class SettingsInterface

    Public Event DatabaseChanged(origin As Boolean, path As String)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.BackColor = Color.Transparent

    End Sub
    Private Sub SettingsInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load settings
        sAutoSave.Text = String.Format("{0}", My.Settings.AUTO_SAVE)
        If (My.Settings.OTHER_CHECKED = True) Then otherSelected() Else defaultSelected()
        loadChart()

        ' Load statistics
        sEpSum.Text = String.Format("{0}", getEpisodeSum())
        sSerieSum.Text = String.Format("{0}", getSerieSum())

    End Sub

#Region " Statistics functions "
    Private Function getEpisodeSum() As Integer

        Dim val As ULong = 0
        Dim table As DataTable = V2_GUI.data.Tables("data")

        For Each row As DataRow In table.Rows()
            val += CInt(row.Item("Episode"))
        Next

        table.Dispose()

        Return val

    End Function
    Private Function getSerieSum() As Integer

        Dim table As DataTable = V2_GUI.data.Tables("data")
        Return table.Rows.Count()

    End Function
    Private Sub loadChart()

        Dim epSum As Integer = Math.Max(getEpisodeSum(), 1)

        Dim list As Hashtable = New Hashtable()
        For Each genre As String In AnimeFilter.ITEM_LIST_ENUM
            list.Add(genre, 0)
        Next

        Dim table As DataTable = V2_GUI.data.Tables("data")
        For Each row As DataRow In table.Rows()

            Dim ep As Integer = CInt(row.Item("Episode"))
            Dim genres As String() = Split(row.Item("Genre").ToString(), ";")
            If genres.Count - 1 = 0 Then
                genres = Split(row.Item("Genre").ToString(), ", ")
                If genres.Count - 1 = 0 Then Continue For
            End If

            For Each genre As String In genres
                list.Item(genre) = list.Item(genre) + ep
            Next

        Next

        Dim x As Integer = 0
        For Each e As String In list.Keys

            Console.WriteLine("{0} => {1}", e, list.Item(e).ToString())

            Dim p As DataPoint = New DataPoint()
            p.XValue = x
            p.YValues(0) = (list.Item(e) / epSum) * 100
            p.AxisLabel = e
            p.ToolTip = String.Format("{0}% des épisodes vus sont du genre `{1}`", Math.Floor(p.YValues(0)), e)

            If p.YValues(0) < 2 Then Continue For

            genreChart.Series(0).Points.Add(p)

            x = x + 1

        Next

        genreChart.ChartAreas(0).AxisX.IsStartedFromZero = True
        genreChart.ChartAreas(0).AxisY.LabelStyle.Enabled = False

    End Sub
#End Region

#Region " Browser functions "
    Private Sub defaultSelected()

        sDefaultBrowser.Image = My.Resources.ic_checked
        sOtherBrowser.Image = My.Resources.ic_unchecked
        My.Settings.OTHER_CHECKED = False

    End Sub
    Private Sub otherSelected()

        Dim bName As String = Nothing
        If My.Settings.BROWSER = "null" Then
            bName = updateBrowser()
            If bName Is Nothing Then Exit Sub
        Else
            bName = My.Settings.BROWSER
        End If

        bName = IO.Path.GetFileNameWithoutExtension(bName)
        bName = bName(0).ToString().ToUpper() & bName.Substring(1).ToLower()
        tip.SetToolTip(sOtherBrowser, bName)

        sOtherBrowser.Image = My.Resources.ic_checked
        sDefaultBrowser.Image = My.Resources.ic_unchecked
        My.Settings.OTHER_CHECKED = True

    End Sub
    Private Function updateBrowser() As String

        Dim url As String = ""
        Dim fileDial As New OpenFileDialog

        fileDial.FileName = ""
        fileDial.InitialDirectory = "C:\Program File\"
        fileDial.Filter = "Client web|*.exe"
        fileDial.Title = "Sélectionner navigateur internet"

        If (fileDial.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            url = fileDial.FileName
            My.Settings.BROWSER = url

            Dim client As String = IO.Path.GetFileNameWithoutExtension(url)
            client = client(0).ToString().ToUpper() & client.Substring(1).ToLower()
            Return client

        Else
            Return Nothing
        End If

    End Function
#End Region

#Region " Handler "
    Private Sub sReturn_Click(sender As Object, e As EventArgs) Handles sReturn.Click

        Me.Visible = False
        Me.Parent.Controls.Remove(Me)
        Dispose()

    End Sub
    Private Sub sDefaultBrowser_Click(sender As Object, e As EventArgs) Handles sDefaultBrowser.Click
        defaultSelected()
    End Sub
    Private Sub sOtherBrowser_Click(sender As Object, e As EventArgs) Handles sOtherBrowser.Click
        otherSelected()
    End Sub
    Private Sub sUpdateBrowser_Click(sender As Object, e As EventArgs) Handles sUpdateBrowser.Click

        Dim bName As String = updateBrowser()
        If bName IsNot Nothing Then tip.SetToolTip(sOtherBrowser, bName)

    End Sub
    Private Sub sDatabaseChange_Click(sender As Object, e As EventArgs) Handles sDatabaseChange.Click

        If (My.Settings.DBCONF) Then
            Dim r As DialogResult = New DialBox("Voulez vous restaurer la base de données ?", V2_GUI.Text, DialBox.BoxMode.ModeYesNo).ShowDialog()
            If (r = DialogResult.Yes) Then
                Me.Visible = False
                Threading.Thread.Sleep(250)
                RaiseEvent DatabaseChanged(True, "")
            End If
        Else
            Dim r2 As DialogResult = New DialBox("Voulez vous changer de base de données ?", V2_GUI.Text, DialBox.BoxMode.ModeYesNo).ShowDialog()
            If (r2 = DialogResult.Yes) Then
                Dim str As String = "Private" 'HACK
                Me.Visible = False
                Threading.Thread.Sleep(250)
                RaiseEvent DatabaseChanged(False, str)
            End If
        End If

    End Sub
#End Region

End Class
