using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class DB: DbContext
    {
        public DB() : base("mydb")
        {

        }
        public DbSet<User> userDB { get; set; }
    }
}