using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYNCCART
{
    public class OrderDetails
    { 
       public static int s_orderID=1000;
       public string OrderID { get; set; }
       public string  CustomerID { get; set; }
       public string  ProductID{ get; set; }
       public double TotalPrice { get; set; }
       public DateTime PurchaseDate { get; set; }
       public int Quantity { get; set; }
       public OrderStatus OrderStatus { get; set; }

      
      public OrderDetails(string customerID,string productID,double totalPrice,DateTime purchasedate,int quantity,OrderStatus orderstatus){
        OrderID =$"OID{++s_orderID}";
        CustomerID=customerID;
        ProductID=productID;
        TotalPrice=totalPrice;
        PurchaseDate=purchasedate;
        Quantity=quantity;
        OrderStatus=orderstatus;
      }
    }
}