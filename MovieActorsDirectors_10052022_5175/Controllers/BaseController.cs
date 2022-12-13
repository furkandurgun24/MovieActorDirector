using MovieActorsDirectors_10052022_5175.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieActorsDirectors_10052022_5175.Controllers
{
    public class BaseController : Controller
    {
        public ProjectContext db;
        public BaseController()
        {
            db = new ProjectContext();
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}