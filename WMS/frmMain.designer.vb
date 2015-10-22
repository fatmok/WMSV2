<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btGetData = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btSetup = New System.Windows.Forms.Button()
        Me.btReport = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser, Me.lbVer})
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
        Me.lbUser.Size = New System.Drawing.Size(907, 23)
        Me.lbUser.Spring = True
        Me.lbUser.Text = "--"
        Me.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbVer
        '
        Me.lbVer.ForeColor = System.Drawing.Color.White
        Me.lbVer.Name = "lbVer"
        Me.lbVer.Size = New System.Drawing.Size(58, 23)
        Me.lbVer.Text = "------"
        Me.lbVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btGetData
        '
        Me.btGetData.BackColor = System.Drawing.Color.White
        Me.btGetData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btGetData.Location = New System.Drawing.Point(758, 202)
        Me.btGetData.Margin = New System.Windows.Forms.Padding(4)
        Me.btGetData.Name = "btGetData"
        Me.btGetData.Size = New System.Drawing.Size(264, 34)
        Me.btGetData.TabIndex = 2
        Me.btGetData.Text = "讀取資料"
        Me.btGetData.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Silver
        Me.btExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btExit.Image = Global.WMS.My.Resources.Resources.sign_out
        Me.btExit.Location = New System.Drawing.Point(758, 557)
        Me.btExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(264, 34)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'btSetup
        '
        Me.btSetup.BackColor = System.Drawing.Color.White
        Me.btSetup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSetup.Location = New System.Drawing.Point(758, 318)
        Me.btSetup.Margin = New System.Windows.Forms.Padding(4)
        Me.btSetup.Name = "btSetup"
        Me.btSetup.Size = New System.Drawing.Size(264, 34)
        Me.btSetup.TabIndex = 4
        Me.btSetup.Text = "系統設定"
        Me.btSetup.UseVisualStyleBackColor = False
        '
        'btReport
        '
        Me.btReport.BackColor = System.Drawing.Color.Silver
        Me.btReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btReport.Location = New System.Drawing.Point(758, 260)
        Me.btReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btReport.Name = "btReport"
        Me.btReport.Size = New System.Drawing.Size(264, 34)
        Me.btReport.TabIndex = 3
        Me.btReport.Text = "報表管理"
        Me.btReport.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 642)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btSetup)
        Me.Controls.Add(Me.btReport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btGetData)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
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
    Friend WithEvents btGetData As System.Windows.Forms.Button
    Friend WithEvents btReport As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btSetup As System.Windows.Forms.Button
    Friend WithEvents lbVer As System.Windows.Forms.ToolStripStatusLabel
End Class
