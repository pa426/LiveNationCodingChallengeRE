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
        public void CheckForErorrsTest1()//Check random input
        {
            var check = Program.CheckForErorrs("sadfasdfasd");
            Assert.AreEqual(false, check);
        }

        [TestMethod()]
        public void CheckForErorrsTest2()//Check incorect input
        {
            var check = Program.CheckForErorrs(",1,3,5");
            Assert.AreEqual(false, check);
        }

        [TestMethod()]
        public void CheckForErorrsTest3()//Check negative integers input
        {
            var check = Program.CheckForErorrs("-15,15");
            Assert.AreEqual(true, check);

        }

        [TestMethod()]
        public void CheckForErorrsTest4()//Check valid input
        {
            var check = Program.CheckForErorrs("1,1669");
            Assert.AreEqual(true, check);
        }

        [TestMethod()]
        public void CheckForErorrsTest5()//Check only one valid input
        {
            var check = Program.CheckForErorrs("1,sdfsd");
            Assert.AreEqual(false, check);
        }

        [TestMethod()]
        public void CheckForErorrsTest6()//Check for max Int32 values
        {
            var check = Program.CheckForErorrs("-2147483648,2147483647");
            Assert.AreEqual(true, check);
        }

        [TestMethod()]
        public void ReverseArrayValuesTest1()//Check for valid input
        {
            int[] testArr = new[] {0, 15};
            var sortedArray = Program.ReverseArrayValues(testArr);
            bool check = !(sortedArray[0] > sortedArray[1]);
            Assert.AreEqual(true, check);
        }

        [TestMethod()]
        public void ReverseArrayValuesTest2()//Check for wrong input
        {
            int[] testArr = new[] { 34, -15 };
            var sortedArray = Program.ReverseArrayValues(testArr);
            bool check = !(sortedArray[0] > sortedArray[1]);
            Assert.AreEqual(true, check);
        }
       
    }
}