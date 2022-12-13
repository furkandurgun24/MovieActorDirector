using MovieActorsDirectors_10052022_5175.Models;
using MovieActorsDirectors_10052022_5175.Models.DataTransferObjects.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieActorsDirectors_10052022_5175.Controllers
{
    public class DirectorController : BaseController
    {
        //CRUD
        //CREATE

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateDirectorDTO model)
        {
            if (ModelState.IsValid)
            {
                Director director = new Director();
                director.FirstName = model.FirstName;
                director.LastName = model.LastName;
                director.BirthDate = model.BirthDate;
                db.Directors.Add(director);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else return View(model);
        }

        public ActionResult List()
        {
            return View(db.Directors.Where(a=>a.IsActive).ToList());
        }
      
        public ActionResult Detail(int id)
        {
            return View(db.Directors.Find(id));
        }

        public ActionResult Update(int id)
        {
            Director director = db.Directors.Find(id);

            UpdateDirectorDTO dto = new UpdateDirectorDTO();
            dto.ID = director.ID;
            dto.LastName = director.LastName;
            dto.FirstName = director.FirstName;
            dto.BirthDate = director.BirthDate.Value;
            return View(dto);
        }

        [HttpPost]
        public ActionResult Update(UpdateDirectorDTO model)
        {
            if (ModelState.IsValid)
            {
                Director updated = db.Directors.Find(model.ID);

                updated.LastName = model.LastName;
                updated.FirstName = model.FirstName;
                updated.BirthDate = model.BirthDate;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else return View(model);
        }

        public ActionResult Delete(int id)
        {
            Director director = db.Directors.Find(id);

            director.IsActive = false;
            db.SaveChanges();
            return RedirectToAction("List");
        }



    }
}