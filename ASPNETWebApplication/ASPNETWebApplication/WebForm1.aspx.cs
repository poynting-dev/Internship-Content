using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPNETWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["salesDB"].ToString());
            cmd.CommandText = "select * from SalesTable";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            Grid.DataSource = ds;
            Grid.DataBind();
            Grid1.DataSource = ds;
            Grid1.DataBind();
            //Grid.DataSource = ds.Tables[0];
            //Grid.DataBind();
            //Grid1.DataSource = ds.Tables[0];
            //Grid1.DataBind();
            con.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //string emailText = textboxEmail.Text;

            //// ToDo: Validate email & send data to data store
            //literalMessage.Text = "You have been subscribed to the Newsletter";
         
            string query = "Insert Into SalesTable (ItemCode, Item_Name, Qty, Rate, Disc_per, GST, CGST, SGST, Amount) VALUES(@ItemCode, @Item_Name, @Qty, @Rate, @Disc_per, @GST, @CGST, @SGST, @Amount)";

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["salesDB"].ToString()))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@ItemCode", SqlDbType.NChar, 10).Value = TextBox1.Text;
                cmd.Parameters.Add("@Item_Name", SqlDbType.NChar).Value = TextBox2.Text;
                cmd.Parameters.Add("@Qty", SqlDbType.NChar).Value = TextBox3.Text;
                cmd.Parameters.Add("@Rate", SqlDbType.Money).Value = TextBox4.Text;
                cmd.Parameters.Add("@Disc_per", SqlDbType.Float).Value = TextBox5.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = TextBox6.Text;
                cmd.Parameters.Add("@CGST", SqlDbType.Float).Value = TextBox7.Text;
                cmd.Parameters.Add("@SGST", SqlDbType.Float).Value = TextBox8.Text;
                cmd.Parameters.Add("@Amount", SqlDbType.Money).Value = TextBox9.Text;

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                BindData();
            }
        }

        protected void Grid_PageIndexChanged(object sender, DataGridPageChangedEventArgs e)
        {
            Grid.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }

        protected void Grid_EditCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = e.Item.ItemIndex;
            BindData();
        }
        protected void Grid_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = -1;
            BindData();
        }

        protected void Grid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void Grid_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        

        protected void Grid_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            string query = "delete from SalesTable where ItemCode = @ItemCode";

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["salesDB"].ToString()))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@ItemCode", SqlDbType.NChar, 10).Value = Grid.DataKeys[(int)e.Item.ItemIndex].ToString();

                // open connection, execute DELETE, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Grid.EditItemIndex = -1;    
            }
            BindData();
        }

        protected void Grid_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            string query = "Update SalesTable set Item_Name=@Item_Name,Qty=@Qty,Rate=@Rate,Disc_per=@Disc_per,GST=@GST,CGST=@CGST,SGST=@SGST, Amount=@Amount where ItemCode=@ItemCode";
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["salesDB"].ToString()))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@ItemCode", SqlDbType.NChar, 10).Value = ((TextBox)e.Item.Cells[0].Controls[0]).Text;
                cmd.Parameters.Add("@Item_Name", SqlDbType.NChar).Value = ((TextBox)e.Item.Cells[1].Controls[0]).Text;
                cmd.Parameters.Add("@Qty", SqlDbType.NChar).Value = ((TextBox)e.Item.Cells[2].Controls[0]).Text;
                cmd.Parameters.Add("@Rate", SqlDbType.Money).Value = ((TextBox)e.Item.Cells[3].Controls[0]).Text;
                cmd.Parameters.Add("@Disc_per", SqlDbType.Float).Value = ((TextBox)e.Item.Cells[4].Controls[0]).Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = ((TextBox)e.Item.Cells[5].Controls[0]).Text;
                cmd.Parameters.Add("@CGST", SqlDbType.Float).Value = ((TextBox)e.Item.Cells[6].Controls[0]).Text;
                cmd.Parameters.Add("@SGST", SqlDbType.Float).Value = ((TextBox)e.Item.Cells[7].Controls[0]).Text;
                cmd.Parameters.Add("@Amount", SqlDbType.Money).Value = ((TextBox)e.Item.Cells[8].Controls[0]).Text;
                // open connection, execute Update, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Grid.EditItemIndex = -1;
            }
            BindData();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}