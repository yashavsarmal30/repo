using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormAuthentication.App_Start
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        /*if (uname.CompareTo("student") == 0 && password.CompareTo("stu@123") == 0)
            return true;
        return false;


    }*/
        protected Boolean Authenticate(string user, String password)
        {
            string[] uname = { "Scott", "Jisun", "Sam" };
            string[] passwords = { "password", "password", "password" };
            for (int i = 0; i < uname.Length; i++)
            {
                bool validUsername = (string.Compare(UserName.Text, uname[i], true) == 0);
                bool validPassword = (string.Compare(UserPass.Text, passwords[i], false) == 0);
                if (validUsername && validPassword == true)
                {
                    return true;
                    // TODO: Log in the user... // TODO: Redirect them to the appropriate page 
                }
               //else return false;            
            }
            return false;
        } 





            protected void Login_Click(object sender, EventArgs e)
        {
            if (Authenticate(UserName.Text, UserPass.Text))
            {

                Response.Redirect("welcome.html");
                Response.End();

            }
            else
            {
                Msg.Text = "Invalid User Name and/or Password";
            }
        }

    }
}