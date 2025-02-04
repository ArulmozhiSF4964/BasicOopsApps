using System;
using System.Collections.Generic;
namespace BankingApp;

public class Program
{
    public static void Main(string[] args)
    {

        List<BankAccountOpening> Customers = new List<BankAccountOpening>();
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
                        string customerName = Console.ReadLine();
                        Console.WriteLine("Enter your gender :");
                        GenderClassification customerGender = Enum.Parse<GenderClassification>(Console.ReadLine(), true);
                        Console.WriteLine("Enter your phonenumber :");
                        long customerPhonenumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your mailId :");
                        string customerMailID = Console.ReadLine();
                        Console.WriteLine("Enter your DOB :");
                        DateTime customerDOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("Enter your password :");
                        string customerPassword = Console.ReadLine();

                        BankAccountOpening account = new BankAccountOpening(customerName, customerGender, customerPhonenumber, customerMailID, customerDOB, customerPassword);

                        Customers.Add(account);

                        Console.WriteLine($"Your Registeration Successful and your CustomerId is  {account.CustomerID}");
                        break;

                    }

                case 2:
                    {
                        Console.WriteLine("Enter your ID:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string password = Console.ReadLine();

                        bool elementFound = true;
                        foreach (BankAccountOpening account in Customers)
                        {

                            if (account.CustomerID.Equals(ID) && account.Password.Equals(password))
                            {
                                elementFound = false;
                                int option3;
                                do
                                {
                                    Console.WriteLine("What do you want do to? \n1.deposit \n2.Withdraw \n3.Current Balance \n4.exit");
                                    option3 = int.Parse(Console.ReadLine());
                                    switch (option3)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter the amount you deposit:");
                                                int depAmount = int.Parse(Console.ReadLine());
                                                account.Deposit(depAmount);
                                                Console.WriteLine("Now your current balance is" + account.Balance);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Enter the amount you want to withdraw:");
                                                int withdrawAmount = int.Parse(Console.ReadLine());
                                                if (withdrawAmount > account.Balance)
                                                {
                                                    Console.WriteLine("Your Balance is not enough to withdraw this amount");
                                                }
                                                else if (account.Balance < 0)
                                                {
                                                    Console.WriteLine("You have insufficient balance");
                                                }
                                                else
                                                {
                                                    account.Withdraw(withdrawAmount);
                                                    Console.WriteLine("Now your current balance is" + account.Balance);
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Your current balance is " + account.Balance);
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter the correct option");
                                                break;
                                            }

                                    }
                                } while (option3 != 4);
                            }
                        }

                        if (elementFound)
                        {
                            Console.WriteLine("Invalid CustomerID and password. please try Again!!!");
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