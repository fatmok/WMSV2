<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btCancel = New System.Windows.Forms.Button
        Me.btOK = New System.Windows.Forms.Button
        Me.dgvMain = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btShowAll = New System.Windows.Forms.Button
        Me.btSearch = New System.Windows.Forms.Button
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btCancel
        '
        Me.btCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(700, 450)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(66, 29)
        Me.btCancel.TabIndex = 35
        Me.btCancel.Text = "離開"
        Me.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btOK.Location = New System.Drawing.Point(630, 450)
        Me.btOK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(66, 29)
        Me.btOK.TabIndex = 34
        Me.btOK.Text = "確定"
        Me.btOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btOK.UseVisualStyleBackColor = True
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(16, 36)
        Me.dgvMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 24
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(749, 408)
        Me.dgvMain.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(483, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 12)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "備註: 輸入的英文大小寫必須相符"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(123, 6)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(280, 22)
        Me.tbSearch.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 12)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "請輸入欲查詢資料:"
        '
        'btShowAll
        '
        Me.btShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btShowAll.Location = New System.Drawing.Point(13, 450)
        Me.btShowAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btShowAll.Name = "btShowAll"
        Me.btShowAll.Size = New System.Drawing.Size(115, 25)
        Me.btShowAll.TabIndex = 32
        Me.btShowAll.Text = "顯示所有資料"
        Me.btShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btShowAll.UseVisualStyleBackColor = True
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(410, 3)
        Me.btSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(66, 25)
        Me.btSearch.TabIndex = 31
        Me.btSearch.Text = "尋找"
        Me.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'frmSearchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 489)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btShowAll)
        Me.Controls.Add(Me.btSearch)
        Me.Name = "frmSearchItem"
        Me.Text = "查找資料"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btShowAll As System.Windows.Forms.Button
    Friend WithEvents btSearch As System.Windows.Forms.Button
End Class
