using MovieActorsDirectors_10052022_5175.Models;
using MovieActorsDirectors_10052022_5175.Models.DataTransferObjects.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieActorsDirectors_10052022_5175.Controllers
{
    public class ActorController : BaseController
    {
       public ActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Create(CreateActorDTO dto)
        {
            if (ModelState.IsValid)
            {
                Actor actor = new Actor();
                actor.BirthDate = dto.BirthDate;
                actor.LastName = dto.LastName;
                actor.FirstName = dto.FirstName;
                db.Actors.Add(actor);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else return View(dto);
        }

        public ActionResult List()
        {
            return View(db.Actors.Where(a=>a.IsActive).ToList());
        }

        public ActionResult Update(int id)
        {
            Actor actor = db.Actors.Find(id);

            UpdateActorDTO dto = new UpdateActorDTO();
            dto.BirthDate = actor.BirthDate.Value;
            dto.FirstName = actor.FirstName;
            dto.LastName = actor.LastName;
            dto.ID = actor.ID;
            return View(dto);
        }

        [HttpPost]
        public ActionResult Update(UpdateActorDTO model)
        {
            if (ModelState.IsValid)
            {
                Actor actor = db.Actors.Find(model.ID);
                actor.LastName = model.LastName;
                actor.FirstName = model.FirstName;
                actor.BirthDate = model.BirthDate;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else return View(model);
        }

    }
}
