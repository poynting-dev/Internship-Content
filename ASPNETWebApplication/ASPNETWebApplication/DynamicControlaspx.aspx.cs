using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASPNETWebApplication
{
    public partial class DynamicControlaspx : System.Web.UI.Page
    {
        protected void onChange(object sender, EventArgs e)
        {
            TextBox txtBox = new TextBox();
            PlaceHolder1.Controls.Clear();
            txtBox.ID = "confirmInput";
            txtBox.CssClass = "form - control";
            PlaceHolder1.Controls.Add(txtBox);
            string email = inputEmail.Text;

            txtBox.Text = email;
            

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(PlaceHolder1.Controls.Count != 0)
                PlaceHolder1.Controls.Clear();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            onChange(sender, e);
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            onChange(sender, e);
        }

        protected void OnPreLoad(object sender, EventArgs e)
        {
            onChange(sender, e);
        }
        //Default
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Label1.Text = "Signed in successfully.";
            }
        }

        //Post Back
        protected void some_buttonName(object sender, EventArgs e)
        {
            onChange(sender, e);
        }

        protected void Unload(object sender, EventArgs e)
        {
            
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            onChange(sender, e);
        }

    }
}