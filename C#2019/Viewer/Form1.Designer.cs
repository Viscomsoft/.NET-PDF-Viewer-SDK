namespace PDFViewerDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.uiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uiExportAllPages = new System.Windows.Forms.ToolStripMenuItem();
            this.uiExportPage = new System.Windows.Forms.ToolStripMenuItem();
            this.uiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiSinglePage = new System.Windows.Forms.ToolStripMenuItem();
            this.uiFacing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uiContinuousPages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiFitPage = new System.Windows.Forms.ToolStripMenuItem();
            this.uiActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.uiFitWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.uiFitContent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ui200Percent = new System.Windows.Forms.ToolStripMenuItem();
            this.ui100Percent = new System.Windows.Forms.ToolStripMenuItem();
            this.ui50Percent = new System.Windows.Forms.ToolStripMenuItem();
            this.ui25Percent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.uiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.uiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.uiFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiNextPage = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPreviousPage = new System.Windows.Forms.ToolStripMenuItem();
            this.uiGotoPage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.uiOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uiSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uiColorDialog = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.uiSaveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.uiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMenu
            // 
            this.uiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.uiMenu.Location = new System.Drawing.Point(0, 0);
            this.uiMenu.Name = "uiMenu";
            this.uiMenu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.uiMenu.Size = new System.Drawing.Size(1968, 43);
            this.uiMenu.TabIndex = 0;
            this.uiMenu.Text = "menuStrip1";
            this.uiMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.uiMenu_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiOpen,
            this.uiProperties,
            this.toolStripSeparator7,
            this.uiPrint,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.uiExportAllPages,
            this.uiExportPage,
            this.uiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 35);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uiOpen
            // 
            this.uiOpen.Name = "uiOpen";
            this.uiOpen.Size = new System.Drawing.Size(371, 36);
            this.uiOpen.Text = "Open...";
            this.uiOpen.Click += new System.EventHandler(this.onOpen);
            // 
            // uiProperties
            // 
            this.uiProperties.Name = "uiProperties";
            this.uiProperties.Size = new System.Drawing.Size(371, 36);
            this.uiProperties.Text = "Properties";
            this.uiProperties.Click += new System.EventHandler(this.onProperties);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(368, 6);
            // 
            // uiPrint
            // 
            this.uiPrint.Name = "uiPrint";
            this.uiPrint.Size = new System.Drawing.Size(371, 36);
            this.uiPrint.Text = "Print...";
            this.uiPrint.Click += new System.EventHandler(this.onPrint);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(368, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(371, 36);
            this.toolStripMenuItem1.Text = "Merge, Split,Delete Page";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // uiExportAllPages
            // 
            this.uiExportAllPages.Name = "uiExportAllPages";
            this.uiExportAllPages.Size = new System.Drawing.Size(371, 36);
            this.uiExportAllPages.Text = "Export All Pages";
            this.uiExportAllPages.Click += new System.EventHandler(this.uiExportAllPages_Click);
            // 
            // uiExportPage
            // 
            this.uiExportPage.Name = "uiExportPage";
            this.uiExportPage.Size = new System.Drawing.Size(371, 36);
            this.uiExportPage.Text = "Export Page";
            this.uiExportPage.Click += new System.EventHandler(this.uiExportPage_Click);
            // 
            // uiExit
            // 
            this.uiExit.Name = "uiExit";
            this.uiExit.Size = new System.Drawing.Size(371, 36);
            this.uiExit.Text = "Exit";
            this.uiExit.Click += new System.EventHandler(this.onExit);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiSinglePage,
            this.uiFacing,
            this.toolStripSeparator2,
            this.uiContinuousPages,
            this.toolStripSeparator5,
            this.zoomToolStripMenuItem,
            this.uiFullscreen});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // uiSinglePage
            // 
            this.uiSinglePage.Name = "uiSinglePage";
            this.uiSinglePage.Size = new System.Drawing.Size(295, 36);
            this.uiSinglePage.Text = "Single Page";
            this.uiSinglePage.Click += new System.EventHandler(this.onSinglePage);
            // 
            // uiFacing
            // 
            this.uiFacing.Name = "uiFacing";
            this.uiFacing.Size = new System.Drawing.Size(295, 36);
            this.uiFacing.Text = "Facing";
            this.uiFacing.Click += new System.EventHandler(this.onFacing);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(292, 6);
            // 
            // uiContinuousPages
            // 
            this.uiContinuousPages.Name = "uiContinuousPages";
            this.uiContinuousPages.Size = new System.Drawing.Size(295, 36);
            this.uiContinuousPages.Text = "Continuous Pages";
            this.uiContinuousPages.Click += new System.EventHandler(this.uiContinuousPages_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(292, 6);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiFitPage,
            this.uiActualSize,
            this.uiFitWidth,
            this.uiFitContent,
            this.toolStripSeparator3,
            this.ui200Percent,
            this.ui100Percent,
            this.ui50Percent,
            this.ui25Percent,
            this.toolStripSeparator4,
            this.uiZoomIn,
            this.uiZoomOut});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.DropDownOpening += new System.EventHandler(this.onZoomOpening);
            // 
            // uiFitPage
            // 
            this.uiFitPage.Name = "uiFitPage";
            this.uiFitPage.Size = new System.Drawing.Size(216, 36);
            this.uiFitPage.Text = "Fit Page";
            this.uiFitPage.Click += new System.EventHandler(this.onFitPage);
            // 
            // uiActualSize
            // 
            this.uiActualSize.Name = "uiActualSize";
            this.uiActualSize.Size = new System.Drawing.Size(216, 36);
            this.uiActualSize.Text = "Actual Size";
            this.uiActualSize.Click += new System.EventHandler(this.onActualSize);
            // 
            // uiFitWidth
            // 
            this.uiFitWidth.Name = "uiFitWidth";
            this.uiFitWidth.Size = new System.Drawing.Size(216, 36);
            this.uiFitWidth.Text = "Fit Width";
            this.uiFitWidth.Click += new System.EventHandler(this.onFitWidth);
            // 
            // uiFitContent
            // 
            this.uiFitContent.Name = "uiFitContent";
            this.uiFitContent.Size = new System.Drawing.Size(216, 36);
            this.uiFitContent.Text = "Fit Content";
            this.uiFitContent.Click += new System.EventHandler(this.onFitContent);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // ui200Percent
            // 
            this.ui200Percent.Name = "ui200Percent";
            this.ui200Percent.Size = new System.Drawing.Size(216, 36);
            this.ui200Percent.Text = "200%";
            this.ui200Percent.Click += new System.EventHandler(this.onZoom200Percent);
            // 
            // ui100Percent
            // 
            this.ui100Percent.Name = "ui100Percent";
            this.ui100Percent.Size = new System.Drawing.Size(216, 36);
            this.ui100Percent.Text = "100%";
            this.ui100Percent.Click += new System.EventHandler(this.onZoom100Percent);
            // 
            // ui50Percent
            // 
            this.ui50Percent.Name = "ui50Percent";
            this.ui50Percent.Size = new System.Drawing.Size(216, 36);
            this.ui50Percent.Text = "50%";
            this.ui50Percent.Click += new System.EventHandler(this.onZoom50Percent);
            // 
            // ui25Percent
            // 
            this.ui25Percent.Name = "ui25Percent";
            this.ui25Percent.Size = new System.Drawing.Size(216, 36);
            this.ui25Percent.Text = "25%";
            this.ui25Percent.Click += new System.EventHandler(this.onZoom25Percent);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // uiZoomIn
            // 
            this.uiZoomIn.Name = "uiZoomIn";
            this.uiZoomIn.Size = new System.Drawing.Size(216, 36);
            this.uiZoomIn.Text = "Zoom In";
            this.uiZoomIn.Click += new System.EventHandler(this.onZoomIn);
            // 
            // uiZoomOut
            // 
            this.uiZoomOut.Name = "uiZoomOut";
            this.uiZoomOut.Size = new System.Drawing.Size(216, 36);
            this.uiZoomOut.Text = "Zoom Out";
            this.uiZoomOut.Click += new System.EventHandler(this.onZoomOut);
            // 
            // uiFullscreen
            // 
            this.uiFullscreen.Name = "uiFullscreen";
            this.uiFullscreen.Size = new System.Drawing.Size(295, 36);
            this.uiFullscreen.Text = "Fullscreen";
            this.uiFullscreen.Click += new System.EventHandler(this.onFullscreen);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiNextPage,
            this.uiPreviousPage,
            this.uiGotoPage,
            this.toolStripSeparator6});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(95, 35);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // uiNextPage
            // 
            this.uiNextPage.Name = "uiNextPage";
            this.uiNextPage.Size = new System.Drawing.Size(250, 36);
            this.uiNextPage.Text = "Next Page";
            this.uiNextPage.Click += new System.EventHandler(this.onNextPage);
            // 
            // uiPreviousPage
            // 
            this.uiPreviousPage.Name = "uiPreviousPage";
            this.uiPreviousPage.Size = new System.Drawing.Size(250, 36);
            this.uiPreviousPage.Text = "Previous Page";
            this.uiPreviousPage.Click += new System.EventHandler(this.onPreviousPage);
            // 
            // uiGotoPage
            // 
            this.uiGotoPage.Name = "uiGotoPage";
            this.uiGotoPage.Size = new System.Drawing.Size(250, 36);
            this.uiGotoPage.Text = "Page...";
            this.uiGotoPage.Click += new System.EventHandler(this.onGotoPage);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(247, 6);
            // 
            // uiOpenFileDialog
            // 
            this.uiOpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1220);
            this.Controls.Add(this.uiMenu);
            this.MainMenuStrip = this.uiMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.onFormLoad);
            this.Resize += new System.EventHandler(this.onFormResize);
            this.uiMenu.ResumeLayout(false);
            this.uiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uiMenu;
        private System.Windows.Forms.OpenFileDialog uiOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiOpen;
        private System.Windows.Forms.ToolStripMenuItem uiProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uiExit;
        private System.Windows.Forms.SaveFileDialog uiSaveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem uiPrint;
        private System.Windows.Forms.ColorDialog uiColorDialog;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiSinglePage;
        private System.Windows.Forms.ToolStripMenuItem uiFacing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiFitPage;
        private System.Windows.Forms.ToolStripMenuItem uiActualSize;
        private System.Windows.Forms.ToolStripMenuItem uiFitWidth;
        private System.Windows.Forms.ToolStripMenuItem uiFitContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ui200Percent;
        private System.Windows.Forms.ToolStripMenuItem ui100Percent;
        private System.Windows.Forms.ToolStripMenuItem ui50Percent;
        private System.Windows.Forms.ToolStripMenuItem ui25Percent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem uiZoomIn;
        private System.Windows.Forms.ToolStripMenuItem uiZoomOut;
        private System.Windows.Forms.ToolStripMenuItem uiFullscreen;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiNextPage;
        private System.Windows.Forms.ToolStripMenuItem uiPreviousPage;
        private System.Windows.Forms.ToolStripMenuItem uiGotoPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem uiContinuousPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem uiExportAllPages;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem uiExportPage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog uiSaveFileDialog2;
    }
}

