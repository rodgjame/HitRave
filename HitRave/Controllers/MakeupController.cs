using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitRave.Controllers
{
    public class MakeupController : Controller
    {
        // GET: /Makeup/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Makeup/Shop/
        public ActionResult Shop()
        {
            return View();
        }
    }
}