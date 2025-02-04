using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class DepartmentDetails
    {
        public static int s_departmentID=101;
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }


        public DepartmentDetails(string depName,int seats){
            DepartmentID=$"DID{++s_departmentID}";
            DepartmentName=depName;
            NumberOfSeats=seats;
        }

    }

}