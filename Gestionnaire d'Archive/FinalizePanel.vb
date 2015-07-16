Public Class FinalizePanel
    Inherits BasePanel

    Private Const MAX_STEP As Integer = 3
    Private stepCount As Integer = 0

    Public Sub New(form As Form)

        MyBase.New(form)
        buildPanel()

    End Sub

#Region "Build function"
    Private Sub buildPanel()

        '
        ' Title
        '
        With MyBase._title
            .Location = New Point(50, 20)
            .Text = "Archive :"
        End With
        '
        ' Subtitle
        '
        With MyBase._subtitle
            .Text = "sauvegarde en cours."
        End With

    End Sub
#End Region

#Region "Methode"
    Public Sub nextStep()

        If stepCount < MAX_STEP Then
            stepCount += 1
            Me._subtitle.Text += " ."
        End If

    End Sub
#End Region

End Class
