<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBTools
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
        Me.tbTraUserMaster = New System.Windows.Forms.Button()
        Me.tbTraAreaMaster = New System.Windows.Forms.Button()
        Me.tbTraCountryMaster = New System.Windows.Forms.Button()
        Me.tbTraBinMaster = New System.Windows.Forms.Button()
        Me.tbTraLogMaster = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btCardMaster = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbTraUserMaster
        '
        Me.tbTraUserMaster.Location = New System.Drawing.Point(50, 33)
        Me.tbTraUserMaster.Name = "tbTraUserMaster"
        Me.tbTraUserMaster.Size = New System.Drawing.Size(196, 48)
        Me.tbTraUserMaster.TabIndex = 0
        Me.tbTraUserMaster.Text = "Truncate UserMaster "
        Me.tbTraUserMaster.UseVisualStyleBackColor = True
        '
        'tbTraAreaMaster
        '
        Me.tbTraAreaMaster.Location = New System.Drawing.Point(50, 106)
        Me.tbTraAreaMaster.Name = "tbTraAreaMaster"
        Me.tbTraAreaMaster.Size = New System.Drawing.Size(196, 48)
        Me.tbTraAreaMaster.TabIndex = 1
        Me.tbTraAreaMaster.Text = "Truncate AreaMaster "
        Me.tbTraAreaMaster.UseVisualStyleBackColor = True
        '
        'tbTraCountryMaster
        '
        Me.tbTraCountryMaster.Location = New System.Drawing.Point(272, 33)
        Me.tbTraCountryMaster.Name = "tbTraCountryMaster"
        Me.tbTraCountryMaster.Size = New System.Drawing.Size(196, 48)
        Me.tbTraCountryMaster.TabIndex = 2
        Me.tbTraCountryMaster.Text = "Truncate CountryMaster "
        Me.tbTraCountryMaster.UseVisualStyleBackColor = True
        '
        'tbTraBinMaster
        '
        Me.tbTraBinMaster.Location = New System.Drawing.Point(272, 106)
        Me.tbTraBinMaster.Name = "tbTraBinMaster"
        Me.tbTraBinMaster.Size = New System.Drawing.Size(196, 48)
        Me.tbTraBinMaster.TabIndex = 3
        Me.tbTraBinMaster.Text = "Truncate BinMaster "
        Me.tbTraBinMaster.UseVisualStyleBackColor = True
        '
        'tbTraLogMaster
        '
        Me.tbTraLogMaster.Location = New System.Drawing.Point(50, 181)
        Me.tbTraLogMaster.Name = "tbTraLogMaster"
        Me.tbTraLogMaster.Size = New System.Drawing.Size(196, 48)
        Me.tbTraLogMaster.TabIndex = 4
        Me.tbTraLogMaster.Text = "Truncate LogMaster "
        Me.tbTraLogMaster.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Bin Upload Time Seting"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btCardMaster
        '
        Me.btCardMaster.Location = New System.Drawing.Point(272, 181)
        Me.btCardMaster.Name = "btCardMaster"
        Me.btCardMaster.Size = New System.Drawing.Size(196, 48)
        Me.btCardMaster.TabIndex = 6
        Me.btCardMaster.Text = "Truncate CardMaster "
        Me.btCardMaster.UseVisualStyleBackColor = True
        '
        'DBTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 350)
        Me.Controls.Add(Me.btCardMaster)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbTraLogMaster)
        Me.Controls.Add(Me.tbTraBinMaster)
        Me.Controls.Add(Me.tbTraCountryMaster)
        Me.Controls.Add(Me.tbTraAreaMaster)
        Me.Controls.Add(Me.tbTraUserMaster)
        Me.Name = "DBTools"
        Me.Text = "Admin Tools"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbTraUserMaster As System.Windows.Forms.Button
    Friend WithEvents tbTraAreaMaster As System.Windows.Forms.Button
    Friend WithEvents tbTraCountryMaster As System.Windows.Forms.Button
    Friend WithEvents tbTraBinMaster As System.Windows.Forms.Button
    Friend WithEvents tbTraLogMaster As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btCardMaster As System.Windows.Forms.Button
End Class
