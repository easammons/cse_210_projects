using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jack Skellington", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jim Jimothy", "Irrationall numbers", "12.3", "2-7");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Sunny Jack", "Alexander the Great", "Roman Cities");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());


    }
}