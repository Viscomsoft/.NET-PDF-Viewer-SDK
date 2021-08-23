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
    public partial class GotoForm : Form
    {
        public GotoForm()
        {
            InitializeComponent();
        }

        public int PageNumber { get; set; }

        private void uiOk_Click(object sender, EventArgs e)
        {
            this.PageNumber = int.Parse(uiPageNumber.Text);
            this.Close();
        }
    }
}
