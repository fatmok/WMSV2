Public Class frmSetup

   
    Private Sub btUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUserList.Click
        Using a As New frmUserSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()

    End Sub

    Private Sub btCountrySetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCountrySetup.Click
        Using a As New frmCountrySetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBin.Click
        Using a As New tbModelNO
            a.ShowDialog()

        End Using
    End Sub

    Private Sub frmSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbUser.Text = MainScript.UserName
        If MainScript.UserName = "sysadmin" Then
            tbDBTools.Visible = True

        End If
    End Sub

    Private Sub btExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Dispose()

    End Sub

    Private Sub btArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btArea.Click
        Using a As New frmAreaSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub tbDBTools_Click(sender As Object, e As EventArgs) Handles tbDBTools.Click
        Using a As New DBTools
            a.ShowDialog()

        End Using
    End Sub

    Private Sub tbGarbageCat_Click(sender As Object, e As EventArgs) Handles tbGarbageCat.Click
        Using a As New frmGarbageCatSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub tbGarbageSubCat_Click(sender As Object, e As EventArgs) Handles tbGarbageSubCat.Click
        Using a As New frmGarbageSubCatSetup
            a.ShowDialog()

        End Using
    End Sub
End Class