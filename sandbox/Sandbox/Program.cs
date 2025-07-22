using System;

class Program
{

    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;
    // }
    static void TestByRef(int x, ref string n)
    {
        x++;
        n += " Plus Betty";
        Console.WriteLine($"In TestByRef: {x}, {n}");
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int? x = null;
        string name = "Betty";

        int y = x ?? 29;
        Console.WriteLine(y);

        name ??= "Bob";
        Console.WriteLine(name);

        string myName = null;
        int? length = myName?.Length;
        Console.WriteLine(length);

        int bobsAge = 23;
        int bettysAge = 31;
        string whoIsOlder = bobsAge > bettysAge ? "Bob is older" : "Betty is older";
        Console.WriteLine(whoIsOlder);


        // int z = 10;
        // string name = "Bob";

            // TestByRef(z, ref name);
            // Console.WriteLine($"In main: {z}, {name}");

            // int index = 0;
            // int duration = 9;
            // DateTime currentTime = DateTime.Now;
            // DateTime endTime = currentTime.AddSeconds(duration);
            // int sleepTime = 250;
            // int count = duration;

            // string animationString = "(^_^)(-_-)";
            // string animationString2 = "\\|/-";

            // // while (DateTime.Now < endTime)
            // // {
            // //     Console.Write(animationString[0..5]));
            // //     Thread.Sleep(sleepTime);
            // //     Console.Write("\b\b\b\b\b");
            // //     Console.Write(animationString[5..]);
            // //     Thread.Sleep(sleepTime);
            // //     Console.Write("\b\b\b\b\b");

            // // }

            // while (DateTime.Now < endTime)
            // {
            //     Console.Write(animationString2[index++ % animationString2.Length]);
            //     Thread.Sleep(sleepTime);
            //     Console.Write("\b");

            // }



            // while (DateTime.Now < endTime)
            // {
            //     Console.Write(count--);
            //     Thread.Sleep(1000);
            //     Console.Write("\b");

            // }

            // while (DateTime.Now < endTime)
            //     {
            //         Console.Write("+");
            //         Thread.Sleep(sleepTime);
            //         Console.Write("\b");
            //         Console.Write("-");
            //         Thread.Sleep(sleepTime);
            //         Console.Write("\b");
            //     }

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


            // Circle myCircle = new Circle();
            // myCircle.SetRadius(10);
            // Console.WriteLine($"{myCircle.GetRadius()}");
            // Circle myCircle2 = new Circle();
            // myCircle2.SetRadius(20);
            // Console.WriteLine($"{myCircle2.GetRadius()}");

            // Console.WriteLine($"{myCircle.GetArea()}");
            // Console.WriteLine($"{myCircle2.GetArea()}");

            // Cylinder myCylinder = new Cylinder();
            // myCylinder.SetHeight(10);
            // myCylinder.SetCircle(myCircle);
            // Console.WriteLine($"{myCylinder.GetVolume()}");

    }
}