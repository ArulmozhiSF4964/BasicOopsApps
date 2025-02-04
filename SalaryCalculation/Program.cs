using System;
using System.Collections.Generic;
namespace SalaryCalculation;
public class Program
{
    public static void Main(string[] args)
    {

        List<EmployeeDetails> employees = new List<EmployeeDetails>();
        Console.WriteLine("1.Registration \n2.Login \n3.Exit");
        Console.WriteLine("Enter the option which you want to perform:");
        int option1 = int.Parse(Console.ReadLine());
        do
        {

            switch (option1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name :");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter your Role :");
                        string role = Console.ReadLine();
                        Console.WriteLine("Enter your gender :");
                        GenderClassification employeeGender = Enum.Parse<GenderClassification>(Console.ReadLine(), true);
                        Console.WriteLine("Enter your Work Location :");
                        LocationClassification employeeWorkLocation = Enum.Parse<LocationClassification>(Console.ReadLine(), true);
                        Console.WriteLine("Enter your team name :");
                        string teamName = Console.ReadLine();
                        Console.WriteLine("Enter your DOJ :");
                        DateTime employeeDOJ = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("Enter your password :");
                        string userPassword = Console.ReadLine();
                        EmployeeDetails employee = new EmployeeDetails(employeeName, role, employeeGender, employeeWorkLocation, teamName, employeeDOJ, userPassword);
                        employees.Add(employee);
                        Console.WriteLine($"Your Registeration Successful and your EmployeeID is  {employee.EmployeeID}");
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Enter your ID:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string password = Console.ReadLine();

                        bool elementFound = true;
                        foreach (EmployeeDetails employee in employees)
                        {

                            if (employee.EmployeeID == ID && employee.Password == password)
                            {
                                elementFound = false;
                                Console.WriteLine("What do you want do to? \n1.Calculate salary \n2.Display Details \n3.exit");
                                int option3 = int.Parse(Console.ReadLine());
                                do
                                {

                                    switch (option3)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter the year:");
                                                int year = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter the month for which you want to calculate salary:");
                                                int month = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter the number of days leave taken:");
                                                int leave = int.Parse(Console.ReadLine());

                                                long month_Salary = employee.SalaryCal(year, month, leave);

                                                Console.WriteLine("Your salary is : " + month_Salary);
                                                break;

                                            }
                                        case 2:
                                            {
                                                Console.WriteLine($"Your EmployeeId is:{employee.EmployeeID}\n Your Name is: {employee.Name}\n Your Role is: {employee.Role}\nYour Gender is: {employee.Gender}\nYour Worklocation is {employee.WorkLocation}Your team name is: {employee.TeamName}\nYour Date of joining is:{employee.DOJ}");
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter correct option.");
                                                break;
                                            }
                                    }
                                    Console.WriteLine("What do you want do to? \n1.Calculate salary \n2.Display Details \n3.exit");
                                    option3 = int.Parse(Console.ReadLine());
                                } while (option3 != 3);
                            }
                        }
                        if (elementFound)
                        {
                            Console.WriteLine("Invalid Employee ID and password. please try Again!!!");
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Enter the correct option");
                        break;
                    }

            }
            Console.WriteLine("1.Registration \n2.Login \n3.Exit");
            Console.WriteLine("Enter the option which you want to perform:");
            option1 = int.Parse(Console.ReadLine());
        } while (option1 != 3);
    }
}
