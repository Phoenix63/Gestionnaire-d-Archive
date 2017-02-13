Public Class SearchFilter

    Public Event FilterBuilt(ByVal value As String)

    Private Sub SearchFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        aFilter.fillItemList("", ";")

        Dim source As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        source.AddRange(V2_GUI.nameList.ToArray())

        aName.AutoCompleteCustomSource = source

    End Sub

    Private Sub build()

        Dim rank As Integer = aRank.Rank
        Dim gender As String = aFilter.getActiveItem()
        Dim name As String = aName.Text
        Dim follow As Boolean = aFollow.Checked
        Dim finish As Boolean = aFinish.Checked

        Dim query As String = ""
        If name.Equals("") Then

            query = "Note >= '" & rank & "'" _
                & " AND Follow = '" & IIf(follow, 1, 0) & "'" _
                & " AND Fini = '" & IIf(finish, 1, 0) & "'"

            If Not gender.Equals("") Then

                Dim genderSplit As String() = gender.Split(aFilter.Separator())

                query = query & " AND ("
                For Each e As String In genderSplit
                    If e.Equals(genderSplit(0)) Then
                        query = query & "Genre LIKE '%" & e & "%'"
                    Else
                        query = query & " OR Genre LIKE '%" & e & "%'"
                    End If
                Next
                query = query & ")"

            End If

        Else
            query = "Nom LIKE '" & name.ToLowerInvariant() & "%'"
        End If

        RaiseEvent FilterBuilt(query)

    End Sub
    Private Sub buildFilter_Click(sender As Object, e As EventArgs) Handles buildFilter.Click
        build()
    End Sub
    Private Sub aName_KeyDown(sender As Object, e As KeyEventArgs) Handles aName.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            build()
        End If
    End Sub

End Class
