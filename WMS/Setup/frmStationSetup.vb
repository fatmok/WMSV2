Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmStationSetup
    Dim myDT As New DataTable
    Dim myBindingSource As New BindingSource
    Dim sql As String = "SELECT     StationMaster.StationId, CountryMaster.CountryName, AreaMaster.AreaName, DistrictMaster.DistrictName, StationMaster.StationCustNo, StationMaster.StationName, " & _
                   "   StationMaster.StationAddress, StationMaster.StationRemark, StationMaster.ModUser, StationMaster.sys_date, StationMaster.on_show " & _
" FROM         StationMaster INNER JOIN " & _
  "                     AreaMaster ON StationMaster.AreaId = AreaMaster.AreaId INNER JOIN " & _
    "                   DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN " & _
      "                 CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId "




    ' = " SELECT          DistrictMaster.DistrictName, AreaMaster.AreaId, AreaMaster.AreaName, AreaMaster.DistrictId, AreaMaster.on_show,  " & _
    '"                             AreaMaster.sys_date, AreaMaster.seq_no, AreaMaster.ModUser " & _
    '" FROM              AreaMaster LEFT OUTER JOIN " & _
    '"                             DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId "


    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))


    Dim Fstatus As Byte = 0


    Private Sub frmUserSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Dim sql As String = "Select * From AreaMaster"
        Fstatus = 0
        Me.SetButtons()

        SqlAda.Fill(myDT)
        myBindingSource.DataSource = myDT
        MainScript.BindDropDownList("CountryMaster", cbCountryID, 1)
        MainScript.BindDropDownList("AreaMaster", cbAreaId, 1)


        MainScript.BindDropDownList("DistrictMaster", cbDistrict, 1)
        tbStationId.DataBindings.Add("Text", myBindingSource, "StationId")

        tbStationCustNo.DataBindings.Add("Text", myBindingSource, "StationCustNo")
        tbStationName.DataBindings.Add("Text", myBindingSource, "StationName")
        cbAreaId.DataBindings.Add("Text", myBindingSource, "AreaName")
        tbStationAddress.DataBindings.Add("Text", myBindingSource, "StationAddress")
        tbStationRemark.DataBindings.Add("Text", myBindingSource, "StationRemark")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        cbDistrict.DataBindings.Add("Text", myBindingSource, "DistrictName")
        cbCountryId.DataBindings.Add("Text", myBindingSource, "CountryName")
    


        Me.BindingNavigator1.BindingSource = myBindingSource

        Me.lbUser.Text = MainScript.UserName

        '        Dim sql2 As String = "	SELECT     CountryMaster.CountryName, DistrictMaster.DistrictName, AreaMaster.AreaName	 " & _
        '"	FROM         AreaMaster INNER JOIN	 " & _
        '"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
        '"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId	 " & _
        '" where AreaMaster.AreaId='" & FunctionScript.GetAreaId(Me.cbAreaId.Text) & "'"
        '        '  MainScript.TestSql(sql2)
        '        Dim dt1 As DataTable = MainScript.GetDataTable(sql2)

        '        If dt1.Rows.Count <> 0 Then
        '            Me.cbCountryId.Text = dt1.Rows(0)("CountryName")
        '            Me.cbDistrict.Text = dt1.Rows(0)("DistrictName")
        '            '  Me.cbAreaId.Text = dt1.Rows(0)("AreaName")
        '        End If



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
            FindID.SearchUnit = "  StationCustNo, StationName,  StationAddress "



            FindID.bindSQL = "SELECT     StationId AS 編號, StationCustNo AS 自訂編號, StationName AS 工作站名稱, AreaId AS 地區, StationAddress AS 地址, StationRemark AS 備註, ModUser AS 經手人, " & _
                    "  sys_date AS 修改日期, on_show AS 顯示    FROM StationMaster "


            tbStationId.Text = FindID.SearchID

            Dim sql As String = " SELECT " & _
