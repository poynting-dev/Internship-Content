using ApiTestApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ApiTestApp.Database
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(): base("DefaultConnection")
        {

        }



        public DbSet<User> Users { get; set; }
    }
}