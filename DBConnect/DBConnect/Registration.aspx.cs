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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into Employee(name,department,city,salary) values (@name,@department,@city,@salary)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@department", tbdept.Text);
                cmd.Parameters.AddWithValue("@city", tbcity.Text);
                cmd.Parameters.AddWithValue("@salary", tbsal.Text);
                cmd.ExecuteNonQuery();

                Response.Write("User registeration done Successfully!!!thank you");

                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}