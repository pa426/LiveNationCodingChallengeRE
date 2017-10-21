using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LiveNationCodingChallenge
{
    public class Program
    {
        private static int[] numberRange;

        public static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("***                                                                       ***");
            Console.WriteLine("***                          FizzBuzz v0.1                                ***");
            Console.WriteLine("***                                                                       ***");
            Console.WriteLine("***   Please insert a number range separated by comma and press ENTER,    ***");
            Console.WriteLine("***                     or 'q' and ENTER to quit.                         ***");
            Console.WriteLine("***                                                                       ***");
            Console.WriteLine("*****************************************************************************");

            string choice = "";

            while (choice != "q")
            {
                choice = Console.ReadLine();
                Console.Clear();

                if (CheckForErorrs(choice))
                {
                    var result = CheckNumbers(numberRange);

                    Console.WriteLine("\n" + result);

                    Console.WriteLine(
                        "\nPlease insert a new number range separated by comma and press ENTER or 'q' and ENTER to quit.");
                }
            }

            Environment.Exit(0);
        }

        public static bool CheckForErorrs(string choice)
        {
            bool check = true;
            string errorHandling = "";

            try
            {
                numberRange = choice.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                if (numberRange.Length != 2)
                {
                    throw new Exception();
                }
            }
            catch
            {
                check = false;
                errorHandling = "Please insert a valid range.";
            }

            if (errorHandling != "")
            {
                Console.Error.WriteLine(errorHandling);
            }

            return check;
        }

        public static string CheckNumbers(int[] numberRange)
        {
            ReverseArrayValues(numberRange);

            string result = "result: ";
            string summary = "summary: ";
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;
            int intCount = 0;

            for (int i = numberRange[0]; i <= numberRange[1]; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    fizzBuzzCount++;
                    result += "fizzbuzz ";
                }
                else
                {
                    if ((i % 3) == 0)
                    {
                        fizzCount++;
                        result += "fizz ";
                    }
                    if ((i % 5) == 0)
                    {
                        buzzCount++;
                        result += "buzz ";
                    }
                    if ((i % 3 != 0) && (i % 5 != 0))
                    {
                        intCount++;
                        result += i + " ";
                    }
                }
            }

            summary += "fizz:"+fizzCount+", buzz:"+buzzCount+", fizzbuzz:"+fizzBuzzCount+", integer:" + intCount;

            return result + "\n" + summary;
        }

        public static int[] ReverseArrayValues(int[] numberRange)
        {
            Array.Sort(numberRange);
            return numberRange;
        }
    }
}