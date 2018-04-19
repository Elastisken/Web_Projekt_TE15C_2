using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Projekt_TE15C_2.Models;

namespace Web_Projekt_TE15C_2.Controllers
{
    public class GameDevelopersController : Controller
    {
        private WebContext db = new WebContext();

        [AllowAnonymous]
        public ActionResult Index(string search)
        {
            var GameDevelopers = db.GamesDevelopers.Include(p => p.GamesDevelopers);
            if (!string.IsNullOrEmpty(search))
            {
                GameDevelopers = GamesDevelopers.Where(p => p.Name.Contains(search));
            }
            return View(GameDevelopers.ToList());
        }

        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameDevelopers gameDevelopers = db.GamesDevelopers.Find(id);
            if (gameDevelopers == null)
            {
                return HttpNotFound();
            }
            return View(gameDevelopers);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Established,About")] GameDevelopers gameDevelopers, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                db.GamesDevelopers.Add(gameDevelopers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameDevelopers);
        }

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameDevelopers gameDevelopers = db.GamesDevelopers.Find(id);
            if (gameDevelopers == null)
            {
                return HttpNotFound();
            }
            return View(gameDevelopers);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] GameDevelopers gameDevelopers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameDevelopers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameDevelopers);
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameDevelopers gameDevelopers = db.GamesDevelopers.Find(id);
            if (gameDevelopers == null)
            {
                return HttpNotFound();
            }
            return View(gameDevelopers);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameDevelopers gameDevelopers = db.GamesDevelopers.Find(id);
            db.GamesDevelopers.Remove(gameDevelopers);
            db.SaveChanges();
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
