using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Information
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            //Thread t = new Thread(new ThreadStart(splash));
            //t.Start();

        }

        //void splash()
        //{
        //    //SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
        //    //frm.AppName = "Student_Info";
        //    //Apllication.run = frm;

        //}

        private void btnLogn_Click(object sender, EventArgs e)
        {
                //string username = "sojib";
                //string Pasword = "8990";
                //if (textBoxName.Text == username && textBoxPass.Text == Pasword)
                //{
                //    this.Hide();
                //    HomePage si = new HomePage();
                //    si.Show();
                //}
                //else if(textBoxName.Text != username)
                //{
                //    MessageBox.Show("Please Enter Valid Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                //    MessageBox.Show("Please Enter Valid Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

            conn obcon = new conn();
            SqlConnection con = new SqlConnection(obcon.strcon);

            con.Open();
            SqlCommand cmd = new SqlCommand("select FullName,Password from tbl_AdminInfo where FullName = '" + textBoxName.Text + "' and Password = '" + textBoxPass.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                this.Hide();
                HomePage si = new HomePage();
                si.Show();
            }
            else if (count > 0)
            {
                MessageBox.Show("Duplicate Username And Password");
            }
            else
            {
                MessageBox.Show("Please Enter Valid UserName And Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxName.Clear();
            textBoxPass.Clear();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPage rp = new RegistrationPage();
            rp.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
