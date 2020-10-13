using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Qlbanhang
{
    public class Dbconnect
    {
       
     
        //    protected SqlConnection _conn = new SqlConnection(@"Data Source=.;Initial Catalog=Qlbanhang;Integrated Security=True");
        protected SqlConnection _conn = new SqlConnection(@"Data Source=.;AttachDbFilename=|DataDirectory|\Qlbanhang.mdf;Integrated Security=True");
    }
}
