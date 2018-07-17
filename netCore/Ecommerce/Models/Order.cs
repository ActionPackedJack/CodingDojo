using System.Collections.Generic;

namespace Ecommerce.Models{
    public class Order:BaseEntity{
        //public string name {get;set;}
        //public List<Product> products {get;set;}
        public Customer customer {get;set;}
    //     public Order(){
    //         products = new List<Product>();
    //     }
    // }
    }
}