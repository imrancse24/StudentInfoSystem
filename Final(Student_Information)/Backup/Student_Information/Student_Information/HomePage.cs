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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInformation si = new StudentInformation(0);
            si.Show();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Semester_Info se = new Semester_Info();
            se.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department_Info di = new Department_Info();
            di.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void courseSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course cs = new Course();
            cs.Show();
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();
            cr.Show();
        }

        private void accountSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSection AS = new AccountSection();
            AS.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
