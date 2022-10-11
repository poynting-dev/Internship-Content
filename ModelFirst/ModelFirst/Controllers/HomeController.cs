using ModelFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ModelFirst.Controllers
{
    public class HomeController : Controller
    {
        string conStr = ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString.ToString();
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd;
            SqlDataReader rdr;
            SqlDataAdapter adapter;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string cnd = "select * from Employee";
                conn.Open();
                cmd = new SqlCommand(cnd, conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                var data = dt.AsEnumerable().Select(x => x.Field<string>("Name")).ToList();
                //rdr = cmd.ExecuteReader();
                //while(rdr.Read())
                //{
                //    var data = rdr.GetValue(1);
                //}
                //rdr.Close();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}