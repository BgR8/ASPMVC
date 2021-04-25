using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekMVC.Controllers
{
    public class MerhabaController : Controller
    {
        // GET: Merhaba
        public string Index()
        {
            return "Örnek İşlev";
        }
        

        // Yönlendir : HomeController => About Sayfası 
        public ActionResult Yonlendir()
        {
            return RedirectToAction("About", "Home");
        }

        // GETİR: Merhaba/Bellek
        [OutputCache(Duration = 15)]
        public string Bellek()
        {
            return "ASP.Net Filtre Sayfası";
        }

        // GETİR: Merhaba/SimdiZaman 20 Saniye Bellek
        [OutputCache(Duration = 20)]
        //[ActionName("ZamanSimdi")] İşlemİsmi ŞimdiZaman Yordamı Yerine
        public string SimdiZaman()
        {
            return DateTime.Now.ToString("T");
        }

        // GET: Merhaba/Hosgeldin
        public string Hosgeldin(string isim, int NO = 1)
        {
            return HttpUtility.HtmlEncode("Merhaba " + isim + ", NO: " + NO);
        }

        public ActionResult Selam(string isim, int Say = 1)
        {
            ViewBag.Message = "Merhaba, " + isim;
            ViewBag.Say = Say;

            return View();
        }
        
    }
}