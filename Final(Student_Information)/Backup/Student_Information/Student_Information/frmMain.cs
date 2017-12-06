using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class frmMain : Form
    {
        int count = 0, buffer = 0;
        public frmMain()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(buffer==3)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(Opacity == 0)
            {
                LogIn li = new LogIn();
                li.Show();
                Hide();
                timer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
