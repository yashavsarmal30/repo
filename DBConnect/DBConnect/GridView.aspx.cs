using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBConnect
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            Console.WriteLine("Connection Open !");
            string sql = "select * from Employee";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            Response.Write("ID\tName\tDepartment\tCity\tSalary" + "<br>");

            while (sdr.Read()) {

                Response.Write(sdr["id"] + "&nbsp;" + sdr["name"] + "&nbsp;" + sdr["department"] + "&nbsp;" + sdr["city"] + "&nbsp;" + sdr["salary"] + "<br>");
            }
            conn.Close();
        }
    }
}