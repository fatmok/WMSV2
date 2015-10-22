Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class frmGetData

    Public Sub SetDefault()
        Me.dgvMain.Rows.Clear()
        Me.dgvMain.Columns.Clear()
        Me.tbFilePath.Text = String.Empty
        Me.tbRowCount.Text = "0"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetData.Click
        DisplayOpenFileDialog()
    End Sub
    Sub DisplayOpenFileDialog()
        Try

        
        Me.dgvMain.Rows.Clear()
        Me.dgvMain.Columns.Clear()
        Me.tbFilePath.Text = String.Empty
        Me.tbRowCount.Text = "0"


        Dim openFile As New System.Windows.Forms.OpenFileDialog()
        openFile.DefaultExt = "csv"
        openFile.Filter = "CSV (*.csv)|*.csv"
        openFile.ShowDialog()
        If openFile.FileNames.Length > 0 Then

            Dim SearchThing1 As String = "@Date" '5
            Dim SearchThing2 As String = "Time" '4
            Dim SearchThing3 As String = "No." '3
            Dim SearchThing4 As String = "S/N" '3
            Dim SearchThing5 As String = "Gross" '5
            Dim SearchThing6 As String = "kgTare" '6
            Dim SearchThing7 As String = "kgNet" '5
                Dim SearchThing8 As String = ",ID"
                Dim SearchThing9 As String = "kg,"

            Dim len1 As Integer = Len(SearchThing1)
            Dim len2 As Integer = Len(SearchThing2)
            Dim len3 As Integer = Len(SearchThing3)
            Dim len4 As Integer = Len(SearchThing4)
            Dim len5 As Integer = Len(SearchThing5)
            Dim len6 As Integer = Len(SearchThing6)
            Dim len7 As Integer = Len(SearchThing7)
                Dim len8 As Integer = Len(SearchThing8)
                Dim len9 As Integer = Len(SearchThing9)
            'MsgBox(len1 & "," & _
            '       len2 & "," & _
            '       len3 & "," & _
            '       len4 & "," & _
            '       len5 & "," & _
            '       len6 & "," & _
            '       len7 & "," & _
            'len8 & ",")

            dgvMain.Columns.Add("Date", "日期")
            dgvMain.Columns.Add("Time", "時間")
            dgvMain.Columns.Add("No", "編號")
            dgvMain.Columns.Add("SN", "S/N")
            dgvMain.Columns.Add("Gross", "毛重")
            dgvMain.Columns.Add("Tare", "皮重")
            dgvMain.Columns.Add("Net", "淨重")
            dgvMain.Columns.Add("CardNo", "RFID")
            dgvMain.Columns.Add("Source", "原數據")
            dgvMain.Columns.Add("FileName", "檔案名稱")
            dgvMain.Columns.Add("DEC Code", "DEC Code")
                dgvMain.Columns.Add("BinId", "BinId")
                dgvMain.Columns.Add("PiSN", "PiSN")
                Dim sFileName As String = openFile.FileName
            '   MsgBox(openFile.SafeFileName)

            Me.tbFilePath.Text = sFileName

                Dim SearchThingPoint1 As Integer 'date
                Dim SearchThingPoint2 As Integer 'time
                Dim SearchThingPoint3 As Integer 'no
                Dim SearchThingPoint4 As Integer 'serial
                Dim SearchThingPoint5 As Integer 'gross
                Dim SearchThingPoint6 As Integer  'tare
                Dim SearchThingPoint7 As Integer 'net
                Dim SearchThingPoint8 As Integer  'kg,
                Dim SearchThingPoint9 As Integer  'kg,


                Dim SearchThingData1 As String
                Dim SearchThingData2 As String
                Dim SearchThingData3 As String
                Dim SearchThingData4 As String
                Dim SearchThingData5 As String
                Dim SearchThingData6 As String

                Dim SearchThingData8 As String
                Dim DECCode As String = String.Empty ' Convert.ToInt32(Mid(SearchThingData8, 5, 6), 16)

                Dim sqlCardMaster As String
                Dim SearchWithinThis As String

                Dim lenAll As Integer
                '     MainScript.TestSql(sqlCardMaster)

                Dim xBinid As String
                Dim CardStart As String

                For Each line As String In System.IO.File.ReadAllLines(sFileName)

                    SearchWithinThis = line

                    lenAll = Len(line)


                    SearchThingPoint1 = SearchWithinThis.IndexOf(SearchThing1) 'date
                    SearchThingPoint2 = SearchWithinThis.IndexOf(SearchThing2) 'time
                    SearchThingPoint3 = SearchWithinThis.IndexOf(SearchThing3) 'no
                    SearchThingPoint4 = SearchWithinThis.IndexOf(SearchThing4) 'serial
                    SearchThingPoint5 = SearchWithinThis.IndexOf(SearchThing5) 'gross
                    SearchThingPoint6 = SearchWithinThis.IndexOf(SearchThing6) 'tare
                    SearchThingPoint7 = SearchWithinThis.IndexOf(SearchThing7) 'net
                    SearchThingPoint8 = SearchWithinThis.IndexOf(SearchThing8) 'kg,
                    SearchThingPoint9 = SearchWithinThis.IndexOf(SearchThing9) 'kg,


                    SearchThingData1 = Trim(Mid(line, SearchThingPoint1 + 1 + len1, SearchThingPoint2 - SearchThingPoint1 - len1))
                    SearchThingData2 = Trim(Mid(line, SearchThingPoint2 + 1 + len2, SearchThingPoint3 - SearchThingPoint2 - len2))
                    SearchThingData3 = Trim(Mid(line, SearchThingPoint3 + 1 + len3, SearchThingPoint4 - SearchThingPoint3 - len3))
                    SearchThingData4 = Trim(Mid(line, SearchThingPoint4 + 1 + len4, SearchThingPoint5 - SearchThingPoint4 - len4))
                    SearchThingData5 = Trim(Mid(line, SearchThingPoint5 + 1 + len5, SearchThingPoint6 - SearchThingPoint5 - len5))
                    SearchThingData6 = Trim(Mid(line, SearchThingPoint6 + 1 + len6, SearchThingPoint7 - SearchThingPoint6 - len6))

                    '
                    'ID8500C6F4BBFA,13038779                    舊咭由第7個號碼開始拆6位()
                    'ID010E2CC40C0B		,	237814796	新咭由第6個號碼開始拆7位






                    'Dim SearchThingData8 As String = Trim(Mid(line, SearchThingPoint8 + 1 + len8, SearchThingPoint1 - SearchThingPoint8 - len8 - 1))

                    SearchThingData8 = Trim(Mid(line, SearchThingPoint8 + 1 + len8, 10))
                    DECCode = String.Empty ' Convert.ToInt32(Mid(SearchThingData8, 5, 6), 16)
                    CardStart = Mid(SearchThingData8, 1, 3)

                   

                    sqlCardMaster = _
                    " SELECT     BinId " & _
                    " FROM CardMaster " & _
                    " WHERE     (RFID = '" + SearchThingData8 + "')"

                    '     MainScript.TestSql(sqlCardMaster)

                    xBinid = MainScript.GetDateByDataReader(sqlCardMaster)
                    If CardStart = "010" Or CardStart = "850" Then
                        dgvMain.Rows.Add(SearchThingData1, SearchThingData2, SearchThingData3, SearchThingData4, SearchThingData5, SearchThingData6, SearchThingData5, SearchThingData8, line, openFile.SafeFileName, DECCode, xBinid)
                        '淨重 現時"同" 毛重
                    End If
                  



                Next

            Me.tbRowCount.Text = Me.dgvMain.Rows.Count


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Dispose()

    End Sub

    Private Sub frmGetData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbUser.Text = MainScript.UserName
    End Sub
    Public Sub UploadData()

        Try

        

            Dim dr As DataGridViewRow
            Dim LogDateOrg As Date
            Dim LogDate As String

            Dim LogTime As String = String.Empty
            Dim LogNo As String = String.Empty
            Dim LogSN As String = String.Empty
            Dim Gross As String = String.Empty
            Dim Tare As String = String.Empty
            Dim Net As String = String.Empty

            Dim LogOri As String = String.Empty
            Dim FileName As String = String.Empty
            Dim sql As String = String.Empty
            Dim RFID As String = String.Empty
            Dim DEC As String = String.Empty
            Dim BinId As String = String.Empty

            Dim ControlMin As Integer = MainScript.GetDateByDataReader("select ControlMin from Control")
            For Each dr In dgvMain.Rows

                'LogDateOrg = dr.Cells(0).Value.ToString
                ' LogDate = Format(LogDateOrg, "yyyy-MM-dd")

                LogDateOrg = Date.ParseExact(dr.Cells(0).Value, "dd-MM-yyyy", System.Globalization.CultureInfo.CurrentCulture)


                LogDate = LogDateOrg.ToString("yyyy-MM-dd")


                LogTime = dr.Cells(1).Value.ToString
                LogNo = dr.Cells(2).Value.ToString
                LogSN = dr.Cells(3).Value.ToString
                Gross = dr.Cells(4).Value.ToString
                Tare = dr.Cells(5).Value.ToString
                Net = dr.Cells(6).Value.ToString
                RFID = dr.Cells(7).Value.ToString


                LogOri = "" 'dr.Cells(8).Value.ToString
                FileName = dr.Cells(9).Value.ToString
                DEC = dr.Cells(10).Value.ToString
                BinId = dr.Cells(11).Value.ToString

                Dim sqlCheck As String = "Select LogTime from LogMaster where LogDate='" + LogDate + "' and Binid='" + BinId + "' "
                Dim dtCheck As DataTable = GetDataTable(sqlCheck)
                '  MainScript.TestSql(sqlCheck)
                If ControlMin = 0 Then
                    Dim delSql As String = "Delete from LogMaster where LogDate='" + LogDate + "' and Binid='" + BinId + "' "
                    OperateData(delSql)
                Else
                    If dtCheck.Rows.Count > 0 Then

                        Dim oldTime As TimeSpan = dtCheck.Rows(0)(0)

                        Dim newTime As TimeSpan = TimeSpan.Parse(LogTime)

                        Dim wD As TimeSpan = newTime.Subtract(oldTime)

                        If wD.TotalMinutes <= ControlMin Then

                            Dim delSql As String = "Delete from LogMaster where LogDate='" + LogDate + "' and Binid='" + BinId + "' "
                            OperateData(delSql)

                        End If

                    End If
                End If
                

          
                sql = "INSERT INTO LogMaster " & _
                                " (LogDate, LogTime, LogNo, LogSN, Gross, Tare, Net, LogOri, FileName,RFID,DecCode,BinId, ModUser) " & _
                   " VALUES ('" & _
                    LogDate & "','" & _
                    LogTime & "','" & _
                    LogNo & "','" & _
                    LogSN & "','" & _
                    Gross & "','" & _
                    Tare & "','" & _
                    Net & "','" & _
                    LogOri & "','" & _
                    FileName & "','" & _
                      RFID & "','" & _
                          DEC & "','" & _
                           BinId & "','" & _
                    MainScript.UserName & "')"

                ' MainScript.TestSql(sql)

                OperateData(sql)





            Next


            MsgBox("上傳完成")
            Me.SetDefault()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub
    Private Sub btUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpload.Click
        UploadData()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using a As New frmReportDateSelector
            a.ShowDialog()




        End Using
    End Sub
End Class
