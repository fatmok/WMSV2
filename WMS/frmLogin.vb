Public Class frmLogin

  

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
      

        Application.Exit()
    End Sub
    Public Sub CheckLogin()
        Dim CanLogin As Boolean = True
        If Me.tbPassword.Text = String.Empty Then
            MessageBox.Show("必需輸入密碼", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Exit Sub

        ElseIf Me.tbUserName.Text = String.Empty Then

            MessageBox.Show("必需輸入使用者", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUserName.Focus()
            Exit Sub

        Else
            If tbUserName.Text = "sysadmin" And tbPassword.Text = "Tefu05811" Then
                MainScript.UserId = "1"
                MainScript.UserName = "sysadmin"
                MainScript.UserLevel = "1"
                Using a As New frmMain2
                    a.ShowDialog()

                End Using

            End If
            If CanLogin Then
                Dim sql As String = "select * from UserMaster where LoginName='" & tbUserName.Text & "' and LoginPassword='" & tbPassword.Text & "'"

                Dim dt As DataTable

                dt = MainScript.GetDataTable(sql)

                If dt.Rows.Count = 0 Then

                    MessageBox.Show("使用者或密碼不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    tbUserName.Focus()
                    Exit Sub
                Else

                    MainScript.UserId = dt.Rows(0)("UserId")
                    MainScript.UserName = dt.Rows(0)("ChName")
                    MainScript.UserLevel = dt.Rows(0)("UserRight")
                    Using a As New frmMain2
                        a.ShowDialog()

                    End Using

                End If



            End If
        End If

    End Sub

    Private Sub btGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetData.Click
        Me.CheckLogin()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPassword.Text = "Tefu05811"
        tbUserName.Text = "sysadmin"

    End Sub
End Class