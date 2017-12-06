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
using System.IO;

namespace Student_Information
{
    public partial class StudentInformation : Form
    {
        byte[] picbyte1 = new byte[] { };
        string gender;

        string ID;

        public int id;
        public StudentInformation(int Std_Id)
        {
            id = Std_Id;
            InitializeComponent();
        }

        public StudentInformation()
        {
            // TODO: Complete member initialization
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
        }
        private void GetDataAcademicInfo()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "Get_AlldataAcademicInfo";
            ds.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            grdAcademicInfo.AutoGenerateColumns = false;
            grdAcademicInfo.DataSource = dt;
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            LoadData();
            BindDataSemester();
            BindDataDept();
            GetDataAcademicInfo();


            GetDataById();


        }
        public void BindDataSemester()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from tbl_SemeseterInfo";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbSemester.DataSource = dt;
            cmbSemester.DisplayMember = "Semester_Name";
            cmbSemester.ValueMember = "Semester_Id";
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Student ss = new Search_Student();
            ss.Show();
            this.Hide();
        }
        void LoadData()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "GetDataFor_dgbBasicInfo";
            ds.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            grdBasicInfo.AutoGenerateColumns = false;
            grdBasicInfo.DataSource = dt;
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

                SqlCommand cmd = new SqlCommand("Insert_Student_Information", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_DateofBirth", SqlDbType.Date);
                cmd.Parameters.Add("@Student_Address", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Department_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Religion", SqlDbType.VarChar);

                //save image
                FileInfo file = new FileInfo(photo_name.Trim());
                byte[] content = new byte[file.Length];
                FileStream imagefile = file.OpenRead();
                imagefile.Read(content, 0, content.Length);
                //
                cmd.Parameters.Add("@Student_Image", SqlDbType.Image);

                cmd.Parameters[0].Value = txtRoll.Text;
                cmd.Parameters[1].Value = txtFullName.Text;
                cmd.Parameters[2].Value = dateofBirth.Value.ToString();
                cmd.Parameters[3].Value = txtAddress.Text;
                if (rdbMale.Checked)
                    cmd.Parameters[4].Value = gender;
                else
                    cmd.Parameters[4].Value = gender;

                cmd.Parameters[5].Value = cmbSemester.SelectedValue;
                cmd.Parameters[6].Value = cmbDept.SelectedValue;
                cmd.Parameters[7].Value = cmbReligion.Text;
                cmd.Parameters[8].Value = content;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                txtAddress.Clear();
                txtFullName.Clear();
                txtRoll.Clear();
                txtRoll.Focus();
                cmbSemester.SelectedIndex = -1;
                cmbDept.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;

                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void UpdateData()
        {
            try
            {
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Update Name is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);
                SqlCommand cmd = new SqlCommand("Update_Student_Information", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_DateofBirth", SqlDbType.Date);
                cmd.Parameters.Add("@Student_Address", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Department_Id", SqlDbType.VarChar);
                cmd.Parameters.Add("@Student_Religion", SqlDbType.VarChar);

                //Update image
                FileInfo file = new FileInfo(photo_name.Trim());
                byte[] content = new byte[file.Length];
                FileStream imagefile = file.OpenRead();
                imagefile.Read(content, 0, content.Length);
                //
                cmd.Parameters.Add("@Student_Image", SqlDbType.VarChar);


                cmd.Parameters[0].Value = id;
                cmd.Parameters[1].Value = txtRoll.Text;
                cmd.Parameters[2].Value = txtFullName.Text;
                cmd.Parameters[3].Value = dateofBirth.Value.ToString();
                cmd.Parameters[4].Value = txtAddress.Text;
                if (rdbMale.Checked)
                    cmd.Parameters[5].Value = gender;
                else
                    cmd.Parameters[5].Value = gender;

                cmd.Parameters[6].Value = cmbSemester.SelectedValue;
                cmd.Parameters[6].Value = cmbDept.SelectedValue;
                cmd.Parameters[7].Value = cmbReligion.Text;
                cmd.Parameters[9].Value = content;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ID = grdBasicInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoll.Text = grdBasicInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFullName.Text = grdBasicInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = grdBasicInfo.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (grdBasicInfo.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }

            cmbSemester.Text = grdBasicInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbDept.Text = grdBasicInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbReligion.Text = grdBasicInfo.Rows[e.RowIndex].Cells[8].Value.ToString();



            byte[] storedimg = (byte[])(grdBasicInfo.Rows[e.RowIndex].Cells[9].Value);
            picbyte1 = storedimg;
            Image newimg;
            using (MemoryStream stream = new MemoryStream(storedimg))
            {
                newimg = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = newimg;
            }
        }
        string photo_name;
        private void Upload_Photo()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Multiselect = false;
                dlg.RestoreDirectory = true;
                dlg.Filter = "User Photo Files|*.*";

                DialogResult rs = dlg.ShowDialog();

                if (rs == DialogResult.OK)
                {
                    photo_name = dlg.FileName.ToString();
                    Bitmap img = new Bitmap(photo_name);
                    pictureBox1.Image = (Image)img;
                }
            }
            catch
            {
                MessageBox.Show("This is not a valid file as User photo!", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtRoll.Clear();
            txtAddress.Clear();
            cmbDept.SelectedIndex = -1;
            cmbSemester.SelectedIndex = -1;
            cmbReligion.SelectedIndex = -1;
            txtRoll.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Upload_Photo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            try
            {
                if (txtRoll.Text == "")
                {
                    MessageBox.Show("Student Roll is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);

                SqlCommand cmd = new SqlCommand("Insert_AcademicInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter outPutVal = new SqlParameter("@New_Student_Id", SqlDbType.Int);
                //outPutVal.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(outPutVal);

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Exam_Type", SqlDbType.VarChar);
                cmd.Parameters.Add("@Session", SqlDbType.VarChar);
                cmd.Parameters.Add("@Group_Major", SqlDbType.VarChar);
                cmd.Parameters.Add("@Grade", SqlDbType.VarChar);
                cmd.Parameters.Add("@CGPA", SqlDbType.VarChar);
                cmd.Parameters.Add("@Board", SqlDbType.VarChar);
                cmd.Parameters.Add("@Institute_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@Edit_Date", SqlDbType.DateTime);
                cmd.Parameters.Add("@Edit_User", SqlDbType.VarChar);

                cmd.Parameters[0].Value = txtRoll.Text;
                cmd.Parameters[1].Value = cmbExamType.Text;
                cmd.Parameters[2].Value = txtSession.Text;
                cmd.Parameters[3].Value = cmbGroup.Text;
                cmd.Parameters[4].Value = cmbGrade.Text;
                cmd.Parameters[5].Value = txtCGPA.Text;
                cmd.Parameters[6].Value = cmbBoard.Text;
                cmd.Parameters[7].Value = txtInstituteName.Text;
                cmd.Parameters[8].Value = DateTime.Now;
                cmd.Parameters[9].Value = "";

                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                GetDataAcademicInfo();
                MessageBox.Show("Add is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void grdAcademicInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = grdAcademicInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbExamType.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGroup.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCGPA.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSession.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbBoard.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtInstituteName.Text = grdAcademicInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void GetDataById()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "GetDataById";
            ds.CommandType = CommandType.StoredProcedure;

            ds.Parameters.Add("@Student_Roll", SqlDbType.VarChar);

            ds.Parameters[0].Value = id;

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                txtRoll.Text = dt.Rows[0]["Student_Roll"].ToString();
                txtFullName.Text = dt.Rows[0]["Student_Name"].ToString();
                dateofBirth.Value = Convert.ToDateTime(dt.Rows[0]["Student_DateofBirth"].ToString());
                txtAddress.Text = dt.Rows[0]["Student_Address"].ToString();

                if (dt.Rows[0]["Student_Gender"].ToString() == "Male")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }

                cmbSemester.Text = dt.Rows[0]["Semester_Name"].ToString();
                cmbDept.Text = dt.Rows[0]["Department_Name"].ToString();
                cmbReligion.Text = dt.Rows[0]["Student_Religion"].ToString();

                cmbExamType.Text = dt.Rows[0]["Exam_Type"].ToString();
                cmbGroup.Text = dt.Rows[0]["Group_Major"].ToString();
                cmbGrade.Text = dt.Rows[0]["Grade"].ToString();
                txtCGPA.Text = dt.Rows[0]["CGPA"].ToString();
                txtSession.Text = dt.Rows[0]["Session"].ToString();
                cmbBoard.Text = dt.Rows[0]["Board"].ToString();
                txtInstituteName.Text = dt.Rows[0]["Institute_Name"].ToString();
            }
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
