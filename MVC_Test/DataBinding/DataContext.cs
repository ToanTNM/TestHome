using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Test.DataBinding
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DB")
        { }

        public DbSet<Student> Students { get; set; }
    }
}