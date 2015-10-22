<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaSetup))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSeqNo = New System.Windows.Forms.TextBox()
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
        Me.cbDistrict = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 257)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(679, 22)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "編號"
        '
        'tbSeqNo
        '
        Me.tbSeqNo.Location = New System.Drawing.Point(78, 155)
        Me.tbSeqNo.Name = "tbSeqNo"
        Me.tbSeqNo.Size = New System.Drawing.Size(147, 22)
        Me.tbSeqNo.TabIndex = 15
        Me.tbSeqNo.Text = "100"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(79, 120)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(147, 22)
        Me.tbName.TabIndex = 13
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(79, 50)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(147, 22)
        Me.tbID.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "地區名稱"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "地域名稱"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "排序"
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(679, 39)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "經手人"
        '
        'tbModUser
        '
        Me.tbModUser.Location = New System.Drawing.Point(78, 188)
        Me.tbModUser.Name = "tbModUser"
        Me.tbModUser.ReadOnly = True
        Me.tbModUser.Size = New System.Drawing.Size(146, 22)
        Me.tbModUser.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "修改日期"
        '
        'tbSysDate
        '
        Me.tbSysDate.Location = New System.Drawing.Point(336, 188)
        Me.tbSysDate.Name = "tbSysDate"
        Me.tbSysDate.ReadOnly = True
        Me.tbSysDate.Size = New System.Drawing.Size(146, 22)
        Me.tbSysDate.TabIndex = 23
        '
        'cbOnShow
        '
        Me.cbOnShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOnShow.FormattingEnabled = True
        Me.cbOnShow.Items.AddRange(New Object() {"Y", "N"})
        Me.cbOnShow.Location = New System.Drawing.Point(336, 51)
        Me.cbOnShow.Name = "cbOnShow"
        Me.cbOnShow.Size = New System.Drawing.Size(32, 20)
        Me.cbOnShow.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "顯示狀態"
        '
        'cbDistrict
        '
        Me.cbDistrict.FormattingEnabled = True
        Me.cbDistrict.Location = New System.Drawing.Point(79, 85)
        Me.cbDistrict.Name = "cbDistrict"
        Me.cbDistrict.Size = New System.Drawing.Size(147, 20)
        Me.cbDistrict.TabIndex = 27
        '
        'frmAreaSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(679, 279)
        Me.Controls.Add(Me.cbDistrict)
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
        Me.Controls.Add(Me.tbSeqNo)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAreaSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "地區設定"
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
    Friend WithEvents tbSeqNo As System.Windows.Forms.TextBox
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
    Friend WithEvents cbDistrict As System.Windows.Forms.ComboBox
End Class
