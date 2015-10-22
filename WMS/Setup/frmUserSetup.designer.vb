<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserSetup))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLoginPassword = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbModUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSysDate = New System.Windows.Forms.TextBox()
        Me.cbOnShow = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbChName = New System.Windows.Forms.TextBox()
        Me.tbEnName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.cbUserRight = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(980, 28)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripStatusLabel1.Text = "使用者:"
        '
        'lbUser
        '
        Me.lbUser.BackColor = System.Drawing.SystemColors.Control
        Me.lbUser.ForeColor = System.Drawing.Color.Black
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(26, 23)
        Me.lbUser.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "編號"
        '
        'tbLoginPassword
        '
        Me.tbLoginPassword.Location = New System.Drawing.Point(156, 161)
        Me.tbLoginPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLoginPassword.Name = "tbLoginPassword"
        Me.tbLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbLoginPassword.Size = New System.Drawing.Size(218, 29)
        Me.tbLoginPassword.TabIndex = 1
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(538, 120)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(218, 29)
        Me.tbEmail.TabIndex = 5
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(156, 118)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(218, 29)
        Me.tbName.TabIndex = 0
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(156, 75)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(218, 29)
        Me.tbID.TabIndex = 12
        Me.tbID.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "使用者名稱"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "電郵"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "使用者密碼"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 46)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 30)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(40, 43)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 46)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 46)
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
        Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(980, 46)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btAddNew
        '
        Me.btAddNew.Image = CType(resources.GetObject("btAddNew.Image"), System.Drawing.Image)
        Me.btAddNew.Name = "btAddNew"
        Me.btAddNew.RightToLeftAutoMirrorImage = True
        Me.btAddNew.Size = New System.Drawing.Size(50, 43)
        Me.btAddNew.Text = "新增"
        Me.btAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveFirstItem
        '
        Me.btMoveFirstItem.Image = CType(resources.GetObject("btMoveFirstItem.Image"), System.Drawing.Image)
        Me.btMoveFirstItem.Name = "btMoveFirstItem"
        Me.btMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.btMoveFirstItem.Size = New System.Drawing.Size(68, 43)
        Me.btMoveFirstItem.Text = "最前面"
        Me.btMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMovePreviousItem
        '
        Me.btMovePreviousItem.Image = CType(resources.GetObject("btMovePreviousItem.Image"), System.Drawing.Image)
        Me.btMovePreviousItem.Name = "btMovePreviousItem"
        Me.btMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.btMovePreviousItem.Size = New System.Drawing.Size(68, 43)
        Me.btMovePreviousItem.Text = "上一個"
        Me.btMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveNextItem
        '
        Me.btMoveNextItem.Image = CType(resources.GetObject("btMoveNextItem.Image"), System.Drawing.Image)
        Me.btMoveNextItem.Name = "btMoveNextItem"
        Me.btMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.btMoveNextItem.Size = New System.Drawing.Size(68, 43)
        Me.btMoveNextItem.Text = "下一個"
        Me.btMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveLastItem
        '
        Me.btMoveLastItem.Image = CType(resources.GetObject("btMoveLastItem.Image"), System.Drawing.Image)
        Me.btMoveLastItem.Name = "btMoveLastItem"
        Me.btMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.btMoveLastItem.Size = New System.Drawing.Size(68, 43)
        Me.btMoveLastItem.Text = "最後面"
        Me.btMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btMoveLastItem.ToolTipText = "最後面"
        '
        'btModData
        '
        Me.btModData.Image = Global.WMS.My.Resources.Resources.Edit
        Me.btModData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btModData.Name = "btModData"
        Me.btModData.Size = New System.Drawing.Size(50, 43)
        Me.btModData.Text = "修改"
        Me.btModData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btDel
        '
        Me.btDel.Image = Global.WMS.My.Resources.Resources.delete
        Me.btDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(50, 43)
        Me.btDel.Text = "刪除"
        Me.btDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSave
        '
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(72, 43)
        Me.btSave.Text = "儲存(&S)"
        Me.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSetDefault
        '
        Me.btSetDefault.Image = CType(resources.GetObject("btSetDefault.Image"), System.Drawing.Image)
        Me.btSetDefault.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSetDefault.Name = "btSetDefault"
        Me.btSetDefault.Size = New System.Drawing.Size(50, 43)
        Me.btSetDefault.Text = "還原"
        Me.btSetDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSearch
        '
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(50, 43)
        Me.btSearch.Text = "搜尋"
        Me.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbExit
        '
        Me.tbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbExit.Image = Global.WMS.My.Resources.Resources.sign_out
        Me.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbExit.Name = "tbExit"
        Me.tbExit.Size = New System.Drawing.Size(50, 43)
        Me.tbExit.Text = "離開"
        Me.tbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btPrint
        '
        Me.btPrint.Image = Global.WMS.My.Resources.Resources.administrative_docs
        Me.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(50, 43)
        Me.btPrint.Text = "列表"
        Me.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 293)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "經手人"
        '
        'tbModUser
        '
        Me.tbModUser.Location = New System.Drawing.Point(156, 290)
        Me.tbModUser.Margin = New System.Windows.Forms.Padding(4)
        Me.tbModUser.Name = "tbModUser"
        Me.tbModUser.ReadOnly = True
        Me.tbModUser.Size = New System.Drawing.Size(217, 29)
        Me.tbModUser.TabIndex = 21
        Me.tbModUser.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "修改日期"
        '
        'tbSysDate
        '
        Me.tbSysDate.Location = New System.Drawing.Point(156, 333)
        Me.tbSysDate.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSysDate.Name = "tbSysDate"
        Me.tbSysDate.ReadOnly = True
        Me.tbSysDate.Size = New System.Drawing.Size(217, 29)
        Me.tbSysDate.TabIndex = 23
        Me.tbSysDate.TabStop = False
        '
        'cbOnShow
        '
        Me.cbOnShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOnShow.FormattingEnabled = True
        Me.cbOnShow.Items.AddRange(New Object() {"Y", "N"})
        Me.cbOnShow.Location = New System.Drawing.Point(538, 78)
        Me.cbOnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOnShow.Name = "cbOnShow"
        Me.cbOnShow.Size = New System.Drawing.Size(46, 26)
        Me.cbOnShow.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "顯示狀態"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 252)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "英文性名"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 207)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "中文姓名"
        '
        'tbChName
        '
        Me.tbChName.Location = New System.Drawing.Point(156, 247)
        Me.tbChName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbChName.Name = "tbChName"
        Me.tbChName.Size = New System.Drawing.Size(218, 29)
        Me.tbChName.TabIndex = 3
        '
        'tbEnName
        '
        Me.tbEnName.Location = New System.Drawing.Point(156, 204)
        Me.tbEnName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEnName.Name = "tbEnName"
        Me.tbEnName.Size = New System.Drawing.Size(218, 29)
        Me.tbEnName.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(442, 168)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "電話"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(538, 164)
        Me.tbPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(218, 29)
        Me.tbPhone.TabIndex = 6
        '
        'cbUserRight
        '
        Me.cbUserRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserRight.FormattingEnabled = True
        Me.cbUserRight.Items.AddRange(New Object() {"3", "2", "1"})
        Me.cbUserRight.Location = New System.Drawing.Point(538, 207)
        Me.cbUserRight.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUserRight.Name = "cbUserRight"
        Me.cbUserRight.Size = New System.Drawing.Size(218, 26)
        Me.cbUserRight.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(442, 212)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "權限"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(445, 252)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(337, 67)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Text = "1.系統管理員-能開啟所有功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.一般使用者-除設定外可使用所有功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.操作員-只可使用匯入資料操作"
        '
        'frmUserSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(980, 423)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbUserRight)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbChName)
        Me.Controls.Add(Me.tbEnName)
        Me.Controls.Add(Me.cbOnShow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSysDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbModUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLoginPassword)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "使用者設定"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbModUser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSysDate As System.Windows.Forms.TextBox
    Friend WithEvents cbOnShow As System.Windows.Forms.ComboBox
    Friend WithEvents btPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btModData As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbChName As System.Windows.Forms.TextBox
    Friend WithEvents tbEnName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents cbUserRight As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
