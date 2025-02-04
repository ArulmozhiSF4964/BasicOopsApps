




try
{
       
    int number1,number2;
    Console.WriteLine("Enter number1");
    while(!int.TryParse(Console.ReadLine(),out number1))
    {
        System.Console.WriteLine("Invalid format. re- Renter again");
    }
    Console.WriteLine("Enter number2");
    while(!int.TryParse(Console.ReadLine(),out number2))
    {
        System.Console.WriteLine("Invalid format. re- Renter again");
    }

    int result = number1 / number2;
    Console.WriteLine(result);

}
catch(DivideByZeroException e){
    System.Console.WriteLine("Infinity");
}
catch(Exception e){
    System.Console.WriteLine(e.Message);
    System.Console.WriteLine(e.StackTrace);
}
System.Console.WriteLine("Out of code");

