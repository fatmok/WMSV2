Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmShopSetup
    Dim myDT As New DataTable
    Dim myBindingSource As New BindingSource
    Dim sql As String = "	SELECT     ShopMaster.ShopId, ShopMaster.ShopCustNo, ShopMaster.ShopName, StationMaster.StationName, CountryMaster.CountryName, DistrictMaster.DistrictName, 	 " & _
"	                      AreaMaster.AreaName, ShopMaster.ShopAddress, ShopMaster.ShopContact, ShopMaster.ShopTel, ShopMaster.ShopFax, ShopMaster.ShopRemark, 	 " & _
"	                      ShopMaster.on_show, ShopMaster.sys_date, ShopMaster.seq_no, ShopMaster.ModUser	 " & _
"	FROM         AreaMaster INNER JOIN	 " & _
"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId INNER JOIN	 " & _
"	                      ShopMaster ON AreaMaster.AreaId = ShopMaster.AreaId INNER JOIN	 " & _
"	                      StationMaster ON ShopMaster.StationId = StationMaster.StationId	 "






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
        MainScript.BindDropDownList("StationMaster", cbStationId, 1)


        tbShopId.DataBindings.Add("Text", myBindingSource, "ShopId")
        tbShopCustNo.DataBindings.Add("Text", myBindingSource, "ShopCustNo")
        tbShopName.DataBindings.Add("Text", myBindingSource, "ShopName")
        tbShopAddress.DataBindings.Add("Text", myBindingSource, "ShopAddress")
        tbShopContact.DataBindings.Add("Text", myBindingSource, "ShopContact")
        tbShopTel.DataBindings.Add("Text", myBindingSource, "ShopTel")
        tbShopFax.DataBindings.Add("Text", myBindingSource, "ShopFax")
        tbShopRemark.DataBindings.Add("Text", myBindingSource, "ShopRemark")
        cbStationId.DataBindings.Add("Text", myBindingSource, "StationName")
        cbAreaId.DataBindings.Add("Text", myBindingSource, "AreaName")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        tbSeqNo.DataBindings.Add("Text", myBindingSource, "seq_no")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
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



            FindID.bindSQL = "	SELECT     ShopMaster.ShopId AS 編號, ShopMaster.ShopCustNo AS 自訂編號, ShopMaster.ShopName AS 商舖名稱, StationMaster.StationName AS 工作站, 	 " & _
"	                      CountryMaster.CountryName AS 總區, DistrictMaster.DistrictName AS 地域, AreaMaster.AreaName AS 地區, ShopMaster.ShopAddress AS 地址, 	 " & _
"	                      ShopMaster.ShopContact AS 聯絡人, ShopMaster.ShopTel AS 電話, ShopMaster.ShopFax AS 傳真, ShopMaster.ShopRemark AS 備註, ShopMaster.on_show AS 顯示 	 " & _
"	                      ShopMaster.seq_no AS 排序, ShopMaster.ModUser AS 經手人, ShopMaster.sys_date AS 修改日期	 " & _
"	FROM         AreaMaster INNER JOIN	 " & _
"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId INNER JOIN	 " & _
"	                      ShopMaster ON AreaMaster.AreaId = ShopMaster.AreaId INNER JOIN	 " & _
"	                      StationMaster ON ShopMaster.StationId = StationMaster.StationId	 "



            tbShopId.Text = FindID.SearchID

            Dim sql As String = "	SELECT     ShopMaster.ShopId, ShopMaster.ShopCustNo, ShopMaster.ShopName, StationMaster.StationName, CountryMaster.CountryName, DistrictMaster.DistrictName, 	 " & _
