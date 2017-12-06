using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    class conn
    {
        public string strcon;
        public conn()
        {
            strcon = @"Data Source=IMRAN\SQLEXPRESS;Initial Catalog=Student_Info;Persist Security Info=True;User ID=sa;Password=sa123";
        }
    }
}
