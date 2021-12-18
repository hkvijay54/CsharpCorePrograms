using System;
// Program to Swap Two Numbers.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Second Number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int temp;

        Console.WriteLine("Before swapping");
        Console.WriteLine("first number: "+num1+" second number: "+num2);

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After swapping");
        Console.WriteLine("first number: " + num1 + " second number: " + num2);
    }
}