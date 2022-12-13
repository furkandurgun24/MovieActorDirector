using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models
{
    public class Actor : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        //navigationProperty
        //1 oyuncunun çokça filmi ve ( bir filmin çokça oyuncuus olacağından ara tablosu oluşmuş olmalı.)

        public virtual List<MovieActors>  MovieActors { get; set; }
    }
}