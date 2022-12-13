using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models.DataTransferObjects.Directors
{
    public class UpdateDirectorDTO
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "bu alan boş bırakılamz")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "bu alan boş bırakılamz")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "bu alan boş bırakılamz")]
        public DateTime BirthDate { get; set; }
    }
}