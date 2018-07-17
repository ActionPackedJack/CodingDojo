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
using Creepypet.Models;

namespace Creepypet.Controllers{
    public class CreepypetController:Controller{
        [HttpGet]
        [Route("")]
        // public IActionResult Index(string key, object value){
        // HttpContext.Session.SetString(key, JsonConvert.SerializeObject(value));
        // var pet = HttpContext.Session.GetString(key);
        // return pet == null ? default(Eldritchcreature) : JsonConvert.DeserializeObject<Eldritchcreature>(pet);
        //         ViewBag.PetStats = pet;  
        //     }
        //     else{
        //         Eldritchcreature pet = HttpContext.Session.GetObjectFromJson<Eldritchcreature>("pet");
        //         ViewBag.PetStats = pet;
        //     }
        //     return View("Index");
            // public IActionResult Index(){
            //     var pet = JsonConvert.DeserializeObject("pet");
            //     if(pet==null){
            //         pet = new Eldritchcreature();
            //     }
            // }
            public IActionResult Index(){
                var petStr = HttpContext.Session.GetString("pet");
                if (petStr== null){
                    Eldritchcreature newPet = new Eldritchcreature();
                    petStr = JsonConvert.SerializeObject(newPet);
                }
                HttpContext.Session.SetString("pet", petStr);
                Eldritchcreature currentPet = JsonConvert.DeserializeObject(petStr);
                ViewBag.PetStats = currentPet;
                System.Console.WriteLine(currentPet.GetType());
                return View("Index");
            }

        }
    }
