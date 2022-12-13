using System;
using System.Collections.Generic;

namespace MovieActorsDirectors_10052022_5175.Models
{
    public class Movie : BaseClass
    {
        public string MovieName { get; set; }
        public DateTime PublishDate { get; set; }

        // navigationProp
        // 1 filmin 1 yönetmenı vardır
        public int DirectorID { get; set; }

        public virtual Director  Director { get; set; }

        //1 filmin çokça oyuncusu vardır.
        public virtual List<MovieActors> MovieActors { get; set; }
    }
}