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
    public class TagsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tags
        public async Task<ActionResult> Index()
        {
            var tags = await db.Tags.ToListAsync();
            var tagsIndexViewModel = ClassTagConverter.ConvertListTagsToListTagIndexViewModel(tags);
            return View(tagsIndexViewModel);
        }

        // GET: Tags/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = await db.Tags.FindAsync(id);
            if (tag == null)
            {
                return HttpNotFound();
            }

            TagDetailViewModel tagDetailViewModel = ClassTagConverter.ConvertTagToTagDetailViewModel(tag);
            return View(tagDetailViewModel);
        }

        // GET: Tags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "name,SlugUrl")]  TagCreateViewModel tagCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                Tag tag = ClassTagConverter.ConvertTagCreateViewModelToTag(tagCreateViewModel);
                db.Tags.Add(tag);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tagCreateViewModel);
        }

        // GET: Tags/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = await db.Tags.FindAsync(id);
            if (tag == null)
            {
                return HttpNotFound();
            }

            TagEditViewModel tagEditViewModel = ClassTagConverter.ConvertTagToTagEditViewModel(tag);
            return View(tagEditViewModel);
        }

        // POST: Tags/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,name,SlugUrl")] TagEditViewModel tagEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Tag tag = ClassTagConverter.ConvertTagEditViewModelToTag(tagEditViewModel);
                db.Entry(tag).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tagEditViewModel);
        }

        // GET: Tags/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = await db.Tags.FindAsync(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            TagDeleteViewModel tagEditViewModel = ClassTagConverter.ConvertTagsToTagDeleteViewModel(tag);
            return View(tagEditViewModel);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Tag tag = await db.Tags.FindAsync(id);
            db.Tags.Remove(tag);
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
