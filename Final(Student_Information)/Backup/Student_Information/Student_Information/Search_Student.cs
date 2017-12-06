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
using Microsoft.Reporting.WinForms;

namespace Student_Information
{
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDatabyNameRollDeptSem();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataRoll();
        }
        void LoadDataRoll()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "get_AllStudentInfoByRoll";
            ds.CommandType = CommandType.StoredProcedure;

            ds.Parameters.Add("@Student_Roll", SqlDbType.VarChar);

            ds.Parameters[0].Value = textBoxSearch.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgbSearch.AutoGenerateColumns = false;
            dgbSearch.DataSource = dt;
        }

        void LoadDatabyNameRollDeptSem()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "get_AllStudentInfoByRollandName";
            ds.CommandType = CommandType.StoredProcedure;

            ds.Parameters.Add("@SearchKey", SqlDbType.VarChar);

            ds.Parameters[0].Value = textBoxSearch.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgbSearch.AutoGenerateColumns = false;
            dgbSearch.DataSource = dt;
        }

        private void Allloaddata()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "combine_SemesterAndStudentInfo";
            ds.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgbSearch.AutoGenerateColumns = false;
            dgbSearch.DataSource = dt;
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            Allloaddata();
            
        }

        public int id;
        private void dgbSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentInformation si = new StudentInformation( id);

            si.id = Convert.ToInt16(dgbSearch.CurrentRow.Cells[0].Value);


            //id = dgbSearch.CurrentRow.Cells[0].Value.ToString();
            //si.txtRoll.Text = dgbSearch.CurrentRow.Cells[1].Value.ToString();
            //si.txtFullName.Text = dgbSearch.CurrentRow.Cells[2].Value.ToString();
            //si.txtAddress.Text = dgbSearch.CurrentRow.Cells[3].Value.ToString();
            //si.txtRoll.Text = dgbSearch.CurrentRow.Cells[4].Value.ToString();
            //si.txtRoll.Text = dgbSearch.CurrentRow.Cells[5].Value.ToString();
            //si.txtRoll.Text = dgbSearch.CurrentRow.Cells[6].Value.ToString();

            si.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            ReportViewPage rp = new ReportViewPage();
            

            conn ob = new conn();
            SqlConnection obCon = new SqlConnection(ob.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = obCon;
            SqlCommand cmd = da.SelectCommand;
            cmd.CommandText = "combine_SemesterAndStudentInfo";
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                rp.reportViewer1.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                rp.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataset = new ReportDataSource("DSStudentInfo", dt);
                rp.reportViewer1.LocalReport.DataSources.Add(reportDataset);

                rp.reportViewer1.LocalReport.Refresh();
                rp.reportViewer1.RefreshReport();
            }

            rp.ShowDialog();
            }

        private void btnStudentprofile_Click(object sender, EventArgs e)
        {
             if (textBoxSearch.Text != null)
            {
                frm_StudentProfile sp = new frm_StudentProfile();

                conn ob = new conn();
                SqlConnection obCon = new SqlConnection(ob.strcon);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = obCon;
                SqlCommand cmd = da.SelectCommand;
                cmd.CommandText = "Get_StudentProfileByRoll";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Student_Roll", SqlDbType.VarChar);

                cmd.Parameters[0].Value = textBoxSearch.Text;

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    sp.reportViewer1.LocalReport.ReportPath = "rpt_StudentProfile.rdlc";
                    sp.reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource reportDataset = new ReportDataSource("DS_StudentProfile", dt);
                    sp.reportViewer1.LocalReport.DataSources.Add(reportDataset);

                    sp.reportViewer1.LocalReport.Refresh();
                    sp.reportViewer1.RefreshReport();
                }
                sp.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please Select Someone");
            }

            
        }
    }
}
