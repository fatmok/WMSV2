Imports System.IO
Imports System.Data.SqlClient
Module MainScript
    'Remark
    ' on_show =3 即是DELETE 了


    Public VersionNo As String = "版本編號： 20140210"

    Public MainIP As String = "(local)\SQLEXPRESS"
    ' Public MainIP As String = "(local)"
    Public MainDB As String = "WMS2015"
    Public MainUser As String = "wms"
    Public MainPassword As String = "Sma14988"
    'tPOS_SR for EAS
    'tPOS_SC for Showroom Collection






    'Remote Server Start #############################################

    ' Public SqlConString As String = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=" & MainUser & ";pwd=" & MainPassword 'Local Server String
    '        Data Source ;Initial Catalog=WMS;Persist Security Info=True;User ID=wms
    Public SqlConString As String = "Data Source=" & MainIP & "; Initial Catalog=" & MainDB & ";Persist Security Info=True;User ID=wms;Password=Sma14988"
    Public SqlRemoteConString As String = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=Tefu05811" 'Remote Server String
    Public SqlConString2 As String = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=Tefu05811" 'Remote Server String
    Public Report_CONNECTION_STRING As String = "Provider=SQLOLEDB;Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=Tefu05811" 'Remote Server 


    'remote Server end ##############################################


    ''Local Server Start #############################################
    'Public SqlConString As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=tPOS_SR;Integrated Security=True"  'Local Server String
    'Public SqlRemoteConString As String = "Data Source=210.177.244.19;Database=tPOS_SR;User ID=terry;pwd=5370788" 'Remote Server String
    'Public SqlConString2 As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=tPOS_SR;Integrated Security=True" 'Local Server String
    'Public Report_CONNECTION_STRING As String = "Provider=SQLOLEDB;Data Source=(local)\SQLEXPRESS;Database=tPOS_SR;User ID=terry;pwd=5370788" 'Remote Server String
    'Local Server End ###############################################
    'Public SqlConString As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=tPOS_SR;Integrated Security=True"  'Local Server String
    'Public SqlConString As String = "Data Source=192.168.1.9;Database=tPOS;User ID=terry;pwd=5370788" 'Remote Server String

    '
    '


    Public RemoteServerIP As String = "192.168.1.34"

    Public SqlCon As New SqlConnection(SqlConString)
    Public SqlCon2 As New SqlConnection(SqlConString2)
    Public SqlConRemote As New SqlConnection(SqlRemoteConString)

    'Public SqlCon As SqlConnection()
    'Public SqlCon2 As SqlConnection()
    'Public SqlConRemote As SqlConnection()

    Public CompanyGroup As String = String.Empty
    Public priceGroup As String = String.Empty

    Public ShopPhone As String = String.Empty
    Public CompanyName As String = String.Empty
    Public CompanyFax As String = String.Empty
    Public CompanyPhone As String = String.Empty
    Public CompanyAddress As String = String.Empty
    Public ShopAddress As String = String.Empty

    Public CompanyWebSite As String = String.Empty

    Public Shop_Inv_Flag As String = String.Empty


    Public UserId As String = String.Empty
    Public UserName As String = String.Empty
    Public UserEMAIL As String = String.Empty
    Public UserLevel As String = String.Empty
    Public ShopId As String = String.Empty
    Public ShopName As String = String.Empty
    Public ShopIP As String = String.Empty
    Public Admin_Level As Boolean = False

    Public SearchId As String = String.Empty
    Public VIPId As String
    Public SYNID As String = String.Empty
    Public SessionId As String = String.Empty
    Public reportSessionid As String
    Public ReportName As String
    Public ReportRemark As String
    Public ReportInMoney As String = String.Empty
    Public ReportNet As String = String.Empty
    Public PayMentMethod As String = String.Empty
    Public PayMentMethod2 As String = String.Empty
    Public tScreen As Boolean = False
   
    Public Function MakeSearchSQL(ByVal SearchUnit As String, ByVal SearchItem As String) As String


        Dim i() As String = Split(SearchUnit, ",")
        Dim x As String = String.Empty
        Dim L As Integer = i.Length
        ' MsgBox(i(1).ToString)
        Dim e As Integer = 1


        For Each y In i
            x += y + " like '%" + SearchItem & "%' "

            If e <> L Then
                x += " OR "

            End If

            e += 1

        Next

        x = " where " + x


        Return x



    End Function
    Public Sub BindDGV(ByVal sql As String, ByVal dgv As DataGridView)

        '   MainScript.TestSql(strTable)

        'Dim sql As String = "Select * from " + strTable
        dgv.DataSource = Nothing
        dgv.Columns.Clear()


        Dim dt As DataTable = GetDataTable(sql)

        dgv.DataSource = dt




    End Sub
    Public Function GetDateByDataReader(ByVal SQL As String)

        Dim i As String = "0"


        Try
            'SELECT transactions.transid as '編號', shoplist.shopname as '店舖名稱', productdetail.productid as '產品編號', productdetail.product_image as '圖片', productdetail.productname as '產品名稱', shoppingcart.qty AS '數量', shoppingcart.price as '原價',  shoppingcart.discount_amount as '節扣', shoppingcart.total_price as '總金額' ,productdetail.MenualAvgPrice as '成本', shoppingcart.remark as '備註',   transactions.sys_date as '時間', transactions.remarks as '發票備註' FROM     shoplist RIGHT OUTER JOIN  transactions ON shoplist.shopid = transactions.shopid LEFT OUTER JOIN  productdetail RIGHT OUTER JOIN  shoppingcart ON productdetail.productid = shoppingcart.productid ON                           transactions.transid = shoppingcart.transid  WHERE    (transactions.sys_date between '2012/7/7 00:00' and  '2012/7/7 23:59')  and transactions.on_show <> 3 and  (transactions.trans_status = 9)  and shoppingcart.on_show <>3 order by shoplist.seq_no

            'MainScript.TestSql(SQL)
            SqlCon.Open()
            Dim SqlCmd As New SqlCommand(SQL, SqlCon)
            'MainScript.TestSql(SqlCon.ConnectionString)

            Dim sdr As SqlDataReader = SqlCmd.ExecuteReader

            While sdr.Read

                i = sdr(0).ToString
                'MsgBox(sdr(0).ToString)
            End While


        Catch ex As Exception
            i = "0"
            MsgBox(ex.ToString)
        Finally
            SqlCon.Close()
        End Try

        Return i
    End Function
    Public Function GetDataSql(ByVal GetThing As String, ByVal TableName As String, ByVal SearchName As String, ByVal SearchItem As String, ByVal SelectConn As String) As String

        Dim no As String = String.Empty
        Dim strSQL As String = "SELECT " & GetThing & " FROM " & TableName & " WHERE " & SearchName & " = '" & SearchItem & "' "

        '  MainScript.TestSql(strSQL)

        Try
            Dim dt As New DataTable
    
            dt = GetDataTable(strSQL)
            'Case "CCG"
            '    dt = GetDataTable(strSQL, "CCG")
            'Case "Remote"
            '    dt = GetDataTable(strSQL, "Remote")





            If dt.Rows.Count <> 0 Then
                no = dt.Rows(0)(0).ToString().Trim()
            Else
                no = 0
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
            no = String.Empty
        End Try


        Return no

    End Function
    Public Function GetDateByDataReaderWnull(ByVal SQL As String)

        Dim i As String = String.Empty


        Try
            'SELECT transactions.transid as '編號', shoplist.shopname as '店舖名稱', productdetail.productid as '產品編號', productdetail.product_image as '圖片', productdetail.productname as '產品名稱', shoppingcart.qty AS '數量', shoppingcart.price as '原價',  shoppingcart.discount_amount as '節扣', shoppingcart.total_price as '總金額' ,productdetail.MenualAvgPrice as '成本', shoppingcart.remark as '備註',   transactions.sys_date as '時間', transactions.remarks as '發票備註' FROM     shoplist RIGHT OUTER JOIN  transactions ON shoplist.shopid = transactions.shopid LEFT OUTER JOIN  productdetail RIGHT OUTER JOIN  shoppingcart ON productdetail.productid = shoppingcart.productid ON                           transactions.transid = shoppingcart.transid  WHERE    (transactions.sys_date between '2012/7/7 00:00' and  '2012/7/7 23:59')  and transactions.on_show <> 3 and  (transactions.trans_status = 9)  and shoppingcart.on_show <>3 order by shoplist.seq_no

            'MainScript.TestSql(SQL)
            SqlCon.Open()
            Dim SqlCmd As New SqlCommand(SQL, SqlCon)
            'MainScript.TestSql(SqlCon.ConnectionString)

            Dim sdr As SqlDataReader = SqlCmd.ExecuteReader

            While sdr.Read

                i = sdr(0).ToString
                'MsgBox(sdr(0).ToString)
            End While


        Catch ex As Exception
            'i = "0"
            MsgBox(ex.ToString)
        Finally
            SqlCon.Close()
        End Try

        Return i
    End Function
    'Public Sub ChangeDB(ByVal CompanyGroup As String)
    '    '  MsgBox(CompanyGroup)

    '    If CompanyGroup = "Sammy" Then

    '        MainDB = "tPOS_SC"
    '        SqlConString = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788"   'Local Server String
    '        SqlRemoteConString = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server String
    '        SqlConString2 = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server String
    '        Report_CONNECTION_STRING = "Provider=SQLOLEDB;Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server 
    '    Else
    '        SqlCon.Close()
    '        SqlCon2.Close()
    '        SqlConRemote.Close()

    '        MainDB = "tPOS_SR"
    '        SqlConString = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788"   'Local Server String
    '        SqlRemoteConString = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server String
    '        SqlConString2 = "Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server String
    '        Report_CONNECTION_STRING = "Provider=SQLOLEDB;Data Source=" & MainIP & ";Database=" & MainDB & ";User ID=terry;pwd=5370788" 'Remote Server 




    '        SqlCon = New SqlConnection(SqlConString)
    '        SqlCon2 = New SqlConnection(SqlConString2)
    '        SqlConRemote = New SqlConnection(SqlRemoteConString)

    '    End If






    'End Sub

 


    Public Function OperateData(ByVal strSQL As String) As Integer

        Dim i As Integer = 0
        Try

            '      MsgBox(MainScript.CompanyGroup & "/" & MainScript.SqlConString)

            MainScript.SqlCon.Open()

            Dim SqlCmd As New SqlCommand(strSQL, MainScript.SqlCon)
            i = SqlCmd.ExecuteNonQuery
            MainScript.SqlCon.Close()

        Catch ex As Exception
            MsgBox("Operate Data Error!!!")
            MsgBox(ex.ToString)
            MainScript.TestSql(strSQL)

        End Try

        Return i

    End Function

    Public Function OperateData(ByVal strSQL As String, ByVal Server As String) As Integer
        Dim i As Integer = 0
        Try

            Select Case Server
                Case "RS"
                    MainScript.SqlConRemote.Open()

                    Dim SqlCmd As New SqlCommand(strSQL, MainScript.SqlConRemote)
                    i = SqlCmd.ExecuteNonQuery
                    MainScript.SqlConRemote.Close()
                Case "LS"
                    MainScript.SqlCon.Open()

                    Dim SqlCmd As New SqlCommand(strSQL, MainScript.SqlCon)
                    i = SqlCmd.ExecuteNonQuery
                    MainScript.SqlCon.Close()
            End Select



        Catch ex As Exception
            MsgBox("Operate Data Error!!!")
            MsgBox(ex.ToString)
            MainScript.TestSql(strSQL)

        End Try

        Return i

    End Function
    Public Function RenewSessionId()

        Try


            ' MainScript.SessionId = MainScript.ShopIP & Mid(Now.Date.Year, 3) & Now.Date.Month & Now.Date.Day & Now.Hour & Now.Minute & Now.Second
            MainScript.SessionId = Mid(Now.Date.Year, 3) & Mid(MainScript.ShopId, 4) & Now.Date.Month & Now.Date.Day & Now.Hour & Now.Minute & Now.Second
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return SessionId

    End Function

    Public Sub TestSql(ByVal strSQL As String)


        Using d As New TestForm
            d.tb1.Text = strSQL
            d.ShowDialog()
        End Using
    End Sub
    Public Function ControlDataAdapter(ByVal MyConn As SqlConnection, ByVal Method As String, ByVal SQLStr As String) As SqlDataAdapter
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim MyCmd As SqlCommand



        MyCmd = New SqlCommand(SQLStr, MyConn)
        Select Case Method
            Case "Select"

                adapter.SelectCommand = MyCmd
            Case "Delete"


                adapter.DeleteCommand = MyCmd

            Case "Update"



                adapter.UpdateCommand = MyCmd

            Case "Insert"


                adapter.InsertCommand = MyCmd

        End Select



        Return adapter
    End Function
    Public Function GetDataTable(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        'MainScript.TestSql(sql)

        Try

            Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))
            SqlAda.Fill(dt)


        Catch ex As Exception
            MsgBox(ex.ToString)

            MsgBox("找不到記錄，請從新輸入!")

        End Try

        Return dt
    End Function
    Public Function GetMaxId(ByVal dbNmae As String, ByVal idName As String, ByVal Server As String) As String
        Dim dt As New DataTable
        Dim xid As String = String.Empty

        Dim sql As String = "Select max(" + idName + ") from " + dbNmae

        Try
            Select Case Server
                Case "RS"
                    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlConRemote))

                    SqlAda.Fill(dt)
                Case "LS"
                    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))
                    SqlAda.Fill(dt)
            End Select

            xid = dt.Rows(0)(0).ToString
            If Len(xid) < 5 Then
                xid = "10001" & MainScript.Shop_Inv_Flag

            ElseIf Len(xid) >= 5 Then

                xid = xid + 1 & MainScript.Shop_Inv_Flag
            Else
                'Dim Cxid As Integer = Len(xid)



                'xid = Mid(xid, 1, Cxid - 1) + 1 & MainScript.Shop_Inv_Flag





            End If

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try




        Return xid

    End Function
    Public Function GetDataTable(ByVal sql As String, ByVal Server As String) As DataTable
        Dim dt As New DataTable
        'MainScript.TestSql(sql)

        Try
            Select Case Server
                Case "RS"
                    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlConRemote))
                    SqlAda.Fill(dt)
                Case "LS"
                    Dim SqlAda As New SqlDataAdapter(New SqlCommand(sql, SqlCon))
                    SqlAda.Fill(dt)
            End Select




        Catch ex As Exception
            MsgBox(ex.ToString)

            MsgBox("找不到記錄，請從新輸入!")

        End Try

        Return dt
    End Function
    Public Function ResizePicA(ByRef Pic As Bitmap, ByVal pWidth As Int32, ByVal pHeight As Int32, ByVal path As String) 
        Try


            Dim bm As New Bitmap(Pic)
            Dim x As Int32 = pWidth 'variable for new width size
            Dim y As Int32 = pHeight 'variable for new height size

            Dim width As Integer = Val(x) 'image width. 

            Dim height As Integer = Val(y) 'image height

            Dim thumb As New Bitmap(width, height)

            Dim g As Graphics = Graphics.FromImage(thumb)

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

            g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, _
    bm.Height), GraphicsUnit.Pixel)

            g.Dispose()
            Dim tempPicPath As String = "c:\P" & Now.Minute & Now.Second & ".jpeg"

            'image path. better to make this dynamic. I am hardcoding a path just for example sake
            thumb.Save(tempPicPath, _
    System.Drawing.Imaging.ImageFormat.Jpeg) 'can use any image format 
            ' PictureBox1.Image = Image.FromFile(tempPicPath)
            bm.Dispose()

            thumb.Dispose()
            path = tempPicPath


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return path
    End Function
    Public Sub UploadAndResizePic(ByVal PicBox As PictureBox, ByVal OFBOX As OpenFileDialog, ByVal pw As Int32, ByVal ph As Int32)
        Try

            OFBOX.InitialDirectory = "c:\"
            OFBOX.DefaultExt = "jpg"
            OFBOX.Filter = "Jpg Files(*.jpg)|*.jpg|Bmp Files(*.bmp)|*.bmp|Gif Files(*.gif)|*.gif"
            OFBOX.ShowDialog()



            PicBox.Image = Image.FromFile(OFBOX.FileName)
            PicBox.Image = Image.FromFile(ResizePicA(PicBox.Image, pw, ph, OFBOX.FileName))



            'Me.lbPhotoPath.Text = OFBOX.FileName
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'Public Function SqlDataReaderForDGV(ByVal strFull As String, ByVal dgv As DataGridView, ByVal i As Integer)
    '    SqlCon.Open()
    '    ' Dim sql As String = "Select * from " + strTable


    '    Dim SqlCmd As New SqlCommand(strFull, SqlCon)
    '    Dim sdr As SqlDataReader = SqlCmd.ExecuteReader
    '    While sdr.Read
    '        dgv
    '        'cb.Items.Add(sdr(i).ToString)

    '    End While
    '    SqlCon.Close()
    '    Return i


    'End Function
    Public Function BindDropDownList(ByVal strTable As String, ByVal cb As ComboBox, ByVal i As Integer)
        SqlCon.Open()
        Dim sql As String = "Select * from " + strTable
        'MainScript.TestSql(sql)


        Dim SqlCmd As New SqlCommand(sql, SqlCon)
        Dim sdr As SqlDataReader = SqlCmd.ExecuteReader
        While sdr.Read
            cb.Items.Add(sdr(i).ToString)

        End While
        SqlCon.Close()
        Return i


    End Function
    Public Function GetNowTime()
        Dim i As String
        i = CStr(Format(Now, "yyyy/MM/dd")) & " " & Format(Now, "HH:mm:ss")
        Return i

    End Function
    Public Function MakeTimeCode()
        Dim i As String
        i = CStr(Format(Now, "yyMMdd")) & Format(Now, "HHmmss")
        Return i
    End Function
    Public Function MakeProductBarCode()
        Dim i As String
        Dim sql As String = "select max(productid) from productdetail"
        Dim dt As DataTable = MainScript.GetDataTable(sql)
        Dim id As String

        If dt.Rows(0)(0).ToString = "" Then
            id = "10001"
        Else
            id = CInt(dt.Rows(0)(0).ToString) + 1
        End If


        i = id & Mid(Now.Year, 4, 1)

        Return i
    End Function
    Public Sub StockEdit(ByVal shopid As String, ByVal productid As String, ByVal qty As String)
        'Dim sql As String = _
        '"Select qty from stock where productid='" & productid & "' and shopid ='" & shopid & "'"

        'Dim sqlX As String = String.Empty

        'Dim oldQty As Integer = MainScript.GetDateByDataReader(sql)

        'If oldQty = 0 Then
        '    sqlX = "INSERT INTO stock (shopid, productid, qty) VALUES  ('" & _
        '    shopid & "','" & productid & "','" & qty & "')"
        'Else
        '    Dim newqty As String = oldQty - CInt(qty)

        '    sqlX = "UPDATE        stock " & _
        '           " SET qty ='" & newqty & "' where shopid ='" & shopid & "' and productid ='" & productid & "'"


        'End If

        'OperateData(sqlX)
        Dim sql As String = _
      "Select qty from stock where productid='" & productid & "' and shopid ='" & shopid & "'"

        Dim sqlX As String = String.Empty

        Dim oldQty As String = MainScript.GetDateByDataReaderWnull(sql)

        



        If oldQty = "" Then
            sqlX = "INSERT INTO stock (shopid, productid, qty) VALUES  ('" & _
            shopid & "','" & productid & "','" & qty & "')"
        Else
            Dim newqty As String = oldQty - CInt(qty)

            sqlX = "UPDATE        stock " & _
                   " SET qty ='" & newqty & "' where shopid ='" & shopid & "' and productid ='" & productid & "'"


        End If

        OperateData(sqlX)



    End Sub
    
End Module

