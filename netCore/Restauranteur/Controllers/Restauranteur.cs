using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restauranteur.Models;

namespace Restauranteur.Controllers{
	[Route("/Restauranteur")]
    public class RestauranteurController:Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
    }
}
