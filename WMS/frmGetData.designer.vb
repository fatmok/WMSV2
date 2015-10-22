<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetData
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
        Me.btGetData = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btUpload = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.tbRowCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btGetData
        '
        Me.btGetData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btGetData.Location = New System.Drawing.Point(746, 736)
        Me.btGetData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btGetData.Name = "btGetData"
        Me.btGetData.Size = New System.Drawing.Size(112, 50)
        Me.btGetData.TabIndex = 0
        Me.btGetData.Text = "讀取資料"
        Me.btGetData.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(3, 18)
        Me.dgvMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowTemplate.Height = 24
        Me.dgvMain.Size = New System.Drawing.Size(1346, 654)
        Me.dgvMain.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 796)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1366, 28)
        Me.StatusStrip1.TabIndex = 2
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
        'btExit
        '
        Me.btExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btExit.Location = New System.Drawing.Point(1236, 736)
        Me.btExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(112, 50)
        Me.btExit.TabIndex = 3
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btUpload
        '
        Me.btUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btUpload.Location = New System.Drawing.Point(867, 736)
        Me.btUpload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btUpload.Name = "btUpload"
        Me.btUpload.Size = New System.Drawing.Size(112, 50)
        Me.btUpload.TabIndex = 4
        Me.btUpload.Text = "上傳資料"
        Me.btUpload.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(988, 736)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "列印報表"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 752)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "檔案位置"
        '
        'tbFilePath
        '
        Me.tbFilePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbFilePath.Location = New System.Drawing.Point(105, 747)
        Me.tbFilePath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(595, 29)
        Me.tbFilePath.TabIndex = 7
        '
        'tbRowCount
        '
        Me.tbRowCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbRowCount.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbRowCount.Location = New System.Drawing.Point(105, 688)
        Me.tbRowCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbRowCount.Name = "tbRowCount"
        Me.tbRowCount.ReadOnly = True
        Me.tbRowCount.Size = New System.Drawing.Size(120, 39)
        Me.tbRowCount.TabIndex = 9
        Me.tbRowCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 702)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "資料行數"
        '
        'frmGetData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 824)
        Me.Controls.Add(Me.tbRowCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btUpload)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.btGetData)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGetData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "讀取資料"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btGetData As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btUpload As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents tbRowCount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
