using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EBBillCalculation;
public class Program
{
    public static void Main(String[] args)
    {
        List<ElectricBill> EBUsers = new List<ElectricBill>();
        Console.WriteLine("1.Registration\n2.Login\n3.Exit");
        Console.WriteLine("Enter the option which you want to perform:");
        int option1 = int.Parse(Console.ReadLine());
        do
        {

            switch (option1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your phone number:");
                        long phonenumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your mailId:");
                        string mailId = Console.ReadLine();
                        ElectricBill users = new ElectricBill(name, phonenumber, mailId);
                        EBUsers.Add(users);
                        Console.WriteLine("Your Registration was sucessful!!! and your MeterId is :" + users.MeterID);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your MeterID:");
                        string ID = Console.ReadLine();
                        bool elementFound = true;
                        foreach (ElectricBill users in EBUsers)
                        {
                            if (users.MeterID == ID)
                            {
                                elementFound = false;
                                Console.WriteLine("What do you want to do?\n1.Calculate Amount\n2.Display Details\n.Exit");
                                int option3 = int.Parse(Console.ReadLine());
                                do
                                {
                                    switch (option3)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter the number of units used:");
                                                int unitsUsed = int.Parse(Console.ReadLine());
                                                users.CalculateAmount(unitsUsed);
                                                Console.WriteLine("Your bill is: " + users.Bill);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine($"Your Details:/n Your MeterID: {users.MeterID} Your name is: {users.UserName} Your Phone number: {users.PhoneNumber} Your MailID is: {users.MailId} Your Bill amount is: {users.Bill}");
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter correct option");
                                                break;

                                            }
                                    }
                                    Console.WriteLine("What do you want to do?\n1.Calculate Amount\n2.Display Details\n3.Exit");
                                    option3 = int.Parse(Console.ReadLine());

                                } while (option3 != 3);
                            }
                        }
                        if (elementFound)
                        {
                            Console.WriteLine("Invalid MeterID");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the correct option");
                        break;
                    }
            }
            Console.WriteLine("1.Registration\n2.Login\n3.Exit");
            Console.WriteLine("Enter the option which you want to perform:");
            option1 = int.Parse(Console.ReadLine());

        } while (option1 != 3);
    }
}
