<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportDateSelector
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btRunReport = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(99, 10)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 29)
        Me.dtpStart.TabIndex = 0
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(426, 10)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 29)
        Me.dtpEnd.TabIndex = 1
        '
        'btRefresh
        '
        Me.btRefresh.Location = New System.Drawing.Point(377, 139)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(156, 66)
        Me.btRefresh.TabIndex = 3
        Me.btRefresh.Text = "清空條件"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(674, 99)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "日期"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpEnd)
        Me.Panel1.Controls.Add(Me.dtpStart)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(18, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 54)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "開始日期:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "結束日期:"
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(539, 139)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(156, 66)
        Me.btExit.TabIndex = 33
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btRunReport
        '
        Me.btRunReport.Location = New System.Drawing.Point(21, 139)
        Me.btRunReport.Name = "btRunReport"
        Me.btRunReport.Size = New System.Drawing.Size(156, 66)
        Me.btRunReport.TabIndex = 34
        Me.btRunReport.Text = "運行報表"
        Me.btRunReport.UseVisualStyleBackColor = True
        '
        'frmReportDateSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 234)
        Me.Controls.Add(Me.btRunReport)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btRefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReportDateSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請選擇項目"
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btRunReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
