using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Viscomsoft.PDFViewer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private PDFView _pdfViewer;

        public Form1()
        {
            InitializeComponent();

            _pdfViewer = new PDFView();
             
            _pdfViewer.Canvas.Parent = this;
            _pdfViewer.Canvas.Location = new Point(0, 24);
            _pdfViewer.PageChanged += new EventHandler(PdfPageChanged);

        }
        void PdfPageChanged(object sender, EventArgs e)
        {
            PDFDocument doc = _pdfViewer.Document;
         //   if (doc != null)
           //     this.Text = doc.FileName + " [" + _pdf.CurrentPage + "/" + doc.PageCount + "]";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resizeCanvas();
        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            if (_pdfViewer.Document != null)
                _pdfViewer.Document.close();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeCanvas();
        }
        private void resizeCanvas()
        {
            if (_pdfViewer!= null)
             _pdfViewer.Canvas.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 24);
        }
     

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files (*.PDF)|*.PDF";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PDFDocument doc = new PDFDocument();
                if (doc.open(openFileDialog1.FileName))
                {
                    bool opened = true;

                    if (opened)
                    {
                         
                        _pdfViewer.Document = doc;
                        _pdfViewer.gotoPage(1);
                    }
                    else
                    {
                        doc.close();
                    }
                }
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            _pdfViewer.nextPage();
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            _pdfViewer.previousPage();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
