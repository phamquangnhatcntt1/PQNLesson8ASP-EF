using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PQNLesson8ASP_CF.Models
{
    public class PqnCategory
    {
        [Key]
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Pqnbook> PqnBooks { get; set; }     

    }
}