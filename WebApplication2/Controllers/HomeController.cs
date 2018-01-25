using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            //return Content("Pagina principal");
        }


        /* public ActionResult Sobre()
         {
             return View();
             //return Content("Pagina principal");
         }*/

       public JsonResult GetDados()
        {

            //var resultado = new { Nome = "linha de codigo", URL = "www.suntechdobrasil.com.br" };

            List<object> resultado = new List<object>();

            resultado.Add(new { Nome = "linha de codigo", URL = "www.suntechdobrasil.com.br" });
            resultado.Add(new { Nome = "linha de teste", URL = "www.teste.com.br" });
            resultado.Add(new { Nome = "hallo word", URL = "www.halloword.com.br" });

            return Json(resultado,JsonRequestBehavior.AllowGet);
        }
    }
}