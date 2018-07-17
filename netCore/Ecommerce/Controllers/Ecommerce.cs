using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers{
    private Context context;
    public EcommerceController(Context context){
        this.context =  context;
    }
	[Route("/Ecommerce")]
    public class EcommerceController:Controller{

        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
        [HttpGet]
        [Route("")]
        public IActionResult dashboard(){
            return View("dashboard");
        }
        [HttpGet]
        [Route("customers")]
        public IActionResult customers(){
            return View("customers");
        }

        [HttpPost]
        [Route("customers")]
        public IActionResult createCustomer(Customer customer){
            if(ModelState.IsValid){
                context.Add(customer);
                context.SaveChanges();
                return RedirectToAction("customers");
            }
        }
        [HttpPost]
        [Route("customers/{customerId}/destroy")]
        public IActionResult destroyCustomer(int customerId){
            Customer customer = context.customers.Where(c => c.id == customerId).SingleOrDefault();
            context.customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("customers");
        }
    }
}
