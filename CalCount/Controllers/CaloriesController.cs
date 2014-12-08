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


        /* -- Show Default View -- */
        public ActionResult Index()
        {
            var db = new CaloriesDataContext();
            var Mealz = db.Meals.ToArray();

            return View(Mealz);
        }








        /* -- Delete Meal -- */
        [HttpGet]
        public ActionResult DeleteMeal(long Id)
        {
            var db = new CaloriesDataContext();
            var Meal = db.Meals.Find(Id);

            return View(Meal);
        }

        [HttpPost]
        [ActionName("DeleteMeal")]
        public ActionResult DeleteMealPost(long Id)
        {
            var db = new CaloriesDataContext();
            var Meal = db.Meals.Find(Id);
            db.Meals.Remove(Meal);
            db.SaveChanges();


            return RedirectToAction("Index");            
        }





        /* -- Edit Meal -- */
        [HttpGet]
        public ActionResult MealEdit(long Id)
        {
            var db = new CaloriesDataContext();
            var Mealz = db.Meals.Find(Id);
            var categoryList = new SelectList(new[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            ViewBag.CategoryList = categoryList;

            return View(Mealz);
        }

        [HttpPost]
        [ActionName("MealEdit")]
        public ActionResult MealEditPost(long Id)
        {
            var db = new CaloriesDataContext();
            var Meal = db.Meals.Find(Id);
            UpdateModel(Meal);
            db.SaveChanges();

            return RedirectToAction("Index");
        }





        /* -- Create Meal -- */
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
