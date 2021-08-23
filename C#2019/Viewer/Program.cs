using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PDFViewerDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                string s = "";
                while (e != null)
                {
                    s += e.StackTrace;
                    s += "\r\n\r\n";
                    e = e.InnerException;
                }

                StreamWriter fs = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\exception.txt");
                fs.WriteLine(s);
                fs.Flush();
                fs.Close();

                MessageBox.Show("An exception has occurred and a log file is generated");
            }
        }
    }
}
