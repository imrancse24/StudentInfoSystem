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
    public partial class StudentInformation : Form
    {
        string gender;
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            LoadData();
            BindDataSemester();
            BindDataDept();
        }
        public void BindDataSemester()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();

            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;

            ds.CommandText = "select* from tbl_SemesterInfo";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxSemester.DataSource = dt;
            comboBoxSemester.DisplayMember = "Semester_Name";
            comboBoxSemester.ValueMember = "Semester_Id";
        }

        public void BindDataDept()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from tbl_DepartmentInfo";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxDept.DataSource = dt;
            comboBoxDept.DisplayMember = "Dept_Name";
            comboBoxDept.ValueMember = "Dept_Id";
        }

        private void savedata()
        {
            try
            {
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Student Name is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);

                SqlCommand cmd = new SqlCommand("Insert_tbl_StudentInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_DateofBirth", SqlDbType.DateTime);
                cmd.Parameters.Add("@Student_Gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Semester", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Department", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Religion", SqlDbType.VarChar);

                cmd.Parameters[0].Value = txtRoll.Text;
                cmd.Parameters[1].Value = txtFullName.Text;
                cmd.Parameters[2].Value = dateofBirth.Value.ToString();
                if (radiobtnMale.Checked)
                    cmd.Parameters[3].Value = gender;
                else
                    cmd.Parameters[3].Value = gender;
                cmd.Parameters[4].Value = comboBoxSemester.Text;
                cmd.Parameters[5].Value = comboBoxDept.Text;
                cmd.Parameters[6].Value = comboBoxReligion.Text;

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

        private void radiobtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radiobtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Search_Student ss = new Search_Student();
            ss.Show();
        }
        void LoadData()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select * from tbl_StudentInfo";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Semester_Info ss = new Semester_Info();
            ss.Show();
        }
    }
}
