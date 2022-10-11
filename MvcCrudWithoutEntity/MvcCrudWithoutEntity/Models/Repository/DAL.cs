using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MvcCrudWithoutEntity.Models.Repository
{
    public class DAL
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);

        public List<UserRegModel> GetDataList()
        {
            List<UserRegModel> lst = new List<UserRegModel>();
            SqlCommand cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new UserRegModel
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

        public bool InsertData(UserRegModel ur)
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
            if (i >= 1)
                return true;
            return false;
        }

        public bool UpdateData(UserRegModel ur)
        {
            int i;
            SqlCommand cmd = new SqlCommand("sp_update", con);
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
            if (i >= 1)
                return true;
            return false;
        }

        public bool DeleteData(UserRegModel ur)
        {
            int i;
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ur.Id);
            con.Open();
            i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            return false;
        }
    }
}