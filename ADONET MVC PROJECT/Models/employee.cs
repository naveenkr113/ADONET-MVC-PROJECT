using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADONET_MVC_PROJECT.Models
{
    public class employee
    {
        public int empno { get; set; }
        public string empnam { get; set; }
        public int empsal { get; set; }
        public string empadd { get; set; }
    }

    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
}