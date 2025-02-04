using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYNCCART
{
    public class CustomerDetails
    {
      public static int s_customerID=3000;
      public string CustomerID;
      public double _balance;
      public string  CustomerName { get; set; }
      public string City { get; set; }
      public long MobileNumber { get; set; }
      public double WalletBalance { get{ return _balance;} }
      public string Email { get; set; }

      public CustomerDetails(string customername, string city,long number,double walletbalance,string email){
        CustomerID =$"CID{++s_customerID}" ;
        CustomerName = customername;
        City=city;
        MobileNumber = number;
        _balance=walletbalance;
        Email = email;

      }






  public void Recharge(double amount){
    _balance+= amount;
  }
  public void DeductBalance(double amount){
    _balance -= amount;
  }

    }
}