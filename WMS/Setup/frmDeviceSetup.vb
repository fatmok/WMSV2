Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmDeviceSetup
    Dim myDT As New DataTable
    Dim myBindingSource As New BindingSource
    Dim sql As String = "Select * From DeviceMaster"
    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))


    Dim Fstatus As Byte = 0


    Private Sub frmUserSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Dim sql As String = "Select * From DeviceMaster"
        Fstatus = 0
        Me.SetButtons()

        SqlAda.Fill(myDT)
        myBindingSource.DataSource = myDT


        tbDeviceId.DataBindings.Add("Text", myBindingSource, "DeviceId")
        tbDeviceSN.DataBindings.Add("Text", myBindingSource, "DeviceSN")
        tbDeviceRemark.DataBindings.Add("Text", myBindingSource, "DeviceRemark")
        tbSeqNo.DataBindings.Add("Text", myBindingSource, "seq_no")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        Me.BindingNavigator1.BindingSource = myBindingSource


        Me.lbUser.Text = MainScript.UserName


    End Sub
    Private Sub SetButtons()

        'FStatus:
        ' 0:瀏覽模式
        ' 1:新增模式
        ' 2:修改模式

        btAddNew.Enabled = (Fstatus = 0) ' And (AllowAddNew)

        btDel.Enabled = (Fstatus = 0) '((Fstatus = 1) Or (Fstatus = 2)) 'And (AllowDelete)
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
            FindID.SearchUnit = "  DeviceId, DeviceSN, DeviceRemark "



            FindID.bindSQL = "SELECT     DeviceId AS 編號, DeviceSN AS 硬件序號, DeviceRemark AS 備註, on_show AS 顯示, seq_no AS 排序, sys_date AS 修改日期, ModUser AS 經手人" & _
                            " FROM         DeviceMaster "


            tbDeviceId.Text = FindID.SearchID

            Dim sql As String = "SELECT     DeviceId, DeviceSN, DeviceRemark, on_show, sys_date, seq_no, ModUser FROM         DeviceMaster " & _
                            "  where DeviceId='" + tbDeviceId.Text + "'"


            ' MainScript.TestSql(sql)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbDeviceId.Text = dt.Rows(0)("DeviceId").ToString()
                tbDeviceSN.Text = dt.Rows(0)("DeviceSN").ToString()
                tbDeviceRemark.Text = dt.Rows(0)("DeviceRemark").ToString()
                tbSeqNo.Text = dt.Rows(0)("seq_no").ToString()
                tbSysDate.Text = dt.Rows(0)("sys_date").ToString()
                tbModUser.Text = dt.Rows(0)("ModUser").ToString()
                cbOnShow.Text = dt.Rows(0)("on_show").ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            blnValidation = False

        End Try
        'tbAttribName.Text = MainScript.GetVar("AttribName", "Customer", "CustomerID='" & tbCustomerID.Text)

        'tbAttribName.Focus()
        Return (blnValidation)
    End Function
    Public Sub SetDefult()
        'Me.tbID.Text = String.Empty
        'Me.tbModUser.Text = String.Empty
        'Me.tbCurrent.Text = String.Empty
        'Me.tbName.Text = String.Empty

        'Me.tbSeqNo.Text = "100"
        'Me.cbOnShow.Text = "Y"

        SqlAda.Fill(myDT)
        myBindingSource.DataSource = myDT


        tbDeviceId.DataBindings.Add("Text", myBindingSource, "DeviceId")
        tbDeviceSN.DataBindings.Add("Text", myBindingSource, "DeviceSN")
        tbDeviceRemark.DataBindings.Add("Text", myBindingSource, "DeviceRemark")
        tbSeqNo.DataBindings.Add("Text", myBindingSource, "seq_no")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        Me.BindingNavigator1.BindingSource = myBindingSource


    End Sub
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

        '    SqlAda.Update(myDT)
        'myBindingSource.RemoveCurrent()

        If MessageBox.Show("是否刪除?刪除的檔案不可被回復!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Try





                Dim id As String = Me.tbDeviceId.Text


                If id = String.Empty Then
                    MsgBox("您未選擇數據不能刪除")

                Else

                    Dim sqla As String = "Delete from DeviceMaster where DeviceId= '" & id & "'"

                    OperateData(sqla)

                    Me.myBindingSource.EndEdit()

                    MainScript.ControlDataAdapter(MainScript.SqlCon, "Select", sql).Update(myDT)


                    myBindingSource.RemoveCurrent()
                    MsgBox("成功刪除")



                End If
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
        Fstatus = 0
        Me.SetButtons()


    End Sub



    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim id As String = Me.tbDeviceId.Text
        Dim DeviceSN As String = Me.tbDeviceSN.Text
        Dim DeviceRemark As String = Me.tbDeviceRemark.Text
        Dim on_show As String
        ''If Me.rbOnShow.Checked = True Then
        ''    on_show = "Y"
        ''Else
        ''    on_show = "N"


        ''End If
        If Me.cbOnShow.Text = "Y" Then
            on_show = "Y"
        Else
            on_show = "N"


        End If
        Dim seq_no As String = Me.tbSeqNo.Text
        Dim ModUser As String = MainScript.UserName

        If id = String.Empty Then

            Me.myBindingSource.EndEdit()

            Dim sql As String


            sql = "Insert into DeviceMaster     (DeviceSN, DeviceRemark, on_show, seq_no, ModUser) " & _
                " VALUES ('" & _
                DeviceSN & "','" & _
                DeviceRemark & "','" & _
                on_show & "','" & _
                seq_no & "','" & _
                ModUser & "')"

            MainScript.ControlDataAdapter(SqlCon, "Insert", sql).Update(myDT)


            MsgBox("成功新增")
        Else
            Me.myBindingSource.EndEdit()

            Dim sql As String = "Update DeviceMaster set DeviceSN = '" & DeviceSN & _
                                "',DeviceRemark='" & DeviceRemark & _
                                 "',on_show='" & on_show & _
                                "',seq_no='" & seq_no & _
                                "',ModUser='" & MainScript.UserName & _
                                "' where DeviceId='" & id & "'"

            MainScript.ControlDataAdapter(MainScript.SqlCon, "Update", sql).Update(myDT)
            '    SqlAda.Update(myDT)
            MsgBox("成功儲存")



        End If
        Fstatus = 0
        SetButtons()
    End Sub


    Private Sub btModData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModData.Click
        Fstatus = 2
        SetButtons()

    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        Using a As New frmReportViewer


            Dim sql As String = "SELECT    DeviceId, DeviceSN, DeviceRemark, sys_date, seq_no, ModUser FROM DeviceMaster "
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptDeviceMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsDeviceMaster_DeviceMaster", dt))
            a.Text = "器材列表"


            a.ShowDialog()

        End Using
    End Sub

    Private Sub bt123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.myBindingSource.EndEdit()
        myBindingSource.RemoveCurrent()

        Me.myBindingSource.EndEdit()
        MsgBox("成功刪除")
    End Sub
End Class