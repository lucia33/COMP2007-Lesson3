using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void submitbutton_Click(object sender, EventArgs e)
        {
            username.Text = "";
            username.Enabled = false;
            password.Enabled = false;
            instructionlabel.Text = "Thank you for logging in.";
        }
    }
}