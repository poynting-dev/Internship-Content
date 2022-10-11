using CRUDMvcTest.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDMvcTest.Models
{
    public class UsersModel
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Description { get; set; }

        #endregion

        #region "Methods"

        public void InsertData(UsersModel ur)
        {
            int i;
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", ur.Id);
            cmd.Parameters.AddWithValue("@Name", ur.Name);
            cmd.Parameters.AddWithValue("@FatherName", ur.FatherName);
            cmd.Parameters.AddWithValue("@Email", ur.Email);
            cmd.Parameters.AddWithValue("@Mobile", ur.Mobile);
            cmd.Parameters.AddWithValue("@Description", ur.Description);
            con.Open();
            i = cmd.ExecuteNonQuery();
            con.Close();

        }

        public UsersModel EditUsers(int Id)
        {
            ///
            SqlCommand cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //adapt.Fill(dt);
            ////


            //
            //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            //

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        UsersModel userobj = new UsersModel();
                        userobj.Id = Convert.ToInt32(item["Id"]);
                        userobj.Name = item["Name"].ToString();
                        userobj.FatherName = item["FatherName"].ToString();
                        userobj.Email = item["Email"].ToString();
                        userobj.Mobile = item["Mobile"].ToString();
                        userobj.Description = item["Description"].ToString();
                        
                        return userobj;
                    }
                }
            }
            return null;
        }
        public List<UsersModel> GetUsers(int Id)
        {
            List<CRUDMvcTest.Models.UsersModel> lst = new List<UsersModel>();
            //Build your List
            SqlCommand cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new UsersModel
                {
                    Id = Convert.ToInt32(dr[0]),
                    Name = Convert.ToString(dr[1]),
                    FatherName = Convert.ToString(dr[2]),
                    Email = Convert.ToString(dr[3]),
                    Mobile = Convert.ToString(dr[4]),
                    Description = Convert.ToString(dr[5]),
                });
            }
            return lst;
        }
        #endregion

    }
}