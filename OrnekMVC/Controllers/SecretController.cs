using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekMVC.Controllers
{
    [Authorize] // [Authorize(Users = "bugra.argon@gmail.com")]
    public class SecretController : Controller
    {
        // GET: Secret        
        public ContentResult Secret()
        {
            return Content("Gizli bilgi burada");
        }
        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Genel bilgi burada");
        }
    }
}