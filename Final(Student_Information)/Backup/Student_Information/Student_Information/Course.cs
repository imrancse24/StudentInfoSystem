using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        string ID;
        public int id;



        public void BindDataDept()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from tbl_Dept_Info";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDept.DataSource = dt;
            cmbDept.DisplayMember = "Department_Name";
            cmbDept.ValueMember = "Department_Id";
        }

        private void Course_Load(object sender, EventArgs e)
        {
            BindDataDept();
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
            ds.CommandText = "select * from tbl_CourseInfo";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dt;
        }


        private void savedata()
        {
            try
            {
                if (txtCourseCode.Text == "")
                {
                    MessageBox.Show("Course Codeis empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);

                SqlCommand cmd = new SqlCommand("Insert_Course", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Credit_Hour", SqlDbType.VarChar);


                cmd.Parameters[0].Value = cmbDept.Text;
                cmd.Parameters[1].Value = txtCourseCode.Text;

                cmd.Parameters[2].Value = txtCourseName.Text;
                cmd.Parameters[3].Value = txtCreditHour.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                txtCourseCode.Clear();
                txtCourseName.Clear();

                cmbDept.SelectedIndex = -1;


                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            
        }

        private void UpdateData()
        {
            try
            {
                if (txtCourseCode.Text == "")
                {
                    MessageBox.Show("Update Name is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);
                SqlCommand cmd = new SqlCommand("Update_tbl_CourseInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Course_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Credit_Hour", SqlDbType.VarChar);
             

                


                cmd.Parameters[0].Value = ID;
                cmd.Parameters[1].Value = cmbDept.Text;
                cmd.Parameters[2].Value = txtCourseCode.Text;
                cmd.Parameters[3].Value = txtCourseName.Text;
                cmd.Parameters[4].Value = txtCreditHour.Text;
               

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                LoadData();

                MessageBox.Show("Update is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCourseCode.Clear();
            txtCourseName.Clear();
        
            cmbDept.SelectedIndex = -1;
           
            txtCourseCode.Focus();
            
            txtCourseName.Focus();

            cmbDept.Focus();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbDept.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCourseCode.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCourseName.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCreditHour.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
