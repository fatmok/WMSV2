<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.btCountrySetup = New System.Windows.Forms.Button()
        Me.btBin = New System.Windows.Forms.Button()
        Me.btArea = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.tbDBTools = New System.Windows.Forms.Button()
        Me.tbGarbageCat = New System.Windows.Forms.Button()
        Me.tbGarbageSubCat = New System.Windows.Forms.Button()
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
        Me.btUserList.Location = New System.Drawing.Point(757, 189)
        Me.btUserList.Margin = New System.Windows.Forms.Padding(4)
        Me.btUserList.Name = "btUserList"
        Me.btUserList.Size = New System.Drawing.Size(264, 34)
        Me.btUserList.TabIndex = 2
        Me.btUserList.Text = "使用者管理"
        Me.btUserList.UseVisualStyleBackColor = False
        '
        'btCountrySetup
        '
        Me.btCountrySetup.BackColor = System.Drawing.Color.White
        Me.btCountrySetup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btCountrySetup.Location = New System.Drawing.Point(757, 255)
        Me.btCountrySetup.Margin = New System.Windows.Forms.Padding(4)
        Me.btCountrySetup.Name = "btCountrySetup"
        Me.btCountrySetup.Size = New System.Drawing.Size(264, 34)
        Me.btCountrySetup.TabIndex = 5
        Me.btCountrySetup.Text = "總區設定"
        Me.btCountrySetup.UseVisualStyleBackColor = False
        '
        'btBin
        '
        Me.btBin.BackColor = System.Drawing.Color.White
        Me.btBin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btBin.Location = New System.Drawing.Point(485, 321)
        Me.btBin.Margin = New System.Windows.Forms.Padding(4)
        Me.btBin.Name = "btBin"
        Me.btBin.Size = New System.Drawing.Size(264, 34)
        Me.btBin.TabIndex = 6
        Me.btBin.Text = "垃圾桶設定"
        Me.btBin.UseVisualStyleBackColor = False
        '
        'btArea
        '
        Me.btArea.BackColor = System.Drawing.Color.White
        Me.btArea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btArea.Location = New System.Drawing.Point(757, 321)
        Me.btArea.Margin = New System.Windows.Forms.Padding(4)
        Me.btArea.Name = "btArea"
        Me.btArea.Size = New System.Drawing.Size(264, 34)
        Me.btArea.TabIndex = 7
        Me.btArea.Text = "地區設定"
        Me.btArea.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Silver
        Me.btExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btExit.Location = New System.Drawing.Point(757, 556)
        Me.btExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(264, 34)
        Me.btExit.TabIndex = 8
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'tbDBTools
        '
        Me.tbDBTools.BackColor = System.Drawing.Color.White
        Me.tbDBTools.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tbDBTools.Location = New System.Drawing.Point(757, 387)
        Me.tbDBTools.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDBTools.Name = "tbDBTools"
        Me.tbDBTools.Size = New System.Drawing.Size(264, 34)
        Me.tbDBTools.TabIndex = 9
        Me.tbDBTools.Text = "資料庫設定"
        Me.tbDBTools.UseVisualStyleBackColor = False
        Me.tbDBTools.Visible = False
        '
        'tbGarbageCat
        '
        Me.tbGarbageCat.BackColor = System.Drawing.Color.White
        Me.tbGarbageCat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tbGarbageCat.Location = New System.Drawing.Point(485, 189)
        Me.tbGarbageCat.Margin = New System.Windows.Forms.Padding(4)
        Me.tbGarbageCat.Name = "tbGarbageCat"
        Me.tbGarbageCat.Size = New System.Drawing.Size(264, 34)
        Me.tbGarbageCat.TabIndex = 10
        Me.tbGarbageCat.Text = "垃圾分類 1 設定"
        Me.tbGarbageCat.UseVisualStyleBackColor = False
        '
        'tbGarbageSubCat
        '
        Me.tbGarbageSubCat.BackColor = System.Drawing.Color.White
        Me.tbGarbageSubCat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tbGarbageSubCat.Location = New System.Drawing.Point(485, 255)
        Me.tbGarbageSubCat.Margin = New System.Windows.Forms.Padding(4)
        Me.tbGarbageSubCat.Name = "tbGarbageSubCat"
        Me.tbGarbageSubCat.Size = New System.Drawing.Size(264, 34)
        Me.tbGarbageSubCat.TabIndex = 11
        Me.tbGarbageSubCat.Text = "垃圾分類 2 設定"
        Me.tbGarbageSubCat.UseVisualStyleBackColor = False
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WMS.My.Resources.Resources.VB_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 642)
        Me.Controls.Add(Me.tbGarbageSubCat)
        Me.Controls.Add(Me.tbGarbageCat)
        Me.Controls.Add(Me.tbDBTools)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btArea)
        Me.Controls.Add(Me.btBin)
        Me.Controls.Add(Me.btCountrySetup)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btUserList)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSetup"
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
    Friend WithEvents btCountrySetup As System.Windows.Forms.Button
    Friend WithEvents btBin As System.Windows.Forms.Button
    Friend WithEvents btArea As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents tbDBTools As System.Windows.Forms.Button
    Friend WithEvents tbGarbageCat As System.Windows.Forms.Button
    Friend WithEvents tbGarbageSubCat As System.Windows.Forms.Button
End Class
