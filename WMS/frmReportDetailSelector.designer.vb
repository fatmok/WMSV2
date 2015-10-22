<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportDetailSelector
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.cbAreaID = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbCountryID = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbRFID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbModelNO = New System.Windows.Forms.TextBox()
        Me.tbCustNo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbShowSelectDate = New System.Windows.Forms.RadioButton()
        Me.rbShowAll = New System.Windows.Forms.RadioButton()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btRunReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.btRefresh.Location = New System.Drawing.Point(377, 503)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(156, 66)
        Me.btRefresh.TabIndex = 3
        Me.btRefresh.Text = "清空條件"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.tbAddress)
        Me.GroupBox1.Controls.Add(Me.cbAreaID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbCountryID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 140)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(674, 166)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "所在位置"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 113)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 18)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "地址"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(125, 110)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(510, 29)
        Me.tbAddress.TabIndex = 38
        '
        'cbAreaID
        '
        Me.cbAreaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAreaID.FormattingEnabled = True
        Me.cbAreaID.Location = New System.Drawing.Point(125, 76)
        Me.cbAreaID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAreaID.Name = "cbAreaID"
        Me.cbAreaID.Size = New System.Drawing.Size(510, 26)
        Me.cbAreaID.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "地域"
        '
        'cbCountryID
        '
        Me.cbCountryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCountryID.FormattingEnabled = True
        Me.cbCountryID.Location = New System.Drawing.Point(125, 38)
        Me.cbCountryID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCountryID.Name = "cbCountryID"
        Me.cbCountryID.Size = New System.Drawing.Size(510, 26)
        Me.cbCountryID.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 44)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "總區"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbRFID)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbModelNO)
        Me.GroupBox2.Controls.Add(Me.tbCustNo)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 171)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "其他"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 132)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "RFID 編號"
        Me.Label9.Visible = False
        '
        'tbRFID
        '
        Me.tbRFID.Location = New System.Drawing.Point(125, 128)
        Me.tbRFID.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRFID.Name = "tbRFID"
        Me.tbRFID.Size = New System.Drawing.Size(510, 29)
        Me.tbRFID.TabIndex = 32
        Me.tbRFID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "形號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "自定編號"
        '
        'tbModelNO
        '
        Me.tbModelNO.Location = New System.Drawing.Point(125, 79)
        Me.tbModelNO.Margin = New System.Windows.Forms.Padding(4)
        Me.tbModelNO.Name = "tbModelNO"
        Me.tbModelNO.Size = New System.Drawing.Size(510, 29)
        Me.tbModelNO.TabIndex = 22
        '
        'tbCustNo
        '
        Me.tbCustNo.Location = New System.Drawing.Point(125, 37)
        Me.tbCustNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCustNo.Name = "tbCustNo"
        Me.tbCustNo.Size = New System.Drawing.Size(510, 29)
        Me.tbCustNo.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.rbShowSelectDate)
        Me.GroupBox3.Controls.Add(Me.rbShowAll)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(674, 121)
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
        Me.Panel1.Location = New System.Drawing.Point(19, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 54)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
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
        'rbShowSelectDate
        '
        Me.rbShowSelectDate.AutoSize = True
        Me.rbShowSelectDate.Checked = True
        Me.rbShowSelectDate.Location = New System.Drawing.Point(194, 29)
        Me.rbShowSelectDate.Name = "rbShowSelectDate"
        Me.rbShowSelectDate.Size = New System.Drawing.Size(105, 22)
        Me.rbShowSelectDate.TabIndex = 5
        Me.rbShowSelectDate.TabStop = True
        Me.rbShowSelectDate.Text = "選擇日期"
        Me.rbShowSelectDate.UseVisualStyleBackColor = True
        '
        'rbShowAll
        '
        Me.rbShowAll.AutoSize = True
        Me.rbShowAll.Location = New System.Drawing.Point(19, 29)
        Me.rbShowAll.Name = "rbShowAll"
        Me.rbShowAll.Size = New System.Drawing.Size(105, 22)
        Me.rbShowAll.TabIndex = 4
        Me.rbShowAll.Text = "所有日期"
        Me.rbShowAll.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(539, 503)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(156, 66)
        Me.btExit.TabIndex = 33
        Me.btExit.Text = "離開"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btRunReport
        '
        Me.btRunReport.Location = New System.Drawing.Point(21, 503)
        Me.btRunReport.Name = "btRunReport"
        Me.btRunReport.Size = New System.Drawing.Size(156, 66)
        Me.btRunReport.TabIndex = 34
        Me.btRunReport.Text = "運行報表"
        Me.btRunReport.UseVisualStyleBackColor = True
        '
        'frmReportDetailSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 591)
        Me.Controls.Add(Me.btRunReport)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btRefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReportDetailSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請選擇項目"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbAreaID As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbCountryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbModelNO As System.Windows.Forms.TextBox
    Friend WithEvents tbCustNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbRFID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btRunReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbShowSelectDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbShowAll As System.Windows.Forms.RadioButton
End Class
