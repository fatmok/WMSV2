Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class tbModelNO
    Dim myDT As New DataTable
    Dim myBindingSource As New BindingSource
    Dim sql As String = _
        " SELECT     AreaMaster.AreaName, CountryMaster.CountryName, GarbageCatMaster.GarbageCatName, " & _
    "GarbageSubCatMaster.GarbageSubCatName, BinMaster.BinId, BinMaster.CustNo, BinMaster.ModelNO,  " & _
    "BinMaster.Size, BinMaster.NetWeight, BinMaster.Capacity, BinMaster.RFID, BinMaster.DecCode1, BinMaster.RFID2, " & _
    "BinMaster.DecCode2, BinMaster.address, BinMaster.remark, " & _
    "BinMaster.on_show, BinMaster.ModUser, BinMaster.sys_date, BinMaster.StationNo " & _
    "FROM         GarbageSubCatMaster RIGHT OUTER JOIN " & _
    "BinMaster ON GarbageSubCatMaster.GarbageSubCatId = BinMaster.GarbageSubCat LEFT OUTER JOIN " & _
    "GarbageCatMaster ON BinMaster.GarbageCat = GarbageCatMaster.GarbageCatId LEFT OUTER JOIN " & _
    "AreaMaster LEFT OUTER JOIN " & _
    "CountryMaster ON AreaMaster.CountryId = CountryMaster.CountryId ON BinMaster.AreaId = AreaMaster.AreaId"


    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))


    Dim Fstatus As Byte = 0


    Private Sub frmUserSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            ' Dim sql As String = "Select * From CountryMaster"
            Fstatus = 0
            Me.SetButtons()

            SqlAda.Fill(myDT)
            myBindingSource.DataSource = myDT
            MainScript.BindDropDownList("CountryMaster", cbCountryID, 1)
            MainScript.BindDropDownList("AreaMaster", cbAreaID, 1)
            MainScript.BindDropDownList("GarbageCatMaster", cbGarbageCat, 1)
            MainScript.BindDropDownList("GarbageSubCatMaster", cbGarbageSubCat, 1)

            tbBinId.DataBindings.Add("Text", myBindingSource, "BinId")
            tbCustNo.DataBindings.Add("Text", myBindingSource, "CustNo")
            cbModelNo.DataBindings.Add("Text", myBindingSource, "ModelNO")
            tbSize.DataBindings.Add("Text", myBindingSource, "Size")
            cbGarbageCat.DataBindings.Add("Text", myBindingSource, "GarbageCatName")
            cbGarbageSubCat.DataBindings.Add("Text", myBindingSource, "GarbageSubCatName")
            tbStationNo.DataBindings.Add("Text", myBindingSource, "StationNo")
            tbNetWeight.DataBindings.Add("Text", myBindingSource, "NetWeight")
            tbCapacity.DataBindings.Add("Text", myBindingSource, "Capacity")
            'tbRFID.DataBindings.Add("Text", myBindingSource, "RFID")
            'tbRFID2.DataBindings.Add("Text", myBindingSource, "RFID2")
            'cbAreaID.DataBindings.Add("Text", myBindingSource, "AreaId")
            'cbCountryID.DataBindings.Add("Text", myBindingSource, "CountryId")
            cbAreaID.DataBindings.Add("Text", myBindingSource, "AreaName")
            cbCountryID.DataBindings.Add("Text", myBindingSource, "CountryName")
            tbAddress.DataBindings.Add("Text", myBindingSource, "address")
            tbRemark.DataBindings.Add("Text", myBindingSource, "remark")
            cbOnShow.DataBindings.Add("Text", myBindingSource, "on_show")
            tbModUser.DataBindings.Add("Text", myBindingSource, "ModUser")
            'tbDecCode1.DataBindings.Add("Text", myBindingSource, "DecCode1")
            'tbDecCode2.DataBindings.Add("Text", myBindingSource, "DecCode2")

            Me.BindingNavigator1.BindingSource = myBindingSource

            Me.lbUser.Text = MainScript.UserName

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub BindDgvData()
        Me.dgvMain.DataSource = Nothing
        Me.dgvMain.Columns.Clear()

        Dim sql As String = "select cardid as CardID,RFID,DecCode as DEC ,ON_SHOW AS STATUS from CardMaster where Binid='" + Me.tbBinID.Text + "'"
        MainScript.BindDGV(sql, dgvMain)

    End Sub
    Private Sub SetButtons()

        'FStatus:
        ' 0:瀏覽模式
        ' 1:新增模式
        ' 2:修改模式

        btAddNew.Enabled = (Fstatus = 0) ' And (AllowAddNew)

        btDel.Enabled = ((Fstatus = 0))
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
            FindID.SearchUnit = " CustNo, ModelNO, Size, NetWeight, Capacity,  address, remark,"



            FindID.bindSQL = "SELECT     BinMaster.BinId AS 編號, BinMaster.CustNo AS 自定編號, BinMaster.ModelNO AS 型號, BinMaster.GarbageCat as 垃圾大分類,BinMaster.GarbageSubCat as 垃圾小分類,BinMaster.StationNo  as 地區編號,BinMaster.Size AS 呎吋, BinMaster.NetWeight AS 淨重, " & _
            " BinMaster.Capacity AS 容量,  CountryMaster.CountryName AS 總區, AreaMaster.AreaName AS 地區, BinMaster.address AS 地址,  " & _
            " BinMaster.remark AS 備註, BinMaster.on_show AS 顯示, BinMaster.ModUser AS 經手人, BinMaster.sys_date AS 修改日期" & _
            " FROM         BinMaster LEFT OUTER JOIN " & _
            " AreaMaster ON BinMaster.AreaId = AreaMaster.AreaId LEFT OUTER JOIN " & _
            " CountryMaster ON BinMaster.CountryId = CountryMaster.CountryId "


            tbBinID.Text = FindID.SearchID

            Dim sql As String = "select BinId, CustNo, ModelNO, Size, NetWeight, Capacity, StationNO,GarbageCat,GarbageSubCat,AreaId, CountryId, address, remark, on_show, ModUser,     sys_date from BinMaster " & _
                            "  where BinId='" + tbBinID.Text + "'"


            '  MainScript.TestSql(FindID.bindSQL)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbBinID.Text = dt.Rows(0)("BinId").ToString()
                tbCustNo.Text = dt.Rows(0)("CustNo").ToString()
                cbModelNo.Text = dt.Rows(0)("ModelNO").ToString()
                tbSize.Text = dt.Rows(0)("Size").ToString()
                tbNetWeight.Text = dt.Rows(0)("NetWeight").ToString()
                tbCapacity.Text = dt.Rows(0)("Capacity").ToString()
                'tbRFID.Text = dt.Rows(0)("RFID").ToString()
                'tbRFID2.Text = dt.Rows(0)("RFID2").ToString()
                cbGarbageCat.Text = FunctionScript.GetGarbageCatName(dt.Rows(0)("GarbageCat").ToString())
                cbGarbageSubCat.Text = FunctionScript.GetGarbageSubCatName(dt.Rows(0)("GarbageSubCat").ToString())
                tbStationNo.Text = dt.Rows(0)("StationNo").ToString()
                cbAreaID.Text = FunctionScript.GetAreaId(dt.Rows(0)("AreaId").ToString())

                cbCountryID.Text = FunctionScript.GetCountryName(dt.Rows(0)("CountryId").ToString())

                tbAddress.Text = dt.Rows(0)("address").ToString()
                tbRemark.Text = dt.Rows(0)("remark").ToString()
                cbOnShow.Text = dt.Rows(0)("on_show").ToString()
                tbModUser.Text = dt.Rows(0)("ModUser").ToString()
                tbSysDate.Text = dt.Rows(0)("sys_date").ToString()
                'tbDecCode1.Text = dt.Rows(0)("DecCode1").ToString()
                'tbDecCode2.Text = dt.Rows(0)("DecCode2").ToString()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            blnValidation = False

        End Try
        'tbAttribName.Text = MainScript.GetVar("AttribName", "Customer", "CustomerID='" & tbCustomerID.Text)

        'tbAttribName.Focus()
        Return (blnValidation)
    End Function
    Private Function tSearchSubInfo() As Boolean
        Dim blnValidation As Boolean = False

        Try


            Dim FindID As New TListReturnID
            FindID.SearchUnit = " CustNo, ModelNO, Size, NetWeight, Capacity,  address, remark,"



            FindID.bindSQL = "SELECT     BinMaster.BinId AS 編號, BinMaster.CustNo AS 自定編號, BinMaster.ModelNO AS 型號, BinMaster.GarbageCat as 垃圾大分類,BinMaster.GarbageSubCat as 垃圾小分類,BinMaster.StationNo  as 地區編號,BinMaster.Size AS 呎吋, BinMaster.NetWeight AS 淨重, " & _
            " BinMaster.Capacity AS 容量,  CountryMaster.CountryName AS 總區, AreaMaster.AreaName AS 地區, BinMaster.address AS 地址,  " & _
            " BinMaster.remark AS 備註, BinMaster.on_show AS 顯示, BinMaster.ModUser AS 經手人, BinMaster.sys_date AS 修改日期" & _
            " FROM         BinMaster LEFT OUTER JOIN " & _
            " AreaMaster ON BinMaster.AreaId = AreaMaster.AreaId LEFT OUTER JOIN " & _
            " CountryMaster ON BinMaster.CountryId = CountryMaster.CountryId "


            tbBinID.Text = FindID.SearchID

            Dim sql As String = "select BinId, CustNo, ModelNO, Size, NetWeight, Capacity, StationNO,GarbageCat,GarbageSubCat,AreaId, CountryId, address, remark, on_show, ModUser,     sys_date from BinMaster " & _
                            "  where BinId='" + tbBinID.Text + "'"


            '  MainScript.TestSql(FindID.bindSQL)

            ' Dim dt As DataTable = MainScript.GetDataTable(sql)
            Dim dt As DataTable = MainScript.GetDataTable(sql)


            If dt.Rows.Count <> 0 Then

                tbBinID.Text = dt.Rows(0)("BinId").ToString()
                tbCustNo.Text = dt.Rows(0)("CustNo").ToString()
                cbModelNo.Text = dt.Rows(0)("ModelNO").ToString()
                tbSize.Text = dt.Rows(0)("Size").ToString()
                tbNetWeight.Text = dt.Rows(0)("NetWeight").ToString()
                tbCapacity.Text = dt.Rows(0)("Capacity").ToString()
                'tbRFID.Text = dt.Rows(0)("RFID").ToString()
                'tbRFID2.Text = dt.Rows(0)("RFID2").ToString()
                cbGarbageCat.Text = FunctionScript.GetGarbageCatName(dt.Rows(0)("GarbageCat").ToString())
                cbGarbageSubCat.Text = FunctionScript.GetGarbageSubCatName(dt.Rows(0)("GarbageSubCat").ToString())
                tbStationNo.Text = dt.Rows(0)("StationNo").ToString()
                cbAreaID.Text = FunctionScript.GetAreaId(dt.Rows(0)("AreaId").ToString())

                cbCountryID.Text = FunctionScript.GetCountryName(dt.Rows(0)("CountryId").ToString())

                tbAddress.Text = dt.Rows(0)("address").ToString()
                tbRemark.Text = dt.Rows(0)("remark").ToString()
                cbOnShow.Text = dt.Rows(0)("on_show").ToString()
                tbModUser.Text = dt.Rows(0)("ModUser").ToString()
                tbSysDate.Text = dt.Rows(0)("sys_date").ToString()
                'tbDecCode1.Text = dt.Rows(0)("DecCode1").ToString()
                'tbDecCode2.Text = dt.Rows(0)("DecCode2").ToString()

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

            Dim id As String = Me.tbBinID.Text

            If id = String.Empty Then
                MsgBox("您未選擇數據不能刪除")

            Else

                Dim sql As String = "Delete from BinMaster where BinId= '" & id & "'"

                OperateData(sql)

                Me.myBindingSource.EndEdit()

                MainScript.ControlDataAdapter(MainScript.SqlCon, "Select", sql).Update(myDT)


                myBindingSource.RemoveCurrent()
                '    SqlAda.Update(myDT)
                MsgBox("成功刪除")



            End If
        End If
    End Sub



    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim Id As String = tbBinID.Text
        Dim CustNo As String = tbCustNo.Text
        Dim ModelNO As String = cbModelNo.Text
        Dim Size As String = tbSize.Text
        Dim NetWeight As String = tbNetWeight.Text
        Dim Capacity As String = tbCapacity.Text
        'Dim RFID As String = tbRFID.Text
        'Dim RFID2 As String = tbRFID2.Text
        '   MsgBox(cbAreaID.Text)
        'Dim DecCode1 As String = tbDecCode1.Text
        'Dim DecCode2 As String = tbDecCode2.Text
        Dim AreaId As String = FunctionScript.GetAreaId(cbAreaID.Text)
        Dim CountryId As String = FunctionScript.GetCountryId(cbCountryID.Text)
        Dim GarbageCat As String = FunctionScript.GetGarbageCatId(cbGarbageCat.Text)
        Dim GarbagesubCat As String = FunctionScript.GetGarbageSubCatId(cbGarbageSubCat.Text)
        Dim StationNo As String = tbStationNo.Text

        Dim address As String = tbAddress.Text
        Dim remark As String = tbRemark.Text
        Dim on_show As String = cbOnShow.Text
        Dim ModUser As String = tbModUser.Text



        If id = String.Empty Then

            Me.myBindingSource.EndEdit()

            Dim sql As String


            sql = "Insert into BinMaster     (  CustNo, ModelNO, Size, NetWeight, Capacity, AreaId, CountryId, address, remark, on_show,StationNO,GarbageCat,GarbageSubCat, ModUser) " & _
                " VALUES ('" & _
                CustNo & "','" & _
                ModelNO & "','" & _
                Size & "','" & _
                NetWeight & "','" & _
                Capacity & "','" & _
                      AreaId & "','" & _
                CountryId & "','" & _
                address & "','" & _
                remark & "','" & _
                on_show & "','" & _
                      StationNo & "','" & _
                GarbageCat & "','" & _
                GarbagesubCat & "','" & _
                ModUser & "')"

            MainScript.ControlDataAdapter(SqlCon, "Insert", sql).Update(myDT)


            MsgBox("成功新增")
        Else
            Me.myBindingSource.EndEdit()

            Dim sql As String = "Update BinMaster set " & _
