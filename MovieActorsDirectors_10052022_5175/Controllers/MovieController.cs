using MovieActorsDirectors_10052022_5175.Models;
using MovieActorsDirectors_10052022_5175.Models.DataTransferObjects.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieActorsDirectors_10052022_5175.Controllers
{
    public class MovieController : BaseController
    {
        public ActionResult Create()
        {
            //yonetmenlerimzi gonderelim
            List<SelectListItem> yonetmenler = new List<SelectListItem>();

            foreach (Director item in db.Directors.Where(a=>a.IsActive).ToList())
            {
                yonetmenler.Add( new SelectListItem { Text=item.ToString(), Value=item.ID.ToString() });
            }

            //oyuncularımızı da gönderelim.
            List<ActorSelectDTO> oyuncularım = db.Actors.Where(a => a.IsActive).Select(a => new ActorSelectDTO { ID = a.ID, FirstName = a.FirstName, LastName = a.LastName, IsSelected = false }).ToList();

            return View(Tuple.Create<Movie, List<SelectListItem>, List<ActorSelectDTO>>(new Movie(),yonetmenler,oyuncularım));
        }
    }
}