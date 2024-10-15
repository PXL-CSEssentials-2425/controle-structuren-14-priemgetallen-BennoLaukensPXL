using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                bool isPriemNumber = true;
                for (int check = 2; check <=number/2; check++)
                {
                    if (number % check == 0)
                    {
                        isPriemNumber = false;
                    }
                }
                if (isPriemNumber && number != 1)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;


                Console.Write($"{number}\t");
                Console.ResetColor();


                if (number % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
