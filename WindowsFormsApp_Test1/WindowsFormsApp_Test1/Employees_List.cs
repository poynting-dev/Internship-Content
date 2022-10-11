using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp_Test1
{
    public partial class employees_list : Form
    {
        public employees_list()
        {
            InitializeComponent();
            show();
        }
        DataSet ds;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insert(object sender, EventArgs e)
        {
            var id = uidInput;
            var employee = employeeInput;
            var practice = practiceInput;
            
            if (!string.IsNullOrEmpty(id.Text) && !string.IsNullOrEmpty(employee.Text) && !string.IsNullOrEmpty(practice.Text))
            {
                // Query to be executed
                string query = "Insert Into intern (uid, name, practice) VALUES(@uid, @name, @practice)";

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDB"].ToString()))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@uid", SqlDbType.Int, 10).Value = uidInput.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = employeeInput.Text;
                    cmd.Parameters.AddWithValue("@practice", SqlDbType.VarChar).Value = practiceInput.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Data Inserted Successfully");
                        //this.internTableAdapter.Fill(this.employeeDataSet.intern);
                        show();
                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show("Enter valid values: ");
                    }
                }
                show();
            }
            else
            {
                MessageBox.Show("Enter Valid information");
            }
        }

        public void update(object sender, EventArgs e)
        {
            var id = uidInput;
            var employee = employeeInput;
            var practice = practiceInput;

            //DataRow row;
            //DataSet ds = new DataSet();

            if (!string.IsNullOrEmpty(id.Text) && !string.IsNullOrEmpty(employee.Text) && !string.IsNullOrEmpty(practice.Text))
            {
                // Query to be executed
                //string query = "select from intern (uid) where uid= " + id.Text;
                string query = "update intern set name = @name, practice = @practice where uid = @uid";

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDB"].ToString()))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@uid", SqlDbType.Int, 10).Value = uidInput.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = employeeInput.Text;
                    cmd.Parameters.AddWithValue("@practice", SqlDbType.VarChar).Value = practiceInput.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();   
                        MessageBox.Show("Data Updated Successfully");
                        //this.internTableAdapter.Fill(this.employeeDataSet.intern);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter valid values: ");
                    }
                    finally
                    {
                        cn.Close();
                    }
                    show();
                }
            }
            else
            {
                MessageBox.Show("Enter Valid information");
            }
        }

        public void delete(object sender, EventArgs e)
        {
            var id = uidInput;
            var employee = employeeInput;
            var practice = practiceInput;

            //DataRow row;
            //DataSet ds = new DataSet();

            if (!string.IsNullOrEmpty(id.Text))
            {
                // Query to be executed
                //string query = "select from intern (uid) where uid= " + id.Text;
                string query = "delete from intern where uid = @uid";

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDB"].ToString()))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@uid", SqlDbType.Int, 10).Value = uidInput.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully");
                        //this.internTableAdapter.Fill(this.employeeDataSet.intern);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter valid values: ");
                    }
                    finally
                    {
                        cn.Close();
                    }
                    show();
                }
            }
            else
            {
                MessageBox.Show("Enter Valid information");
            }
        }

        public void show()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDB"].ToString());
            //string querySimple = string.Format("displayOrderedIntern");
            string queryProcedure = string.Format("displayOrderedIntern");

            SqlDataAdapter adapter = new SqlDataAdapter(queryProcedure, conn);
            ds = new DataSet(); 
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void search(object sender, EventArgs e)
        {
            var id = uidInput;
            DataTable dt = new DataTable();

            if (!string.IsNullOrEmpty(id.Text))
            {
                // Query to be executed
                //string query = "select from intern (uid) where uid= " + id.Text;
                string query = "select * from intern where uid = @uid";

                //SqlDataAdapter adapter = new SqlDataAdapter();
                //string sqlQuery = string.Format("displayOrderedIntern");
                //SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                //cmd.Parameters.Add("id", id.Text);

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDB"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM intern WHERE uid = @uid"))
                    {
                        cmd.Parameters.Add("@uid", SqlDbType.Int, 10).Value = uidInput.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cn;
                        cn.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            employeeInput.Text = sdr["name"].ToString();
                            practiceInput.Text = sdr["practice"].ToString();
                            MessageBox.Show("Hello");
                        }
                        cn.Close();
                    }
                    //


                    //employeeInput.Text = row["name"].ToString();
                    //practiceInput.Text = row["Age"].ToString();
                    //MessageBox.Show("Hello");
                }
                //using (SqlCommand cmd = new SqlCommand(query, cn))
                //{
                //    // define parameters and their values
                //    cmd.Parameters.Add("@uid", SqlDbType.Int, 10).Value = uidInput.Text;
                //    cmd.CommandType = CommandType.Text;

                //    // open connection, execute INSERT, close connection
                //    cn.Open();
                //    try
                //    {
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("Data Find Successfully");
                //        this.internTableAdapter.Fill(this.employeeDataSet.intern);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Enter valid values: ");
                //    }
                //    finally
                //    {
                //        cn.Close();
                //    }
                //}
            }
            else
            {
                MessageBox.Show("Enter Valid information");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employees_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.intern' table. You can move, or remove it, as needed.
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.internTableAdapter.FillBy(this.employeeDataSet.intern);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void uidInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
