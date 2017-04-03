Imports System.ComponentModel

Public NotInheritable Class DialBox

    Public Enum BoxMode
        ModeOK
        ModeYesNo
        ModeCancel
    End Enum

    Private _title As String
    Private _content As String
    Private _mode As BoxMode

    Public Sub New(content As String, Optional title As String = "", Optional mode As BoxMode = BoxMode.ModeOK)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If (V2_GUI.ShowIcon) Then bIcon.Image = V2_GUI.Icon.ToBitmap
        Me._content = content
        Me._title = title
        Me._mode = mode

    End Sub
    Private Sub InformationBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bTitle.Text = Me._title
        bText.Text = Me._content

        Select Case Me._mode
            Case BoxMode.ModeOK
                bOK.Visible = True
            Case BoxMode.ModeYesNo
                bYes.Visible = True
                bNo.Visible = True
            Case Else
                bOK.Visible = True
        End Select

    End Sub

#Region " Property "
    <Description("Get or define content")>
    Public Property Message As String
        Get
            Return bText.Text
        End Get
        Set(value As String)
            Me._content = value
            Me.Invalidate()
        End Set
    End Property
#End Region

#Region " Handler "
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub bYes_Click(sender As Object, e As EventArgs) Handles bYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
    Private Sub bNo_Click(sender As Object, e As EventArgs) Handles bNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
#End Region

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, bTitle.MouseDown, bIcon.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, bTitle.MouseMove, bIcon.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, bTitle.MouseUp, bIcon.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub

#End Region

End Class