" CustNo ='" + CustNo + "', " & _
" ModelNO ='" + ModelNO + "', " & _
" Size ='" + Size + "', " & _
" NetWeight ='" + NetWeight + "', " & _
" Capacity ='" + Capacity + "', " & _
" AreaId ='" + AreaId + "', " & _
" CountryId ='" + CountryId + "', " & _
" address ='" + address + "', " & _
" remark ='" + remark + "', " & _
" on_show ='" + on_show + "', " & _
" StationNo ='" + StationNo + "', " & _
" GarbageCat ='" + GarbageCat + "', " & _
" GarbageSubCat ='" + GarbagesubCat + "', " & _
" ModUser ='" + ModUser + "' " & _
                                " where BinId='" & Id & "'"
            '  MainScript.TestSql(sql)

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


            Dim sql As String = " SELECT  CountryMaster.CountryName, AreaMaster.AreaName, " & _
            " BinMaster.CustNo, BinMaster.ModelNO, BinMaster.Size, BinMaster.NetWeight, " & _
            " BinMaster.Capacity, " & _
            " BinMaster.address, BinMaster.remark, BinMaster.ModUser, BinMaster.sys_date, " & _
            " GarbageCatMaster.GarbageCatName, " & _
            " GarbageSubCatMaster.GarbageSubCatName, BinMaster.StationNo, BinMaster.on_show " & _
            " FROM     GarbageSubCatMaster RIGHT OUTER JOIN  " & _
            " BinMaster ON GarbageSubCatMaster.GarbageSubCatId = BinMaster.GarbageSubCat " & _
            " LEFT OUTER JOIN " & _
            " GarbageCatMaster ON BinMaster.GarbageCat = GarbageCatMaster.GarbageCatId " & _
            " LEFT OUTER JOIN               AreaMaster LEFT OUTER JOIN " & _
            " CountryMaster ON AreaMaster.CountryId = CountryMaster.CountryId " & _
            " ON BinMaster.AreaId = AreaMaster.AreaId "
            'MainScript.TestSql(sql)
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptBinMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsBinMaster_BinMaster", dt))
            a.Text = "垃圾桶列表"


            a.ShowDialog()

        End Using
    End Sub

    Private Sub tbRemark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbOnShow_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbRFID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        BindDgvData()

    End Sub
    Private Sub ReturnData()
        Try

        
        Dim Row As Int16 = Me.dgvMain.CurrentRow.Index
        Dim id As String = Me.dgvMain.Item(0, Row).Value
            Me.tbDeviceId.Text = id
            Me.tbRFID.Text = Me.dgvMain.Item(1, Row).Value
            Me.tbDec.Text = Me.dgvMain.Item(2, Row).Value
            Me.cbCardOnShow.Text = Me.dgvMain.Item(3, Row).Value

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick
        ReturnData()
    End Sub
    Private Sub SetCardDefault()
        tbDeviceId.Text = String.Empty
        tbRFID.Text = String.Empty
        tbDec.Text = String.Empty
        cbCardOnShow.Text = "Y"
        tbRFID.Focus()
    End Sub
    Private Sub btAddN_Click(sender As Object, e As EventArgs) Handles btAddN.Click

        SetCardDefault()

        MessageBox.Show("Please Input Card Detail")
    End Sub

    Private Sub btCardSave_Click(sender As Object, e As EventArgs) Handles btCardSave.Click
        Try
            Dim Binid As String = Me.tbBinID.Text
            Dim cardid As String = Me.tbDeviceId.Text
            Dim rfid As String = Me.tbRFID.Text
            Dim dec As String = Me.tbDec.Text
            Dim on_show As String = cbCardOnShow.Text

            If Me.tbRFID.Text = String.Empty Then
                MessageBox.Show("必需輸入咭資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim checkCard As String = "select RFID from CardMaster where RFID='" + Me.tbRFID.Text + "'"

            If Me.tbDeviceId.Text = String.Empty Then
                Dim dt As DataTable = MainScript.GetDataTable(checkCard)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("咭號已存在不能加入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else

                    Dim sqlAdd As String = _
                        " INSERT INTO CardMaster " & _
                      " (BinId, RFID, DecCode, on_show,ModUser)" & _
                      " VALUES('" + Binid + "','" + rfid + "','" + dec + "' ,'" + on_show + "','" + MainScript.UserName + "' )"

                    OperateData(sqlAdd)
                    MsgBox("新增成功")


                End If
            Else
                Dim sqlUpdate As String = _
                    "UPDATE    CardMaster " & _
                    "   SET   RFID ='" & rfid & "', DecCode ='" & dec & "', on_show ='" & on_show & "', ModUser ='" & MainScript.UserName & "' where cardid ='" & tbDeviceId.Text & "'"
                ' MainScript.TestSql(sqlUpdate)
                OperateData(sqlUpdate)
                MsgBox("更新成功")


            End If
            SetCardDefault()
            BindDgvData()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btCardDel_Click(sender As Object, e As EventArgs) Handles btCardDel.Click
        If Me.tbDeviceId.Text = String.Empty Then
            MessageBox.Show("必需選擇咭資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            If MessageBox.Show("是否刪除?刪除後不能被回復!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                Dim sql As String = "Delete cardmaster where cardid ='" + tbDeviceId.Text + "'"
                OperateData(sql)
                MsgBox("已成功刪除")
            End If

        End If
        SetCardDefault()
        BindDgvData()
    End Sub

    Private Sub dgvMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellClick
        ReturnData()
    End Sub
End Class