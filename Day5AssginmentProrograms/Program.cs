using System;
// C# Program to Find the Largest Among Three Numbers
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the 1st number :");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three: "+num1);
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three: "+num2);
            }
        }
        else if (num2 > num3)
            Console.WriteLine("The 2nd Number is the greatest among three: "+num2);
        else
            Console.WriteLine("The 3rd Number is the greatest among three: "+num3);
    }
}