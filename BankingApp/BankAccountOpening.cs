using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp;

public class BankAccountOpening
{
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public GenderClassification Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string MailId { get; set; }
        public DateTime DOB { get; set; }
        public string Password { get; set; }

    public BankAccountOpening(){
    }
    public BankAccountOpening(string name,GenderClassification gender,long phonenumber,string mailID,DateTime dob,string password){
        CustomerID = $"HDFC{++s_customerID}";
        Name=name;
        Gender=gender;
        PhoneNumber=phonenumber;
        MailId=mailID;
        DOB=dob;
        Password=password;
        

    }
    public  void Deposit(int amount){
        Balance += amount; 
    }
     public  void Withdraw(int amount ){
        Balance -= amount; 
    }
}
