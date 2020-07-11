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
            return View(db.DistribucionesTerritorial.ToList());
        }

      
        public ActionResult Create(long padreId = 0)
        {
            ViewBag.Geography = LoadGeograpy();

            if (padreId != 0)
            { 
                DistribucionTerritorial dtPadre = null;
                DistribucionTerritorial dt = null;

                dtPadre = db.DistribucionesTerritorial.Where(x => x.Id == padreId).ToList().FirstOrDefault();
                dt = new DistribucionTerritorial
                {
                    PadreId = dtPadre.Id,
                    Nivel = dtPadre.Nivel + 1,
                    Parent = dtPadre
                };
                return View(dt);             
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(DistribucionTerritorial dt)
        {

            DistribucionTerritorial dtPadre = null;
            if (dt.PadreId != null)
            {
                dtPadre = db.DistribucionesTerritorial.Where(x => x.Id == dt.PadreId).ToList().FirstOrDefault();
            }

            if (dt.Distintivo == null)
            {
                dt.Distintivo = dt.Nombre;
            }

            if (dt.PadreId != null)
            {

                dt.Nivel = dtPadre.Nivel+1;
                dt.Parent = dtPadre;
            }
            else
            {
                dt.Nivel = 0;
            }
            dt.FechaIngreso = DateTime.Now;
            db.DistribucionesTerritorial.Add(dt);

            dt.Id = db.SaveChanges();

            ViewBag.Geography = LoadGeograpy();


            return View();

        }

        public ActionResult Edit(long Id)
        {

            DistribucionTerritorial dt = db.DistribucionesTerritorial.Where(x => x.Id == Id).ToList().FirstOrDefault();
            ViewBag.Geography = LoadGeograpy();

            return View(dt);
        }

        [HttpPost]
        public ActionResult Edit(DistribucionTerritorial dt)
        {
            DistribucionTerritorial dt2 = db.DistribucionesTerritorial.Where(x => x.Id == dt.Id).ToList().FirstOrDefault();
            dt2.Nombre = dt.Nombre;
            dt2.Distintivo = dt.Distintivo;
            dt2.PadreId = dt.PadreId;
            dt2.Nivel = dt.Nivel;
            dt2.FechaUltimaModificacion = DateTime.Now;
            dt2.Tipo = dt.Tipo;

            if (dt.PadreId != null)
            {
                DistribucionTerritorial dtPadre = db.DistribucionesTerritorial.Where(x => x.Id == dt.PadreId).ToList().FirstOrDefault();
                dt2.Parent = dtPadre;
            }


            db.SaveChanges();

            ViewBag.Geography = LoadGeograpy();

            return View(dt2);
        }

        public ActionResult Delete(long id)
        {
            DistribucionTerritorial dt = db.DistribucionesTerritorial.Find(id);
            db.DistribucionesTerritorial.Remove(dt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IEnumerable<SelectListItem> LoadGeograpy()
        {
            List<DistribucionTerritorial> geography = db.DistribucionesTerritorial.ToList();
            return geography.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Nombre+"-"+x.Tipo });
        }


    }
}