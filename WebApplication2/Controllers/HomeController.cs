using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;
using WebApplication2.Models;
using WebApplication2.Views.Home;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DistanceConverter(DistanceConverter converter)
        { if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }
        [HttpGet]
        public IActionResult BMICalculator()
        {

            return View();
        }
        [HttpPost]
        public IActionResult BMICalculator(BMICalculator bmiIndex)
        { if (bmiIndex.Centimetres > 140)
            {
                bmiIndex.CalculateBMI();
                bmiIndex.OutputBMI();
                bmiIndex.GetHealthMessage();
            }
            else if (bmiIndex.Feet > 4 && bmiIndex.Stones > 6)
            {
                bmiIndex.CalculateBMI();
                bmiIndex.OutputBMI();
                bmiIndex.GetHealthMessage();
            }
            else
            {
                ViewBag.Error = "You entered values too small for any adult";

                return View();
            }
            return RedirectToAction("GetHealthMessage", new {bmiIndex});
        }

        public IActionResult GetHealthMessage(BMICalculator bmiIndex)
        {
            return View(bmiIndex);
            
        }
     



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
