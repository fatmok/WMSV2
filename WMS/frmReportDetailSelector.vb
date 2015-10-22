Imports Microsoft.Reporting.WinForms

Public Class frmReportDetailSelector
    Public ReportName As String = String.Empty

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Dispose()

    End Sub

    Private Sub btRunReport_Click(sender As Object, e As EventArgs) Handles btRunReport.Click
        Using a As New frmReportViewer

            Dim sDate As String = String.Empty
            Dim eDate As String = String.Empty
            Dim var As String = String.Empty

            If cbCountryID.Text <> String.Empty Then

                var += " CountryMaster.CountryName ='" + cbCountryID.Text + "' "


            End If

            If cbAreaID.Text <> String.Empty Then

                var += " and AreaMaster.AreaName ='" + cbAreaID.Text + "' "
            End If

            If rbShowSelectDate.Checked Then
                sDate = dtpStart.Value.Date.ToString("yyyy-MM-dd")
                eDate = dtpEnd.Value.Date.ToString("yyyy-MM-dd")


                var += " and  (LogMaster.LogDate >= '" + CStr(sDate) + "' and LogMaster.LogDate <= '" + CStr(eDate) + "')"
            End If

            If tbAddress.Text <> String.Empty Then
                var += " and  BinMaster.address like '%" + tbAddress.Text + "%'"
            End If

            If tbCustNo.Text <> String.Empty Then

                var += " and BinMaster.CustNo ='" + tbCustNo.Text + "' "
            End If

            If tbModelNO.Text <> String.Empty Then
                var += " and BinMaster.ModelNO ='" + tbModelNO.Text + "'"
            End If

            'If tbRFID.Text <> String.Empty Then
            '    var += " and ( BinMaster.RFID='" + tbRFID.Text + "' or BinMaster.RFID2 ='" + tbRFID.Text + "') "
            'End If



            Dim sql As String
            sql = _
            "SELECT  LogMaster.LogId, LogMaster.LogDate, LogMaster.LogTime, LogMaster.Gross, LogMaster.Tare," & _
            " LogMaster.Net, LogMaster.ModUser, LogMaster.BinId," & _
            " AreaMaster.AreaName, GarbageCatMaster.GarbageCatName, GarbageSubCatMaster.GarbageSubCatName," & _
            " BinMaster.CustNo, BinMaster.ModelNO," & _
            " BinMaster.StationNo, CountryMaster.CountryName, BinMaster.address" & _
            " FROM     CountryMaster RIGHT OUTER JOIN " & _
            " AreaMaster ON CountryMaster.CountryId = AreaMaster.CountryId RIGHT OUTER JOIN " & _
            " GarbageSubCatMaster RIGHT OUTER JOIN " & _
            " BinMaster ON GarbageSubCatMaster.GarbageSubCatId = BinMaster.GarbageSubCat LEFT OUTER JOIN " & _
            " GarbageCatMaster ON BinMaster.GarbageCat = GarbageCatMaster.GarbageCatId ON  " & _
            " AreaMaster.AreaId = BinMaster.AreaId RIGHT OUTER JOIN " & _
            " LogMaster ON BinMaster.BinId = LogMaster.BinId where " + var


            'MainScript.TestSql(sql)


            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)



            Select Case ReportName
                Case "Summary"
                    a.ReportViewer1.LocalReport.ReportPath = "report\rptSummary.rdlc"
                    a.Text = "Summary Report"
                Case "SummaryGType1"
                    a.ReportViewer1.LocalReport.ReportPath = "report\rptSummaryGType1.rdlc"
                    a.Text = "Summary Report - Garbage Type 1"
                Case "SummaryGType2"
                    a.ReportViewer1.LocalReport.ReportPath = "report\rptSummaryGType2.rdlc"
                    a.Text = "Summary Report - Garbage Type 2"

                Case "MonthlyInvoice"
                    a.ReportViewer1.LocalReport.ReportPath = "report\rptInvoice.rdlc"
                    a.Text = "Monthly Statement"
                Case "MonthlySite"
                    a.ReportViewer1.LocalReport.ReportPath = "report\rptSiteReport.rdlc"
                    a.Text = "Monthly Site Report"

            End Select

            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1
            Dim a1(0) As ReportParameter
            a1(0) = New ReportParameter("UserName", "DD")


            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsSummary_Summary", dt))
            ' a.ReportViewer1.LocalReport.SetParameters(a1)


            a.ShowDialog()



        End Using
    End Sub
    Public Sub SetDefault()


        Me.tbAddress.Text = String.Empty
        Me.tbCustNo.Text = String.Empty
        Me.tbModelNO.Text = String.Empty
        Me.tbRFID.Text = String.Empty

        dtpStart.Value = Now

        dtpEnd.Value = Now
        ' Me.cbAreaID.SelectedIndex = 0
        Me.cbCountryID.SelectedIndex = 0
        Me.cbAreaID.Items.Clear()


        Me.rbShowAll.Checked = True


        MainScript.BindDropDownList("AreaMaster where countryid ='" + FunctionScript.GetCountryId(cbCountryID.Text) + "'", cbAreaID, 1)




    End Sub
    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        SetDefault()

    End Sub



    Private Sub frmReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainScript.BindDropDownList("CountryMaster", cbCountryID, 1)
        ' MainScript.BindDropDownList("AreaMaster", cbAreaID, 1)
        SetDefault()

    End Sub

    Private Sub cbCountryID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCountryID.SelectedIndexChanged
        cbAreaID.Items.Clear()
        '  MsgBox(cbCountryID.SelectedValue)
        MainScript.BindDropDownList("AreaMaster where countryid ='" + FunctionScript.GetCountryId(cbCountryID.Text) + "'", cbAreaID, 1)
    End Sub

    Private Sub rbShowSelectDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbShowSelectDate.CheckedChanged
        If rbShowSelectDate.Checked Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False

        End If
    End Sub

    Private Sub rbShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbShowAll.CheckedChanged
        If rbShowSelectDate.Checked Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False

        End If
    End Sub
End Class