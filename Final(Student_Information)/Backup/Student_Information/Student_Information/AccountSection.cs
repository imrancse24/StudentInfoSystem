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
    public partial class AccountSection : Form
    {
        public AccountSection()
        {
            InitializeComponent();
        }

        string ID;

        private void DataBindDept()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

          


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

        public void BindDataStudentName()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;
            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select* from Student_Information where Student_Roll='" + txtStdRoll.Text + "'";
            ds.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbFullName.DataSource = dt;
            cmbFullName.DisplayMember = "Student_Name";
            cmbFullName.ValueMember = "Student_Roll";
        }

        private void txtStdRoll_TextChanged(object sender, EventArgs e)
        {
            DataBindDept();
            BindDataStudentName();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
            ds.CommandText = "get_IndividualRegisteredCourse";
            ds.CommandType = CommandType.StoredProcedure;

            ds.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
            ds.Parameters.Add("@Dept", SqlDbType.VarChar);
            ds.Parameters.Add("@Semester_Name", SqlDbType.VarChar);
            ds.Parameters.Add("@Session", SqlDbType.VarChar);

            ds.Parameters[0].Value = txtStdRoll.Text;
            ds.Parameters[1].Value = cmbDept.Text;
            ds.Parameters[2].Value = cmbSemester.Text;
            ds.Parameters[3].Value = txtSession.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgb_Accounts.AutoGenerateColumns = false;
            dgb_Accounts.DataSource = dt;

            double Total = 0;

            for (int i = 0; i < dgb_Accounts.Rows.Count; ++i)
            {
                Total += Convert.ToDouble(dgb_Accounts.Rows[i].Cells["Credit_Hour"].Value);
            }

            lbl_TotalCredit.Text = Total.ToString();

        }

        private void dgb_Accounts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Total = 0;
                Total += Convert.ToDouble(lbl_TotalCredit.Text) * Convert.ToDouble(textBox1.Text);

                lbl_TotalFee.Text = Total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            
        }

        void Calculation()
        {
            double Total1 = 0;
            Total1 += Convert.ToDouble(lbl_Due.Text) - Convert.ToDouble(txtPaid.Text);
            
            lbl_Due.Text = Total1.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCalculate.Text == "Calculate")
                {
                    double Total = 0;
                    Total += Convert.ToDouble(lbl_TotalFee.Text) - Convert.ToDouble(txtPaid.Text);
                    lbl_Due.Text = Total.ToString();
                }

                else if (btnCalculate.Text == "Calculation")
                {
                    Calculation();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


                savedata();
                LoadAccountSection();

            
            //LoadAccountSection();

            
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

                SqlCommand cmd = new SqlCommand("Insert_tbl_CreditFeesPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester", SqlDbType.VarChar);
               
                cmd.Parameters.Add("@Session", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_Credit", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_Fee", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_Paid", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_due", SqlDbType.VarChar);


                cmd.Parameters[0].Value = txtStdRoll.Text;
                cmd.Parameters[1].Value = cmbDept.Text;
                cmd.Parameters[2].Value = cmbSemester.SelectedItem.ToString();
             
                cmd.Parameters[3].Value = txtSession.Text;
                cmd.Parameters[4].Value = lbl_TotalCredit.Text;
                cmd.Parameters[5].Value = lbl_TotalFee.Text;
                cmd.Parameters[6].Value = txtPaid.Text;
                cmd.Parameters[7].Value = lbl_Due.Text;


             
                con.Open();
                cmd.ExecuteNonQuery();
               
                con.Close();
                LoadData();
                txtStdRoll.Clear();
                txtSession.Clear();
              
                cmbDept.SelectedIndex = -1;
                
                cmbSemester.SelectedIndex = -1;

                cmbDept.SelectedIndex = -1;


                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }




        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtStdRoll.Clear();

            txtSession.Clear();
            cmbFullName.SelectedIndex = -1;
           
            cmbDept.SelectedIndex = -1;
            
            cmbSemester.SelectedIndex = -1;

            cmbDept.SelectedIndex = -1;
            lbl_TotalCredit.Text = "";
            lbl_TotalFee.Text = "";
            lbl_Due.Text = "";
            //textBox1.Clear();
            txtPaid.Clear();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStdRoll.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbDept.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbSemester.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtSession.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            lbl_TotalCredit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            lbl_TotalFee.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txtPaid.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            lbl_Due.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();


            btnCalculate.Text = "Calculation";
          
        }

        private void UpdateCreditFeesPayment()
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

                SqlCommand cmd = new SqlCommand("Update_tbl_CreditFeesPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Dept", SqlDbType.VarChar);
                cmd.Parameters.Add("@Semester", SqlDbType.VarChar);

                cmd.Parameters.Add("@Session", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Total_Credit", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_Fee", SqlDbType.VarChar);
                //cmd.Parameters.Add("@Total_Paid", SqlDbType.VarChar);
                cmd.Parameters.Add("@Total_due", SqlDbType.VarChar);


                cmd.Parameters[0].Value = txtStdRoll.Text;
             
                cmd.Parameters[1].Value = cmbSemester.SelectedItem.ToString();

                cmd.Parameters[2].Value = txtSession.Text;
              
                cmd.Parameters[3].Value = lbl_TotalFee.Text;
              
                cmd.Parameters[4].Value = lbl_Due.Text;




                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                LoadAccountSection();
                txtStdRoll.Clear();
                txtSession.Clear();

                cmbDept.SelectedIndex = -1;

                cmbSemester.SelectedIndex = -1;

                cmbDept.SelectedIndex = -1;
              






                MessageBox.Show("Update is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }



         void LoadAccountSection()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select * from tbl_CreditFeesPayment";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
        private void AccountSection_Load(object sender, EventArgs e)
        {
            LoadAccountSection();
            //UpdateCourseReg();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCreditFeesPayment();
        }
    }
}
