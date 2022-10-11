using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using ADO.NET_DEMO.Models;
using System.Data;

namespace ADO.NET_DEMO.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult Index()
        {
            List<Users> users = new List<Users>();
            DataTable user = new DataTable();
            //{
            //    new Users()
            //    {
            //        Id = 1,
            //    }
            //};
            SqlConnection conn;
            SqlCommand cmd;
            using(conn = new SqlConnection("Data Source=.; Initial Catalog=Office; Integrated Security=SSPI "))
            {
                conn.Open();
                cmd = new SqlCommand("select * from Users", conn);
                //SqlDataAdapter data = new SqlDataAdapter(cmd);
                //data.Fill(users);
                //var myData = users.Tables[0].AsEnumerable().Select(r => new Users
                //{
                //    Id = r.Field<int>("Id"),
                //    Name = r.Field<string>("Name"),
                //    salary = r.Field<int>("salary")
                //});

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new Users() { Id = (int)reader[0], Name = reader[1].ToString(), salary = (int)reader[2] });
                }

            }
            return View(users);
        }
    }
}