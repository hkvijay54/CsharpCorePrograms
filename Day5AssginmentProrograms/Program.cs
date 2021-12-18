using System;
// Program to Check Whether a Number is Even or Odd.
class Program
{
    static void Main(string[] args)
    {
        int num1, rem1;

        Console.WriteLine("Input an integer : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        rem1 = num1 % 2;

        if (rem1 == 0)
            Console.WriteLine("{0} is an even integer", num1);
        else
            Console.WriteLine("{0} is an odd integer", num1);
    }
}