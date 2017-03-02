Public Class SearchFilter

    ' Outer Event
    Public Event FilterBuilt(ByVal value As String, out As Boolean)

    Private Sub SearchFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        aFilter.fillItemList("", ";")
        updateNameList()

    End Sub

#Region " Function "
    Public Sub updateNameList()

        Dim source As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        source.AddRange(V2_GUI.nameList.ToArray())
        aName.AutoCompleteCustomSource = source

    End Sub
    Private Sub build()

        Dim rank As Integer = aRank.Rank
        Dim gender As String = aFilter.getActiveItem()
        Dim name As String = aName.Text

        Dim query As String = ""
        If name.Equals("") Then

            If Not gender.Equals("") Then

                Dim genderSplit As String() = gender.Split(aFilter.Separator())

                query = "("
                For Each e As String In genderSplit
                    If e.Equals(genderSplit(0)) Then
                        query = query & "Genre LIKE '%" & e & "%'"
                    Else
                        query = query & " OR Genre LIKE '%" & e & "%'"
                    End If
                Next
                query = query & ")"

            Else
                query = "Note >= '" & IIf(rank = 1, 0, rank) & "'"
            End If

            If cbSuivi.SelectedIndex() > 0 Then
                query = query & " AND Follow = '" & IIf(cbSuivi.SelectedIndex() = 1, "1", "0") & "'"
            End If

            If cbFini.SelectedIndex() > 0 Then
                query = query & " AND Fini = '" & IIf(cbFini.SelectedIndex() = 1, "0", "1") & "'"
            End If

        Else
            query = "Nom LIKE '" & name.ToLowerInvariant() & "%'"
        End If

        Console.WriteLine("LOG: " & query)
        Console.WriteLine("LOG: cbSuivi = " & cbSuivi.SelectedIndex & " - cbFini = " & cbFini.SelectedIndex)

        RaiseEvent FilterBuilt(query, aOut.Checked())

    End Sub
#End Region

#Region " Handler "
    Private onOut As Boolean = False
    Private Sub buildFilter_Click(sender As Object, e As EventArgs) Handles buildFilter.Click
        build()
    End Sub
    Private Sub aName_KeyDown(sender As Object, e As KeyEventArgs) Handles aName.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            build()
        End If
    End Sub
    Private Sub aOut_CheckedChanged(sender As Object, e As EventArgs) Handles aOut.CheckedChanged

        If aOut.Checked Then
            cbSuivi.SelectedIndex = 1
            cbFini.SelectedIndex = 1
        ElseIf onOut Then
            cbSuivi.SelectedIndex = 0
            cbFini.SelectedIndex = 0
        End If

        onOut = aOut.Checked()

    End Sub
    Private Sub aFollow_CheckedChanged(sender As Object, e As EventArgs) Handles aFollow.CheckedChanged
        aOut.Checked = If(sender.Checked(), aOut.Checked, False)
    End Sub
    Private Sub cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSuivi.SelectedIndexChanged, cbFini.SelectedIndexChanged
        If onOut Then
            aOut.Checked = False
            onOut = False
        End If
    End Sub
#End Region

End Class
