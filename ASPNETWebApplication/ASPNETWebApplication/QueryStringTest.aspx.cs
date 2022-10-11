using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETWebApplication
{
    public partial class CookiesTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if(!Page.IsPostBack)
        //    {
        //        string s = Request.QueryString["Username"];
        //        Response.Write("Welcome: " + s);
        //    }   
        //}

        //protected void btnClick(object sender, EventArgs e)
        //{
        //    Response.Redirect(String.Format("CookiesTest.aspx?Username={0}", TextBox1.Text.Trim()));
        //    //string s = this.Request.QueryString["Username"];
        //    //submitBtn.Text = s;

        //}

        //protected void btnClick(object sender, EventArgs e)
        //{
        //    //Getting the click count
        //    if (Request.QueryString["click"] != null)
        //    {
        //        lblClick.Text = Request.QueryString["click"];
        //    }

        //    //setting Query String
        //    int postbacks = 0;
        //    if (Request.QueryString["click"] != null)
        //    {
        //        postbacks = Convert.ToInt32(Request.QueryString["click"]) + 1;
        //    }
        //    else
        //    {
        //        postbacks = 1;
        //    }
        //    //Response.Redirect("QueryStringTest.aspx?click=" + postbacks);
        //}

        protected void btnClick(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(HiddenField1.Value);
            Response.Write("Count is: " + count.ToString());
            HiddenField1.Value = Convert.ToString(count+1);
        }
    }
}