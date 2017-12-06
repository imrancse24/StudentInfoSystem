using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class frm_StudentProfile : Form
    {
        public frm_StudentProfile()
        {
            InitializeComponent();
        }

        private void frm_StudentProfile_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
