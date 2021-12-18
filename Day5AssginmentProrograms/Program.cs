using System;
// prime factorisation.
class Program
{
    public static void PrimeFact(int n)
    {
        while (n % 2 == 0)
        {
            Console.Write(2 + " ");
            n /= 2;
        }
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while(n%i == 0)
            {
                Console.Write(i + " ");
                n /= i;
            }
        }
        if(n>2)
        {
            Console.Write(n);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int n = Convert.ToInt32(Console.ReadLine());
        PrimeFact(n);
    }
}