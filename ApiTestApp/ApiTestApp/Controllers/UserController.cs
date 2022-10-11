using ApiTestApp.Database;
using ApiTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ApiTestApp.Controllers
{
    public class UserController: ApiController
    {
        DatabaseContext db = new DatabaseContext();

        //api/user
        public IEnumerable<User> GetUsers()
        {
            return db.Users.ToList();
        }

        //api/user/2
        public User GetUser(int Id)
        {
            return db.Users.Find(Id);
        }

        //api/user
        [HttpPost]
        public HttpResponseMessage AddUser(User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.Created);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                return response;
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateUser(int Id, User model)
        {
            try
            {
                if (Id == model.Id)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.NotModified);
                    return response;
                }

            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                return response;
            }
        }

        //api/user
        public HttpResponseMessage DeleteUser(int Id)
        {
            User user = db.Users.Find(Id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                return response;
            }
            else
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                return response;
            }

        }
    }
}