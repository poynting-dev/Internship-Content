using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETWebApplication
{
    public partial class CookiesTest1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int postbacks = 0;
            if (Request.Cookies["number"] != null)
            {
                postbacks = Convert.ToInt32(Request.Cookies["number"].Value) + 1;
            }
            // Generating Response  
            else
            {
                postbacks = 1;
            }
            Response.Cookies["number"].Value = postbacks.ToString();
            //Persistent Cookie
            Response.Cookies["number"].Expires = DateTime.Now.AddMilliseconds(5000);

            lblClick.Text = Response.Cookies["number"].Value;
        }
    }
}