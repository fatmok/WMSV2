<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain2
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

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miReadCardRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.miReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.miUserRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCountryRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAreaRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGarbageCatRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGarbageSubCatRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBinRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCardRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miLogMasterRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSummaryType1Rpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSummaryType2Rpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSiteRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSummaryRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMonthlyInvoiceRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.系統設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miUserSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miCountrySetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDistrictSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAreaSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miGarbageCatSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGarbageSubCatSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBinSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.資料庫設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miStationSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.miShopSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於系統ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDeviceSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser, Me.lbVer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(826, 22)
        Me.StatusStrip1.TabIndex = 1
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
        Me.lbUser.Size = New System.Drawing.Size(726, 17)
        Me.lbUser.Spring = True
        Me.lbUser.Text = "--"
        Me.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbVer
        '
        Me.lbVer.ForeColor = System.Drawing.Color.Black
        Me.lbVer.Name = "lbVer"
        Me.lbVer.Size = New System.Drawing.Size(38, 17)
        Me.lbVer.Text = "------"
        Me.lbVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miReadCardRecord, Me.miReport, Me.系統設定ToolStripMenuItem, Me.關於系統ToolStripMenuItem, Me.miExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'miReadCardRecord
        '
        Me.miReadCardRecord.Image = Global.WMS.My.Resources.Resources.archives_24px_505082_easyicon_net
        Me.miReadCardRecord.Name = "miReadCardRecord"
        Me.miReadCardRecord.Size = New System.Drawing.Size(68, 36)
        Me.miReadCardRecord.Text = "讀取資料"
        Me.miReadCardRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miReport
        '
        Me.miReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miUserRpt, Me.miCountryRpt, Me.miAreaRpt, Me.miGarbageCatRpt, Me.miGarbageSubCatRpt, Me.miBinRpt, Me.miCardRpt, Me.miLogMasterRpt, Me.miSummaryType1Rpt, Me.miSummaryType2Rpt, Me.miSiteRpt, Me.miSummaryRpt, Me.miMonthlyInvoiceRpt})
        Me.miReport.Image = Global.WMS.My.Resources.Resources.administrative_docs
        Me.miReport.Name = "miReport"
        Me.miReport.Size = New System.Drawing.Size(68, 36)
        Me.miReport.Text = "報表管理"
        Me.miReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miUserRpt
        '
        Me.miUserRpt.Name = "miUserRpt"
        Me.miUserRpt.Size = New System.Drawing.Size(182, 22)
        Me.miUserRpt.Text = "使用者列表"
        '
        'miCountryRpt
        '
        Me.miCountryRpt.Name = "miCountryRpt"
        Me.miCountryRpt.Size = New System.Drawing.Size(182, 22)
        Me.miCountryRpt.Text = "總區列表"
        '
        'miAreaRpt
        '
        Me.miAreaRpt.Name = "miAreaRpt"
        Me.miAreaRpt.Size = New System.Drawing.Size(182, 22)
        Me.miAreaRpt.Text = "地區列表"
        '
        'miGarbageCatRpt
        '
        Me.miGarbageCatRpt.Name = "miGarbageCatRpt"
        Me.miGarbageCatRpt.Size = New System.Drawing.Size(182, 22)
        Me.miGarbageCatRpt.Text = "垃圾分類1列表"
        '
        'miGarbageSubCatRpt
        '
        Me.miGarbageSubCatRpt.Name = "miGarbageSubCatRpt"
        Me.miGarbageSubCatRpt.Size = New System.Drawing.Size(182, 22)
        Me.miGarbageSubCatRpt.Text = "垃圾分類2列表"
        '
        'miBinRpt
        '
        Me.miBinRpt.Name = "miBinRpt"
        Me.miBinRpt.Size = New System.Drawing.Size(182, 22)
        Me.miBinRpt.Text = "垃圾桶列表"
        '
        'miCardRpt
        '
        Me.miCardRpt.Name = "miCardRpt"
        Me.miCardRpt.Size = New System.Drawing.Size(182, 22)
        Me.miCardRpt.Text = "咭編號列表"
        '
        'miLogMasterRpt
        '
        Me.miLogMasterRpt.Name = "miLogMasterRpt"
        Me.miLogMasterRpt.Size = New System.Drawing.Size(182, 22)
        Me.miLogMasterRpt.Text = "每天數據匯入報告"
        '
        'miSummaryType1Rpt
        '
        Me.miSummaryType1Rpt.Name = "miSummaryType1Rpt"
        Me.miSummaryType1Rpt.Size = New System.Drawing.Size(182, 22)
        Me.miSummaryType1Rpt.Text = "分區統計報告 分類1"
        '
        'miSummaryType2Rpt
        '
        Me.miSummaryType2Rpt.Name = "miSummaryType2Rpt"
        Me.miSummaryType2Rpt.Size = New System.Drawing.Size(182, 22)
        Me.miSummaryType2Rpt.Text = "分區統計報告 分類2"
        '
        'miSiteRpt
        '
        Me.miSiteRpt.Name = "miSiteRpt"
        Me.miSiteRpt.Size = New System.Drawing.Size(182, 22)
        Me.miSiteRpt.Text = "商戶簡報"
        '
        'miSummaryRpt
        '
        Me.miSummaryRpt.Name = "miSummaryRpt"
        Me.miSummaryRpt.Size = New System.Drawing.Size(182, 22)
        Me.miSummaryRpt.Text = "分區統計報告"
        '
        'miMonthlyInvoiceRpt
        '
        Me.miMonthlyInvoiceRpt.Name = "miMonthlyInvoiceRpt"
        Me.miMonthlyInvoiceRpt.Size = New System.Drawing.Size(182, 22)
        Me.miMonthlyInvoiceRpt.Text = "月結單"
        '
        '系統設定ToolStripMenuItem
        '
        Me.系統設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miUserSetup, Me.ToolStripMenuItem1, Me.miCountrySetup, Me.miDistrictSetup, Me.miAreaSetup, Me.ToolStripMenuItem2, Me.miGarbageCatSetup, Me.miGarbageSubCatSetup, Me.miBinSetup, Me.資料庫設定ToolStripMenuItem, Me.miStationSetup, Me.miShopSetup, Me.miDeviceSetup})
        Me.系統設定ToolStripMenuItem.Image = Global.WMS.My.Resources.Resources.settings_24px_505161_easyicon_net
        Me.系統設定ToolStripMenuItem.Name = "系統設定ToolStripMenuItem"
        Me.系統設定ToolStripMenuItem.Size = New System.Drawing.Size(68, 36)
        Me.系統設定ToolStripMenuItem.Text = "系統設定"
        Me.系統設定ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miUserSetup
        '
        Me.miUserSetup.Name = "miUserSetup"
        Me.miUserSetup.Size = New System.Drawing.Size(155, 22)
        Me.miUserSetup.Text = "使用者設定"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'miCountrySetup
        '
        Me.miCountrySetup.Name = "miCountrySetup"
        Me.miCountrySetup.Size = New System.Drawing.Size(155, 22)
        Me.miCountrySetup.Text = "總區設定"
        '
        'miDistrictSetup
        '
        Me.miDistrictSetup.Name = "miDistrictSetup"
        Me.miDistrictSetup.Size = New System.Drawing.Size(155, 22)
        Me.miDistrictSetup.Text = "地域設定"
        '
        'miAreaSetup
        '
        Me.miAreaSetup.Name = "miAreaSetup"
        Me.miAreaSetup.Size = New System.Drawing.Size(155, 22)
        Me.miAreaSetup.Text = "地區設定"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 6)
        '
        'miGarbageCatSetup
        '
        Me.miGarbageCatSetup.Name = "miGarbageCatSetup"
        Me.miGarbageCatSetup.Size = New System.Drawing.Size(155, 22)
        Me.miGarbageCatSetup.Text = "垃圾分類1設定"
        '
        'miGarbageSubCatSetup
        '
        Me.miGarbageSubCatSetup.Name = "miGarbageSubCatSetup"
        Me.miGarbageSubCatSetup.Size = New System.Drawing.Size(155, 22)
        Me.miGarbageSubCatSetup.Text = "垃圾分類2設定"
        '
        'miBinSetup
        '
        Me.miBinSetup.Name = "miBinSetup"
        Me.miBinSetup.Size = New System.Drawing.Size(155, 22)
        Me.miBinSetup.Text = "垃圾桶設定"
        '
        '資料庫設定ToolStripMenuItem
        '
        Me.資料庫設定ToolStripMenuItem.Name = "資料庫設定ToolStripMenuItem"
        Me.資料庫設定ToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.資料庫設定ToolStripMenuItem.Text = "資料庫設定"
        '
        'miStationSetup
        '
        Me.miStationSetup.Name = "miStationSetup"
        Me.miStationSetup.Size = New System.Drawing.Size(155, 22)
        Me.miStationSetup.Text = "工作站設定"
        '
        'miShopSetup
        '
        Me.miShopSetup.Name = "miShopSetup"
        Me.miShopSetup.Size = New System.Drawing.Size(155, 22)
        Me.miShopSetup.Text = "商舖設定"
        '
        '關於系統ToolStripMenuItem
        '
        Me.關於系統ToolStripMenuItem.Image = Global.WMS.My.Resources.Resources.lightbulb_24px_505132_easyicon_net
        Me.關於系統ToolStripMenuItem.Name = "關於系統ToolStripMenuItem"
        Me.關於系統ToolStripMenuItem.Size = New System.Drawing.Size(68, 36)
        Me.關於系統ToolStripMenuItem.Text = "關於系統"
        Me.關於系統ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miExit
        '
        Me.miExit.Image = Global.WMS.My.Resources.Resources.door_out
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(44, 36)
        Me.miExit.Text = "離開"
        Me.miExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miDeviceSetup
        '
        Me.miDeviceSetup.Name = "miDeviceSetup"
        Me.miDeviceSetup.Size = New System.Drawing.Size(155, 22)
        Me.miDeviceSetup.Text = "器材設定"
        '
        'frmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WMS.My.Resources.Resources.waston_all6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 599)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain2"
        Me.Text = "垃圾通廢物管理系統"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbVer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents miReadCardRecord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miUserRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCountryRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGarbageCatRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 系統設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關於系統ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAreaRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGarbageSubCatRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miBinRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCardRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miLogMasterRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSummaryType1Rpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSummaryType2Rpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSiteRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSummaryRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miMonthlyInvoiceRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miUserSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCountrySetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAreaSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGarbageCatSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGarbageSubCatSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miBinSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 資料庫設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miDistrictSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miStationSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miShopSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miDeviceSetup As System.Windows.Forms.ToolStripMenuItem
End Class
