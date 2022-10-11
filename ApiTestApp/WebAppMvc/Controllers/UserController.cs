using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAppMvc.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text;

namespace WebAppMvc.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44312/api/user");
        HttpClient client;

        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        // GET: User
        public ActionResult Index()
        {
            List<UserViewModel> modelList = new List<UserViewModel>();
            HttpResponseMessage response  = client.GetAsync(baseAddress).Result;
            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList =  JsonConvert.DeserializeObject<List<UserViewModel> >(data); 
            }
            return View(modelList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(baseAddress, content).Result;
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        ///Edit
        public ActionResult Edit(int Id)
        {
            UserViewModel model = new UserViewModel();
            HttpResponseMessage response = client.GetAsync(baseAddress + "/" + Id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<UserViewModel>(data);
            }
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(baseAddress + "/" + model.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("model", model);
        }
    }
}