using System.Data;
using System.Linq;
using System.Web.Mvc;
using NewCustomerIntegration.Services;
using NewCustomerIntegration.Domain.Models;

namespace NewCustomerIntegration.Controllers
{
    public class RulesController : Controller
    {
        private DBIntegrationContext db = new DBIntegrationContext();

        private INewCustomerOrganizationService service;
        public RulesController(INewCustomerOrganizationService service)
        {
            this.service = service;
        }

        //
        // GET: /Rules/

        public ActionResult Index()
        {
            return View(db.Rules.ToList());
        }

        //
        // GET: /Rules/Details/5

        public ActionResult Details(long id = 0)
        {
            NewCustomerIntegration.Domain.Models.Rule rule = db.Rules.Find(id);
            if (rule == null)
            {
                return HttpNotFound();
            }
            return View(rule);
        }

        //
        // GET: /Rules/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Rules/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewCustomerIntegration.Domain.Models.Rule rule)
        {
            if (ModelState.IsValid)
            {
                db.Rules.Add(rule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rule);
        }

        //
        // GET: /Rules/Edit/5

        public ActionResult Edit(long id = 0)
        {
            NewCustomerIntegration.Domain.Models.Rule rule = db.Rules.Find(id);
            if (rule == null)
            {
                return HttpNotFound();
            }
            return View(rule);
        }

        //
        // POST: /Rules/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NewCustomerIntegration.Domain.Models.Rule rule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rule);
        }

        //
        // GET: /Rules/Delete/5

        public ActionResult Delete(long id = 0)
        {
            NewCustomerIntegration.Domain.Models.Rule rule = db.Rules.Find(id);
            if (rule == null)
            {
                return HttpNotFound();
            }
            return View(rule);
        }

        //
        // POST: /Rules/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            NewCustomerIntegration.Domain.Models.Rule rule = db.Rules.Find(id);
            db.Rules.Remove(rule);
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