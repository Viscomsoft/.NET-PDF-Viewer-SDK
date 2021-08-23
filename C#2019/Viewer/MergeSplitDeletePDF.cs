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
    public partial class MergeSplitDeletePDF : Form
    {
        public int iType { get; set; }
        public string strMergeSource1 { get; set; }
        public string strMergeSource2 { get; set; }

        public string strSplitSource { get; set; }
        public int iSplitStartPage { get; set; }

        public string strDeletePageSource { get; set; }
        public int iDeletePageNo { get; set; }


        public MergeSplitDeletePDF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              openFileDialog1.Filter = "PDF File|*.PDF||";
              if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  txtmergesource1.Text = openFileDialog1.FileName;
              }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtmergesource2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              txtsplitsource.Text = openFileDialog1.FileName;
            }
         
        }

        private void buttonmerge_Click(object sender, EventArgs e)
        {
            if (txtmergesource1.Text == "")
            {
                MessageBox.Show("Please select PDF 1 file");
                return;
            }

            if (txtmergesource2.Text == "")
            {
                MessageBox.Show("Please select PDF 2 file");
                return;
            }

            strMergeSource1 = txtmergesource1.Text;
            strMergeSource2 = txtmergesource2.Text;
            iType = 0;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtsplitsource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strSplitSource = this.txtsplitsource.Text;
            iSplitStartPage = Int32.Parse(this.txtsplitfrompage.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            iType = 1;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtdeletepagesource.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtdeletepagesource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strDeletePageSource = txtdeletepagesource.Text;
            iDeletePageNo = Int32.Parse(this.txtdeletepage.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            iType = 2;
            this.Close();
        }
    }
}
