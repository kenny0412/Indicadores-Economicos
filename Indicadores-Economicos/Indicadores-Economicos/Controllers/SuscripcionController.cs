using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Indicadores_Economicos.Models;

namespace Indicadores_Economicos.Controllers
{
    //vsita para ver los datos
    public class SuscripcionController : Controller
    {
        private EmailController emailController = new EmailController();
        private IndicadoresEconomicosEntities4 db = new IndicadoresEconomicosEntities4();

        // GET: Suscripcion
        public ActionResult Index()
        {
            var sUBSCRIPTION = db.SUBSCRIPTION.Include(s => s.PROVINCE);
            return View(sUBSCRIPTION.ToList());
        }

        // GET: Suscripcion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBSCRIPTION sUBSCRIPTION = db.SUBSCRIPTION.Find(id);
            if (sUBSCRIPTION == null)
            {
                return HttpNotFound();
            }
            return View(sUBSCRIPTION);
        }

        // GET: Suscripcion/Create
        public ActionResult Create()
        {
            ViewBag.idProvince = new SelectList(db.PROVINCE, "idProvince", "province1");
            return View();
        }

        // POST: Suscripcion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idUser,fullname,identificationCard,age,email,profesion,idProvince,canton,district")] SUBSCRIPTION sUBSCRIPTION)
        {
            if (findSub(sUBSCRIPTION.email) != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
            if (ModelState.IsValid)
            {
                db.SUBSCRIPTION.Add(sUBSCRIPTION);
                db.SaveChanges();
                emailController.sendEmail("Confirmar cuenta banco central", "Cuenta de " + sUBSCRIPTION.fullname + " creada con éxito", sUBSCRIPTION.email);
                @ViewBag.sub_create = "Suscripción realizada correctamente";
            }

            ViewBag.idProvince = new SelectList(db.PROVINCE, "idProvince", "province1", sUBSCRIPTION.idProvince);
            return View(sUBSCRIPTION);
        }
        public SUBSCRIPTION findSub(string email)
        {
            SUBSCRIPTION sub = db.Database.SqlQuery<SUBSCRIPTION>("SELECT * FROM SUBSCRIPTION WHERE email = '" + email + "'").FirstOrDefault();
            if (sub == null)
            {
                return null;
            }
            else
            {
                return sub;
            }
        }
        public bool findSubBool(string email)
        {
            SUBSCRIPTION sub = db.Database.SqlQuery<SUBSCRIPTION>("SELECT * FROM SUBSCRIPTION WHERE email = '" + email + "';").FirstOrDefault();
            if (sub == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // GET: Suscripcion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBSCRIPTION sUBSCRIPTION = db.SUBSCRIPTION.Find(id);
            if (sUBSCRIPTION == null)
            {
                return HttpNotFound();
            }
            ViewBag.idProvince = new SelectList(db.PROVINCE, "idProvince", "province1", sUBSCRIPTION.idProvince);
            return View(sUBSCRIPTION);
        }

        // POST: Suscripcion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idUser,fullname,identificationCard,age,email,profesion,idProvince,canton,district")] SUBSCRIPTION sUBSCRIPTION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sUBSCRIPTION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idProvince = new SelectList(db.PROVINCE, "idProvince", "province1", sUBSCRIPTION.idProvince);
            return View(sUBSCRIPTION);
        }

        // GET: Suscripcion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBSCRIPTION sUBSCRIPTION = db.SUBSCRIPTION.Find(id);
            if (sUBSCRIPTION == null)
            {
                return HttpNotFound();
            }
            return View(sUBSCRIPTION);
        }

        // POST: Suscripcion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SUBSCRIPTION sUBSCRIPTION = db.SUBSCRIPTION.Find(id);
            db.SUBSCRIPTION.Remove(sUBSCRIPTION);
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
