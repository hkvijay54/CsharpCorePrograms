using System;
// Power of 2.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");  
        int num = Convert.ToInt32(Console.ReadLine());
        double res;
        for(int i=0;i<=num;i++)
        {
            res = Math.Pow(2, i);
            Console.WriteLine("2^" + i + "= " + res);
        }
    }
}