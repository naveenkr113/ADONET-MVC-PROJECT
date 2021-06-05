using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADONET_MVC_PROJECT.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADONET_MVC_PROJECT.DAL
{
    public class employeerepository:clscon
    {
       

        public void Save_Rec(employee emp)
        {
             if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into employee values(@eno, @en, @esal, @eadd)",con);
            cmd.Parameters.AddWithValue("@eno", emp.empno);
            cmd.Parameters.AddWithValue("en", emp.empnam);
            cmd.Parameters.AddWithValue("esal", emp.empsal);
            cmd.Parameters.AddWithValue("eadd", emp.empadd);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();


        }
        public List<employee> Disp_Rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select*from employee",con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<employee> obj = new List<employee>();
            while (dr.Read())
            {
                employee ab = new employee();
                ab.empno = Convert.ToInt32(dr[0]);
                ab.empnam = dr[1].ToString();
                ab.empsal = Convert.ToInt32(dr[2]);
                ab.empadd = dr[3].ToString();
                obj.Add(ab);
            

            }

            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
}