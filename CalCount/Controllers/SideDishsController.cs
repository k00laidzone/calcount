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


        public ActionResult Index()
        {
            var db = new CaloriesDataContext();
            if (db.Sides.Count() >= 0)
            {
                var Sidez = db.Sides.ToArray();
                return View(Sidez);
            }
            return View();
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.sidedishs Side)
        {

            if (ModelState.IsValid)
            {
                var db = new CaloriesDataContext();
                db.Sides.Add(Side);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
