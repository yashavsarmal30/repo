﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBConnect
{
    public partial class GridView2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            
            SqlDataAdapter sde = new SqlDataAdapter("Select * from Employee", conn);
            DataSet ds = new DataSet();
            sde.Fill(ds);
            GridView1.DataSource = ds;  
            GridView1.DataBind();
        }
    }
}