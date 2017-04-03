using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quePreparoConCSharp.Controllers
{
    public class HomeController : Controller
    {
        //ACA ESTAN TODOS LOS CONTROLERS PARA ENTREGAR VISTAS
        //LAS DE LOS BOTONES DEL NAVBAR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MiHeladera()
        {

            return View();
        }

        public ActionResult MejorSalgo()
        {

            return View();

        }

        public ActionResult EnchulameLaCocina()
        {
            return View();
        }

    }
}