using System;

class Program
{

    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;
    // }


    
    static void Main(string[] args)
    {
        // //Console.WriteLine("Hello Sandbox World!");

        // Console.WriteLine("Input your first name: ");
        // string firstName = Console.ReadLine();
        // Console.WriteLine($"Your first name is: {firstName}");

        // Console.WriteLine("Input your last name: ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"Your full name is: {firstName} {lastName}");

        // int x = 10;
        // if (x == 10)
        // {
        //     Console.WriteLine("x is 10");
        // }

        // Console.WriteLine("Hey how are you? ");

        // Console.WriteLine("Hey baby how you doin? ");

        // double total = AddNumbers(123.90, 985.12356);
        // Console.WriteLine(total);

        // bool done = false;
        // while(done)
        // {
        //     // . . . 
        //     done = true;
        // }

        //Console.WriteLine("Hello World!");


        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");
        
    }
}