using System;
// Flip Coin and print percentage of Heads and Tails.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Year : ");  
            int Year = Convert.ToInt32(Console.ReadLine());
        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);  
            else Console.WriteLine("{0} is not a Leap Year.", Year); 
    }
}