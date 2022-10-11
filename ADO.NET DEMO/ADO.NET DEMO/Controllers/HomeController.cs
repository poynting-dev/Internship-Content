using ADO.NET_DEMO.Models;
using MessageBird;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO.NET_DEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //const string YourAccessKey = "AquLAl0e6sUIG90jTbHnqCaqW"; // your access key here
            //Client client = Client.CreateDefault(YourAccessKey);
            //const long Msisdn = +918461914451; // your phone number here

            //MessageBird.Objects.Message message = client.SendMessage("Priyanshu", "Hi There!", new[] { Msisdn });

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
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
            using (conn = new SqlConnection("Data Source=.; Initial Catalog=Office; Integrated Security=SSPI "))
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

            //return View();
        }
    }
}