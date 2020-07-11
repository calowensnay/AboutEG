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
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Posts
        public async Task<ActionResult> Index()
        {
            var posts = await db.Posts.ToListAsync();
            var postIndexViewModel = ClassPostConverter.ConvertListPostsToListPostIndexViewModel(posts);


            return View(postIndexViewModel);
        }

        // GET: Posts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            PostDetailViewModel postDetailViewModel = ClassPostConverter.ConvertPostToPostDetailViewModel(post);
            return View(postDetailViewModel);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public async Task<ActionResult> Create([Bind(Include = "SubTitle,Title,SlugUrl,PostDate,HtmlContent,IsProvisional,PublishDate,Ahutor")] PostCreateViewModel postCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                Post post = ClassPostConverter.ConvertPostCreateViewModelToPost(postCreateViewModel);
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(postCreateViewModel);
        }

        // GET: Posts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            PostEditViewModel postEditViewModel = ClassPostConverter.ConvertPostToPostEditViewModel(post);
            return View(postEditViewModel);
        }

        // POST: Posts/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SubTitle,Title,SlugUrl,PostDate,HtmlContent,IsProvisional,PublishDate,Ahutor")] PostEditViewModel postEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Post post = ClassPostConverter.ConvertPostEditViewModelToPost(postEditViewModel);
                db.Entry(post).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(postEditViewModel);
        }

        // GET: Posts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            PostDeleteViewModel postEditViewModel = ClassPostConverter.ConvertPostsToPostDeleteViewModel(post);

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Post post = await db.Posts.FindAsync(id);
            db.Posts.Remove(post);
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