" StationId, " & _
" StationCustNo, " & _
" StationName, " & _
" AreaId, " & _
" StationAddress, " & _
" StationRemark, " & _
" ModUser, " & _
" sys_date, " & _
" on_show, " & _
" createDate, " & _
" createor " & _
                                        " from StationMaster  where StationId='" + tbStationId.Text + "'"


            ' MainScript.TestSql(sql)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbStationId.Text = dt.Rows(0)("StationId").ToString
                tbStationCustNo.Text = dt.Rows(0)("StationCustNo").ToString
                tbStationName.Text = dt.Rows(0)("StationName").ToString
                cbAreaId.Text = dt.Rows(0)("AreaId").ToString
                tbStationAddress.Text = dt.Rows(0)("StationAddress").ToString
                tbStationRemark.Text = dt.Rows(0)("StationRemark").ToString
                tbModUser.Text = dt.Rows(0)("ModUser").ToString
                tbSysDate.Text = dt.Rows(0)("sys_date").ToString
                cbOnShow.Text = dt.Rows(0)("on_show").ToString
               


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

        tbStationId.DataBindings.Add("Text", myBindingSource, "StationId")
        tbStationCustNo.DataBindings.Add("Text", myBindingSource, "StationCustNo")
        tbStationName.DataBindings.Add("Text", myBindingSource, "StationName")
        cbAreaId.DataBindings.Add("Text", myBindingSource, "AreaId")
        tbStationAddress.DataBindings.Add("Text", myBindingSource, "StationAddress")
        tbStationRemark.DataBindings.Add("Text", myBindingSource, "StationRemark")
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
        If MessageBox.Show("是否刪除?刪除的檔案不可被回復!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then



            Me.myBindingSource.EndEdit()

            Dim id As String = Me.tbStationId.Text

            If id = String.Empty Then
                MsgBox("您未選擇數據不能刪除")

            Else

                Dim sql As String = "Delete from StationMaster where StationId= '" & id & "'"



                MainScript.ControlDataAdapter(MainScript.SqlCon, "Delete", sql).Update(myDT)
                '    SqlAda.Update(myDT)
                MsgBox("成功刪除")



            End If
        End If
    End Sub



    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
       
        Dim DistrictId As String = FunctionScript.GetDistrictId(Me.cbDistrict.Text)


        Dim id As String = tbStationId.Text
        Dim StationCustNo As String = tbStationCustNo.Text
        Dim StationName As String = tbStationName.Text
        Dim AreaId As String = FunctionScript.GetAreaId(Me.cbAreaId.Text)
        Dim StationAddress As String = tbStationAddress.Text
        Dim StationRemark As String = tbStationRemark.Text
        ' Dim ModUser As String = tbModUser.Text
        'Dim sys_date As String = tbSysDate.Text
        Dim on_show As String




        If Me.cbOnShow.Text = "Y" Then
            on_show = "Y"
        Else
            on_show = "N"


        End If
        Dim seq_no As String = Me.tbSeqNo.Text
        Dim ModUser As String = MainScript.UserName

        If FunctionScript.CheckIdExist("StationId", "StationMaster", "StationCustNo = '" & Me.tbStationCustNo.Text & "' and StationId <> '" & Me.tbStationId.Text & "'") = True Then

            MsgBox("編號已存在不能加入")
            Exit Sub

        End If


        If id = String.Empty Then

            Me.myBindingSource.EndEdit()

            Dim sql As String


            sql = " INSERT INTO    StationMaster    ( " & _
" StationCustNo, " & _
" StationName, " & _
" AreaId, " & _
" StationAddress, " & _
" StationRemark, " & _
" ModUser, " & _
" on_show " & _
"  )  VALUES  ( " & _
" '" & StationCustNo & "'," & _
" '" & StationName & "'," & _
" '" & AreaId & "'," & _
" '" & StationAddress & "'," & _
" '" & StationRemark & "'," & _
" '" & ModUser & "'," & _
" '" & on_show & "')"


            Try


                MainScript.ControlDataAdapter(SqlCon, "Insert", sql).Update(myDT)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            MsgBox("成功新增")
        Else
            Me.myBindingSource.EndEdit()

            Dim sql As String = " UPDATE       StationMaster      SET " & _
" StationCustNo ='" & StationCustNo & "', " & _
" StationName ='" & StationName & "', " & _
" AreaId ='" & AreaId & "', " & _
" StationAddress ='" & StationAddress & "', " & _
" StationRemark ='" & StationRemark & "', " & _
" ModUser ='" & ModUser & "', " & _
" on_show ='" & on_show & "' " & _
                                            " where StationId='" & id & "'"
            '     MainScript.TestSql(sql)
            Try



                MainScript.ControlDataAdapter(MainScript.SqlCon, "Update", sql).Update(myDT)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

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


            Dim sql As String = "	SELECT     StationMaster.StationId, StationMaster.StationCustNo, StationMaster.StationName, StationMaster.StationAddress, StationMaster.StationRemark, 	 " & _
"	                      StationMaster.ModUser, StationMaster.sys_date, StationMaster.on_show, AreaMaster.AreaName, CountryMaster.CountryName, DistrictMaster.DistrictName	 " & _
"	FROM         AreaMaster INNER JOIN	 " & _
"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId INNER JOIN	 " & _
"	                      StationMaster ON AreaMaster.AreaId = StationMaster.AreaId	 "


            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            '   da.Fill(dt)






            '將ReportViewer1的DataSources集合清除
            a.ReportViewer1.LocalReport.ReportPath = "report\rptStationMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsStationMaster_StationMaster", dt))
            a.Text = "列表"

            a.ShowDialog()

        End Using

    End Sub

    Private Sub cbCountryId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCountryId.SelectedIndexChanged

        'If cbCountryId.Text <> "" Then
        '    cbDistrict.Items.Clear()
        '    cbDistrict.SelectedIndex = 0


        '    MainScript.BindDropDownList("DistrictMaster where CountryId='" & FunctionScript.GetCountryId(Me.cbCountryId.Text) & "'", cbDistrict, 1)

        'End If





    End Sub

    Private Sub cbDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDistrict.SelectedIndexChanged
        'If cbDistrict.Text <> "" Then


        '    cbAreaId.Items.Clear()
        '    'cbAreaId.Text = ""
        '    'cbAreaId.SelectedIndex = 0
        '    MainScript.BindDropDownList("AreaMaster where DistrictId='" & FunctionScript.GetDistrictId(Me.cbDistrict.Text) & "'", cbAreaId, 1)
        'End If
    End Sub

   
   
    Private Sub cbCountryId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCountryId.SelectionChangeCommitted
        If cbCountryId.Text <> "" Then
            cbDistrict.Items.Clear()
            '  cbDistrict.SelectedIndex = 0
            '   cbAreaId.Items.Clear()
            cbDistrict.Text = ""
            '     cbAreaId.Text = ""
            MainScript.BindDropDownList("DistrictMaster where CountryId='" & FunctionScript.GetCountryId(Me.cbCountryId.Text) & "'", cbDistrict, 1)
            '     MainScript.BindDropDownList("AreaMaster where DistrictId='" & FunctionScript.GetDistrictId(Me.cbDistrict.Text) & "'", cbAreaId, 1)
        End If
    End Sub

    Private Sub cbDistrict_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDistrict.SelectionChangeCommitted
        If cbDistrict.Text <> "" Then


            cbAreaId.Items.Clear()
            cbAreaId.Text = ""
            'cbAreaId.SelectedIndex = 0
            MainScript.BindDropDownList("AreaMaster where DistrictId='" & FunctionScript.GetDistrictId(Me.cbDistrict.Text) & "'", cbAreaId, 1)
        End If
    End Sub
End Class