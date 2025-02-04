using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission
{
      /// <summary>
      /// Class StudentDeatils <see cref = " StudentDetails"/> <see href="www.syncfusion.com"/>  used for creating for each student 
      /// </summary>

public class StudentDetails
{
        //properties
        //shortcut - for the below line prop + enter

    /// <summary>
    /// Field s_studentID used for auto incrementing and providing common ID scheme for all students
    /// </summary>
       private static int s_studentID=4000;//field of studentID for incrementing purpose  //here s is static _ represents field

       /// <summary>
       /// Property StudentID used to provide student id for an instance of <see cref="StudentDetails"/> 
       /// </summary>
       /// <value></value>

        public string StudentID { get; set; }//to store id in form of SF4001


        /// <summary>
        /// Property Name used to provide name for an instance of <see cref="StudentDeatils"/> 
        /// </summary>
        /// <value></value>
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

    /// <summary>
    /// Property Father Name is used to provide Father's Name for an instance of <see cref="StudentDetails"/>
    /// </summary>
    /// <value></value>
    public string FatherName { get; set; }

/// <summary>
/// Property Gender is used to provide Gender for an instance of <see cref="StudentDeatails"/> 
/// </summary>
/// <value></value>
    public GenderDetails Gender { get; set; }

    /// <summary>
    /// Property DOB is used to provide Date of Birth for an instance of <see cref="StudentDeatails"/> 
    /// </summary>
    /// <value></value>

    public DateTime DOB { get; set; }

    /// <summary>
    /// Property Physics is used to provide Physics mark for an instance of <see cref="StudentDeatails"/> 
    /// </summary>
    /// <value></value>

    public int Physics { get; set; }
    
    /// <summary>
    /// Property Chemistry is used to provide chemistry mark for an instance of <see cref="StudentDeatails"/> 
    /// </summary> <summary>
    /// 
    /// </summary>
    /// <value></value>

    public int Chemistry { get; set; }
    /// <summary>
    /// Property Maths is used to provide maths mark for an instance of <see cref="StudentDeatails"/> 
    /// </summary>
    /// <value></value>

    public int Maths { get; set; }



    //Constructors - behaviours / methods -used to assign values to its structures
    //Default Constructor


    /// <summary>
    /// Used to initialize default values to properties of an instance of <see cref="StudentDetails"/> 
    /// </summary>
    public StudentDetails()
    { // for setting the dafault values

        
        Name = "";
        FatherName = "";
        DOB = DateTime.Now;
        Gender = GenderDetails.UnKnown;
    }

    //Parameterized
    /// <summary>
    /// Used to initialize properties using parameter values for an instance of <see cref="StudentDeatils"/>
    /// <use href = "www.syncfusion.com"/>
    /// </summary>
    /// <param name="name">Parameter Name is a string, It used to assign values to property Name</param>
    /// <param name="fatherName">Parameter fatherName is a string, It used to assign values to property FatherName</param>
    /// <param name="gender">Parameter gender is a string, It is a enum GenderDetails<see cref="GenderDetails"/>,
    /// It used to assign values to property </param>
    /// <param name="dob">Parameter dob is a DateTime, It used to assign values to property DOB</param>
    /// <param name="physics">Parameter physics is a integer, It used to assign values to property Physics</param>
    /// <param name="chemistry">Parameter chemistry is a integer, It used to assign values to property Chemistry</param>
    /// <param name="maths">Parameter maths is a integer, It used to assign values to property Maths</param>
    
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
    /// <summary>
    /// Used to initialize properties using parameter values for an instance of <see cref="StudentDeatils"/>
    /// <use href = "www.syncfusion.com"/>
    /// </summary>
    /// <param name="name">Parameter Name is a string, It used to assign values to property Name</param>
    /// <param name="fatherName">Parameter fatherName is a string, It used to assign values to property FatherName</param>
    /// <param name="gender">Parameter gender is a string, It is a enum GenderDetails<see cref="GenderDetails"/>,
    /// It used to assign values to property </param>
    /// <param name="dob">Parameter dob is a DateTime, It used to assign values to property DOB</param>
    /// <param name="physics">Parameter physics is a integer, It used to assign values to property Physics</param>
    /// <param name="chemistry">Parameter chemistry is a integer, It used to assign values to property Chemistry</param>
    /// <param name="maths">Parameter maths is a integer, It used to assign values to property Maths</param>

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
    /// <summary>
    /// TotalMarks()  method will find the sum of physics, Chemistry and Maths property value
    /// </summary>
    /// <returns> Returns the sum of physics, Chemistry , Maths marks</returns>
    public int Total()
    {
        return Physics + Chemistry + Maths;
    }
   /// <summary>
   /// Average()  method  used to calculate the average of physics, Chemistry and Maths marks
   /// </summary>
   /// <returns> Returns the average of physics, Chemistry , Maths marks</returns>
    public double Average()
    {
        return (double)Total() / 3;

    }
    /// <summary>
    /// Method IsEligible() used to find  the student is eligible for admission or not
    /// </summary>
    /// <param name="cutOff">Parameter cutOff is used to give the cutoff value and it compared with the average to find Eligibity</param>
    /// <returns>if average is greater than cutoff it returns true </returns>
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
}

//This id increment is not used in real time application