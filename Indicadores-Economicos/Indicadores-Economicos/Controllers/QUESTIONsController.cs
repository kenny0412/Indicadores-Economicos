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
    public class QUESTIONsController : Controller
    {
        private IndicadoresEconomicosEntities4 db = new IndicadoresEconomicosEntities4();

        // GET: QUESTIONs
        public ActionResult Index()
        {
            return View(db.QUESTION.ToList());
        }

        // GET: QUESTIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUESTION qUESTION = db.QUESTION.Find(id);
            if (qUESTION == null)
            {
                return HttpNotFound();
            }
            return View(qUESTION);
        }

        // GET: QUESTIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QUESTIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idQuestion,author,startdate,content")] QUESTION qUESTION)
        {
            if (ModelState.IsValid)
            {
                db.QUESTION.Add(qUESTION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qUESTION);
        }

        // GET: QUESTIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUESTION qUESTION = db.QUESTION.Find(id);
            if (qUESTION == null)
            {
                return HttpNotFound();
            }
            return View(qUESTION);
        }

        // POST: QUESTIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idQuestion,author,startdate,content")] QUESTION qUESTION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qUESTION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qUESTION);
        }

        // GET: QUESTIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUESTION qUESTION = db.QUESTION.Find(id);
            if (qUESTION == null)
            {
                return HttpNotFound();
            }
            return View(qUESTION);
        }

        // POST: QUESTIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QUESTION qUESTION = db.QUESTION.Find(id);
            db.QUESTION.Remove(qUESTION);
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
