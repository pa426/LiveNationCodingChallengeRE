using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNationCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert a number range separated by comma and press ENTER or 'q' to quit.");

            string choice = "";

            while (choice != "q")
            {
                choice = Console.ReadLine();
                Console.Clear();

                try
                {
                    int[] numberRange = choice.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                    if (numberRange.Length != 2)
                    {
                        throw new Exception("");
                    }

                    for (int i = numberRange[0]; i <= numberRange[1]; i++)
                    {
                        if ((i % 5 == 0) && (i % 3 == 0))
                        {
                            Console.Write("fizzbuzz ");
                        }
                        else
                        {
                            if ((i % 3) == 0)
                            {
                                Console.Write("fizz ");
                            }
                            if ((i % 5) == 0)
                            {
                                Console.Write("buzz ");
                            }
                            if ((i % 3 != 0) && (i % 5 != 0))
                            {
                                Console.Write(i + " ");
                            }
                        }

                    }

                    Console.WriteLine("\nPlease insert a new number range separated by comma and press ENTER or 'q' to quit.");
                }
                catch
                {
                    Console.Error.WriteLine("Please insert a valid range.");
                }
            }

            Environment.Exit(0);
        }
    }
}
