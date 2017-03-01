Imports System.ComponentModel

Public NotInheritable Class InformationBox

    Private Sub InformationBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bTitle.Text = Me.Text
        If (Me.ShowIcon) Then
            bIcon.Image = Me.Icon.ToBitmap
        End If

    End Sub

#Region " Property "
    <Description("Get or define the comment bloc")>
    Public Property Comments As String
        Get
            Return bComment.Text
        End Get
        Set(value As String)
            bComment.Text = value
            Me.Invalidate()
        End Set
    End Property
    <Description("Get or define the version bloc")>
    Public Property Version As String
        Get
            Return bVersion.Text
        End Get
        Set(value As String)
            bVersion.Text = value
            Me.Invalidate()
        End Set
    End Property
#End Region

#Region " Handler "
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click, bOK.Click
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
