using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Woods.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using DapperApp.Factory;

namespace Woods.Controllers{
    public class WoodsController:Controller{
        private readonly WoodsFactory trailfactory;
        public WoodsController(){
            trailfactory =  new WoodsFactory(); 
        }
        [HttpPost]
        [Route("/Add")]
        public IActionResult NewTrail(string Name, int Elevation, float Length){;
        Trail NewTrail= new Trail{
            Name=Name,
            Elevation=Elevation,
            Length=Length,
        };
        trailfactory.Add(NewTrail);
        return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            ViewBag.woods = trailfactory.all();
            //var AllWoods= ViewBag.woods.ToList();
            return View("Index");
        }
        [HttpGet]
        [Route("/show/{id}")]
        public IActionResult Show(int id)
        {
            int destination = id;
            ViewBag.destination= trailfactory.FindByID(destination);
            return View("show");
        }
    }
}

