using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekMVC.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Search(string name = "İsim Girilmedi")
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }

        /*public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Search(string name = "Ornek")
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
        [HttpGet]
        public ActionResult Search()
        {
            var input = "Başka Arama İşlevi";
            return Content(input);
        }*/
    }
}