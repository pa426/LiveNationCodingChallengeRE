using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveNationCodingChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LiveNationCodingChallenge.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckNumberTestStringFormat() //Test to check is the output is in the corect format
        {
           
            int[] numberRange = "45,25".Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            var result = Program.CheckNumbers(numberRange);
            var check = true;
            var resultRange = result.Split(' ').Select(n => n).ToArray();

            foreach (string str  in resultRange)
            {
                int nr = 0;
                int.TryParse(str, out nr);

                if (str != "fizz" && str != "buzz" && str != "fizzbuzz" && str != "" && nr == 0)
                {
                    check = false;
                }
            }

            Assert.AreEqual(true, check);
        }

        [TestMethod()]
        public void CheckForErorrsTest1()
        {
            
        }

        [TestMethod()]
        public void CheckForErorrsTest2()
        {

        }

        [TestMethod()]
        public void CheckForErorrsTest3()
        {

        }

        [TestMethod()]
        public void CheckForErorrsTest4()
        {

        }

        [TestMethod()]
        public void CheckForErorrsTest5()
        {

        }
    }
}