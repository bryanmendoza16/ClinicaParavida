﻿using System;
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
    public class UsuariosController : Controller
    {
        static string cadena = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ClinicaParavidaContext-202406011617071;  Integrated Security= True"; 

        ///GET: acceso
        public ActionResult Lging ()
        {
            return View ();
        }
        public ActionResult Registrar()
        {

            return View ();
        }

        [HttpPost]
        public ActionResult Registrar()
        {
            bool registrado;
            string mesaje; 
            if (Usuario.Clave == Usuario.ConfirmarClave  )

            return SB.ToString ();
        }
    }



    //public class UsuariosController : Controller
    //{
    //    private ClinicaParavidaContext db = new ClinicaParavidaContext();

    //    // GET: Usuarios
    //    public ActionResult Index()
    //    {
    //        return View(db.Usuarios.ToList());
    //    }

    //    // GET: Usuarios/Details/5
    //    public ActionResult Details(string id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Usuario usuario = db.Usuarios.Find(id);
    //        if (usuario == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(usuario);
    //    }

    //    // GET: Usuarios/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Usuarios/Create
    //    // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
    //    // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "IdUsuario,User,Clave,ConfirmarClave")] Usuario usuario)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Usuarios.Add(usuario);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(usuario);
    //    }

    //    // GET: Usuarios/Edit/5
    //    public ActionResult Edit(string id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Usuario usuario = db.Usuarios.Find(id);
    //        if (usuario == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(usuario);
    //    }

    //    // POST: Usuarios/Edit/5
    //    // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
    //    // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "IdUsuario,User,Clave,ConfirmarClave")] Usuario usuario)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(usuario).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(usuario);
    //    }

    //    // GET: Usuarios/Delete/5
    //    public ActionResult Delete(string id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Usuario usuario = db.Usuarios.Find(id);
    //        if (usuario == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(usuario);
    //    }

    //    // POST: Usuarios/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(string id)
    //    {
    //        Usuario usuario = db.Usuarios.Find(id);
    //        db.Usuarios.Remove(usuario);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    //}
}
