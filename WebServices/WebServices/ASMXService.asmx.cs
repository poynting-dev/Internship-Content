using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace WebServices
{
    /// <summary>
    /// Summary description for ASMXService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ASMXService : System.Web.Services.WebService
    {
        DataTable emp = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a*b;
        }

        [WebMethod]
        public String Employees()
        {
            emp.Columns.Add("Id");
            emp.Columns.Add("Name");

            emp.Rows.Add( "101", "Pradeep");
            emp.Rows.Add( "102", "Mohit");
            emp.Rows.Add( "103", "Prashant");
            emp.Rows.Add( "104", "Ankur");
            return JsonConvert.SerializeObject(emp);
        }
    }
}
