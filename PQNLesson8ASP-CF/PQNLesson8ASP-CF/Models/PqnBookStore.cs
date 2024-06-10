using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PQNLesson8ASP_CF.Models
{
    public class PqnBookStore:DbContext
    {
        public PqnBookStore() : base()
        {

        }
        public DbSet<PqnCategory> PqnCategories { get; set; }
        public DbSet<Pqnbook> PqnBooks { get; set; }    
    }
}