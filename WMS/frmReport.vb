Imports Microsoft.Reporting.WinForms
Public Class frmReport


    Private Sub btUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUserList.Click
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

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Dispose()

    End Sub

    Private Sub btCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCountry.Click
        Using a As New frmReportViewer


            Dim sql As String = "SELECT    CountryId, CountryName, CountryCurrent, sys_date, seq_no, ModUser FROM CountryMaster "
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptCountryList.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsCountryMaster_CountryMaster", dt))

            a.Text = "總區列表"
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btArea.Click



        Using a As New frmReportViewer


            Dim sql As String = " SELECT      AreaMaster.AreaId, AreaMaster.AreaName, AreaMaster.CountryId, AreaMaster.on_show, AreaMaster.sys_date, AreaMaster.seq_no, AreaMaster.ModUser,  " & _
"                       CountryMaster.CountryName " & _
" FROM         AreaMaster LEFT OUTER JOIN " & _
"                       CountryMaster ON AreaMaster.CountryId = CountryMaster.CountryId "

            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            '   da.Fill(dt)






            '將ReportViewer1的DataSources集合清除
            a.ReportViewer1.LocalReport.ReportPath = "report\rptAreaMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsAreaMaster_AreaMaster", dt))
            a.Text = "地區列表"

            a.ShowDialog()

        End Using




    End Sub

    Private Sub btBinList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBinList.Click
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

    Private Sub btLogMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogMaster.Click
        Using a As New frmReportDateSelector
            a.ShowDialog()




        End Using
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbUser.Text = MainScript.UserName
    End Sub

    Private Sub btSummaryReport_Click(sender As Object, e As EventArgs) Handles btSummaryReport.Click
        Using a As New frmReportDetailSelector
            a.ReportName = "Summary"

            a.ShowDialog()

        End Using
    End Sub

    Private Sub btCardMaster_Click(sender As Object, e As EventArgs) Handles btCardMaster.Click
        Using a As New frmReportViewer


            Dim sql As String = _
            " SELECT  CardMaster.on_show, CardMaster.ModUser, CardMaster.sys_date, CardMaster.RFID" & _
            " , CardMaster.DecCode" & _
            " , BinMaster.CustNo, BinMaster.ModelNO, " & _
            " BinMaster.StationNo " & _
            " FROM     CardMaster RIGHT OUTER JOIN " & _
            " BinMaster ON CardMaster.BinId = BinMaster.BinId " & _
            " WHERE   (CardMaster.on_show = 'Y' ) "

            Dim dt As New DataTable
            dt = MainScript.GetDataTable(Sql)


            '   da.Fill(dt)






            '將ReportViewer1的DataSources集合清除
            a.ReportViewer1.LocalReport.ReportPath = "report\rptCardMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsCardMaster_CardMaster", dt))
            a.Text = "咭編號列表"

            a.ShowDialog()

        End Using
    End Sub

    Private Sub btGarbage1_Click(sender As Object, e As EventArgs) Handles btGarbage1.Click
        Using a As New frmReportViewer


            Dim sql As String = "SELECT    GarbageCatId, GarbageCatName,sys_date, seq_no, mod_user FROM GarbageCatMaster "
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptGarbageCatMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsGarbageCatMaster_GarbageCatMaster", dt))
            a.Text = "垃圾分類1列表"


            a.ShowDialog()

        End Using
    End Sub

    Private Sub btGarType2_Click(sender As Object, e As EventArgs) Handles btGarType2.Click
        Using a As New frmReportViewer


            Dim sql As String = "SELECT    GarbageSubCatId, GarbageSubCatName,sys_date, seq_no, mod_user FROM GarbageSubCatMaster "
            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)


            a.ReportViewer1.LocalReport.ReportPath = "report\rptGarbageSubCatMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsGarbageSubCatMaster_GarbageSubCatMaster", dt))
            a.Text = "垃圾分類2列表"


            a.ShowDialog()

        End Using
    End Sub

    Private Sub btSummaryType1_Click(sender As Object, e As EventArgs) Handles btSummaryType1.Click
        Using a As New frmReportDetailSelector
            a.ReportName = "SummaryGType1"
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btSummaryGType2_Click(sender As Object, e As EventArgs) Handles btSummaryGType2.Click
        Using a As New frmReportDetailSelector
            a.ReportName = "SummaryGType2"
            a.ShowDialog()

        End Using
    End Sub

    
    Private Sub btMonthlyInvoice_Click(sender As Object, e As EventArgs) Handles btMonthlyInvoice.Click
        Using a As New frmReportDetailSelector
            a.ReportName = "MonthlyInvoice"
            a.ShowDialog()

        End Using
    End Sub

    Private Sub btSiteReport_Click(sender As Object, e As EventArgs) Handles btSiteReport.Click
        Using a As New frmReportDetailSelector
            a.ReportName = "MonthlySite"
            a.ShowDialog()

        End Using
    End Sub
End Class