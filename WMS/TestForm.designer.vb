<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb1 = New System.Windows.Forms.TextBox
        Me.btCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.SystemColors.InfoText
        Me.tb1.ForeColor = System.Drawing.Color.LimeGreen
        Me.tb1.Location = New System.Drawing.Point(12, 12)
        Me.tb1.Multiline = True
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(420, 119)
        Me.tb1.TabIndex = 0
        '
        'btCancel
        '
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(357, 137)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 1
        Me.btCancel.Text = "離開"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'testFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(451, 167)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.tb1)
        Me.Name = "testFrom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents btCancel As System.Windows.Forms.Button
End Class
