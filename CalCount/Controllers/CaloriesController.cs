using CalCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalCount.Controllers
{
    public class CaloriesController : Controller
    {
        //
        // GET: /Calories/

        public ActionResult Index()
        {
            var db = new CaloriesDataContext();
            var Mealz = db.Meals.ToArray();

            return View(Mealz);
        }

        public ActionResult MealEdit(long Id)
        {
            var db = new CaloriesDataContext();
            var Mealz = db.Meals.Find(Id);

            return View();
        }

        public ActionResult Viewer()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.calcount caloriez)
        {
            var categoryList = new SelectList(new[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            ViewBag.CategoryList = categoryList;

            if (ModelState.IsValid)
            {
                var db = new CaloriesDataContext();
                db.Meals.Add(caloriez);
                db.SaveChanges();



                return RedirectToAction("Index");
            }

            return View();
        }



    }
}
