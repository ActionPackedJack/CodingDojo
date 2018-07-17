
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models{
    public class Wedding: BaseEntity{
        [Required]
        [Range(typeof(DateTime), "1/1/2018", "1/1/8000")]
        public DateTime when {get;set;}
        [Required]
        public string spouse1 {get;set;}
        [Required]
        public string spouse2 {get;set;}
        public List<Guest> guests {get;set;}

        public Wedding(){
            guests = new List<Guest>();
        }

    }
}
