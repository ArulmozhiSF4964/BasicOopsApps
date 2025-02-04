/*using System;
using System.Collections.Generic;

namespace CollageAdmission;

public class Program
{
    public static void Main(string[] agrs)
    {
        //student 1
        List<StudentDetails> students = new List<StudentDetails>();
        string option ="";

        do
        {
        //copy of the that blueprint student deetails
        StudentDetails student1 = new StudentDetails();
        Console.WriteLine("Enter your name:");
        student1.Name = Console.ReadLine();
        Console.WriteLine("Enter your father's name:");
        student1.FatherName = Console.ReadLine();
        Console.WriteLine("Enter your gender:");
        student1.Gender = Console.ReadLine();
        Console.WriteLine("Enter your dob:");
        student1.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine("Enter your physics mark:");
        student1.Physic
        
        s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your chemistry mark:");
        student1.Chemistry = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your maths mark:");
        student1.Maths = int.Parse(Console.ReadLine());
        students.Add(student1);

        //Termination condition
        System.Console.WriteLine("Do you want to continue");
        option = Console.ReadLine();
        }while (option.ToLower() == "yes");

        foreach (StudentDetails student in students)
        {
            System.Console.WriteLine($"Student Details:\nName:{student.Name}\nFatherName:{student.FatherName}\nGender:{student.Gender}\nDate of Birth:{student.DOB}\nPhysics Mark:{student.Chemistry}\nChemistry Mark:{student.Chemistry}\nMaths mark:{student.Maths}");

        }


    }

}*/

using System;
using System.Collections.Generic;
using CollegeAdmissionLibrary;

namespace Application;

public class Program
{
    public static void Main(string[] agrs)
    {
        //student 1
        List<StudentDetails> students = new List<StudentDetails>();
        string option ="";

        do
        {
            //copy of the that blueprint student deetails
       
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your father's name:");
        string fatherName = Console.ReadLine();
        /*Console.WriteLine("Enter your gender: 1. male 2.female 3.Transgender");
        GenderDetails gender1 = (GenderDetails) int.Parse(Console.ReadLine());*/

        Console.WriteLine("Enter your gender: 1. male 2.female 3.Transgender");
        GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(),true);//true for ignoring case


        //string Gender = Console.ReadLine();
        Console.WriteLine("Enter your dob:");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine("Enter your physics mark:");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your chemistry mark:");
        int chemistry = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your maths mark:");
        int maths = int.Parse(Console.ReadLine());

        StudentDetails student1 = new StudentDetails(name,fatherName,gender,dob,physics,chemistry,maths);
        students.Add(student1);
        Console.WriteLine($"Your Registration successful.ID{student1.StudentID}");

        //Termination condition
        System.Console.WriteLine("Do you want to continue");
        option = Console.ReadLine();
        
        }while (option.ToLower() == "yes");

        System.Console.WriteLine("Enter Id:");
        string studentID = Console.ReadLine().ToUpper();

        foreach (StudentDetails student in students)
        {
            if(studentID.Equals(student.StudentID)){
                System.Console.WriteLine($"Student Details:\n ID{student.StudentID}\nName:{student.Name}\nFatherName:{student.FatherName}\nGender:{student.Gender}\nDate of Birth:{student.DOB}\nPhysics Mark:{student.Chemistry}\nChemistry Mark:{student.Chemistry}\nMaths mark:{student.Maths}");
                if(student.IsELigible(75)){
                          System.Console.WriteLine("You are elibigle for admiision");
                 }
                else{
                      System.Console.WriteLine("You are not eligible");
                }

            }
            
        }


    }

}
