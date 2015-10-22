<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGarbageCatSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGarbageCatSetup))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSeqNo = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.tbMod_User = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSysDate = New System.Windows.Forms.TextBox()
        Me.cbOnShow = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 342)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1003, 30)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 25)
        Me.ToolStripStatusLabel1.Text = "使用者:"
        '
        'lbUser
        '
        Me.lbUser.BackColor = System.Drawing.SystemColors.Control
        Me.lbUser.ForeColor = System.Drawing.Color.Black
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(26, 25)
        Me.lbUser.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "編號"
        '
        'tbSeqNo
        '
        Me.tbSeqNo.Location = New System.Drawing.Point(120, 159)
        Me.tbSeqNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSeqNo.Name = "tbSeqNo"
        Me.tbSeqNo.Size = New System.Drawing.Size(218, 29)
        Me.tbSeqNo.TabIndex = 6
        Me.tbSeqNo.Text = "100"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(118, 117)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(218, 29)
        Me.tbName.TabIndex = 5
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(118, 74)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(218, 29)
        Me.tbID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "名稱"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "排序"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 48)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 45)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 48)
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(1003, 48)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btAddNew
        '
        Me.btAddNew.Image = CType(resources.GetObject("btAddNew.Image"), System.Drawing.Image)
        Me.btAddNew.Name = "btAddNew"
        Me.btAddNew.RightToLeftAutoMirrorImage = True
        Me.btAddNew.Size = New System.Drawing.Size(54, 45)
        Me.btAddNew.Text = "新增"
        Me.btAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveFirstItem
        '
        Me.btMoveFirstItem.Image = CType(resources.GetObject("btMoveFirstItem.Image"), System.Drawing.Image)
        Me.btMoveFirstItem.Name = "btMoveFirstItem"
        Me.btMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.btMoveFirstItem.Size = New System.Drawing.Size(73, 45)
        Me.btMoveFirstItem.Text = "最前面"
        Me.btMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMovePreviousItem
        '
        Me.btMovePreviousItem.Image = CType(resources.GetObject("btMovePreviousItem.Image"), System.Drawing.Image)
        Me.btMovePreviousItem.Name = "btMovePreviousItem"
        Me.btMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.btMovePreviousItem.Size = New System.Drawing.Size(73, 45)
        Me.btMovePreviousItem.Text = "上一個"
        Me.btMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveNextItem
        '
        Me.btMoveNextItem.Image = CType(resources.GetObject("btMoveNextItem.Image"), System.Drawing.Image)
        Me.btMoveNextItem.Name = "btMoveNextItem"
        Me.btMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.btMoveNextItem.Size = New System.Drawing.Size(73, 45)
        Me.btMoveNextItem.Text = "下一個"
        Me.btMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btMoveLastItem
        '
        Me.btMoveLastItem.Image = CType(resources.GetObject("btMoveLastItem.Image"), System.Drawing.Image)
        Me.btMoveLastItem.Name = "btMoveLastItem"
        Me.btMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.btMoveLastItem.Size = New System.Drawing.Size(73, 45)
        Me.btMoveLastItem.Text = "最後面"
        Me.btMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btMoveLastItem.ToolTipText = "最後面"
        '
        'btModData
        '
        Me.btModData.Image = Global.WMS.My.Resources.Resources.Edit
        Me.btModData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btModData.Name = "btModData"
        Me.btModData.Size = New System.Drawing.Size(54, 45)
        Me.btModData.Text = "修改"
        Me.btModData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btDel
        '
        Me.btDel.Image = Global.WMS.My.Resources.Resources.delete
        Me.btDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(54, 45)
        Me.btDel.Text = "刪除"
        Me.btDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSave
        '
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(74, 45)
        Me.btSave.Text = "儲存(&S)"
        Me.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSetDefault
        '
        Me.btSetDefault.Image = CType(resources.GetObject("btSetDefault.Image"), System.Drawing.Image)
        Me.btSetDefault.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSetDefault.Name = "btSetDefault"
        Me.btSetDefault.Size = New System.Drawing.Size(54, 45)
        Me.btSetDefault.Text = "還原"
        Me.btSetDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSearch
        '
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(54, 45)
        Me.btSearch.Text = "搜尋"
        Me.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbExit
        '
        Me.tbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbExit.Image = Global.WMS.My.Resources.Resources.sign_out
        Me.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbExit.Name = "tbExit"
        Me.tbExit.Size = New System.Drawing.Size(54, 45)
        Me.tbExit.Text = "離開"
        Me.tbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btPrint
        '
        Me.btPrint.Image = Global.WMS.My.Resources.Resources.administrative_docs
        Me.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(54, 45)
        Me.btPrint.Text = "列表"
        Me.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "經手人"
        '
        'tbMod_User
        '
        Me.tbMod_User.Location = New System.Drawing.Point(118, 201)
        Me.tbMod_User.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMod_User.Name = "tbMod_User"
        Me.tbMod_User.ReadOnly = True
        Me.tbMod_User.Size = New System.Drawing.Size(217, 29)
        Me.tbMod_User.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "修改日期"
        '
        'tbSysDate
        '
        Me.tbSysDate.Location = New System.Drawing.Point(507, 201)
        Me.tbSysDate.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSysDate.Name = "tbSysDate"
        Me.tbSysDate.ReadOnly = True
        Me.tbSysDate.Size = New System.Drawing.Size(217, 29)
        Me.tbSysDate.TabIndex = 23
        '
        'cbOnShow
        '
        Me.cbOnShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOnShow.FormattingEnabled = True
        Me.cbOnShow.Items.AddRange(New Object() {"Y", "N"})
        Me.cbOnShow.Location = New System.Drawing.Point(504, 76)
        Me.cbOnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOnShow.Name = "cbOnShow"
        Me.cbOnShow.Size = New System.Drawing.Size(46, 26)
        Me.cbOnShow.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "顯示狀態"
        '
        'frmGarbageCatSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1003, 372)
        Me.Controls.Add(Me.cbOnShow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSysDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMod_User)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSeqNo)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGarbageCatSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "垃圾分類 1 設定"
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents tbMod_User As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSysDate As System.Windows.Forms.TextBox
    Friend WithEvents cbOnShow As System.Windows.Forms.ComboBox
    Friend WithEvents btPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btModData As System.Windows.Forms.ToolStripButton
End Class
