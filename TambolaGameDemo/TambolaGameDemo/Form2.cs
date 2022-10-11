using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TambolaGameDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=.; database=TambolaGame ; Integrated Security=SSPI;";

            string joiningCode = textBox3.ToString();
            //using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand("select * from gameInfo where code = " + joiningCode.ToString() + ";", con))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSet ds1 = new DataSet();
            //    da.Fill(ds1);
            //    int i = ds1.Tables[0].Rows.Count;
            //    if (i > 0)
            //    {
            //        //exist
            //        //hostButton_Click(sender, e);
            //    }
            //}

            //MessageBox.Show("Joining code is: " + randCode.ToString(), "Host Game");


            //// Query to be executed
            //string query = "Insert Into gameInfo (code) VALUES (@code) ";

            //// instance connection and command
            //using (SqlConnection cn = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand(query, cn))
            //{
            //    // add parameters and their values
            //    //cmd.Parameters.Add("@FN", System.Data.SqlDbType.NVarChar, 100).Value = firstName;
            //    cmd.Parameters.Add("@code", System.Data.SqlDbType.Int).Value = randCode;

            //    // open connection, execute command and close connection
            //    cn.Open();
            //    cmd.ExecuteNonQuery();
            //    cn.Close();
            //}



            //Form3 f3 = new Form3();
            Form3 f3 = new Form3(textBox1.Text, textBox2.Text);
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
