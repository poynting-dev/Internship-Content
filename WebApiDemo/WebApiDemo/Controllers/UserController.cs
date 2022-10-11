using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { userId = 100, name = "Prateek", age = 22 });
            userList.Add(new User { userId = 101, name = "Nishant", age = 25 });
        }

        //api/user
        public IHttpActionResult GetUsers()
        {
            return Ok(userList);
        }

        //api/user
        public IHttpActionResult GetUserById(int id)
        {
            User user = userList.Find(u => u.userId == id);
            return Ok(user);
        }
    }
}
