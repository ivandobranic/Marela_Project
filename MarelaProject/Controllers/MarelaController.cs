using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarelaProject.Models;
using PagedList;

namespace MarelaProject.Controllers
{
    //[Authorize]
    public class MarelaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Marela
        public ActionResult MaliciousFiles(string SearchBy, string Search, int? itemsPerPage, int? Page)
        {

            ViewBag.CurrentItemsPerPage = itemsPerPage;

            if (SearchBy == "MalwareName")
            {
                return View(db.MarelaModels.Where(x => x.MalwareName.StartsWith(Search)||Search == null).ToList().ToPagedList(Page ?? 1, pageSize: itemsPerPage ?? 25));
            }

           else 
            {
                return View(db.MarelaModels.Where(x => x.CompanyName.StartsWith(Search)||Search == null).ToList().ToPagedList(Page ?? 1, pageSize: itemsPerPage ?? 25));
            }
          
        }


    
        public ActionResult CAndCServer()
        {

             return View();

        }

        public ActionResult MaliciousDomain()
        {
            return View();
        }

      
        // GET: Marela/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarelaModels marelaModels = db.MarelaModels.Find(id);
            if (marelaModels == null)
            {
                return HttpNotFound();
            }
            return View(marelaModels);
        }

        // GET: Marela/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marela/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InvestigationNumber,CompanyName,MalwareName,MD5,SHA1,SHA256,ssdeep,FileType,FileSize,Description")] MarelaModels marelaModels)
        {
            if (ModelState.IsValid)
            {

                db.MarelaModels.Add(marelaModels);
                db.SaveChanges();
                return RedirectToAction("MaliciousFiles");
            }


            return View(marelaModels);

        }

        // GET: Marela/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarelaModels marelaModels = db.MarelaModels.Find(id);
            if (marelaModels == null)
            {
                return HttpNotFound();
            }
            return View(marelaModels);
        }

        // POST: Marela/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InvestigationNumber,CompanyName,MalwareName,MD5,SHA1,SHA256,ssdeep,FileType,FileSize,Description")] int id, MarelaModels marelaModels)
        {
            if (ModelState.IsValid)
            {
                marelaModels.LastModification = DateTime.Now;
                db.Entry(marelaModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MaliciousFiles");
            }
            return View(marelaModels);
        }

        // GET: Marela/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarelaModels marelaModels = db.MarelaModels.Find(id);
            if (marelaModels == null)
            {
                return HttpNotFound();
            }
            return View(marelaModels);
        }

        // POST: Marela/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarelaModels marelaModels = db.MarelaModels.Find(id);
            db.MarelaModels.Remove(marelaModels);
            db.SaveChanges();
            return RedirectToAction("MaliciousFiles");
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
