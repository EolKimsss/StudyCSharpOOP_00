using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            if (button1.Text == "Start")
                        { button1.Text = "Changed"; }
                        else 
                        {button1.Text = "Start"; }*/
            button1.Text = "Changed";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;

            Thread th = new Thread(() =>
            {
                for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
                {
                    // progressBar1.Value = i;
                    progressBar1.BeginInvoke(
                        new Action(()=>{ progressBar1.Value = 1; 
                    }));


            Thread.Sleep(10);
                }
            });
            th.IsBackground = true;
            th.Start();

            //button1.Text = "Start";
        }
    }
}
