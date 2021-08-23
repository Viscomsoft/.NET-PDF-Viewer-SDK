using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Viscomsoft.PDFViewer;

namespace PDFViewerDemo
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

           
            _pdf = new PDFView();
            _pdf.ContinuousPages = true;
            _pdf.Canvas.Parent = this;
            _pdf.Canvas.Location = new Point(0, 24);
            _pdf.PageChanged += new EventHandler(_pdf_PageChanged);
            
            //let scrolling the pdf file using the mouse wheel 
            _pdf.Canvas.Select();
        }
        #endregion

        #region Event Handlers
        private void onOpen(object sender, EventArgs e)
        {
            uiOpenFileDialog.Filter = "All Supported Files|*.PDF;*.tif;*.tiff;*.jpg;*.png*.oxps| PDF Files (*.PDF)|*.PDF|TIFF Files (*.tif)|*.tif;*.tiff|JPEG File(*.jpg)|*.jpg|PNG File(*.png)|*.png|XPS document(*.oxps)|*.oxps||";
            if (uiOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PDFDocument doc = new PDFDocument();
                if (doc.open(uiOpenFileDialog.FileName))
                {
                    bool opened = true;

                    if (doc.RequiresPassword)
                    {
                        opened = false;

                        while (!opened)
                        {
                            PasswordForm pwdForm = new PasswordForm();
                            if (pwdForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                opened = doc.applyPassword(pwdForm.Password);
                                if (!opened)
                                    MessageBox.Show("Invalid password", "Document is have user password");
                            }
                            else
                                break;
                        }
                    }

                    if (opened)
                    {
                       
                        _pdf.Document = doc;
                        _pdf.gotoPage(1);
                       
                    }
                    else
                    {
                        doc.close();
                    }
                }
            }
        }

        private void onSaveText(object sender, EventArgs e)
        {
            
        }

        private void onPrint(object sender, EventArgs e)
        {
            if (_pdf.Document != null)
                _pdf.Document.print(_pdf.CurrentPage);
        }

        private void onProperties(object sender, EventArgs e)
        {
            PDFDocument doc = _pdf.Document;
            if (doc == null)
                return;

            String info = "Format:\t\t";
            info += doc.PDFVersion;
            info += "\nProducer:\t\t";
            info += doc.PDFProducer;
            info += "\nFile Name:\t";
            info += doc.FileName;
            info += "\nFile Size:\t\t";
            info += doc.FileSize;
            info += "\nPages:\t\t";
            info += doc.PageCount;
            info += "\nCreated:\t\t";
            info += doc.Created;
            info += "\nModified:\t\t";
            info += doc.Modified;
           
            PDFPage page = new PDFPage(doc);

            
            page.load(1);
            info += "\nPage Size:\t\t";

            info += page.PageSize;

            
            MessageBox.Show(info);

            //need release
            page.unload(doc, true);

          
          
        }

        private void onExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onSinglePage(object sender, EventArgs e)
        {
            uncheckViewMenuItems();
            uiSinglePage.Checked = true;

            _pdf.View = Viscomsoft.PDFViewer.View.SinglePage;
           

        }

        private void onFacing(object sender, EventArgs e)
        {
            uncheckViewMenuItems();
            uiFacing.Checked = true;
            _pdf.View = Viscomsoft.PDFViewer.View.Facing;
        }

        private void onBookView(object sender, EventArgs e)
        {
        
        }

        private void onContinuousPages(object sender, EventArgs e)
        {
            //uiContinuousPages.Checked = !uiContinuousPages.Checked;
            //_pdf.ContinuousPages = uiContinuousPages.Checked;
        }

        private void onFitPage(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            uiFitPage.Checked = true;
            _pdf.Zoom = Zoom.FitPage;
        }

        private void onActualSize(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            uiActualSize.Checked = true;
            _pdf.Zoom = Zoom.ActualSize;
        }

        private void onFitWidth(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            uiFitWidth.Checked = true;
            _pdf.Zoom = Zoom.FitWidth;
        }

        private void onFitContent(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            uiFitContent.Checked = true;
            _pdf.Zoom = Zoom.FitContent;
        }

        private void onZoom200Percent(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            ui200Percent.Checked = true;
            _pdf.Zoom = Zoom.Percent200;
        }

        private void onZoom100Percent(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            ui100Percent.Checked = true;
            _pdf.Zoom = Zoom.Percent100;
        }

        private void onZoom50Percent(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            ui50Percent.Checked = true;
            _pdf.Zoom = Zoom.Percent50;
        }

        private void onZoom25Percent(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();
            ui25Percent.Checked = true;
            _pdf.Zoom = Zoom.Percent25;
        }

        private void onZoomIn(object sender, EventArgs e)
        {
            _pdf.zoomIn();
        }

        private void onZoomOut(object sender, EventArgs e)
        {
            _pdf.zoomOut();
        }

        private void onFullscreen(object sender, EventArgs e)
        {
            _pdf.fullscreen();
        }

        private void onNextPage(object sender, EventArgs e)
        {
            _pdf.nextPage();
        }

        private void onPreviousPage(object sender, EventArgs e)
        {
            _pdf.previousPage();
        }

        private void onGotoPage(object sender, EventArgs e)
        {
            GotoForm frm = new GotoForm();
            frm.ShowDialog();
                _pdf.gotoPage(frm.PageNumber);
        }

        private void onFind(object sender, EventArgs e)
        {
          
        }

       

        private void onFormLoad(object sender, EventArgs e)
        {
              uiContinuousPages.Checked=true;
               
            resizeCanvas();
        }

        private void onFormResize(object sender, EventArgs e)
        {
            resizeCanvas();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (_pdf.Document != null)
                _pdf.Document.close();
        }

        
        private void onZoomOpening(object sender, EventArgs e)
        {
            uncheckZoomMenuItems();

            switch (_pdf.Zoom)
            {
                case Zoom.FitPage:
                    uiFitPage.Checked = true;
                    break;
                case Zoom.Percent100:
                case Zoom.ActualSize:
                    uiActualSize.Checked = true;
                    ui100Percent.Checked = true;
                    break;
                case Zoom.FitWidth:
                    uiFitWidth.Checked = true;
                    break;
                case Zoom.FitContent:
                    uiFitContent.Checked = true;
                    break;
                case Zoom.Percent200:
                    ui200Percent.Checked = true;
                    break;
                case Zoom.Percent50:
                    ui50Percent.Checked = true;
                    break;
                case Zoom.Percent25:
                    ui25Percent.Checked = true;
                    break;
            }
        }

        void _pdf_PageChanged(object sender, EventArgs e)
        {

           
            PDFDocument doc = _pdf.Document;
            if (doc != null)
                this.Text = doc.FileName + " [" + _pdf.CurrentPage + "/" + doc.PageCount + "]";
        }
        #endregion

        #region Internal
        private void resizeCanvas()
        {
            if(_pdf!=null)
            _pdf.Canvas.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 24);
        }

        private void uncheckZoomMenuItems()
        {
            uiFitPage.Checked = false;
            uiActualSize.Checked = false;
            uiFitWidth.Checked = false;
            uiFitContent.Checked = false;
            ui200Percent.Checked = false;
            ui100Percent.Checked = false;
            ui50Percent.Checked = false;
            ui25Percent.Checked = false;
        }

        private void uncheckViewMenuItems()
        {
            uiSinglePage.Checked = false;
            uiFacing.Checked = false;
          
        }
        #endregion

        #region Data
        private PDFView _pdf;
        #endregion

        private void uiBookView_Click(object sender, EventArgs e)
        {

        
        }

        private void uiContinuousPages_Click(object sender, EventArgs e)
        {
            uiContinuousPages.Checked = !uiContinuousPages.Checked;
            _pdf.ContinuousPages = uiContinuousPages.Checked;
         
        }

        private void uiFind_Click(object sender, EventArgs e)
        {
         
        }

        private void uiHighlightColor_Click(object sender, EventArgs e)
        {
          
        }

        private void uiSaveText_Click(object sender, EventArgs e)
        {
           
        }

        private void uiExportAllPages_Click(object sender, EventArgs e)
        {
            if (_pdf.Document == null)
                return;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                if (_pdf.Document.ExportAllPages(this.folderBrowserDialog1.SelectedPath, 4))
                    MessageBox.Show("Export all pages completed");
                else
                    MessageBox.Show("Export failed");
            }
        }

        private void uiExportPage_Click(object sender, EventArgs e)
        {
            if (_pdf.Document == null)
                return;
                      

            ExportPage frm = new ExportPage();
           
            frm.ShowDialog();
           
             uiSaveFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg";
             if (uiSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {

                 if (_pdf.Document.ExportPage(uiSaveFileDialog.FileName ,frm.SelPageNumber, 4))
                     MessageBox.Show("Export completed");
                 else
                     MessageBox.Show("Export failed");

             }
        }

        private void uiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MergeSplitDeletePDF frm = new MergeSplitDeletePDF();

          
            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
              return;

            if (frm.iType==0) // merge pdf 
            {
            uiSaveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
             if (uiSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {

                 if (_pdf.MergePDF(frm.strMergeSource1,frm.strMergeSource2, uiSaveFileDialog.FileName))
                     MessageBox.Show("Merge completed");
                 else
                     MessageBox.Show("Merge failed");

             }
            }
            else if (frm.iType == 1) // split pdf 
            {
                uiSaveFileDialog.Filter = "PDF Files 1  (*.pdf)|*.pdf";
                uiSaveFileDialog2.Filter = "PDF Files 2 (*.pdf)|*.pdf";
                if (uiSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (uiSaveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)


                        if (frm.iSplitStartPage == 1) //at least split from page 2 
                            frm.iSplitStartPage = 2;

                        if (_pdf.SplitPDF(frm.strSplitSource, frm.iSplitStartPage - 1, uiSaveFileDialog.FileName, uiSaveFileDialog2.FileName))
                        MessageBox.Show("Split completed");
                    else
                        MessageBox.Show("Split failed");
                }
            }
            else if (frm.iType == 2) // delete page of pdf
            {
              
               

                    if (_pdf.DeletePDFPage(frm.strDeletePageSource, frm.iDeletePageNo-1 ))
                        MessageBox.Show("Delete Page completed");
                    else
                        MessageBox.Show("Delete Page failed");

              
            }

        }

    }
}
