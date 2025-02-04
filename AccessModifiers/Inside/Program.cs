using System;
namespace Inside;
class Program{
    public static void Main(string[] args){
        Son son = new();
        System.Console.WriteLine(son.PublicNumber);
        System.Console.WriteLine(son.PrivateNumber);
        System.Console.WriteLine(son.PrivateOutNumber);
        System.Console.WriteLine(son.InternalParentNumber);

    }
}
