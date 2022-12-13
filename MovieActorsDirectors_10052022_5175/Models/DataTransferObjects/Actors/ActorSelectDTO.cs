using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models.DataTransferObjects.Actors
{
    public class ActorSelectDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get => FirstName + " " + LastName; }

        // checkboxlarda oyuncunun seçilip seçilmediğini anlamak için.
        public bool IsSelected { get; set; }
    }
}