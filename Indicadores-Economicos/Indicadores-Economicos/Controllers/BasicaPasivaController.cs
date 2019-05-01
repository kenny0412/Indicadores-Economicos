using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Indicadores_Economicos.Controllers
{
    public class BasicaPasivaController : Controller
    {
        // GET: BasicaPasiva
        public ActionResult Index()
        {
            cr.fi.bccr.gee.wsIndicadoresEconomicos cliente = new cr.fi.bccr.gee.wsIndicadoresEconomicos();
            DataSet tipoCambioVenta = cliente.ObtenerIndicadoresEconomicos("423", "15/01/2014", "15/03/2019", "Felipe Ramirez", "N");
            //ViewBag.indicador = "Código indicador: " + tipoCambioVenta.Tables[0].Rows[0].ItemArray[0].ToString();
            //ViewBag.fecha = "Fecha consultada: " + tipoCambioVenta.Tables[0].Rows[0].ItemArray[1].ToString();
            ViewBag.valor = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[0].ItemArray[2]);
            ViewBag.valor2 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[31].ItemArray[2]);
            ViewBag.valor3 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[59].ItemArray[2]);
            ViewBag.valor4 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[90].ItemArray[2]);
            ViewBag.valor5 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[120].ItemArray[2]);
            ViewBag.valor6 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[151].ItemArray[2]);
            ViewBag.valor7 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[181].ItemArray[2]);
            ViewBag.valor8 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[212].ItemArray[2]);
            ViewBag.valor9 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[243].ItemArray[2]);
            ViewBag.valor10 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[273].ItemArray[2]);
            ViewBag.valor11 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[304].ItemArray[2]);
            ViewBag.valor12 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[334].ItemArray[2]);
            ViewBag.valor13 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[365].ItemArray[2]);
            ViewBag.valor14 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[396].ItemArray[2]);
            ViewBag.valor15 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[424].ItemArray[2]);
            ViewBag.valor16 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[455].ItemArray[2]);
            ViewBag.valor17 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[485].ItemArray[2]);
            ViewBag.valor18 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[516].ItemArray[2]);
            ViewBag.valor19 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[546].ItemArray[2]);
            ViewBag.valor20 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[577].ItemArray[2]);
            ViewBag.valor21 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[608].ItemArray[2]);
            ViewBag.valor22 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[638].ItemArray[2]);
            ViewBag.valor23 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[669].ItemArray[2]);
            ViewBag.valor24 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[699].ItemArray[2]);
            ViewBag.valor25 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[730].ItemArray[2]);
            ViewBag.valor26 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[761].ItemArray[2]);
            ViewBag.valor27 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[790].ItemArray[2]);
            ViewBag.valor28 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[821].ItemArray[2]);
            ViewBag.valor29 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[851].ItemArray[2]);
            ViewBag.valor30 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[882].ItemArray[2]);
            ViewBag.valor31 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[912].ItemArray[2]);
            ViewBag.valor32 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[943].ItemArray[2]);
            ViewBag.valor33 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[974].ItemArray[2]);
            ViewBag.valor34 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1004].ItemArray[2]);
            ViewBag.valor35 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1035].ItemArray[2]);
            ViewBag.valor36 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1065].ItemArray[2]);
            ViewBag.valor37 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1096].ItemArray[2]);
            ViewBag.valor38 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1127].ItemArray[2]);
            ViewBag.valor39 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1155].ItemArray[2]);
            ViewBag.valor40 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1186].ItemArray[2]);
            ViewBag.valor41 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1216].ItemArray[2]);
            ViewBag.valor42 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1247].ItemArray[2]);
            ViewBag.valor43 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1277].ItemArray[2]);
            ViewBag.valor44 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1308].ItemArray[2]);
            ViewBag.valor45 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1339].ItemArray[2]);
            ViewBag.valor46 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1369].ItemArray[2]);
            ViewBag.valor47 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1400].ItemArray[2]);
            ViewBag.valor48 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1430].ItemArray[2]);
            ViewBag.valor49 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1461].ItemArray[2]);
            ViewBag.valor50 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1492].ItemArray[2]);
            ViewBag.valor51 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1520].ItemArray[2]);
            ViewBag.valor52 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1551].ItemArray[2]);
            ViewBag.valor53 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1581].ItemArray[2]);
            ViewBag.valor54 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1612].ItemArray[2]);
            ViewBag.valor55 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1642].ItemArray[2]);
            ViewBag.valor56 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1673].ItemArray[2]);
            ViewBag.valor57 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1704].ItemArray[2]);
            ViewBag.valor58 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1734].ItemArray[2]);
            ViewBag.valor59 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1765].ItemArray[2]);
            ViewBag.valor60 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1795].ItemArray[2]);
            ViewBag.valor61 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1826].ItemArray[2]);
            ViewBag.valor62 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1857].ItemArray[2]);
            ViewBag.valor63 = Convert.ToInt32(tipoCambioVenta.Tables[0].Rows[1885].ItemArray[2]);

            return View();
        }
    }
}