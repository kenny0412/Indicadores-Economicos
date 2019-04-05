using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indicadores_Economicos.Controllers
{
    public class InfoIndicadoresController : Controller
    {
        // GET: InfoIndicadores
        public ActionResult InfoTasaMonetaria()
        {
            return View();
        }

        public ActionResult InfoTasaBasicaPasiva()
        {
            return View();
        }

        public ActionResult InfoCompraDolar()
        {
            return View();
        }

        public ActionResult InfoVentaDolar()
        {
            return View();
        }
    }
}