using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYNCCART
{
    public class ProductDetails
    {
        public static int s_productID = 2000;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public double ShippingDuration { get; set; }

        public ProductDetails(string productname,int stock,double price,double shippingduration){
            ProductID=$"PID{++s_productID}";
            ProductName=productname;
            Stock=stock;
            Price=price;
            ShippingDuration=shippingduration;
        }
    }
}