using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomValidator.App_Start
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void UserCustomValidate(object source, ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;
            //checking for input length greater than 6 and less than 25 characters
            if (str.Length < 6 || str.Length > 25)
            {
                return;
            }
            //checking for a atleast a single capital letter
            bool capital = false;
            foreach (char ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    capital = true;
                    break;
                }
            }
            if (!capital)
            {
                return;
            }
            bool lower = false;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    lower = true;
                    break;
                }
            }
            if (!lower)
            {
                return;
            }
            bool digit = false;
            foreach (char ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    digit = true;
                    break;
                }
            }
            if (!digit)
            {
                return;
            }
            args.IsValid = true;
        } //end of UserCustomValidate method



        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}