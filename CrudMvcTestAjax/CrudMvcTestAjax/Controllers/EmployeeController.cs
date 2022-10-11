using CrudMvcTestAjax.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMvcTestAjax.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);

        // GET: Employee
        public ActionResult Index()
        {
            if(ModelState.IsValid)
                ModelState.AddModelError(string.Empty, "Enter all the required fiels");

            return View();
        }

        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
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

        //[HttpGet]
        public ActionResult AddOrEdit(int Id=0)
        {
            Employee emp = new Employee();
            if(Id!=0)
            {
                emp = GetDataList().Find(ur => ur.Id == Id);
            }
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddOrEdit(Employee emp)
        {
            try
            {
                int i;
                SqlCommand cmd = new SqlCommand("sp_ins_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", emp.Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@FatherName", emp.FatherName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Mobile", emp.Mobile);
                cmd.Parameters.AddWithValue("@Description", emp.Description);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
                ModelState.AddModelError(string.Empty, "Enter all the required fiels");

                return View("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Enter all the required fiels");
                return View("Index");

            }
        }


        public List<Employee> GetDataList()
        {
            List<Employee> lst = new List<Employee>();
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


        public ActionResult Delete(int Id)
        {
            try
            {
                int i;
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("ViewAll");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");

            }
        }
    }
}