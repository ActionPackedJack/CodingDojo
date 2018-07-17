using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;
using SessionExtensions;
using System;

namespace Dojodachi.Controllers{
    [Route("/Dojodachi")]
    public class DojodachiController:Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            Dachi dachi = HttpContext.Session.GetJSON<Dachi>("Dojodachi");
        }
        if(Dachi==null){
            HttpContext.Session.SetJSON("Dojodachi",new Dachi());
        }
        ViewBag.dachi=dachi;
        return View("Index");
    }
    public IActionResult action(string button)
    {
        Dachi dachi = HttpContext.Session.GetJSON("Dojodachi");
        string result= "";
        switch(button){
            case "Work":
                dachi.work();
                break;

            case "Sleep":
                dachi.sleep();
                break;

            case "Play":
                dachi.play();
                break;

            case "Feed":
                dachi.feed();
                break;
            case "Reset":
                dachi= new Dachi();
                break;
        }
        return RedirectToAction("Index");
    }
}