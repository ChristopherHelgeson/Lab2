using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean goAgain = true;
                
            while (goAgain == true)
            {
                Console.Clear();
                Console.WriteLine("Grand Circus C# .NET Lab 2");
                Console.Write("\nPlease enter an integer from 1 to 100, inclusive: ");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("\nYou entered the integer " + userInput + ".");

                if (userInput % 2 == 1)
                {
                    Console.WriteLine(userInput + " is an ODD number.");
                }
                else if (userInput <= 25)
                {
                    Console.WriteLine(userInput + " is an EVEN number and is less than 25.");
                }
                else if (userInput >= 25 && userInput <= 60)
                {
                    Console.WriteLine(userInput + " is an EVEN number and is greater than 25 and less than or equal to 60.");
                }
                else
                {
                    Console.WriteLine(userInput + " is an EVEN number and is greater than 60.");
                }

                Console.Write("\nWould you like me to evaluate another number?");
                Console.WriteLine("\n\t1) Yes\n\t2) No");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        goAgain = true;
                        break;
                    case 2:
                        goAgain = false;
                        Console.WriteLine("Thanks for playing.");
                        Console.WriteLine("\nPress any key to continue . . .");
                        Console.ReadLine();
                        break;
                    default:
                        goAgain = false;
                        Console.WriteLine("Answers other than 1 or 2 are interpretted as No");
                        Console.WriteLine("Thanks for playing.");
                        Console.WriteLine("\nPress any key to continue . . .");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
