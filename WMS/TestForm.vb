Public Class TestForm

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.tb1.Text = MainScript.TextString
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub
End Class