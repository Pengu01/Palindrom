using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifinput = "";
            string input;
            Console.WriteLine("Är Palindrom?");
            input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ifinput = ifinput + input[i];
            }
            if (input == ifinput)
            {
                Console.WriteLine("Ja\n" + ifinput);
            }
            else Console.WriteLine("Nej\n" + ifinput);
        }
    }
}
