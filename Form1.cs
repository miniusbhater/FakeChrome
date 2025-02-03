using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Chrome
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {


            Random rand = new Random();
            int progress = 1;
            int taken = 0;
            int max = 20000;
            label4.Text = $"{progress}%";
            while (progress < 100)
            {
                int delay = rand.Next(200, 1000); 
                if (taken + delay > max)
                    delay = max - taken; 
                await Task.Delay(delay);
                taken += delay;
                progress += rand.Next(1, 10); 
                if (progress > 100) progress = 100; 
                label4.Text = $"{progress}%";
            }
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


       
