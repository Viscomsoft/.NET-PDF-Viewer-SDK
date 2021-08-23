using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFViewerDemo
{
    public partial class ExportForm : Form
    {
        public int SelPageNumber { get; set; }
        public ExportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelPageNumber = int.Parse(txtPage.Text);
            this.Close();
        }
    }
}
