using System;

class Program
{

    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;
    // }


    class Circle 
    {

        private double _radius;

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("error, radius must > 0");
                return;
            }
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }


        public double GetArea()
        {
            return Math.PI*_radius*_radius;
        }

    }
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
        Console.WriteLine($"{myCircle.GetArea()}");
    }
}