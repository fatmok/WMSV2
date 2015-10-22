Public Class frmMain2

   
    Private Sub miReadCardRecord_Click(sender As Object, e As EventArgs) Handles miReadCardRecord.Click
        Using a As New frmGetData
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miUserSetup_Click(sender As Object, e As EventArgs) Handles miUserSetup.Click
        Using a As New frmUserSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Application.Exit()

    End Sub

    Private Sub miCountrySetup_Click(sender As Object, e As EventArgs) Handles miCountrySetup.Click
        Using a As New frmCountrySetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miAreaSetup_Click(sender As Object, e As EventArgs) Handles miAreaSetup.Click
        Using a As New frmAreaSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miGarbageCatSetup_Click(sender As Object, e As EventArgs) Handles miGarbageCatSetup.Click
        Using a As New frmGarbageCatSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miGarbageSubCatSetup_Click(sender As Object, e As EventArgs) Handles miGarbageSubCatSetup.Click
        Using a As New frmGarbageSubCatSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miBinSetup_Click(sender As Object, e As EventArgs) Handles miBinSetup.Click
        Using a As New tbModelNO
            a.ShowDialog()

        End Using
    End Sub

    Private Sub 資料庫設定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 資料庫設定ToolStripMenuItem.Click
        Using a As New DBTools
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miDistrictSetup_Click(sender As Object, e As EventArgs) Handles miDistrictSetup.Click
        Using a As New frmDistrictSetup
            a.ShowDialog()
        End Using
    End Sub

    Private Sub miStationSetup_Click(sender As Object, e As EventArgs) Handles miStationSetup.Click
        Using a As New frmStationSetup
            a.ShowDialog()


        End Using
    End Sub


    Private Sub miShopSetup_Click(sender As Object, e As EventArgs) Handles miShopSetup.Click
        Using a As New frmShopSetup
            a.ShowDialog()

        End Using
    End Sub

    Private Sub 關於系統ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關於系統ToolStripMenuItem.Click
        Using a As New AboutBox1
            a.ShowDialog()

        End Using
    End Sub

    Private Sub miReport_Click(sender As Object, e As EventArgs) Handles miReport.Click

    End Sub

    Private Sub miDeviceSetup_Click(sender As Object, e As EventArgs) Handles miDeviceSetup.Click
        Using a As New frmDeviceSetup
            a.ShowDialog()

        End Using
    End Sub
End Class