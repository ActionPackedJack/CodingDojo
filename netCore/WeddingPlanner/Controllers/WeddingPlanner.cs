using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;


namespace WeddingPlanner.Controllers{
	//[Route("/")]
    public class WeddingPlannerController:Controller{
        private WPContext _context;
        public WeddingPlannerController(WPContext context){
            _context =  context;
    }
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
        [HttpGet]
        [Route("login")]
        public IActionResult login(LoginVM loginVM){
            if(ModelState.IsValid){
                User user = _context.Login(loginVM);
                if(user == null){
                    TempData["error"] = "Invalid credentials.";
                }
                else{
                    return RedirectToAction("weddings");
                }
            }
            return View("login");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult loginPost(LoginVM loginVM){
            if(ModelState.IsValid){
                System.Console.WriteLine("STATE IS QUITE VALID INDEED.");
                User user = _context.Login(loginVM);
                HttpContext.Session.SetInt32("logged", user.Id);
                User CurrentUser = _context._users.SingleOrDefault(u => u.Id == HttpContext.Session.GetInt32("logged"));
                ViewBag.loggedin=CurrentUser;
                ViewBag.Greeting=ViewBag.loggedin.first;
                if(user == null){
                    System.Console.WriteLine("You ain't no user of mine.");
                    TempData["error"] = "Invalid credentials.";
                }
                else{
                    return RedirectToAction("weddings");
                }
            }
            return View("login");
        }
        [HttpGet]
        [Route("register")]
        public IActionResult register(){
            return View();
        }
        [HttpPost]
        [Route("register")]
        public IActionResult registerPost(RegisterVM registerVM){
            if(ModelState.IsValid){
                _context.CreateUser(registerVM);
                _context.SaveChanges();     
            }           
            return RedirectToAction("register");
        }
        [HttpGet]
        [Route("weddings")]
        public IActionResult Weddings(){
            List<Wedding>weddings = _context._weddings.Include(p => p.guests).ToList();
            ViewBag.wed=weddings;
            System.Console.WriteLine("WEDDINGS ARE HERE:");
            System.Console.WriteLine(weddings);
            return View();
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Wedding item){
            Wedding marriage = new Wedding();
            marriage.spouse1 = item.spouse1;
            marriage.spouse2 = item.spouse2;
            marriage.when = item.when;
            // {
            //     spouse1 = item.spouse1,
            //     spouse2 = item.spouse2,
            //     when = item.when,
            // };
            _context._weddings.Add(marriage);
            _context.SaveChanges();
            System.Console.WriteLine("YEAH IT WORKED");
            return View("weddings");
        }
       //weddings= _context._weddings.SingleOrDefault(e => e.);
    }
}

