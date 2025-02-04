using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission;
 public class StudentDetails
{
        public static int s_studentID = 3000;
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName  { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        public long MobileNumber { get; set; }
        public string Email { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public StudentDetails(string name,string fathername,DateTime dob,GenderDetails gender,long mobile,string email,int physics,int chemistry,int maths){
            StudentID=$"SF{++s_studentID}";
            StudentName=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            MobileNumber=mobile;
            Email=email;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    public int Total()
    {
        return Physics + Chemistry + Maths;
    }
    public double Average()
    {
        return (double)Total() / 3;

    }
    public bool IsELigible(double cutOff)
    {
        if (Average() >= cutOff)
        {
            return true;
        }
        return false;
    }
}
