Public Class LoadPanel
    Inherits BasePanel

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
            .Text = "chargement en cours. . ."
        End With

    End Sub
#End Region

End Class
