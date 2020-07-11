using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AboutEG.Models;
using AboutEG.Utils;
using AboutEG.ViewModels;

namespace AboutEG.Controllers
{
    public class CategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categories
        public async Task<ActionResult> Index()
        {
            var categories = await db.Categories.ToListAsync();
            var categoriesIndexViewModel = ClassCategoryConverter.ConvertListCategorysToListCategoryIndexViewModel(categories);
            return View(categoriesIndexViewModel);
        }

        public async Task<ActionResult> LoadCategoriesJSON()
        {
            var result = await db.Categories.ToListAsync();
            var categoriesIndexViewModel = ClassCategoryConverter.ConvertListCategorysToListCategoryIndexViewModel(result);
            return Json(categoriesIndexViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: Categories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = await db.Categories.FindAsync(id);
            if (category == null)
            {
                return HttpNotFound();
            }

            CategoryDetailViewModel categoryDetailViewModel = ClassCategoryConverter.ConvertCategoryToCategoryDetailViewModel(category);
            return View(categoryDetailViewModel);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Name,SlugUrl")] CategoryCreateViewModel categoryCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = ClassCategoryConverter.ConvertCategoryCreateViewModelToCategory(categoryCreateViewModel);
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(categoryCreateViewModel);
        }

        // GET: Categories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = await db.Categories.FindAsync(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            CategoryEditViewModel categoryEditViewModel = ClassCategoryConverter.ConvertCategoryToCategoryEditViewModel(category);
            return View(categoryEditViewModel);
        }

        // POST: Categories/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,SlugUrl")] CategoryEditViewModel categoryEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = ClassCategoryConverter.ConvertCategoryEditViewModelToCategory(categoryEditViewModel);
                db.Entry(category).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categoryEditViewModel);
        }

        // GET: Categories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = await db.Categories.FindAsync(id);

            if (category == null)
            {
                return HttpNotFound();
            }

            CategoryDeleteViewModel categoryEditViewModel = ClassCategoryConverter.ConvertCategorysToCategoryDeleteViewModel(category);
            return View(categoryEditViewModel);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Category category = await db.Categories.FindAsync(id);
            db.Categories.Remove(category);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
