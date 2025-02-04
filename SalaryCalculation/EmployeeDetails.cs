using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation;
public class EmployeeDetails
{
    private static int  s_employeeID =1000;
    public string EmployeeID { get; set; }
    
    public string Name { get; set; }
    public string Role  { get; set; }

    public GenderClassification Gender { get; set; }
    public LocationClassification WorkLocation { get; set; }

    public string TeamName { get; set; }
    public DateTime DOJ { get; set; }
    public string Password { get; set; }

    public EmployeeDetails(string name,string role,GenderClassification gender,LocationClassification location,string teamname,DateTime date,string password){
        EmployeeID = $"SF{++s_employeeID}";
        Name=name;
        Role=role;
        Gender=gender;
        WorkLocation = location;
        TeamName=teamname;
        DOJ = date;
        Password = password;

    }

    public long SalaryCal(int year,int month,int leaveTaken){
        int totaldays=DateTime.DaysInMonth(year,month);
        int workingdays = totaldays-leaveTaken;
        long salary = workingdays*500;
        return salary;
    }

        
}
