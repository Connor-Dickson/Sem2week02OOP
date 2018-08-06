using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CIV_UnitTesting_Exercises;

namespace UnitTesting
{
    [TestFixture]
    public class Fibonaccitests
    {
        [TestCase]
        public void When_FibocacciRec_Expect_FibonacciNumber()
        {
            RecursiveCalculations.FibocacciRec(1, 1, 6);
            Assert.AreEqual()
        }
    } 
}
