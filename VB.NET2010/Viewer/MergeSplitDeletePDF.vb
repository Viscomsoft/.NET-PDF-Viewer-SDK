Public Class MergeSplitDeletePDF

    Public iType As Integer
    Public strMergeSource1 As String
    Public strMergeSource2 As String

    Public strSplitSource As String
    Public iSplitStartPage As Integer
    Public strDeletePageSource As String
    Public iDeletePageNo As Integer



    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        OpenFileDialog1.Filter = "PDF File|*.PDF||"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txtmergesource1.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub button2_Click(sender As System.Object, e As System.EventArgs) Handles button2.Click
        OpenFileDialog1.Filter = "PDF File|*.PDF||"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txtmergesource2.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub buttonmerge_Click(sender As System.Object, e As System.EventArgs) Handles buttonmerge.Click
        If txtmergesource1.Text = "" Then

            MessageBox.Show("Please select PDF 1 file")
            Exit Sub
        End If


        If txtmergesource2.Text = "" Then

            MessageBox.Show("Please select PDF 2 file")
            Exit Sub
        End If


        strMergeSource1 = txtmergesource1.Text
        strMergeSource2 = txtmergesource2.Text
        iType = 0
        DialogResult = Windows.Forms.DialogResult.OK

        Close()
    End Sub

    Private Sub MergeSplitDeletePDF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button3_Click(sender As System.Object, e As System.EventArgs) Handles button3.Click
        OpenFileDialog1.Filter = "PDF File|*.PDF||"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txtsplitsource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub button4_Click(sender As System.Object, e As System.EventArgs) Handles button4.Click
        If txtsplitsource.Text = "" Then

            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If


        strSplitSource = txtsplitsource.Text
        iSplitStartPage = Int32.Parse(txtsplitfrompage.Text)

        iType = 1
        DialogResult = Windows.Forms.DialogResult.OK

        Close()
    End Sub

    Private Sub button5_Click(sender As System.Object, e As System.EventArgs) Handles button5.Click
        OpenFileDialog1.Filter = "PDF File|*.PDF||"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txtdeletepagesource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub button6_Click(sender As System.Object, e As System.EventArgs) Handles button6.Click
        If txtdeletepagesource.Text = "" Then

            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If


        strDeletePageSource = txtdeletepagesource.Text
        iDeletePageNo = Int32.Parse(txtdeletepage.Text)

        iType = 2
        DialogResult = Windows.Forms.DialogResult.OK

        Close()
    End Sub
End Class