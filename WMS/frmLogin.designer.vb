<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btGetData
        '
        Me.btGetData.BackColor = System.Drawing.Color.White
        Me.btGetData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btGetData.Location = New System.Drawing.Point(792, 516)
        Me.btGetData.Margin = New System.Windows.Forms.Padding(4)
        Me.btGetData.Name = "btGetData"
        Me.btGetData.Size = New System.Drawing.Size(223, 34)
        Me.btGetData.TabIndex = 2
        Me.btGetData.Text = "登    入"
        Me.btGetData.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(792, 295)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(223, 33)
        Me.tbPassword.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(708, 300)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "密  碼:"
        '
        'tbUserName
        '
        Me.tbUserName.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbUserName.Location = New System.Drawing.Point(792, 250)
        Me.tbUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(223, 33)
        Me.tbUserName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(708, 253)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "使用者:"
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Silver
        Me.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btExit.Location = New System.Drawing.Point(792, 559)
        Me.btExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(223, 34)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "離    開"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btGetData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WMS.My.Resources.Resources.VB_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btExit
        Me.ClientSize = New System.Drawing.Size(1056, 642)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbUserName)
        Me.Controls.Add(Me.btGetData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btGetData As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
