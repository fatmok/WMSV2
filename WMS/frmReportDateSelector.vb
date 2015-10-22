Imports Microsoft.Reporting.WinForms

Public Class frmReportDateSelector

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




            sDate = dtpStart.Value.Date.ToString("yyyy-MM-dd")
            eDate = dtpEnd.Value.Date.ToString("yyyy-MM-dd")


            var += "   (LogMaster.LogDate >= '" + CStr(sDate) + "' and LogMaster.LogDate <=  '" + CStr(eDate) + "')"





            Dim sql As String = "SELECT  LogMaster.LogId, LogMaster.LogDate, LogMaster.LogTime, LogMaster.LogNo," & _
            " LogMaster.LogSN, LogMaster.RFID, LogMaster.Gross, LogMaster.Tare, " & _
            " LogMaster.Net, LogMaster.LogOri, LogMaster.FileName, LogMaster.sys_date, LogMaster.ModUser," & _
            " LogMaster.DecCode, LogMaster.BinId," & _
            " LogMaster.PiSn, BinMaster.ModelNO, BinMaster.CustNo, BinMaster.StationNo " & _
            " FROM     LogMaster LEFT OUTER JOIN " & _
            " BinMaster ON LogMaster.BinId = BinMaster.BinId where " + var

            Dim dt As New DataTable
            dt = MainScript.GetDataTable(sql)
            '   MainScript.TestSql(sql)

            a.ReportViewer1.LocalReport.ReportPath = "report\rptLogMaster.rdlc"
            a.ReportViewer1.LocalReport.DataSources.Clear()

            '然後重新新增一個名稱為"AdventureWorksDataSet_Employee"的ReportDataSource給ReportViewer1

            a.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsLogMaster_LogMaster", dt))
            a.Text = "每天數據匯入報告"

            a.ShowDialog()



        End Using
    End Sub
    Public Sub SetDefault()




        dtpStart.Value = Now

        dtpEnd.Value = Now




    End Sub
    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        SetDefault()

    End Sub



    Private Sub frmReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDefault()

    End Sub




End Class