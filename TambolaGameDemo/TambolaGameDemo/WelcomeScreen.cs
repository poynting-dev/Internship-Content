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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=.; database=TambolaGame ; Integrated Security=SSPI;";

            int randCode = RandomNumber(1000, 9999);

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("select * from gameInfo where code = " + randCode.ToString() + ";", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                int i = ds1.Tables[0].Rows.Count;
                if (i > 0)
                {
                    //exist
                    hostButton_Click(sender, e);
                }
            }

            MessageBox.Show("Joining code is: "+ randCode.ToString(), "Host Game");

            
            // Query to be executed
            string query = "Insert Into gameInfo (code) VALUES (@code) ";

            // instance connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // add parameters and their values
                //cmd.Parameters.Add("@FN", System.Data.SqlDbType.NVarChar, 100).Value = firstName;
                cmd.Parameters.Add("@code", System.Data.SqlDbType.Int).Value = randCode;

                // open connection, execute command and close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {

        }

        private void joinButton_MouseClick(object sender, MouseEventArgs e)
        {
            joinButton.ForeColor = Color.White;
        }

        private void joinButton_MouseEnter(object sender, EventArgs e)
        {
            joinButton.BackColor = Color.SkyBlue;
        }

        private void joinButton_MouseLeave(object sender, EventArgs e)
        {
            joinButton.BackColor = Color.DeepSkyBlue;
        }

        private void joinButton_MouseHover(object sender, EventArgs e)
        {
            
            
        }
    }
}
