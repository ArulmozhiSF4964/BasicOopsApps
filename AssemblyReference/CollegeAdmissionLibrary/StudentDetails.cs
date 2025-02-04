using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionLibrary;

public class StudentDetails
{
        //properties
        //shortcut - for the below line prop + enter


       private static int s_studentID=4000;//field of studentID for incrementing purpose  //here s is static _ represents field

        public string StudentID { get; set; }//to store id in form of SF4001
        public string Name { get; set; } //auto implemented property //get,set -accessors
                                         //public string Name { get; } - read only property

    // 90% of the fields are private
    // example for field (all property and attribute)-> public string _firstName; used for stroing  
    /*
    public string FirstName
    {
          get{return _firstName;} //read only
          set{_firstName = value ;} //write only
    }
    value is used for representing FirstName (FirstName is not used inside so value used)
    */
    //simpled version of above is below
    //above we can change it to  both read and write only(we can change it) but below we can change it only to readonly we can't make it to write only
    public string FatherName { get; set; }

    public GenderDetails Gender { get; set; }

    public DateTime DOB { get; set; }

    public int Physics { get; set; }

    public int Chemistry { get; set; }

    public int Maths { get; set; }



    //Constructors - behaviours / methods -used to assign values to its structures
    //Default Constructor

    public StudentDetails()
    { // for setting the dafault values

        
        Name = "";
        FatherName = "";
        DOB = DateTime.Now;
        Gender = GenderDetails.UnKnown;
    }
    public StudentDetails(string name, string fatherName, GenderDetails gender, DateTime dob, int physics, int chemistry, int maths)
    {
        StudentID = $"SF{++s_studentID}";
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        DOB = dob;
        Physics = physics;
        Chemistry = chemistry;
        Maths = maths;
    }

    public StudentDetails(string name, string fatherName, GenderDetails gender, DateTime dob)
    {
        StudentID = $"SF{++s_studentID}";
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        DOB = dob;
    }

    ~StudentDetails() //default garbage colection
    {

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
    public void Dispose()
    {//  manual handling of garbage colection
        Name = null;
        GC.SuppressFinalize(this);
        GC.Collect();
    }
}

//This id increment is not used in real time application