using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace UserDashboard.Controllers{
	[Route("/")]
    public class UserDashboardController:Controller{
        private Context context;
        public UserDashboardController(Context context){
            this.context =  context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
        [HttpGet]
        [Route("/login")]
        public IActionResult login(){
            return View("login");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult loginPost(LoginVM loginVM){
            if(ModelState.IsValid){
                User user = context.Login(loginVM);
                if(user == null){
                    TempData["error"] = "Invalid credentials.";
                }
                else{
                    return RedirectToAction("login");
                }
            }
            return View("login");
        }
        [HttpGet]
        [Route("register")]
        public IActionResult register(){
            return View("register");
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult registerPost(RegisterVM registerVM){
            if(ModelState.IsValid){
                context.CreateUser(registerVM);
                context.SaveChanges();                
            }
                return RedirectToAction("register");
        }
    }
}
