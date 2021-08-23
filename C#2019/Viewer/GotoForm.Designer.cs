namespace PDFViewerDemo
{
    partial class GotoForm
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
            this.uiOk = new System.Windows.Forms.Button();
            this.uiPageNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiOk
            // 
            this.uiOk.Location = new System.Drawing.Point(185, 53);
            this.uiOk.Name = "uiOk";
            this.uiOk.Size = new System.Drawing.Size(75, 23);
            this.uiOk.TabIndex = 5;
            this.uiOk.Text = "Ok";
            this.uiOk.UseVisualStyleBackColor = true;
            this.uiOk.Click += new System.EventHandler(this.uiOk_Click);
            // 
            // uiPageNumber
            // 
            this.uiPageNumber.Location = new System.Drawing.Point(61, 12);
            this.uiPageNumber.Name = "uiPageNumber";
            this.uiPageNumber.Size = new System.Drawing.Size(199, 20);
            this.uiPageNumber.TabIndex = 4;
            this.uiPageNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goto";
            // 
            // GotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.uiOk);
            this.Controls.Add(this.uiPageNumber);
            this.Controls.Add(this.label1);
            this.Name = "GotoForm";
            this.Text = "Goto Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiOk;
        private System.Windows.Forms.TextBox uiPageNumber;
        private System.Windows.Forms.Label label1;
    }
}