"	                      AreaMaster.AreaName, ShopMaster.ShopAddress, ShopMaster.ShopContact, ShopMaster.ShopTel, ShopMaster.ShopFax, ShopMaster.ShopRemark, 	 " & _
"	                      ShopMaster.on_show, ShopMaster.sys_date, ShopMaster.seq_no, ShopMaster.ModUser	 " & _
"	FROM         AreaMaster INNER JOIN	 " & _
"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId INNER JOIN	 " & _
"	                      ShopMaster ON AreaMaster.AreaId = ShopMaster.AreaId INNER JOIN	 " & _
"	                      StationMaster ON ShopMaster.StationId = StationMaster.StationId	 " & _
                                                    " from ShopMaster  where ShopId='" + tbShopId.Text + "'"


            ' MainScript.TestSql(sql)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbShopId.Text = dt.Rows(0)("ShopId").ToString
                tbShopCustNo.Text = dt.Rows(0)("ShopCustNo").ToString
                tbShopName.Text = dt.Rows(0)("ShopName").ToString
                tbShopAddress.Text = dt.Rows(0)("ShopAddress").ToString
                tbShopContact.Text = dt.Rows(0)("ShopContact").ToString
                tbShopTel.Text = dt.Rows(0)("ShopTel").ToString
                tbShopFax.Text = dt.Rows(0)("ShopFax").ToString
                tbShopRemark.Text = dt.Rows(0)("ShopRemark").ToString
                cbStationId.Text = dt.Rows(0)("StationId").ToString
                cbAreaId.Text = dt.Rows(0)("AreaId").ToString
                cbOnShow.Text = dt.Rows(0)("on_show").ToString
                tbSysDate.Text = dt.Rows(0)("sys_date").ToString
                tbSeqNo.Text = dt.Rows(0)("seq_no").ToString
                tbModUser.Text = dt.Rows(0)("ModUser").ToString




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

        tbShopId.DataBindings.Add("Text", myBindingSource, "ShopId")
        tbShopCustNo.DataBindings.Add("Text", myBindingSource, "ShopCustNo")
        tbShopName.DataBindings.Add("Text", myBindingSource, "ShopName")
        tbShopAddress.DataBindings.Add("Text", myBindingSource, "ShopAddress")
        tbShopContact.DataBindings.Add("Text", myBindingSource, "ShopContact")
        tbShopTel.DataBindings.Add("Text", myBindingSource, "ShopTel")
        tbShopFax.DataBindings.Add("Text", myBindingSource, "ShopFax")
        tbShopRemark.DataBindings.Add("Text", myBindingSource, "ShopRemark")
        cbStationId.DataBindings.Add("Text", myBindingSource, "StationId")
        cbAreaId.DataBindings.Add("Text", myBindingSource, "AreaId")
        cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
        tbSysDate.DataBindings.Add("Text", myBindingSource, "sys_date")
        tbSeqNo.DataBindings.Add("Text", myBindingSource, "seq_no")
        tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")





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

            Dim id As String = Me.tbShopId.Text

            If id = String.Empty Then
                MsgBox("您未選擇數據不能刪除")

            Else

                Dim sql As String = "Delete from ShopMaster where ShopId= '" & id & "'"



                MainScript.ControlDataAdapter(MainScript.SqlCon, "Delete", sql).Update(myDT)
                '    SqlAda.Update(myDT)
                MsgBox("成功刪除")



            End If
        End If
    End Sub



    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        Dim DistrictId As String = FunctionScript.GetDistrictId(Me.cbDistrict.Text)


        Dim id As String = tbShopId.Text
        Dim ShopCustNo As String = tbShopCustNo.Text
        Dim ShopName As String = tbShopName.Text
        Dim ShopAddress As String = tbShopAddress.Text
        Dim ShopContact As String = tbShopContact.Text
        Dim ShopTel As String = tbShopTel.Text
        Dim ShopFax As String = tbShopFax.Text
        Dim ShopRemark As String = tbShopRemark.Text
        Dim StationId As String = FunctionScript.GetStationId(cbStationId.Text)
        Dim AreaId As String = FunctionScript.GetAreaId(cbAreaId.Text)


        

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

        If FunctionScript.CheckIdExist("shopId", "shopMaster", "shopCustNo = '" & Me.tbShopCustNo.Text & "' and shopId <> '" & Me.tbShopId.Text & "'") = True Then

            MsgBox("編號已存在不能加入")
            Exit Sub

        End If


        If id = String.Empty Then

            Me.myBindingSource.EndEdit()

            Dim sql As String


            sql = " INSERT INTO    shopMaster    ( " & _
" ShopId, " & _
" ShopCustNo, " & _
" ShopName, " & _
" ShopAddress, " & _
" ShopContact, " & _
" ShopTel, " & _
" ShopFax, " & _
" ShopRemark, " & _
" StationId, " & _
" AreaId, " & _
" on_show, " & _
" seq_no, " & _
" ModUser " & _
"  )  VALUES  ( " & _
" '" & ShopId & "'," & _
" '" & ShopCustNo & "'," & _
" '" & ShopName & "'," & _
" '" & ShopAddress & "'," & _
" '" & ShopContact & "'," & _
" '" & ShopTel & "'," & _
" '" & ShopFax & "'," & _
" '" & ShopRemark & "'," & _
" '" & StationId & "'," & _
" '" & AreaId & "'," & _
" '" & on_show & "'," & _
" '" & seq_no & "'," & _
" '" & ModUser & "'" & _
 ")"


            Try


                MainScript.ControlDataAdapter(SqlCon, "Insert", sql).Update(myDT)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            MsgBox("成功新增")
        Else
            Me.myBindingSource.EndEdit()

            Dim sql As String = " UPDATE       ShopMaster      SET " & _
" ShopId ='" & ShopId & "', " & _
" ShopCustNo ='" & ShopCustNo & "', " & _
" ShopName ='" & ShopName & "', " & _
" ShopAddress ='" & ShopAddress & "', " & _
" ShopContact ='" & ShopContact & "', " & _
" ShopTel ='" & ShopTel & "', " & _
" ShopFax ='" & ShopFax & "', " & _
" ShopRemark ='" & ShopRemark & "', " & _
" StationId ='" & StationId & "', " & _
" AreaId ='" & AreaId & "', " & _
" on_show ='" & on_show & "', " & _
" seq_no ='" & seq_no & "', " & _
" ModUser ='" & ModUser & "' " & _
                                            " where ShopId='" & id & "'"
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


            Dim sql As String = "	SELECT     ShopMaster.ShopId AS 編號, ShopMaster.ShopCustNo AS 自訂編號, ShopMaster.ShopName AS 商舖名稱, StationMaster.StationName AS 工作站, 	 " & _
