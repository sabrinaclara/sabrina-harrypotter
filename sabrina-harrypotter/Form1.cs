using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sabrina_harrypotter
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                Form2 outroform = new Form2();
                outroform.ShowDialog();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;        
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.progressBar1.Maximum = 100;
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
