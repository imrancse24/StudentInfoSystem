using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Information
{
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn obcon = new conn();
            SqlConnection con = new SqlConnection(obcon.strcon);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_StudentInfo where Student_ID = " + int.Parse(textBoxSearch.Text), con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=SOJIB;Initial Catalog=StudentInfo_Management;User ID=sa;Password=25255656");
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbl_StudentInfo where Student_Name like '" + textBoxSearch.Text + "%'", con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
  
        }
    }
}
