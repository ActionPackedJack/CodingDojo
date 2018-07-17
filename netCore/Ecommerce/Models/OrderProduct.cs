using System.Collections.Generic;

namespace Ecommerce.Models{
    public class OrderProduct:BaseEntity{
        public int orderId{get;set;}
        public Order order {get;set;}
        public int productId {get;set;}
        public Product product {get;set;}
    
    public OrderProduct(int orderId, Order order, int productId, Product product){
        this.orderId= orderId;
        this.order = order;
        this.productId= productId;
        this.product = product;
    }
}