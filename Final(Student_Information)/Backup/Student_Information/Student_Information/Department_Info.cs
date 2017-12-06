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
    public partial class Department_Info : Form
    {
        string id;
        public Department_Info()
        {
            InitializeComponent();
        }

        private void Department_Info_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select * from tbl_Dept_Info";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDept_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void savedata()
        {
            try
            {
                if (txtDept_Name.Text == "")
                {
                    MessageBox.Show("Student Name is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);

                SqlCommand cmd = new SqlCommand("Insert_Department", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Department_Name", SqlDbType.VarChar);


                cmd.Parameters[0].Value = txtDept_Name.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