"	                      CountryMaster.CountryName AS 總區, DistrictMaster.DistrictName AS 地域, AreaMaster.AreaName AS 地區, ShopMaster.ShopAddress AS 地址, 	 " & _
"	                      ShopMaster.ShopContact AS 聯絡人, ShopMaster.ShopTel AS 電話, ShopMaster.ShopFax AS 傳真, ShopMaster.ShopRemark AS 備註, ShopMaster.on_show AS 顯示, 	 " & _
"	                      ShopMaster.seq_no AS 排序, ShopMaster.ModUser AS 經手人, ShopMaster.sys_date AS 修改日期	 " & _
"	FROM         AreaMaster INNER JOIN	 " & _
"	                      DistrictMaster ON AreaMaster.DistrictId = DistrictMaster.DistrictId INNER JOIN	 " & _
"	                      CountryMaster ON DistrictMaster.CountryId = CountryMaster.CountryId INNER JOIN	 " & _
"	                      ShopMaster ON AreaMaster.AreaId = ShopMaster.AreaId INNER JOIN	 " & _
"	                      StationMaster ON ShopMaster.StationId = StationMaster.StationId	 "



            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            '   da.Fill(dt)






            '將ReportViewer1的DataSources集合清除
            a.ReportViewer1.LocalReport.ReportPath = "report\rptShopMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsShopMaster_ShopMaster", dt))
            a.Text = "商舖列表"

            a.ShowDialog()

        End Using

    End Sub

 



    Private Sub cbCountryId_SelectionChangeCommitted(sender As Object, e As EventArgs)
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

    Private Sub cbDistrict_SelectionChangeCommitted(sender As Object, e As EventArgs)
        If cbDistrict.Text <> "" Then


            cbAreaId.Items.Clear()
            cbAreaId.Text = ""
            'cbAreaId.SelectedIndex = 0
            MainScript.BindDropDownList("AreaMaster where DistrictId='" & FunctionScript.GetDistrictId(Me.cbDistrict.Text) & "'", cbAreaId, 1)
        End If
    End Sub

    Private Function tSearchSubInfo() As Boolean
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
               
                cbOnShow.Text = dt.Rows(0)("on_show").ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try
        'tbAttribName.Text = MainScript.GetVar("AttribName", "Customer", "CustomerID='" & tbCustomerID.Text)

        'tbAttribName.Focus()

    End Function

    Private Sub tbDec_TextChanged(sender As Object, e As EventArgs) Handles tbDeviceSN.TextChanged

    End Sub

    Private Sub tbDeviceRemark_TextChanged(sender As Object, e As EventArgs) Handles tbDeviceRemark.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub tbSearchDevice_Click(sender As Object, e As EventArgs) Handles tbSearchDevice.Click
        tSearchSubInfo()

    End Sub
    Private Sub AddDevice()
        Try
            If Me.tbDeviceId.Text = String.Empty Then
                MsgBox("你未選擇器材")
                Exit Sub

            End If
            '  MainScript.TestSql(Me.tbd)
            If Me.tbDeviceId.Text <> "" Then
                MsgBox("有關器材已使用中,不能加入")
                Exit Sub

            End If

            '            Dim DeviceLogId As String = tbDeviceLogId.Text
            Dim ShopId As String = tbShopId.Text
            Dim DeviceId As String = tbDeviceId.Text
            Dim status As String = cbStatus.Text
            Dim ModUser As String = tbModUser.Text



            Dim sql As String
            sql = " INSERT INTO    DeviceLog   ( " & _
" ShopId, " & _
" DeviceId, " & _
" status, " & _
" ModUser " & _
"  )  VALUES  ( " & _
" '" & ShopId & "'," & _
" '" & DeviceId & "'," & _
" '" & status & "'," & _
" '" & ModUser & "')"

            OperateData(sql)
            MsgBox("新增成功")







        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btAddN_Click(sender As Object, e As EventArgs) Handles btAddN.Click
        AddDevice()
        BindDgvData()
    End Sub
    Private Sub BindDgvData()
        Me.dgvMain.DataSource = Nothing
        Me.dgvMain.Columns.Clear()

        Dim sql As String = "	SELECT     DeviceLog.DeviceLogId AS 編號, DeviceMaster.DeviceSN AS 器材序號, DeviceMaster.DeviceRemark AS 備註, DeviceLog.status AS 狀態, 	 " & _
"	                      DeviceLog.sys_date AS 修改日期, DeviceLog.ModUser AS 經手人	 " & _
"	FROM         DeviceLog LEFT OUTER JOIN	 " & _
"	                      DeviceMaster ON DeviceLog.DeviceId = DeviceMaster.DeviceId where  DeviceLog.shopid =  '" + Me.tbShopId.Text + "'"

        MainScript.BindDGV(sql, dgvMain)

    End Sub
    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        BindDgvData()
    End Sub
End Class