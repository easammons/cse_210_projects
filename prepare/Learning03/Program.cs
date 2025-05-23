using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(6);
        Fraction frac3 = new Fraction(6, 7);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac2.GetFractionString());
        frac2.Top = 3;
        frac2.Bottom = 7;
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac3.GetFractionString());

        double value = Math.Round(frac3.GetDecimalValue(), 3);
        Console.WriteLine(value);
    }
}