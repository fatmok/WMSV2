Public Class frmMain

 

   

    Private Sub btGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetData.Click
        Using a As New frmGetData
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Application.Exit()
      
    End Sub

    Private Sub btSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSetup.Click
        If MainScript.UserLevel <> "1" Then
            MessageBox.Show("您沒有權限使用這功能", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Using a As New frmSetup
                a.ShowDialog()

            End Using
        End If
    End Sub

    Private Sub btReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReport.Click

        If MainScript.UserLevel = "3" Then
            MessageBox.Show("您沒有權限使用這功能", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Using a As New frmReport
                a.ShowDialog()
            End Using

        End If
            End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lbUser.Text = MainScript.UserName
        Dim asi As New Security.Policy.ApplicationSecurityInfo(AppDomain.CurrentDomain.ActivationContext)
        lbVer.Text = String.Format("Version: {0}", asi.ApplicationId.Version.ToString())
    End Sub
End Class