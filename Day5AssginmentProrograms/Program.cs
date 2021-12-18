using System;
// Program to Compute Quotient and Remainder.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Divident");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Divisor");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
    }
}