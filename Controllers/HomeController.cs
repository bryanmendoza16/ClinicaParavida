using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaParavida.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema de Gestion de Citas de Clinica Paravida.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de Informacion de nuestra Clinica.";

            return View();
        }
    }
}