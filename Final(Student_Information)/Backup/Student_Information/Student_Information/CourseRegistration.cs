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
    public partial class CourseRegistration : Form
    {
        public CourseRegistration()
        {
            InitializeComponent();
        }
        string ID;
        private void CourseRegistration_Load(object sender, EventArgs e)
        {
            
            LoadData();
            

        }

        void BindCourseIdforCSE()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from tbl_CourseInfo where Dept='"+ cmbDept.Text+"'";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCourseCode.DataSource = dt;
            cmbCourseCode.DisplayMember = "Course_Code";
            cmbCourseCode.ValueMember = "Course_Code";
        }

        public void BindDataDept()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = new SqlCommand();
            //da.SelectCommand.Connection = ob;
            //SqlCommand ds = da.SelectCommand;
            //ds.CommandText = "select* from Student_Information where Student_Roll = '"+ txtStdRoll.Text+"'";
            //ds.CommandType = CommandType.Text;
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //cmbDept.DataSource = dt;
            //cmbDept.DisplayMember = "Department_Name";
            //cmbDept.ValueMember = "Department_Id";


            using (SqlCommand cmd = ob.CreateCommand())
            {
                ob.Open();
                cmd.CommandText = "BindDeptNameByDeptId";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);

                cmd.Parameters[0].Value = txtStdRoll.Text;

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    cmbDept.DisplayMember = "Department_Name";
                    cmbDept.ValueMember = "Department_Id";
                    cmbDept.DataSource = dt;

                }
            }


        }






        void BindCourseName()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select Course_Name from tbl_CourseInfo where Course_Code='" + cmbCourseCode.SelectedValue + "'";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Course_Name";
            comboBox2.ValueMember = "Course_Name";
        }


        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCourseIdforCSE();
            //BindCourseNameforCSE();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCourseName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
            
        }

        void BindName()
        {

        }

        private void savedata()
        {
            try
            {
                if (txtStdRoll.Text == "")
                {
                    MessageBox.Show("Student Roll is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);

                SqlCommand cmd = new SqlCommand("Insert_tbl_CourseRegInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Session", SqlDbType.VarChar);


                cmd.Parameters[0].Value = txtStdRoll.Text;
                cmd.Parameters[1].Value = cmbDept.Text;
                cmd.Parameters[2].Value = cmbSemester.SelectedItem.ToString();
                cmd.Parameters[3].Value = cmbCourseCode.SelectedValue.ToString();

                cmd.Parameters[4].Value = comboBox2.SelectedValue.ToString();
                cmd.Parameters[5].Value = txtSession.Text;

                SqlCommand cmd1 = new SqlCommand("Insert_tbl_RegisteredCourse", con);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Status", SqlDbType.VarChar);


                cmd1.Parameters[0].Value = txtStdRoll.Text;
                cmd1.Parameters[1].Value = cmbDept.Text;
                cmd1.Parameters[2].Value = cmbCourseCode.SelectedValue.ToString();
                cmd1.Parameters[3].Value = comboBox2.SelectedValue.ToString();
                cmd1.Parameters[4].Value = "Registered";

                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();
                LoadData();
                txtStdRoll.Clear();
                txtSession.Clear();
                cmbCourseCode.SelectedIndex = -1; 
                cmbDept.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                cmbSemester.SelectedIndex = -1;

                cmbDept.SelectedIndex = -1;


                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }




        }

        void LoadData()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select * from tbl_CourseRegInfo";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStdRoll.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbDept.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSemester.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbCourseCode.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSession.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        public void BindDataStudentName()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from Student_Information where Student_Roll='"+txtStdRoll.Text+"'";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbFullName.DataSource = dt;
            cmbFullName.DisplayMember = "Student_Name";
            cmbFullName.ValueMember = "Student_Roll";
        }

        private void txtStdRoll_TextChanged(object sender, EventArgs e)
        {
            BindDataDept();
            BindDataStudentName();
        }

       private void UpdateCourseReg()
       {
            try
            {
                if (txtSession.Text == "")
                {
                    MessageBox.Show("Session is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);
                SqlCommand cmd = new SqlCommand("Update_tbl_CourseRegInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Sl_No", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Session", SqlDbType.VarChar);



                cmd.Parameters[0].Value = ID;
                cmd.Parameters[1].Value = txtStdRoll.Text;
                cmd.Parameters[2].Value = cmbDept.Text;
                cmd.Parameters[3].Value = cmbSemester.SelectedItem.ToString();
                cmd.Parameters[4].Value = cmbCourseCode.SelectedValue.ToString();

                cmd.Parameters[5].Value = comboBox2.SelectedValue.ToString();
                cmd.Parameters[6].Value = txtSession.Text;


                SqlCommand cmd1 = new SqlCommand("Update_tbl_RegisteredCourse", con);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@Sl_No", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Course_Code", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Course_Name", SqlDbType.VarChar);
                cmd1.Parameters.Add("@Status", SqlDbType.VarChar);


                cmd1.Parameters[0].Value = ID;
                cmd1.Parameters[1].Value = txtStdRoll.Text;
                cmd1.Parameters[2].Value = cmbDept.Text;
                cmd1.Parameters[3].Value = cmbCourseCode.SelectedValue.ToString();
                cmd1.Parameters[4].Value = comboBox2.SelectedValue.ToString();
                cmd1.Parameters[5].Value = "Registered";

                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();
                LoadData();
                txtStdRoll.Clear();
                txtSession.Clear();
                cmbCourseCode.SelectedIndex = -1;
                cmbDept.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                cmbSemester.SelectedIndex = -1;

                cmbDept.SelectedIndex = -1;

            
               

                

                MessageBox.Show("Update is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
       }

       private void btnUpdate_Click(object sender, EventArgs e)
       {
           UpdateCourseReg();
       }

       private void btnNew_Click(object sender, EventArgs e)
       {
           txtStdRoll.Clear();
          
           txtSession.Clear();
           cmbFullName.SelectedIndex = -1;
           cmbCourseCode.SelectedIndex = -1;
           cmbDept.SelectedIndex = -1;
           comboBox2.SelectedIndex = -1;
           cmbSemester.SelectedIndex = -1;

           cmbDept.SelectedIndex = -1;
       }

       private void cmbFullName_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

     
    }
}
