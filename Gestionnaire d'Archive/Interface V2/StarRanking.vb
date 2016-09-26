Public Class StarRanking

    Private rank As Integer = 1

    Public Event rankChanged(value As Integer)

#Region " MouseEnter "
    Private Sub s1_MouseEnter(sender As Object, e As EventArgs) Handles s1.MouseEnter
        rank = 1
        s2.Image = My.Resources.inactivestar
    End Sub
    Private Sub s2_MouseEnter(sender As Object, e As EventArgs) Handles s2.MouseEnter
        rank = 2
        s1.Image = My.Resources.activestar
        s2.Image = My.Resources.activestar
        s3.Image = My.Resources.inactivestar
        s4.Image = My.Resources.inactivestar
        s5.Image = My.Resources.inactivestar
    End Sub
    Private Sub s3_MouseEnter(sender As Object, e As EventArgs) Handles s3.MouseEnter
        rank = 3
        s1.Image = My.Resources.activestar
        s2.Image = My.Resources.activestar
        s3.Image = My.Resources.activestar
        s4.Image = My.Resources.inactivestar
        s5.Image = My.Resources.inactivestar
    End Sub
    Private Sub s4_MouseEnter(sender As Object, e As EventArgs) Handles s4.MouseEnter
        rank = 4
        s1.Image = My.Resources.activestar
        s2.Image = My.Resources.activestar
        s3.Image = My.Resources.activestar
        s4.Image = My.Resources.activestar
        s5.Image = My.Resources.inactivestar
    End Sub
    Private Sub s5_MouseEnter(sender As Object, e As EventArgs) Handles s5.MouseEnter
        rank = 5
        s1.Image = My.Resources.activestar
        s2.Image = My.Resources.activestar
        s3.Image = My.Resources.activestar
        s4.Image = My.Resources.activestar
        s5.Image = My.Resources.activestar
    End Sub
#End Region

    Private Sub StarRanking_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        RaiseEvent rankChanged(rank)
    End Sub

End Class
