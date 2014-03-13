using CalCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalCount.Controllers
{
    public class SideDishsController : Controller
    {
        //
        // GET: /SideDishs/

        public ActionResult Index()
        {
            var db = new CaloriesDataContext();
            var Sidez = db.Sides.ToArray();
            return View(Sidez);
        }

    }
}
