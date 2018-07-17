using System.Collections.Generic;

namespace Ecommerce.Models{
    public class Product:BaseEntity{
        public string name {set;get;}
        public string url {set;get;}
        public string description {get;set;}
        public int quantity {get;set;}
        public Order order {get;set;}

        public Product(){
            List<Order> orders = new List<Order>();
        }
        public Product(string name, string description, string url, int quantity){
            this.name = name;
            this.description = description;
            this.url = url;
            this. quantity = quantity;

        }    
}