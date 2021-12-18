using System;
// Flip Coin and print percentage of Heads and Tails.
class Program
{
    static void Main(string[] args)
    {
        float headcount = 0;
        float tailcount = 0;
        Random rand = new Random();
        for (int i = 0; i <= 100; i++)
        {
            int flip = rand.Next(0, 2);
            //Console.WriteLine(i + " . " + flip);
            if (flip == 1)
            {
                headcount++;
            }
            else
            {
                tailcount++;
            }
        }
        Console.WriteLine("count of heads are " + (headcount/100)*100 + "%");
        Console.WriteLine("count of tails are " + (tailcount/100)*100 + "%");

    }
}