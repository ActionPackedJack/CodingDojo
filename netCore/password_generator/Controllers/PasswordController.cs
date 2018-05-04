using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    using System;
    public class PasswordController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Password()
        {
            string result="";
            Random rand = new Random();
            string[] chars=
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
                "G",
                "H",
                "I",
                "J",
                "K",
                "L",
                "M",
                "N",
                "O",
                "P",
                "Q",
                "R",
                "S",
                "T",
                "U",
                "V",
                "W",
                "X",
                "Y",
                "Z",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
            };
            for(int i=0; i<14; i++)
            {
                result += chars[rand.Next(0,35)];
            }
            int? Count = HttpContext.Session.GetInt32("Count");
                if(Count==null)
                {
                    Count=0;
                }
                    else{Count++;}
                HttpContext.Session.SetInt32("Count", (int)Count);
            System.Console.WriteLine("THE COUNT IS THUS:");
            System.Console.WriteLine(Count);
            ViewBag.Count = Count;
            ViewBag.Password=result;
            return View();
        }
    }
}