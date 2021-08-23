<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportPageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinglePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContinuousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FitPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FitContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem200Percent = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem100Percent = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem50Percent = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem25Percent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NexPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.GoToToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1278, 43)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.PropertiesToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportAllToolStripMenuItem1, Me.ExportPageToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(65, 35)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(371, 36)
        Me.ToolStripMenuItem1.Text = "Merge, Split,Delete Page"
        '
        'ExportAllToolStripMenuItem1
        '
        Me.ExportAllToolStripMenuItem1.Name = "ExportAllToolStripMenuItem1"
        Me.ExportAllToolStripMenuItem1.Size = New System.Drawing.Size(371, 36)
        Me.ExportAllToolStripMenuItem1.Text = "Export All Pages"
        '
        'ExportPageToolStripMenuItem1
        '
        Me.ExportPageToolStripMenuItem1.Name = "ExportPageToolStripMenuItem1"
        Me.ExportPageToolStripMenuItem1.Size = New System.Drawing.Size(371, 36)
        Me.ExportPageToolStripMenuItem1.Text = "Export Page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinglePageToolStripMenuItem, Me.FacingToolStripMenuItem, Me.ToolStripSeparator1, Me.ContinuousToolStripMenuItem, Me.ZoomToolStripMenuItem, Me.FullScreenToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(81, 35)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SinglePageToolStripMenuItem
        '
        Me.SinglePageToolStripMenuItem.Name = "SinglePageToolStripMenuItem"
        Me.SinglePageToolStripMenuItem.Size = New System.Drawing.Size(295, 36)
        Me.SinglePageToolStripMenuItem.Text = "Single Page"
        '
        'FacingToolStripMenuItem
        '
        Me.FacingToolStripMenuItem.Name = "FacingToolStripMenuItem"
        Me.FacingToolStripMenuItem.Size = New System.Drawing.Size(295, 36)
        Me.FacingToolStripMenuItem.Text = "Facing"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(292, 6)
        '
        'ContinuousToolStripMenuItem
        '
        Me.ContinuousToolStripMenuItem.Name = "ContinuousToolStripMenuItem"
        Me.ContinuousToolStripMenuItem.Size = New System.Drawing.Size(295, 36)
        Me.ContinuousToolStripMenuItem.Text = "Continuous Pages"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FitPageToolStripMenuItem, Me.ActualSizeToolStripMenuItem, Me.FitToolStripMenuItem, Me.FitContentToolStripMenuItem, Me.ToolStripSeparator2, Me.MenuItem200Percent, Me.MenuItem100Percent, Me.MenuItem50Percent, Me.MenuItem25Percent, Me.ToolStripSeparator3, Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(295, 36)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'FitPageToolStripMenuItem
        '
        Me.FitPageToolStripMenuItem.Name = "FitPageToolStripMenuItem"
        Me.FitPageToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.FitPageToolStripMenuItem.Text = "Fit Page"
        '
        'ActualSizeToolStripMenuItem
        '
        Me.ActualSizeToolStripMenuItem.Name = "ActualSizeToolStripMenuItem"
        Me.ActualSizeToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.ActualSizeToolStripMenuItem.Text = "Actual Size"
        '
        'FitToolStripMenuItem
        '
        Me.FitToolStripMenuItem.Name = "FitToolStripMenuItem"
        Me.FitToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.FitToolStripMenuItem.Text = "Fit Width"
        '
        'FitContentToolStripMenuItem
        '
        Me.FitContentToolStripMenuItem.Name = "FitContentToolStripMenuItem"
        Me.FitContentToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.FitContentToolStripMenuItem.Text = "Fit Content"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(213, 6)
        '
        'MenuItem200Percent
        '
        Me.MenuItem200Percent.Name = "MenuItem200Percent"
        Me.MenuItem200Percent.Size = New System.Drawing.Size(216, 36)
        Me.MenuItem200Percent.Text = "200%"
        '
        'MenuItem100Percent
        '
        Me.MenuItem100Percent.Name = "MenuItem100Percent"
        Me.MenuItem100Percent.Size = New System.Drawing.Size(216, 36)
        Me.MenuItem100Percent.Text = "100%"
        '
        'MenuItem50Percent
        '
        Me.MenuItem50Percent.Name = "MenuItem50Percent"
        Me.MenuItem50Percent.Size = New System.Drawing.Size(216, 36)
        Me.MenuItem50Percent.Text = "50%"
        '
        'MenuItem25Percent
        '
        Me.MenuItem25Percent.Name = "MenuItem25Percent"
        Me.MenuItem25Percent.Size = New System.Drawing.Size(216, 36)
        Me.MenuItem25Percent.Text = "25%"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(213, 6)
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.ZoomInToolStripMenuItem.Text = "Zoom In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(295, 36)
        Me.FullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NexPageToolStripMenuItem, Me.PreviousPageToolStripMenuItem, Me.PageToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(95, 35)
        Me.GoToToolStripMenuItem.Text = "Go To"
        '
        'NexPageToolStripMenuItem
        '
        Me.NexPageToolStripMenuItem.Name = "NexPageToolStripMenuItem"
        Me.NexPageToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.NexPageToolStripMenuItem.Text = "Nex Page"
        '
        'PreviousPageToolStripMenuItem
        '
        Me.PreviousPageToolStripMenuItem.Name = "PreviousPageToolStripMenuItem"
        Me.PreviousPageToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.PreviousPageToolStripMenuItem.Text = "Previous Page"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.PageToolStripMenuItem.Text = "Page.."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 897)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinglePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FitPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FitContentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem200Percent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem100Percent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem50Percent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem25Percent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NexPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportPageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContinuousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog

End Class
