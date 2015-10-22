<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btUserList = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btCountry = New System.Windows.Forms.Button()
        Me.btArea = New System.Windows.Forms.Button()
        Me.btBinList = New System.Windows.Forms.Button()
        Me.btLogMaster = New System.Windows.Forms.Button()
        Me.btSummaryReport = New System.Windows.Forms.Button()
        Me.btCardMaster = New System.Windows.Forms.Button()
        Me.btGarbage1 = New System.Windows.Forms.Button()
        Me.btGarType2 = New System.Windows.Forms.Button()
        Me.btSummaryType1 = New System.Windows.Forms.Button()
        Me.btSummaryGType2 = New System.Windows.Forms.Button()
        Me.btMonthlyInvoice = New System.Windows.Forms.Button()
        Me.btSiteReport = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1056, 28)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripStatusLabel1.Text = "使用者:"
        '
        'lbUser
        '
        Me.lbUser.BackColor = System.Drawing.SystemColors.Control
        Me.lbUser.ForeColor = System.Drawing.Color.White
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(26, 23)
        Me.lbUser.Text = "--"
        '
        'btUserList
        '
        Me.btUserList.BackColor = System.Drawing.Color.White
        Me.btUserList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btUserList.Location = New System.Drawing.Point(489, 196)
        Me.btUserList.Margin = New System.Windows.Forms.Padding(4)
        Me.btUserList.Name = "btUserList"
        Me.btUserList.Size = New System.Drawing.Size(264, 34)
        Me.btUserList.TabIndex = 2
        Me.btUserList.Text = "使用者列表"
        Me.btUserList.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Silver
        Me.btExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btExit.Location = New System.Drawing.Point(774, 541)
        Me.btExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(264, 34)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'btCountry
        '
        Me.btCountry.BackColor = System.Drawing.Color.White
        Me.btCountry.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btCountry.Location = New System.Drawing.Point(774, 196)
        Me.btCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.btCountry.Name = "btCountry"
        Me.btCountry.Size = New System.Drawing.Size(264, 34)
        Me.btCountry.TabIndex = 6
        Me.btCountry.Text = "總區列表"
        Me.btCountry.UseVisualStyleBackColor = False
        '
        'btArea
        '
        Me.btArea.BackColor = System.Drawing.Color.White
        Me.btArea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btArea.Location = New System.Drawing.Point(774, 255)
        Me.btArea.Margin = New System.Windows.Forms.Padding(4)
        Me.btArea.Name = "btArea"
        Me.btArea.Size = New System.Drawing.Size(264, 34)
        Me.btArea.TabIndex = 7
        Me.btArea.Text = "地區列表"
        Me.btArea.UseVisualStyleBackColor = False
        '
        'btBinList
        '
        Me.btBinList.BackColor = System.Drawing.Color.White
        Me.btBinList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btBinList.Location = New System.Drawing.Point(774, 314)
        Me.btBinList.Margin = New System.Windows.Forms.Padding(4)
        Me.btBinList.Name = "btBinList"
        Me.btBinList.Size = New System.Drawing.Size(264, 34)
        Me.btBinList.TabIndex = 8
        Me.btBinList.Text = "垃圾桶列表"
        Me.btBinList.UseVisualStyleBackColor = False
        '
        'btLogMaster
        '
        Me.btLogMaster.BackColor = System.Drawing.Color.White
        Me.btLogMaster.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLogMaster.Location = New System.Drawing.Point(774, 373)
        Me.btLogMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.btLogMaster.Name = "btLogMaster"
        Me.btLogMaster.Size = New System.Drawing.Size(264, 34)
        Me.btLogMaster.TabIndex = 9
        Me.btLogMaster.Text = "每天數據匯入報告"
        Me.btLogMaster.UseVisualStyleBackColor = False
        '
        'btSummaryReport
        '
        Me.btSummaryReport.BackColor = System.Drawing.Color.White
        Me.btSummaryReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSummaryReport.Location = New System.Drawing.Point(774, 488)
        Me.btSummaryReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btSummaryReport.Name = "btSummaryReport"
        Me.btSummaryReport.Size = New System.Drawing.Size(264, 34)
        Me.btSummaryReport.TabIndex = 10
        Me.btSummaryReport.Text = "分區統計報告"
        Me.btSummaryReport.UseVisualStyleBackColor = False
        '
        'btCardMaster
        '
        Me.btCardMaster.BackColor = System.Drawing.Color.White
        Me.btCardMaster.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btCardMaster.Location = New System.Drawing.Point(489, 373)
        Me.btCardMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.btCardMaster.Name = "btCardMaster"
        Me.btCardMaster.Size = New System.Drawing.Size(264, 34)
        Me.btCardMaster.TabIndex = 11
        Me.btCardMaster.Text = "咭編號列表"
        Me.btCardMaster.UseVisualStyleBackColor = False
        '
        'btGarbage1
        '
        Me.btGarbage1.BackColor = System.Drawing.Color.White
        Me.btGarbage1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btGarbage1.Location = New System.Drawing.Point(489, 255)
        Me.btGarbage1.Margin = New System.Windows.Forms.Padding(4)
        Me.btGarbage1.Name = "btGarbage1"
        Me.btGarbage1.Size = New System.Drawing.Size(264, 34)
        Me.btGarbage1.TabIndex = 12
        Me.btGarbage1.Text = "垃圾分類1列表"
        Me.btGarbage1.UseVisualStyleBackColor = False
        '
        'btGarType2
        '
        Me.btGarType2.BackColor = System.Drawing.Color.White
        Me.btGarType2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btGarType2.Location = New System.Drawing.Point(489, 314)
        Me.btGarType2.Margin = New System.Windows.Forms.Padding(4)
        Me.btGarType2.Name = "btGarType2"
        Me.btGarType2.Size = New System.Drawing.Size(264, 34)
        Me.btGarType2.TabIndex = 13
        Me.btGarType2.Text = "垃圾分類2列表"
        Me.btGarType2.UseVisualStyleBackColor = False
        '
        'btSummaryType1
        '
        Me.btSummaryType1.BackColor = System.Drawing.Color.White
        Me.btSummaryType1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSummaryType1.Location = New System.Drawing.Point(489, 432)
        Me.btSummaryType1.Margin = New System.Windows.Forms.Padding(4)
        Me.btSummaryType1.Name = "btSummaryType1"
        Me.btSummaryType1.Size = New System.Drawing.Size(264, 34)
        Me.btSummaryType1.TabIndex = 14
        Me.btSummaryType1.Text = "分區統計報告 - 分類1"
        Me.btSummaryType1.UseVisualStyleBackColor = False
        '
        'btSummaryGType2
        '
        Me.btSummaryGType2.BackColor = System.Drawing.Color.White
        Me.btSummaryGType2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSummaryGType2.Location = New System.Drawing.Point(774, 432)
        Me.btSummaryGType2.Margin = New System.Windows.Forms.Padding(4)
        Me.btSummaryGType2.Name = "btSummaryGType2"
        Me.btSummaryGType2.Size = New System.Drawing.Size(264, 34)
        Me.btSummaryGType2.TabIndex = 15
        Me.btSummaryGType2.Text = "分區統計報告 - 分類2"
        Me.btSummaryGType2.UseVisualStyleBackColor = False
        '
        'btMonthlyInvoice
        '
        Me.btMonthlyInvoice.BackColor = System.Drawing.Color.White
        Me.btMonthlyInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btMonthlyInvoice.Location = New System.Drawing.Point(489, 541)
        Me.btMonthlyInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.btMonthlyInvoice.Name = "btMonthlyInvoice"
        Me.btMonthlyInvoice.Size = New System.Drawing.Size(264, 34)
        Me.btMonthlyInvoice.TabIndex = 16
        Me.btMonthlyInvoice.Text = "月結單"
        Me.btMonthlyInvoice.UseVisualStyleBackColor = False
        '
        'btSiteReport
        '
        Me.btSiteReport.BackColor = System.Drawing.Color.White
        Me.btSiteReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSiteReport.Location = New System.Drawing.Point(489, 488)
        Me.btSiteReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btSiteReport.Name = "btSiteReport"
        Me.btSiteReport.Size = New System.Drawing.Size(264, 34)
        Me.btSiteReport.TabIndex = 17
        Me.btSiteReport.Text = "商戶簡報"
        Me.btSiteReport.UseVisualStyleBackColor = False
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WMS.My.Resources.Resources.VB_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 642)
        Me.Controls.Add(Me.btSiteReport)
        Me.Controls.Add(Me.btMonthlyInvoice)
        Me.Controls.Add(Me.btSummaryGType2)
        Me.Controls.Add(Me.btSummaryType1)
        Me.Controls.Add(Me.btGarType2)
        Me.Controls.Add(Me.btGarbage1)
        Me.Controls.Add(Me.btCardMaster)
        Me.Controls.Add(Me.btSummaryReport)
        Me.Controls.Add(Me.btLogMaster)
        Me.Controls.Add(Me.btBinList)
        Me.Controls.Add(Me.btArea)
        Me.Controls.Add(Me.btCountry)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btUserList)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WMS"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btUserList As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btCountry As System.Windows.Forms.Button
    Friend WithEvents btArea As System.Windows.Forms.Button
    Friend WithEvents btBinList As System.Windows.Forms.Button
    Friend WithEvents btLogMaster As System.Windows.Forms.Button
    Friend WithEvents btSummaryReport As System.Windows.Forms.Button
    Friend WithEvents btCardMaster As System.Windows.Forms.Button
    Friend WithEvents btGarbage1 As System.Windows.Forms.Button
    Friend WithEvents btGarType2 As System.Windows.Forms.Button
    Friend WithEvents btSummaryType1 As System.Windows.Forms.Button
    Friend WithEvents btSummaryGType2 As System.Windows.Forms.Button
    Friend WithEvents btMonthlyInvoice As System.Windows.Forms.Button
    Friend WithEvents btSiteReport As System.Windows.Forms.Button
End Class
