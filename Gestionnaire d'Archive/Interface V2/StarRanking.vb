Public Class StarRanking

    Private _rank As Integer = 1
    Private _lastRank As Integer = 1
    Private _maxRank As Integer = 5

    Public Event rankChanged(value As Integer)
    Private Event updateRank(value As Integer)

    Public Property Rank() As Integer
        Get
            Return _rank
        End Get
        Set(value As Integer)
            If (value <= _maxRank) Then RaiseEvent updateRank(value)
        End Set
    End Property

#Region " MouseHandler "
    Private Sub star_Click(sender As Object, e As EventArgs) Handles s5.Click, s4.Click, s3.Click, s2.Click, s1.Click

        If TypeOf sender Is PictureBox Then
            If CInt(sender.tag) <> _lastRank Then

                RaiseEvent updateRank(CInt(sender.tag))
                RaiseEvent rankChanged(Rank)

            End If
        End If

    End Sub
#End Region

#Region " EventHandler "
    Private Sub updateRankValue(value As Integer) Handles Me.updateRank

        _rank = value
        _lastRank = value

        For i = 1 To value
            Dim pic As PictureBox = CType(Me.Controls.Item("s" & i), PictureBox)
            pic.Image = My.Resources.activestar
        Next

        For i = value + 1 To 5
            Dim pic As PictureBox = CType(Me.Controls.Item("s" & i), PictureBox)
            pic.Image = My.Resources.inactivestar
        Next

    End Sub
#End Region

End Class
