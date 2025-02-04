using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace EBBillCalculation;

public class ElectricBill
{
        public static int s_meterID =1000;

        public string MeterID { get; set; }
        public string UserName  { get; set; }

        public long PhoneNumber { get; set; }
        public string MailId { get; set; }
        public int UnitsUsed { get; set; }
        public int Bill { get; set; }

    public ElectricBill(string name,long p_number,string mail){
        MeterID=$"EB{++s_meterID}";
        UserName=name;
        PhoneNumber=p_number;
        MailId=mail;

    }
    public int CalculateAmount(int units){
        if(units>= 0 && units<100){
            Bill=0;
        }
        else if(units>=100 && units<=200){
            units=units-100;
            Bill = units * 2;

        }
        else if(units >200 && units<=400){
            units = units -100;
            units = units -100;
            Bill=200+units*5;
        }
        else{
            units = units - 400;
            Bill = 200+1000+units*8;
        }
        return Bill;
    }
} 

