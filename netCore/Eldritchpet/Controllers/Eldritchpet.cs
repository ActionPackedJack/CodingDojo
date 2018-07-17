using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Eldritchpet.Models;

namespace Eldritchpet.Controllers{
    public class EldritchpetController:Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            if (HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet")==null){
                Eldritchcreature pet = new Eldritchcreature();
                 HttpContext.Session.SetObjectAsJson("pet", pet);
                ViewBag.PetStats = pet;  
            }
            else{
                Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
                ViewBag.PetStats = pet;
            }
            return View("Index");

        }
        [HttpGet]
        [Route("/feed")]
        public IActionResult feed(){
            System.Console.WriteLine("FEEDING HERE BOSS");
            Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
            pet.feed();
            HttpContext.Session.SetObjectAsJson("pet", pet);
            ViewBag.PetStats = pet;
            return View("Index");
        }
        [HttpGet]
        [Route("/work")]
        public IActionResult work(){
            Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
            pet.work();
            ViewBag.PetStats = pet;
            HttpContext.Session.SetObjectAsJson("pet", pet);
            return View("Index");
        }
        [HttpGet]
        [Route("/sleep")]
        public IActionResult sleep(){
            Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
            pet.sleep();
            ViewBag.PetStats = pet;
            HttpContext.Session.SetObjectAsJson("pet", pet);
            return View("Index");
        }   
        [HttpGet]
        [Route("/play")]
        public IActionResult play(){
            Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
            pet.play();
            ViewBag.PetStats = pet;
            HttpContext.Session.SetObjectAsJson("pet", pet);
            return View("Index");
        }
        [HttpGet]
        [Route("/reset")]
        public IActionResult reset(){
            Eldritchcreature pet = new Eldritchcreature();
            ViewBag.PetStats = pet;
            HttpContext.Session.SetObjectAsJson("pet", pet);
            return View("Index");
        }

// $.get("/petaction", myPet, function(data){
//     $("element").html = data.property;
// });
//         [HttpGet]
//         [Route("/petaction")]
//         public IActionResult PetAction(string action, Eldritchcreature pet){
//             if (action == "feed") {
//                 pet.feed();
//             }
//             return Json(pet);
//         }
//             // void Feed(){
//             //     Eldritchcreature pet= HttpContext.Session("pet");
//             //     pet.feed();
//             //     Session["pet"] = pet;
//             //     return;
//             // }
    }
// Somewhere in your namespace, outside other classes
public static class SessionExtensions
{
    // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
    public static void SetObjectAsJson(this ISession session, string key, object value)
    {
        // This helper function simply serializes theobject to JSON and stores it as a string in session
        session.SetString(key, JsonConvert.SerializeObject(value));
    }
       
    // generic type T is a stand-in indicating that we need to specify the type on retrieval
    public static T GetObjectFromJson<T>(this ISession session, string key)
    {
        string value = session.GetString(key);
        // Upon retrieval the object is deserialized based on the type we specified
        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    }
}
}