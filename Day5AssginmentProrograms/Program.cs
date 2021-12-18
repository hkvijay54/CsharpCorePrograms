using System;
// Harmonic value
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");  
        int num = Convert.ToInt32(Console.ReadLine());
        float res=1;
        for(int i=1;i<=num;i++)
        {
            res = (res + 1) / i;
            if(i == 1)
            {
                Console.Write("1 + ");
            }
            else if(i == num)
            {
                Console.Write("1/" + i + " = " + res);
            }
            else
            {
                Console.Write("1/" + i + " +");
            }
        }
    }
}