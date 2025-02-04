using System;
namespace StaticElements;
class Program{
    public static void Main(string[] args)
    {
        StudentDetails student = new StudentDetails()
        {
            Name = "Arul"
        };
        StudentDetails student1 = new ()
        {
            Name = "Arul1"
        };
        StudentDetails student2 = new ()
        {
            Name = "Arul2"
        };
        TrainerDetails.ShowData();
        TrainerDetails.Name="Baskaran";
        TrainerDetails.TrainerID="SF4002";

    }
}