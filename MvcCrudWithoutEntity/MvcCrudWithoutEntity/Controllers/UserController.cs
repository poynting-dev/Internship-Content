using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MvcCrudWithoutEntity.Models;
using MvcCrudWithoutEntity.Models.Repository;

namespace MvcCrudWithoutEntity.Controllers
{
    public class UserController : Controller
    {
        DAL dal = new DAL();
        // GET: User
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(dal.GetDataList());
        }

        // GET: User/Details/5
        public ActionResult Details(int Id)
        {
            return View(dal.GetDataList().Find(ur => ur.Id==Id));
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserRegModel ur)
        {
            try
            {
                // TODO: Add insert logic here
                if(dal.InsertData(ur))
                {
                    ViewBag.Message = "Data Saved";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int Id)
        {
            return View(dal.GetDataList().Find(ur => ur.Id == Id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, UserRegModel ur)
        {
            try
            {
                if (dal.UpdateData(ur))
                {
                    ViewBag.Message = "Data Updated";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int Id)
        {
            return View(dal.GetDataList().Find(ur => ur.Id == Id));
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, UserRegModel ur)
        {
            try
            {
                if (dal.DeleteData(ur))
                {
                    ViewBag.Message = "Data Deleted";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
