﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Qlbanhang
{
    public class Dbconnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=.;Initial Catalog=Qlbanhang;Integrated Security=True");
    }
}
