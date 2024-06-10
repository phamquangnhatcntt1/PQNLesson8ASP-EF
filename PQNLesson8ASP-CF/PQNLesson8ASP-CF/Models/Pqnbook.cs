using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PQNLesson8ASP_CF.Models
{
    public class Pqnbook
    {
        [Key]
        public int PqnBookId { get; set; }
        public string PqnBookTitle { get; set; }
        public string PqnBookAuthor { get; set; }
        public string PqnBookYear { get; set; }
        public string PqnBookPublisher { get; set; }
        public string PqnBookPicture { get; set; }
        public int PqnCategoryId { get; set;}

        public virtual PqnCategory PqnCategory  { get;set; }
    }
}