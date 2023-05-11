using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Models;
using ConsoleAppProject.App02;
using ConsoleAppProject.App01;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Index Page View
        {
            return View();
        }

        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            return View(converter);
        }
        [HttpGet]
        public IActionResult BmiCalculatorWeb(BMICalculatorWeb model)
        {
            return View(model);
        }

        public IActionResult BmiResultM(BMICalculatorWeb model)
        {
            ViewBag.BMIResult = model.BMIcalc(false);
            ViewBag.BMIDescription = model.BMIdescription(0);
            ViewBag.BMIColour = model.BMIdescription(1);
            return View();
        }

        public IActionResult BmiResultI(BMICalculatorWeb model)
        {
            ViewBag.BMIResult = model.BMIcalc(true);
            ViewBag.BMIDescription = model.BMIdescription(0);
            ViewBag.BMIColour = model.BMIdescription(1);
            return View();
        }
  

        public IActionResult StudentMarks() // Student Marks Page View
        {
            return View();
        }
        public IActionResult Create(PostsController model) // Social Network Page View
        {
            return View(model);
        }
        public IActionResult NetworkApp()
        {

            return View();
        }

        public IActionResult CreateNewPost() // Social Network Page View
        {
            return View();
        }

        public IActionResult RPS() // RPS GAME
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Error Handling
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
