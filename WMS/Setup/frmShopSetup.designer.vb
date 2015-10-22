<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopSetup
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShopSetup))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btAddNew = New System.Windows.Forms.ToolStripButton()
        Me.btMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.btMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.btMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.btMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btModData = New System.Windows.Forms.ToolStripButton()
        Me.btDel = New System.Windows.Forms.ToolStripButton()
        Me.btSave = New System.Windows.Forms.ToolStripButton()
        Me.btSetDefault = New System.Windows.Forms.ToolStripButton()
        Me.btSearch = New System.Windows.Forms.ToolStripButton()
        Me.tbExit = New System.Windows.Forms.ToolStripButton()
        Me.btPrint = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbShopFax = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbShopContact = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbShopTel = New System.Windows.Forms.TextBox()
        Me.cbStationId = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbShopRemark = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbShopAddress = New System.Windows.Forms.TextBox()
        Me.cbAreaId = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbCountryId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbShopCustNo = New System.Windows.Forms.TextBox()
        Me.cbDistrict = New System.Windows.Forms.ComboBox()
        Me.cbOnShow = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSysDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbModUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSeqNo = New System.Windows.Forms.TextBox()
        Me.tbShopName = New System.Windows.Forms.TextBox()
        Me.tbShopId = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btAddN = New System.Windows.Forms.Button()
        Me.btCardDel = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btCardSave = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbDeviceSN = New System.Windows.Forms.TextBox()
        Me.tbDeviceRemark = New System.Windows.Forms.TextBox()
        Me.tbDeviceId = New System.Windows.Forms.TextBox()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.tbSearchDevice = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbDeviceShopId = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(666, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "使用者:"
        '
        'lbUser
        '
        Me.lbUser.BackColor = System.Drawing.SystemColors.Control
        Me.lbUser.ForeColor = System.Drawing.Color.Black
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(18, 17)
        Me.lbUser.Text = "--"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(28, 36)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btAddNew
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btMoveFirstItem, Me.btMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.btMoveNextItem, Me.btMoveLastItem, Me.BindingNavigatorSeparator2, Me.btAddNew, Me.btModData, Me.btDel, Me.btSave, Me.btSetDefault, Me.btSearch, Me.tbExit, Me.btPrint})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.btMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.btMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.btMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(666, 39)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btAddNew
        '
        Me.btAddNew.Image = CType(resources.GetObject("btAddNew.Image"), System.Drawing.Image)
        Me.btAddNew.Name = "btAddNew"
        Me.btAddNew.RightToLeftAutoMirrorImage = True
        Me.btAddNew.Size = New System.Drawing.Size(36, 36)
        Me.btAddNew.Text = "新增"
        Me.btAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveFirstItem
        '
        Me.btMoveFirstItem.Image = CType(resources.GetObject("btMoveFirstItem.Image"), System.Drawing.Image)
        Me.btMoveFirstItem.Name = "btMoveFirstItem"
        Me.btMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.btMoveFirstItem.Size = New System.Drawing.Size(48, 36)
        Me.btMoveFirstItem.Text = "最前面"
        Me.btMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMovePreviousItem
        '
        Me.btMovePreviousItem.Image = CType(resources.GetObject("btMovePreviousItem.Image"), System.Drawing.Image)
        Me.btMovePreviousItem.Name = "btMovePreviousItem"
        Me.btMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.btMovePreviousItem.Size = New System.Drawing.Size(48, 36)
        Me.btMovePreviousItem.Text = "上一個"
        Me.btMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveNextItem
        '
        Me.btMoveNextItem.Image = CType(resources.GetObject("btMoveNextItem.Image"), System.Drawing.Image)
        Me.btMoveNextItem.Name = "btMoveNextItem"
        Me.btMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.btMoveNextItem.Size = New System.Drawing.Size(48, 36)
        Me.btMoveNextItem.Text = "下一個"
        Me.btMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveLastItem
        '
        Me.btMoveLastItem.Image = CType(resources.GetObject("btMoveLastItem.Image"), System.Drawing.Image)
        Me.btMoveLastItem.Name = "btMoveLastItem"
        Me.btMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.btMoveLastItem.Size = New System.Drawing.Size(48, 36)
        Me.btMoveLastItem.Text = "最後面"
        Me.btMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btMoveLastItem.ToolTipText = "最後面"
        '
        'btModData
        '
        Me.btModData.Image = Global.WMS.My.Resources.Resources.Edit
        Me.btModData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btModData.Name = "btModData"
        Me.btModData.Size = New System.Drawing.Size(36, 36)
        Me.btModData.Text = "修改"
        Me.btModData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btDel
        '
        Me.btDel.Image = Global.WMS.My.Resources.Resources.delete
        Me.btDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(36, 36)
        Me.btDel.Text = "刪除"
        Me.btDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSave
        '
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(51, 36)
        Me.btSave.Text = "儲存(&S)"
        Me.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSetDefault
        '
        Me.btSetDefault.Image = CType(resources.GetObject("btSetDefault.Image"), System.Drawing.Image)
        Me.btSetDefault.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSetDefault.Name = "btSetDefault"
        Me.btSetDefault.Size = New System.Drawing.Size(36, 36)
        Me.btSetDefault.Text = "還原"
        Me.btSetDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSearch
        '
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(36, 36)
        Me.btSearch.Text = "搜尋"
        Me.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbExit
        '
        Me.tbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbExit.Image = Global.WMS.My.Resources.Resources.sign_out
        Me.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbExit.Name = "tbExit"
        Me.tbExit.Size = New System.Drawing.Size(36, 36)
        Me.tbExit.Text = "離開"
        Me.tbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btPrint
        '
        Me.btPrint.Image = Global.WMS.My.Resources.Resources.administrative_docs
        Me.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(36, 36)
        Me.btPrint.Text = "列印"
        Me.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 361)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.tbShopFax)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.tbShopContact)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.tbShopTel)
        Me.TabPage1.Controls.Add(Me.cbStationId)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.tbShopRemark)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.tbShopAddress)
        Me.TabPage1.Controls.Add(Me.cbAreaId)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cbCountryId)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.tbShopCustNo)
        Me.TabPage1.Controls.Add(Me.cbDistrict)
        Me.TabPage1.Controls.Add(Me.cbOnShow)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.tbSysDate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.tbModUser)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.tbSeqNo)
        Me.TabPage1.Controls.Add(Me.tbShopName)
        Me.TabPage1.Controls.Add(Me.tbShopId)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "基本資料"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 12)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "傳真"
        '
        'tbShopFax
        '
        Me.tbShopFax.Location = New System.Drawing.Point(87, 156)
        Me.tbShopFax.Name = "tbShopFax"
        Me.tbShopFax.Size = New System.Drawing.Size(178, 22)
        Me.tbShopFax.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 12)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "聯絡人"
        '
        'tbShopContact
        '
        Me.tbShopContact.Location = New System.Drawing.Point(87, 100)
        Me.tbShopContact.Name = "tbShopContact"
        Me.tbShopContact.Size = New System.Drawing.Size(178, 22)
        Me.tbShopContact.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "電話"
        '
        'tbShopTel
        '
        Me.tbShopTel.Location = New System.Drawing.Point(87, 128)
        Me.tbShopTel.Name = "tbShopTel"
        Me.tbShopTel.Size = New System.Drawing.Size(178, 22)
        Me.tbShopTel.TabIndex = 49
        '
        'cbStationId
        '
        Me.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStationId.FormattingEnabled = True
        Me.cbStationId.Location = New System.Drawing.Point(403, 95)
        Me.cbStationId.Name = "cbStationId"
        Me.cbStationId.Size = New System.Drawing.Size(147, 20)
        Me.cbStationId.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(344, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "工作站"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "備註"
        '
        'tbShopRemark
        '
        Me.tbShopRemark.Location = New System.Drawing.Point(87, 212)
        Me.tbShopRemark.Multiline = True
        Me.tbShopRemark.Name = "tbShopRemark"
        Me.tbShopRemark.Size = New System.Drawing.Size(463, 51)
        Me.tbShopRemark.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "地址"
        '
        'tbShopAddress
        '
        Me.tbShopAddress.Location = New System.Drawing.Point(87, 184)
        Me.tbShopAddress.Name = "tbShopAddress"
        Me.tbShopAddress.Size = New System.Drawing.Size(463, 22)
        Me.tbShopAddress.TabIndex = 51
        '
        'cbAreaId
        '
        Me.cbAreaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAreaId.FormattingEnabled = True
        Me.cbAreaId.Location = New System.Drawing.Point(403, 69)
        Me.cbAreaId.Name = "cbAreaId"
        Me.cbAreaId.Size = New System.Drawing.Size(147, 20)
        Me.cbAreaId.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "地區名稱"
        '
        'cbCountryId
        '
        Me.cbCountryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryId.FormattingEnabled = True
        Me.cbCountryId.Location = New System.Drawing.Point(403, 16)
        Me.cbCountryId.Name = "cbCountryId"
        Me.cbCountryId.Size = New System.Drawing.Size(147, 20)
        Me.cbCountryId.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(344, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "總區名稱"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "自訂編號"
        '
        'tbShopCustNo
        '
        Me.tbShopCustNo.Location = New System.Drawing.Point(87, 44)
        Me.tbShopCustNo.Name = "tbShopCustNo"
        Me.tbShopCustNo.Size = New System.Drawing.Size(178, 22)
        Me.tbShopCustNo.TabIndex = 46
        '
        'cbDistrict
        '
        Me.cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDistrict.FormattingEnabled = True
        Me.cbDistrict.Location = New System.Drawing.Point(403, 42)
        Me.cbDistrict.Name = "cbDistrict"
        Me.cbDistrict.Size = New System.Drawing.Size(147, 20)
        Me.cbDistrict.TabIndex = 54
        '
        'cbOnShow
        '
        Me.cbOnShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOnShow.FormattingEnabled = True
        Me.cbOnShow.Items.AddRange(New Object() {"Y", "N"})
        Me.cbOnShow.Location = New System.Drawing.Point(404, 156)
        Me.cbOnShow.Name = "cbOnShow"
        Me.cbOnShow.Size = New System.Drawing.Size(32, 20)
        Me.cbOnShow.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "顯示狀態"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "修改日期"
        '
        'tbSysDate
        '
        Me.tbSysDate.Location = New System.Drawing.Point(404, 272)
        Me.tbSysDate.Name = "tbSysDate"
        Me.tbSysDate.ReadOnly = True
        Me.tbSysDate.Size = New System.Drawing.Size(146, 22)
        Me.tbSysDate.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "經手人"
        '
        'tbModUser
        '
        Me.tbModUser.Location = New System.Drawing.Point(87, 269)
        Me.tbModUser.Name = "tbModUser"
        Me.tbModUser.ReadOnly = True
        Me.tbModUser.Size = New System.Drawing.Size(146, 22)
        Me.tbModUser.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "排序"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "商舖名稱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "地域名稱"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "編號"
        '
        'tbSeqNo
        '
        Me.tbSeqNo.Location = New System.Drawing.Point(404, 121)
        Me.tbSeqNo.Name = "tbSeqNo"
        Me.tbSeqNo.Size = New System.Drawing.Size(66, 22)
        Me.tbSeqNo.TabIndex = 57
        Me.tbSeqNo.Text = "100"
        '
        'tbShopName
        '
        Me.tbShopName.Location = New System.Drawing.Point(87, 72)
        Me.tbShopName.Name = "tbShopName"
        Me.tbShopName.Size = New System.Drawing.Size(178, 22)
        Me.tbShopName.TabIndex = 47
        '
        'tbShopId
        '
        Me.tbShopId.Location = New System.Drawing.Point(87, 16)
        Me.tbShopId.Name = "tbShopId"
        Me.tbShopId.ReadOnly = True
        Me.tbShopId.Size = New System.Drawing.Size(178, 22)
        Me.tbShopId.TabIndex = 59
        Me.tbShopId.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelAdmin)
        Me.TabPage2.Controls.Add(Me.dgvMain)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "器材管理"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdmin.Controls.Add(Me.Label20)
        Me.PanelAdmin.Controls.Add(Me.tbDeviceShopId)
        Me.PanelAdmin.Controls.Add(Me.tbSearchDevice)
        Me.PanelAdmin.Controls.Add(Me.cbStatus)
        Me.PanelAdmin.Controls.Add(Me.Label17)
        Me.PanelAdmin.Controls.Add(Me.btAddN)
        Me.PanelAdmin.Controls.Add(Me.btCardDel)
        Me.PanelAdmin.Controls.Add(Me.btCancel)
        Me.PanelAdmin.Controls.Add(Me.btCardSave)
        Me.PanelAdmin.Controls.Add(Me.Label18)
        Me.PanelAdmin.Controls.Add(Me.Label19)
        Me.PanelAdmin.Controls.Add(Me.Label21)
        Me.PanelAdmin.Controls.Add(Me.tbDeviceSN)
        Me.PanelAdmin.Controls.Add(Me.tbDeviceRemark)
        Me.PanelAdmin.Controls.Add(Me.tbDeviceId)
        Me.PanelAdmin.Location = New System.Drawing.Point(341, 18)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(261, 290)
        Me.PanelAdmin.TabIndex = 8
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Y", "N"})
        Me.cbStatus.Location = New System.Drawing.Point(81, 178)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(32, 20)
        Me.cbStatus.TabIndex = 4
        Me.cbStatus.Text = "Y"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 12)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "狀態"
        '
        'btAddN
        '
        Me.btAddN.Location = New System.Drawing.Point(8, 247)
        Me.btAddN.Margin = New System.Windows.Forms.Padding(2)
        Me.btAddN.Name = "btAddN"
        Me.btAddN.Size = New System.Drawing.Size(59, 23)
        Me.btAddN.TabIndex = 16
        Me.btAddN.Text = "加入"
        Me.btAddN.UseVisualStyleBackColor = True
        '
        'btCardDel
        '
        Me.btCardDel.Location = New System.Drawing.Point(135, 247)
        Me.btCardDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCardDel.Name = "btCardDel"
        Me.btCardDel.Size = New System.Drawing.Size(59, 23)
        Me.btCardDel.TabIndex = 15
        Me.btCardDel.Text = "DELETE"
        Me.btCardDel.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(198, 247)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(59, 23)
        Me.btCancel.TabIndex = 14
        Me.btCancel.Text = "CANCEL"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btCardSave
        '
        Me.btCardSave.Location = New System.Drawing.Point(72, 247)
        Me.btCardSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btCardSave.Name = "btCardSave"
        Me.btCardSave.Size = New System.Drawing.Size(59, 23)
        Me.btCardSave.TabIndex = 13
        Me.btCardSave.Text = "SAVE"
        Me.btCardSave.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 41)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 12)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "S/N"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 68)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "備註"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 15)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 12)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "器材編號"
        '
        'tbDeviceSN
        '
        Me.tbDeviceSN.Location = New System.Drawing.Point(81, 39)
        Me.tbDeviceSN.Margin = New System.Windows.Forms.Padding(2)
        Me.tbDeviceSN.Name = "tbDeviceSN"
        Me.tbDeviceSN.ReadOnly = True
        Me.tbDeviceSN.Size = New System.Drawing.Size(165, 22)
        Me.tbDeviceSN.TabIndex = 1
        '
        'tbDeviceRemark
        '
        Me.tbDeviceRemark.Location = New System.Drawing.Point(81, 65)
        Me.tbDeviceRemark.Margin = New System.Windows.Forms.Padding(2)
        Me.tbDeviceRemark.Multiline = True
        Me.tbDeviceRemark.Name = "tbDeviceRemark"
        Me.tbDeviceRemark.ReadOnly = True
        Me.tbDeviceRemark.Size = New System.Drawing.Size(165, 80)
        Me.tbDeviceRemark.TabIndex = 2
        '
        'tbDeviceId
        '
        Me.tbDeviceId.Enabled = False
        Me.tbDeviceId.Location = New System.Drawing.Point(81, 13)
        Me.tbDeviceId.Margin = New System.Windows.Forms.Padding(2)
        Me.tbDeviceId.Name = "tbDeviceId"
        Me.tbDeviceId.ReadOnly = True
        Me.tbDeviceId.Size = New System.Drawing.Size(165, 22)
        Me.tbDeviceId.TabIndex = 0
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMain.Location = New System.Drawing.Point(14, 18)
        Me.dgvMain.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMain.RowTemplate.Height = 31
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(303, 290)
        Me.dgvMain.TabIndex = 7
        '
        'tbSearchDevice
        '
        Me.tbSearchDevice.Location = New System.Drawing.Point(8, 201)
        Me.tbSearchDevice.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearchDevice.Name = "tbSearchDevice"
        Me.tbSearchDevice.Size = New System.Drawing.Size(59, 23)
        Me.tbSearchDevice.TabIndex = 76
        Me.tbSearchDevice.Text = "搜尋"
        Me.tbSearchDevice.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 152)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 12)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "所屬商舖"
        '
        'tbDeviceShopId
        '
        Me.tbDeviceShopId.Location = New System.Drawing.Point(81, 149)
        Me.tbDeviceShopId.Margin = New System.Windows.Forms.Padding(2)
        Me.tbDeviceShopId.Name = "tbDeviceShopId"
        Me.tbDeviceShopId.ReadOnly = True
        Me.tbDeviceShopId.Size = New System.Drawing.Size(165, 22)
        Me.tbDeviceShopId.TabIndex = 3
        '
        'frmShopSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(666, 437)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmShopSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商舖設定"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btAddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents btSetDefault As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btModData As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbShopFax As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbShopContact As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbShopTel As System.Windows.Forms.TextBox
    Friend WithEvents cbStationId As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbShopRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbShopAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbAreaId As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbCountryId As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbShopCustNo As System.Windows.Forms.TextBox
    Friend WithEvents cbDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents cbOnShow As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSysDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbModUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents tbShopName As System.Windows.Forms.TextBox
    Friend WithEvents tbShopId As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PanelAdmin As System.Windows.Forms.Panel
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btAddN As System.Windows.Forms.Button
    Friend WithEvents btCardDel As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btCardSave As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbDeviceSN As System.Windows.Forms.TextBox
    Friend WithEvents tbDeviceRemark As System.Windows.Forms.TextBox
    Friend WithEvents tbDeviceId As System.Windows.Forms.TextBox
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearchDevice As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbDeviceShopId As System.Windows.Forms.TextBox
End Class
