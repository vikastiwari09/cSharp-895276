// See https://aka.ms/new-console-template for more information
using System;

class Interval
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        bool belongsToI = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);

        Console.WriteLine($"x {(belongsToI ? "belongs to" : "does not belong to")} I");
    }
}

