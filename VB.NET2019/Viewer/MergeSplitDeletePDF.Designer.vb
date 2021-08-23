<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MergeSplitDeletePDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button6 = New System.Windows.Forms.Button()
        Me.txtdeletepage = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.txtdeletepagesource = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.txtsplitfrompage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.txtsplitsource = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.buttonmerge = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtmergesource2 = New System.Windows.Forms.TextBox()
        Me.txtmergesource1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(151, 625)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(153, 36)
        Me.button6.TabIndex = 44
        Me.button6.Text = "Delete Page"
        Me.button6.UseVisualStyleBackColor = True
        '
        'txtdeletepage
        '
        Me.txtdeletepage.Location = New System.Drawing.Point(268, 553)
        Me.txtdeletepage.Margin = New System.Windows.Forms.Padding(6)
        Me.txtdeletepage.Name = "txtdeletepage"
        Me.txtdeletepage.Size = New System.Drawing.Size(98, 35)
        Me.txtdeletepage.TabIndex = 43
        Me.txtdeletepage.Text = "1"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(30, 559)
        Me.label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(178, 24)
        Me.label5.TabIndex = 42
        Me.label5.Text = "Delete Page No"
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(620, 477)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(131, 36)
        Me.button5.TabIndex = 41
        Me.button5.Text = "select"
        Me.button5.UseVisualStyleBackColor = True
        '
        'txtdeletepagesource
        '
        Me.txtdeletepagesource.Location = New System.Drawing.Point(151, 477)
        Me.txtdeletepagesource.Name = "txtdeletepagesource"
        Me.txtdeletepagesource.Size = New System.Drawing.Size(441, 35)
        Me.txtdeletepagesource.TabIndex = 40
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(30, 483)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(106, 24)
        Me.label4.TabIndex = 39
        Me.label4.Text = "PDF File"
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(151, 384)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(153, 36)
        Me.button4.TabIndex = 38
        Me.button4.Text = "Split PDF"
        Me.button4.UseVisualStyleBackColor = True
        '
        'txtsplitfrompage
        '
        Me.txtsplitfrompage.Location = New System.Drawing.Point(268, 294)
        Me.txtsplitfrompage.Margin = New System.Windows.Forms.Padding(6)
        Me.txtsplitfrompage.Name = "txtsplitfrompage"
        Me.txtsplitfrompage.Size = New System.Drawing.Size(98, 35)
        Me.txtsplitfrompage.TabIndex = 37
        Me.txtsplitfrompage.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 300)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Split From Page No"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(620, 225)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(131, 36)
        Me.button3.TabIndex = 35
        Me.button3.Text = "select"
        Me.button3.UseVisualStyleBackColor = True
        '
        'txtsplitsource
        '
        Me.txtsplitsource.Location = New System.Drawing.Point(151, 225)
        Me.txtsplitsource.Name = "txtsplitsource"
        Me.txtsplitsource.Size = New System.Drawing.Size(441, 35)
        Me.txtsplitsource.TabIndex = 34
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(30, 225)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 24)
        Me.label3.TabIndex = 33
        Me.label3.Text = "PDF File"
        '
        'buttonmerge
        '
        Me.buttonmerge.Location = New System.Drawing.Point(151, 149)
        Me.buttonmerge.Name = "buttonmerge"
        Me.buttonmerge.Size = New System.Drawing.Size(153, 36)
        Me.buttonmerge.TabIndex = 32
        Me.buttonmerge.Text = "Merge PDF"
        Me.buttonmerge.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 92)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 24)
        Me.label2.TabIndex = 31
        Me.label2.Text = "PDF 2"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(620, 80)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(131, 36)
        Me.button2.TabIndex = 30
        Me.button2.Text = "select"
        Me.button2.UseVisualStyleBackColor = True
        '
        'txtmergesource2
        '
        Me.txtmergesource2.Location = New System.Drawing.Point(151, 80)
        Me.txtmergesource2.Name = "txtmergesource2"
        Me.txtmergesource2.Size = New System.Drawing.Size(441, 35)
        Me.txtmergesource2.TabIndex = 29
        '
        'txtmergesource1
        '
        Me.txtmergesource1.Location = New System.Drawing.Point(151, 22)
        Me.txtmergesource1.Name = "txtmergesource1"
        Me.txtmergesource1.Size = New System.Drawing.Size(441, 35)
        Me.txtmergesource1.TabIndex = 28
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 24)
        Me.label1.TabIndex = 27
        Me.label1.Text = "PDF 1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(620, 19)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(131, 36)
        Me.button1.TabIndex = 26
        Me.button1.Text = "select"
        Me.button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MergeSplitDeletePDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 685)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.txtdeletepage)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.txtdeletepagesource)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.txtsplitfrompage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.txtsplitsource)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.buttonmerge)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.txtmergesource2)
        Me.Controls.Add(Me.txtmergesource1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "MergeSplitDeletePDF"
        Me.Text = "Merge Split Delete PDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents txtdeletepage As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents txtdeletepagesource As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents txtsplitfrompage As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents txtsplitsource As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents buttonmerge As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents txtmergesource2 As System.Windows.Forms.TextBox
    Private WithEvents txtmergesource1 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
