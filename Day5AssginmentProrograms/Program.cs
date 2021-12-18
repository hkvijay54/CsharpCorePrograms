using System;
// C# Program to Check Whether an Alphabet is Vowel or Consonant.
class Program
{
    static void Main(string[] args)
    {
        char ch;
        Console.Write("Input an Alphabet (A-Z or a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        int i = ch;
        if (i >= 48 && i <= 57)
        {
            Console.Write("You entered a number, Please enter an alpahbet.");
        }
        else
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The {0} Alphabet is vowel",ch);
                    break;
                case 'i':
                    Console.WriteLine("The {0} Alphabet is vowel", ch);
                    break;
                case 'o':
                    Console.WriteLine("The {0} Alphabet is vowel", ch);
                    break;
                case 'u':
                    Console.WriteLine("The {0} Alphabet is vowel", ch);
                    break;
                case 'e':
                    Console.WriteLine("The {0} Alphabet is vowel", ch);
                    break;
                default:
                    Console.WriteLine("The {0} Alphabet is Consonant", ch);
                    break;
            }
        }
    }
}