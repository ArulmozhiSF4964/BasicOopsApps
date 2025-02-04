using System;
namespace MethodAssignment;
class Program{
    public static void Main(string[] args){
        String confirmation="no";

        do{
        // Getting the input value from user
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());


        //Displaying the menu
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("Enter the option you want to perform:");
        string option = Console.ReadLine();


        //performing the switch operation
        switch(option){
            case "1":
            {
                Console.WriteLine("Addition value "+Add(number1,number2));
                break;
            }
            case "2":
            {
                Console.WriteLine("Subtraction value "+Sub(number1,number2));
                break;
            }
            case "3":
            {
                Console.WriteLine("Multiplication value "+Multiply(number1,number2));
                break;
            }
            case "4":
            {
                Console.WriteLine("Division value "+Divide(number1,number2));
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input");
                break;
            }

        }
        //Asking the user if want to continue
        Console.WriteLine("Do you want continue?yes/no:");
        confirmation=Console.ReadLine();


        }while(confirmation=="yes");
        
    }
    //Addition operation
    public static int Add(int number1,int number2){
            int addValue=number1+number2;
            return addValue;
    }
    //Subtraction operation
    public static int Sub(int number1,int number2){
            int subValue=number1+number2;
            return subValue;
    }
    //Multiplication operation
    public static long Multiply(int number1,int number2){
            long mulValue=number1*number2;
            return mulValue;
    }
    //Division operation
    public static int Divide(int number1,int number2){
            int divValue=number1/number2;
            return divValue;
    }

}
