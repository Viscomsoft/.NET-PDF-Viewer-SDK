Public Class ExportPage
    Public iSelPageNumber As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        iSelPageNumber = txtpageno.Text
        Close()
    End Sub

    Private Sub ExportPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class