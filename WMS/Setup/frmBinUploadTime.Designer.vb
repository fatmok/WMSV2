<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBinUploadTime
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
        Me.tbMinute = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOK = New System.Windows.Forms.Button()
        Me.tbExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbMinute
        '
        Me.tbMinute.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMinute.Location = New System.Drawing.Point(193, 43)
        Me.tbMinute.Name = "tbMinute"
        Me.tbMinute.Size = New System.Drawing.Size(210, 45)
        Me.tbMinute.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Minute:"
        '
        'tbOK
        '
        Me.tbOK.Location = New System.Drawing.Point(233, 114)
        Me.tbOK.Name = "tbOK"
        Me.tbOK.Size = New System.Drawing.Size(82, 46)
        Me.tbOK.TabIndex = 2
        Me.tbOK.Text = "SAVE"
        Me.tbOK.UseVisualStyleBackColor = True
        '
        'tbExit
        '
        Me.tbExit.Location = New System.Drawing.Point(321, 114)
        Me.tbExit.Name = "tbExit"
        Me.tbExit.Size = New System.Drawing.Size(82, 46)
        Me.tbExit.TabIndex = 3
        Me.tbExit.Text = "EXIT"
        Me.tbExit.UseVisualStyleBackColor = True
        '
        'frmBinUploadTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 189)
        Me.Controls.Add(Me.tbExit)
        Me.Controls.Add(Me.tbOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMinute)
        Me.Name = "frmBinUploadTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UploadTimeSetup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbOK As System.Windows.Forms.Button
    Friend WithEvents tbExit As System.Windows.Forms.Button
End Class
