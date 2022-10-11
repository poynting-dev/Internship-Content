using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCRUDBasic.Models;

namespace MvcCRUDBasic.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);

        public ActionResult Index()
        {
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


        public JsonResult Insert(int Id, string Name, string FatherName, string Email, string Mobile, string Description)
        {
            string result = string.Empty;
            try
            {
                int i;
                SqlCommand cmd = new SqlCommand("sp_ins_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@FatherName", FatherName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Description", Description);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
                result = "Successfully Inserted";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoadDb()
        {
            return Json(GetAllEmployee().ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(string Id)
        {
            string result = string.Empty;
            try
            {
                int i;
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(Id));
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
                result = "Deleted Successfully";

            }
            catch (Exception ex)
            {
                result=ex.Message;

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        List<Employee> GetAllEmployee()
        {
            List<Employee> lst = new List<Employee>();
            //Build your List
            SqlCommand cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new Employee
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

        public JsonResult LoadDbbyId(string Id)
        {
            int id = Convert.ToInt32(Id);
            return Json(GetAllEmployee().Where(a => a.Id == id).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}