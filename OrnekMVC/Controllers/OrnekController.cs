using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace OrnekMVC.Controllers
{
    public class OrnekController : Controller
    {
        // GET: Ornek
        public ActionResult Index()
        {
            return View();
        }
        public string Denetleyicim()
        {
            return "Merhaba, ben bir denetleyiciyim";
        }
        
        public ActionResult Goruntum()
        {
            ViewBag.Icerik = "ÖrnekMVC - Görüntüm Sayfasına Hoşgeldiniz.";
            return View();
        }

        public ActionResult Sunucu()
        {
            ViewBag.Icerik = "Sunucu Bilgisi";
            return View();
        }

        public ActionResult donguFor()
        {
            ViewBag.Icerik = "For Döngüsü";
            return View();
        }
    }
}