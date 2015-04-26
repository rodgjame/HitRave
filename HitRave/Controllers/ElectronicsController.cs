using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitRave.Controllers
{
    public class ElectronicsController : Controller
    {
        // GET: /Electronics/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Electronics/Shop/
        public ActionResult Shop()
        {
            return View();
        }
    }
}