using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrome
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string temp = System.IO.Path.GetTempPath();
            string url = "https://download.mozilla.org/?product=firefox-stub&os=win&lang=en-GB";
            string directory = temp;
            string file = "Firefox Installer.exe";
            string filepath = Path.Combine(directory, file);
            using (WebClient webclient = new WebClient())
            {
                try
                {
                    webclient.DownloadFile(url, filepath);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("shits fucked :(");
                }
                Process.Start(filepath);
                this.Close();
            }

            
        }
    }
}

