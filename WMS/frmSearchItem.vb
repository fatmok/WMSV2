Public Class frmSearchItem
    Public strSQL As String
    Public SearchUnit, TableName As String

    Private Sub BindDB()

        'Dim dt As DataTable = MainScript.GetDataTable(strSQL)
        'Me.dgvMain.DataSource = dt



        MainScript.BindDGV(strSQL, dgvMain)

    End Sub
    Private Sub frmSearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDB()

    End Sub
    Private Sub ShowAll()
        MainScript.BindDGV(strSQL, dgvMain)
    End Sub

    Private Sub tbSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSearch.TextChanged
        If Me.tbSearch.Text <> String.Empty Then



            Dim strSQL1 As String = strSQL & MainScript.MakeSearchSQL(SearchUnit, Me.tbSearch.Text)

            ' MainScript.TestSql(strSQL)


            BindDGV(strSQL1, dgvMain)
        Else
            BindDGV(strSQL, dgvMain)
        End If
    End Sub

    Private Sub btShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btShowAll.Click
        BindDGV(strSQL, dgvMain)
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()

    End Sub

    Private Sub dgvMain_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
Public Class TListReturnID

    Dim FID As String
    Dim strID As String
    Public SearchUnit As String
    Public bindSQL As String
    Public TableName As String



    Property SearchID()

        Get
            '取得供應商編號->顯示供應商選單視窗
            FID = ShowID()
            SearchID = FID
        End Get
        Set(ByVal value)
            '設定供應商編號
            FID = value
        End Set

    End Property

    Public Function ShowID()

        Dim fmQrySearchItem As New frmSearchItem
        With frmSearchItem
            .strSQL = bindSQL

            .SearchUnit = SearchUnit
            If .ShowDialog = DialogResult.OK Then

                strID = .dgvMain.Item(0, .dgvMain.CurrentRow.Index).Value
            End If
        End With

        '傳回使用者所挑選的供應商編號
        Return strID

    End Function

End Class