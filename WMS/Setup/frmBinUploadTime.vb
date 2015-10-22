Public Class frmBinUploadTime

    Private Sub frmBinUploadTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbMinute.Text = MainScript.GetDateByDataReader("Select controlmin from control")

    End Sub

    Private Sub tbExit_Click(sender As Object, e As EventArgs) Handles tbExit.Click
        Me.Dispose()

    End Sub

    Private Sub tbOK_Click(sender As Object, e As EventArgs) Handles tbOK.Click
        If Not IsNumeric(Me.tbMinute.Text) Then
            MessageBox.Show("必需輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim sql As String = "update control set controlmin ='" + Me.tbMinute.Text + "'"
            OperateData(sql)
            MsgBox("Finish")
        End If
        

    End Sub
End Class