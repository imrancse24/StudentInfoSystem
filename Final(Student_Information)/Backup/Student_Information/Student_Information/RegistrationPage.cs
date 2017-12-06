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
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        byte[] picbyte1 = new byte[] { };

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            loadData();
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void savedata()
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn obcon = new conn();
                SqlConnection con = new SqlConnection(obcon.strcon);



                SqlCommand cmd = new SqlCommand("Insert_tbl_AdminInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FullName", SqlDbType.VarChar);
                cmd.Parameters.Add("@Number", SqlDbType.VarChar);
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                //cmd.Parameters.Add("@confirm_Password", SqlDbType.VarChar);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@Address", SqlDbType.VarChar);

                //save image
                FileInfo file = new FileInfo(photo_name.Trim());
                byte[] content = new byte[file.Length];
                FileStream imagefile = file.OpenRead();
                imagefile.Read(content, 0, content.Length);
                //
                cmd.Parameters.Add("@Photo", SqlDbType.Image);

                cmd.Parameters[0].Value = txtName.Text;
                cmd.Parameters[1].Value = txtNumber.Text;
                if (rdbMale.Checked)
                    cmd.Parameters[2].Value = gender;
                else if (rdbFemale.Checked)
                {
                    cmd.Parameters[2].Value = gender;
                }
                else
                {
                    cmd.Parameters[2].Value = gender;
                }

                cmd.Parameters[3].Value = txtPass.Text;
                //cmd.Parameters[4].Value = txtCnrfmPass.Text;
                cmd.Parameters[4].Value = txtEmail.Text;
                cmd.Parameters[5].Value = textAddress.Text;
                cmd.Parameters[6].Value = content;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();

                MessageBox.Show("Insert is Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        string gender;
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void rdbOthers_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Others";
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            Upload_Photo();
            //    OpenFileDialog dlg = new OpenFileDialog();
            //    dlg.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|ALL files(*.*)|*.*";

            //    if (dlg.ShowDialog() == DialogResult.OK)
            //    {
            //        string PicPath = dlg.FileName.ToString();
            //        txtFileName.Text = PicPath;
            //        pictureBox1.Image = Image.FromFile(PicPath);
            //    }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        private void loadData()
        {
            conn obcon = new conn();
            SqlConnection ob = new SqlConnection(obcon.strcon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = ob;

            SqlCommand ds = da.SelectCommand;
            ds.CommandText = "select * from tbl_AdminInfo";
            ds.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        string id;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            //if (dataGridView1.Rows[e.RowIndex].Cells[6].Value != null)
            //{
                textAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //}
            //else
            //{
            //    textAddress.Text = "";
            //}

            byte[] storedimg = (byte[])(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            picbyte1 = storedimg;
            Image newimg;
            using (MemoryStream stream = new MemoryStream(storedimg))
            {
                newimg = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = newimg;
            }

        }
    }
}
