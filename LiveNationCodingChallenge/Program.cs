using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNationCodingChallenge
{
    public class Program
    {
        private static int[] numberRange;
        public static void Main(string[] args)
        {

            Console.WriteLine("Please insert a number range separated by comma and press ENTER or 'q' to quit.");

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
                        "\nPlease insert a new number range separated by comma and press ENTER or 'q' to quit.");
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

            if (numberRange[0] > numberRange[1])
            {
                var temp = numberRange[0];
                numberRange[0] = numberRange[1];
                numberRange[1] = temp;
            }

            string result = "";

            for (int i = numberRange[0]; i <= numberRange[1]; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    result += "fizzbuzz ";
                }
                else
                {
                    if ((i % 3) == 0)
                    {
                        result += "fizz ";
                    }
                    if ((i % 5) == 0)
                    {
                        result += "buzz ";
                    }
                    if ((i % 3 != 0) && (i % 5 != 0))
                    {
                        result += i + " ";
                    }
                }
            }
            return result;
        }

    }
}
