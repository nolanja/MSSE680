using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewCustomerIntegration.Domain.Models;

namespace NewCustomerIntegration.Controllers.ServiceLayer
{
    public class SiteTypeController : Controller
    {
        private DBIntegrationContext db = new DBIntegrationContext();

        private INewCustomerService service;
        public SiteTypeController(INewCustomerService service)
        {
            this.service = service;
        }
        //
        // GET: /SiteType/

        public ActionResult Index()
        {
            return View(db.SiteTypes.ToList());
        }

        //
        // GET: /SiteType/Details/5

        public ActionResult Details(long id = 0)
        {
            SiteType sitetype = db.SiteTypes.Find(id);
            if (sitetype == null)
            {
                return HttpNotFound();
            }
            return View(sitetype);
        }

        //
        // GET: /SiteType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SiteType/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SiteType sitetype)
        {
            if (ModelState.IsValid)
            {
                db.SiteTypes.Add(sitetype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sitetype);
        }

        //
        // GET: /SiteType/Edit/5

        public ActionResult Edit(long id = 0)
        {
            SiteType sitetype = db.SiteTypes.Find(id);
            if (sitetype == null)
            {
                return HttpNotFound();
            }
            return View(sitetype);
        }

        //
        // POST: /SiteType/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SiteType sitetype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sitetype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sitetype);
        }

        //
        // GET: /SiteType/Delete/5

        public ActionResult Delete(long id = 0)
        {
            SiteType sitetype = db.SiteTypes.Find(id);
            if (sitetype == null)
            {
                return HttpNotFound();
            }
            return View(sitetype);
        }

        //
        // POST: /SiteType/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SiteType sitetype = db.SiteTypes.Find(id);
            db.SiteTypes.Remove(sitetype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}