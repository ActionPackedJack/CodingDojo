using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models{
    public class Customer:BaseEntity{
        [Required]
        public string name {set;get;}
        public List<Order> orders {set;get;}
        public Customer(string name){
            this.name = name;

        }
        public Customer(){
            orders = new List<Order>();
        }
    }
}