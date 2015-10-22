Public Class DBTools

    Private Sub tbTraUserMaster_Click(sender As Object, e As EventArgs) Handles tbTraUserMaster.Click
        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then



            Dim sql As String
            sql = "truncate table UserMaster"
            OperateData(sql)
            MsgBox("完成")
        End If
    End Sub

    Private Sub tbTraAreaMaster_Click(sender As Object, e As EventArgs) Handles tbTraAreaMaster.Click
        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim sql As String
            sql = "truncate table AreaMaster"
            OperateData(sql)
            MsgBox("完成")
        End If
    End Sub

    Private Sub tbTraCountryMaster_Click(sender As Object, e As EventArgs) Handles tbTraCountryMaster.Click
        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then


            Dim sql As String
            sql = "truncate table CountryMaster"
            OperateData(sql)
            MsgBox("完成")
        End If
    End Sub

    Private Sub tbTraBinMaster_Click(sender As Object, e As EventArgs) Handles tbTraBinMaster.Click

        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim sql As String
            sql = "truncate table BinMaster"
            OperateData(sql)
            MsgBox("完成")
        End If
    End Sub

    Private Sub tbTraLogMaster_Click(sender As Object, e As EventArgs) Handles tbTraLogMaster.Click
        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim sql As String
            sql = "truncate table LogMaster"
            OperateData(sql)
            MsgBox("完成")

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using a As New frmBinUploadTime
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btCardMaster_Click(sender As Object, e As EventArgs) Handles btCardMaster.Click
        If MessageBox.Show("是否確定刪除,刪除後資料不可被回復", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim sql As String
            sql = "truncate table CardMaster"
            OperateData(sql)
            MsgBox("完成")
        End If
    End Sub
End Class