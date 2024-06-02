using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClinicaParavida.Data;
using ClinicaParavida.Models;

namespace ClinicaParavida.Controllers
{
    public class EnfermerasController : Controller
    {
        private ClinicaParavidaContext db = new ClinicaParavidaContext();

        // GET: Enfermeras
        public ActionResult Index()
        {
            return View(db.Enfermeras.ToList());
        }

        // GET: Enfermeras/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enfermera enfermera = db.Enfermeras.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            return View(enfermera);
        }

        // GET: Enfermeras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enfermeras/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoEnfermera,Nombres,Apellidos,Dui,Doctor,Hora,Fecha,Estado")] Enfermera enfermera)
        {
            if (ModelState.IsValid)
            {
                db.Enfermeras.Add(enfermera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enfermera);
        }

        // GET: Enfermeras/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enfermera enfermera = db.Enfermeras.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            return View(enfermera);
        }

        // POST: Enfermeras/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoEnfermera,Nombres,Apellidos,Dui,Doctor,Hora,Fecha,Estado")] Enfermera enfermera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enfermera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enfermera);
        }

        // GET: Enfermeras/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enfermera enfermera = db.Enfermeras.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            return View(enfermera);
        }

        // POST: Enfermeras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Enfermera enfermera = db.Enfermeras.Find(id);
            db.Enfermeras.Remove(enfermera);
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
