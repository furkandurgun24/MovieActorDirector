using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models
{
    public class Director : BaseClass
    {
        public Director()
        {
            Movies = new List<Movie>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; } // nullable prop

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // navigation property
        //1 yönetmenin çokça filmi olabilir.
        public virtual List<Movie>  Movies { get; set; }
    }
}