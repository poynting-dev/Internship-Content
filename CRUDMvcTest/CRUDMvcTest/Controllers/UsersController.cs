using CRUDMvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDMvcTest.Models;

namespace CRUDMvcTest.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            UsersModel model = new UsersModel();
            return View(model);
        }

        // GET: Users/Details/5
        public ActionResult Details(int Id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(UsersModel model)
        {
            try
            {
                // TODO: Add insert logic here
                UsersModel us = new UsersModel();
                List<UsersModel> ls = us.InsertData(model);
                return Index();
            }
            catch
            {
                return View("List", model.GetUsers(0));
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int Id)
        {
            UsersModel model = new UsersModel();
            model = model.EditUsers(Id);
            return View("Create", model);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int Id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
