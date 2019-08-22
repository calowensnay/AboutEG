using AboutEG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutEG.Controllers
{
    public class DistribucionTerritorialController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: DistribucionTerritorial
        public ActionResult Index()
        {
            return View(db.DistribucionesTerritoriales.ToList());
        }
    }
}