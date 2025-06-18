using System;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        List<Shape> myshapes = new List<Shape>();

        Square mySquare = new Square("Red", 4);
        myshapes.Add(mySquare);
        Rectangle myRectangle = new Rectangle("Purple", 4, 6);
        myshapes.Add(myRectangle);
        Circle myCircle = new Circle("Yellow", 4);
        myshapes.Add(myCircle);

        // string color = myCircle.Color;
        // double area = myCircle.GetArea();
        // Console.WriteLine(color);
        // Console.WriteLine(area);


        foreach (Shape s in myshapes)
        {
            string color = s.Color;
            double area = s.GetArea();

            Console.WriteLine($"This shape is {color} with an area of {area}.");
        }
    }
}