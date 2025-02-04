using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class AdmissionDetails
    {
        public static int s_admissionID=1001;
        public string AdmissionID { get; set; }
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }


        public AdmissionDetails(string studentID,string departmentID, DateTime admissiondate, AdmissionStatus admissionstatus ){
            AdmissionID = $"AID{++s_admissionID}";
            StudentID=studentID;
            DepartmentID=departmentID;
            AdmissionDate=admissiondate;
            AdmissionStatus=admissionstatus;
        }
    }
}