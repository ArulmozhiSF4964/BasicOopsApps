using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class Operations
    {
        //Creating the lists to add objects
        List<StudentDetails> students = new List<StudentDetails>();
        List<DepartmentDetails> departments = new();
        List<AdmissionDetails> admissionDetails = new();
        StudentDetails currentLoggedStudent;
        //DefaultData method is used to add datas
        public void DefaultData()
        {
            System.Console.WriteLine("Default data");

            StudentDetails student = new StudentDetails("Ravi E", "Ettapparajan", new DateTime(1999, 11, 16), GenderDetails.Male, 9870893412, "ravi@gmail.com", 92, 98, 91);
            StudentDetails student1 = new StudentDetails("Baskaran S", "Sethurajan", new DateTime(1999, 11, 17), GenderDetails.Male, 3245760098, "boss@gmail.com", 91, 97, 90);
            students.AddRange(new List<StudentDetails>() { student, student1 });

            DepartmentDetails department = new DepartmentDetails("EEE", 29);
            DepartmentDetails department1 = new("CSE", 29);
            DepartmentDetails department2 = new("MECH", 30);
            DepartmentDetails department3 = new("ECE", 30);

            departments.AddRange(new List<DepartmentDetails>() { department, department1, department2, department3 });

            AdmissionDetails admission = new AdmissionDetails("SF3001", "DID101", new DateTime(2024, 05, 11), AdmissionStatus.Booked);
            AdmissionDetails admission1 = new AdmissionDetails("SF3002", "DID102", new DateTime(2024, 05, 12), AdmissionStatus.Cancelled);
            admissionDetails.AddRange(new List<AdmissionDetails>() { admission, admission1 });

        }
        //Mainmenu() method Consists of Registration,Login and Exit
        public void MainMenu()
        {
            bool flag = true;
            do
            {
                //action to be repeated
                System.Console.WriteLine("****Main Menu****");
                System.Console.WriteLine("Select \n1.Registration \n2.Login \n3.Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }

                //termination condition
            } while (flag);//condition for looping



        }
        //Registration() method is used to register new students.for this it collecting the relevent details of this student
        public void Registration()
        {
            System.Console.WriteLine("**** User Registration ***");
            System.Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Father name");
            string fathername = Console.ReadLine();
            System.Console.WriteLine("Enter DOB");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter your Gender:");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter email ID");
            string email = Console.ReadLine();
            System.Console.WriteLine("Enter Physics mark:");
            int physics = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Chemistry mark:");
            int chemistry = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Maths mark:");
            int maths = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Mobile:");
            long mobile = long.Parse(Console.ReadLine());


            StudentDetails student = new(name, fathername, dob, gender, mobile, email, physics, chemistry, maths);
            Console.WriteLine($"Registration Successful {student.StudentID}");
            students.Add(student);



        }
        //Login() method is used to login to the application using its RegistrationID
        public void Login()
        {
            System.Console.WriteLine("User Login");
            System.Console.WriteLine("Enter your registration ID");
            string studentID = Console.ReadLine().ToUpper();
            bool flag = true;
            //traverse student list and find student is present or not
            foreach (StudentDetails student in students)
            {
                if (studentID.Equals(student.StudentID))
                {

                    //if present - show login successful
                    System.Console.WriteLine("Login successful");
                    flag = false;
                    currentLoggedStudent = student;
                    SubMenu();
                    break;
                }
            }
            //if not present - show invalid user id
            if (flag)
            {
                System.Console.WriteLine("Invalid User ID");
            }

        }


        public void SubMenu()
        {
            bool flag = true;
            do
            {
                //action to be repeated
                System.Console.WriteLine("***SubMenu***");
                //show option ->show details, check eiligibility, take admission, cancel admission, show history, exit
                Console.WriteLine("Select option \n1.Show details \n2.Check Eligibility \n3.Take Admission \n4.Cancel Admission \n5.Show History \n6.Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            CheckEligibity();
                            break;

                        }
                    case 3:
                        {
                            TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            ShowHistory();
                            break;
                        }
                    case 6:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }


                //termination condition
            } while (flag);

        }

        public void ShowDetails()
        {
            Console.WriteLine($"|{currentLoggedStudent.StudentID,-15} |{currentLoggedStudent.StudentName} | {currentLoggedStudent.FatherName,-15} | {currentLoggedStudent.DOB,-15} | {currentLoggedStudent.Gender,-15}|{currentLoggedStudent.MobileNumber,-15}|{currentLoggedStudent.Email,-15}|{currentLoggedStudent.Physics,-15}|{currentLoggedStudent.Chemistry,-15}|{currentLoggedStudent.Maths,-15}");
        }
        public void CheckEligibity()
        {
            System.Console.WriteLine(currentLoggedStudent.IsELigible(75)?"You are eligible":" You are not Eligible");
        }
        public void TakeAdmission()
        {
            //show department details
            foreach(DepartmentDetails departmentData in departments)
            {
                Console.WriteLine($"|{departmentData.DepartmentID,-15} | {departmentData.DepartmentName,-15} | {departmentData.NumberOfSeats,-15}");
            }
            //Ask and get department id
            Console.WriteLine("Enter Department ID");
            string departmentID=Console.ReadLine().ToUpper();
            //traverse and check department id is valid/not
            bool flag = true;
            foreach(DepartmentDetails department in departments)
            {
                if(department.DepartmentID.Equals(departmentID)){
                    flag = false;
                    //if valid then check seat availability in that department - if not then show seats are filled in this department
                    if(department.NumberOfSeats>0){
                        //if seats available then check student is eligible or not - if not eligible then show you are not eligible for this
                        if(currentLoggedStudent.IsELigible(75)){
                            
                                 //if eligible then check student was taken the admission already
                                 //if he was not taken any admission then reduce the department seat count.
                                 bool admissionTakenFlag = true;
                                 foreach(AdmissionDetails admission in admissionDetails){
                                    if((admission.StudentID.Equals(currentLoggedStudent.StudentID)) && (admission.AdmissionStatus.Equals(AdmissionStatus.Booked)) && (admission.DepartmentID.Equals(departmentID)))
                                    {
                                        admissionTakenFlag=false;
                                        Console.WriteLine("you are already taken admission");
                                        break;
                                    }

                                 }
                                 if(admissionTakenFlag){
                                        department.NumberOfSeats--;
                                        AdmissionDetails currentAdmission = new(currentLoggedStudent.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Booked);
                                        admissionDetails.Add(currentAdmission);
                                        Console.WriteLine("Admission Taken sucessfully");
                                        break;
                                    }
                        }
                        else{
                            Console.WriteLine("your are not eligible for taking admission");
                        }

                    }
                    else{
                        Console.WriteLine("All seats are filled");
                    }

                }
            }
            //if id is valid then show invalid department id
            Console.WriteLine(flag?"Invalid department ID":" ");
            
           
            //create admission object and add to the list
            //show admission taken successfully.

        }
        public void CancelAdmission()
        {
            
            System.Console.WriteLine("Cancel Admission");
            Console.WriteLine("Are you sure? do you still want to cancel your admission");
            string choise = Console.ReadLine().ToLower();
            if(choise =="yes"){
                bool flag= true;
                //traverse and find the current login student's admission entry whose status is Booked.
                foreach(AdmissionDetails admission in admissionDetails){
                    if(admission.StudentID.Equals(currentLoggedStudent.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Booked)){
                           //if found return the seat to department
                           foreach(DepartmentDetails department in departments){
                            if(department.DepartmentID.Equals(admission.DepartmentID)){
                                department.NumberOfSeats++;
                                break;
                            }
                           }
                          //change the admission status to cancelled.
                          admission.AdmissionStatus=AdmissionStatus.Cancelled;
                      flag = false;
                      Console.WriteLine("Admission cancelled sucessfully!");
                      break;
                    }
                }
                Console.WriteLine(flag?"No Admission history":" ");
                

            }

        }
        public void ShowHistory()
        {
            System.Console.WriteLine("History of admission");
            bool flag=true;
            foreach(AdmissionDetails admissionData in admissionDetails){
                if(admissionData.StudentID.Equals(currentLoggedStudent.StudentID)){
                Console.WriteLine($"|{admissionData.StudentID,-15} | {admissionData.DepartmentID,-15} | {admissionData.AdmissionDate,-15} | {admissionData.AdmissionStatus}");
                flag = false;

                }

            }
            Console.WriteLine(flag?"No admission history found":" ");

        }

    }

}
