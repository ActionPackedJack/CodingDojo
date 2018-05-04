using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using calling_card.Models;

namespace calling_card.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{first}/{last}/{age}/{color}")]
        public JsonResult DisplayInt(string first, string last, string age, string color)
        {
            var CallingCard = new {
                First_name = first,
                Last_name = last,
                Age = age,
                Favorite_color= color
            };
            return Json(CallingCard);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
