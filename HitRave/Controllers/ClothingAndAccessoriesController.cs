using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitRave.Controllers
{
    public class ClothingAndAccessoriesController : Controller
    {
        // GET: /ClothingAndAccessories/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /ClothingAndAccessories/Shop/
        public ActionResult Shop()
        {
            return View();
        }
    }
}