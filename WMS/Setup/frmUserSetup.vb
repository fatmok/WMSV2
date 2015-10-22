Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmUserSetup
    Dim myDT As New DataTable
    Dim myBindingSource As New BindingSource
    Dim sql As String = "Select * From UserMaster"
    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))


    Dim Fstatus As Byte = 0


    Private Sub frmUserSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Dim sql As String = "Select * From CountryMaster"
        Fstatus = 0
        Me.SetButtons()

        SqlAda.Fill(myDT)
        myBindingSource.DataSource = myDT


        tbID.DataBindings.Add("Text", myBindingSource, "UserId")
        tbName.DataBindings.Add("Text", myBindingSource, "LoginName")
        tbEnName.DataBindings.Add("Text", myBindingSource, "EnName")
        tbChName.DataBindings.Add("Text", myBindingSource, "ChName")
        tbPhone.DataBindings.Add("Text", myBindingSource, "phone")
        tbEmail.DataBindings.Add("Text", myBindingSource, "email")
        tbLoginPassword.DataBindings.Add("Text", myBindingSource, "LoginPassword")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        cbUserRight.DataBindings.Add("Text", myBindingSource, "UserRight")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        'cbUserRight.DataBindings.Add("SelectedItem", myBindingSource, "UserRight")
        'cbOnShow.DataBindings.Add("SelectedItem", myBindingSource, "on_show")
        Me.BindingNavigator1.BindingSource = myBindingSource


        Me.lbUser.Text = MainScript.UserName


    End Sub
    Private Sub SetButtons()

        'FStatus:
        ' 0:瀏覽模式
        ' 1:新增模式
        ' 2:修改模式

        btAddNew.Enabled = (Fstatus = 0) ' And (AllowAddNew)

        btDel.Enabled = ((Fstatus = 1) Or (Fstatus = 2)) 'And (AllowDelete)
        btSave.Enabled = (Fstatus = 1) Or (Fstatus = 2)
        btSetDefault.Enabled = (Fstatus = 1) Or (Fstatus = 2)
        btSearch.Enabled = (Fstatus = 0) 'And (tbxSearch.Text <> "")
        btPrint.Enabled = (Fstatus = 0) 'And (MyID <> String.Empty) And (AllowPrint)
        'tbxSearch.ReadOnly = (FStatus <> 0)
        btMoveFirstItem.Enabled = (Fstatus = 0)
        btMoveLastItem.Enabled = (Fstatus = 0)
        btMoveNextItem.Enabled = (Fstatus = 0)
        btMovePreviousItem.Enabled = (Fstatus = 0)

    End Sub


  







    Private Sub tbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbExit.Click
        Me.Dispose()
    End Sub




    Private Sub tbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        If tSearchInfo() Then
            'BindDetail()

            Fstatus = 2
            SetButtons()


        End If
    End Sub
    Private Function tSearchInfo() As Boolean
        Dim blnValidation As Boolean = False

        Try


            Dim FindID As New TListReturnID
            FindID.SearchUnit = "  UserId, LoginName,  EnName, ChName, email, phone "



            FindID.bindSQL = "SELECT     UserId AS 編號, LoginName AS 使用者名稱, EnName AS 英文名稱, ChName AS 中文名稱, email AS 電子郵箱, phone AS 電話號碼, UserRight AS 權限, " & _
                      " on_show AS 顯示, sys_date AS 修改日期, ModUser AS 經手人 " & _
                    " FROM         UserMaster "


            tbID.Text = FindID.SearchID

            Dim sql As String = "SELECT    UserId, LoginName, LoginPassword, EnName, ChName, email, phone, UserRight, on_show, sys_date, ModUser FROM         UserMaster " & _
                            "  where UserId='" + tbID.Text + "'"


            ' MainScript.TestSql(sql)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbID.Text = dt.Rows(0)("UserId").ToString()
                tbName.Text = dt.Rows(0)("LoginName").ToString()
                tbLoginPassword.Text = dt.Rows(0)("LoginPassword").ToString()
                tbEnName.Text = dt.Rows(0)("EnName").ToString()
                tbChName.Text = dt.Rows(0)("ChName").ToString()
                tbEmail.Text = dt.Rows(0)("email").ToString()
                tbPhone.Text = dt.Rows(0)("phone").ToString()
                '  cbUserRight.Text = dt.Rows(0)("UserRight").ToString()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            blnValidation = False

        End Try
        'tbAttribName.Text = MainScript.GetVar("AttribName", "Customer", "CustomerID='" & tbCustomerID.Text)

        'tbAttribName.Focus()
        Return (blnValidation)
    End Function
  
    Private Sub btAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddNew.Click
        Fstatus = 1
        SetButtons()
    End Sub

    Private Sub btSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSetDefault.Click
        Me.myBindingSource.CancelEdit()

        Fstatus = 0
        SetButtons()

    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        If MessageBox.Show("是否刪除?刪除的檔案不可被回復!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then



            Me.myBindingSource.EndEdit()

            Dim id As String = Me.tbID.Text

            If id = String.Empty Then
                MsgBox("您未選擇數據不能刪除")

            Else

                Dim sql As String = "Delete from UserMaster where UserId= '" & id & "'"



                MainScript.ControlDataAdapter(MainScript.SqlCon, "Delete", sql).Update(myDT)
                '    SqlAda.Update(myDT)
                MsgBox("成功刪除")
                Fstatus = 0
                SetButtons()



            End If
        End If
    End Sub



    Private Sub btInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  SetDefult()
        Fstatus = 1
        SetButtons()
    End Sub

    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try

        
        Dim id As String = Me.tbID.Text

        Dim LoginName As String = tbName.Text
        Dim LoginPassword As String = tbLoginPassword.Text
        Dim EnName As String = tbEnName.Text
        Dim ChName As String = tbChName.Text
        Dim email As String = tbEmail.Text
        Dim phone As String = tbPhone.Text
        Dim UserRight As String = cbUserRight.Text

        'Select Case UserRight
        '    Case "操作員"
        '        UserRight = "3"
        '    Case "一般使用者"
        '        UserRight = "2"
        '    Case "系統管理員"
        '        UserRight = "1"
        'End Select


        Dim on_show As String = cbOnShow.Text


        If Me.cbOnShow.Text = "Y" Then
            on_show = "Y"
        Else
            on_show = "N"


        End If
        Dim seq_no As String = Me.tbLoginPassword.Text
        Dim ModUser As String = MainScript.UserName

        If id = String.Empty Then

            Me.myBindingSource.EndEdit()

            Dim sql As String

            sql = "Insert into UserMaster ( LoginName, LoginPassword, EnName, ChName, email, phone, UserRight, on_show, ModUser) " & _
                " VALUES ('" & _
LoginName & "','" & _
LoginPassword & "','" & _
EnName & "','" & _
ChName & "','" & _
email & "','" & _
phone & "','" & _
UserRight & "','" & _
 on_show & "','" & _
ModUser & "')"
                '        MainScript.TestSql(sql)


            MainScript.ControlDataAdapter(SqlCon, "Insert", sql).Update(myDT)


            MsgBox("成功新增")
        Else
            Me.myBindingSource.EndEdit()

            Dim sql As String = "Update UserMaster set " & _
                            " LoginName ='" + LoginName + "', " & _
" LoginPassword ='" + LoginPassword + "', " & _
" EnName ='" + EnName + "', " & _
" ChName ='" + ChName + "', " & _
" email ='" + email + "', " & _
" phone ='" + phone + "', " & _
" on_show ='" + on_show + "', " & _
" UserRight ='" + UserRight + "', " & _
" ModUser='" + MainScript.UserName + "'" & _
                                            " where UserId='" & id & "'"

            '  MainScript.TestSql(sql)
            ' MainScript.OperateData(sql)
            MainScript.ControlDataAdapter(MainScript.SqlCon, "Update", sql).Update(myDT)
            '    SqlAda.Update(myDT)
            MsgBox("成功儲存")
        


        End If
        Fstatus = 0
            SetButtons()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btModData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModData.Click
        Fstatus = 2
        SetButtons()

    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        Using a As New frmReportViewer


            Dim sql As String = "SELECT    UserId, LoginName, LoginPassword, EnName, ChName, email, phone, UserRight, on_show, sys_date, ModUser FROM UserMaster "
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptUserList.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsUserMaster_UserMaster", dt))
            a.Text = "使用者列表"

            a.ShowDialog()

        End Using
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        cbOnShow.Text = MainScript.GetDateByDataReader("SELECT on_show from  UserMaster where userid='" + tbID.Text + "'")
        cbUserRight.Text = MainScript.GetDateByDataReader("SELECT userright from  UserMaster where userid='" + tbID.Text + "'")
    End Sub
End Class