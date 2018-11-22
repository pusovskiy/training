using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RegistrationForm.Models;

namespace RegistrationForm.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext() : base("UserContext")
        {

        }
    }
}