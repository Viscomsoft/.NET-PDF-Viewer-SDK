
Imports Viscomsoft.PDFViewer
Public Class Form1


    Dim _pdfviewer As New PDFView



    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "PDF Files (*.PDF)|*.PDF"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim doc As New PDFDocument
            If doc.open(OpenFileDialog1.FileName) Then
                _pdfviewer.Document = doc
               
                _pdfviewer.gotoPage(1)

            End If


            End If

    End Sub

    Private Sub resizeCanvas()
        _pdfviewer.Canvas.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - 24)
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(_pdfviewer.Document) Then
            _pdfviewer.Document.close()
        End If

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        _pdfviewer.Canvas.Parent = Me

        _pdfviewer.Canvas.Location = New Point(0, 24)

        resizeCanvas()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        resizeCanvas()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
