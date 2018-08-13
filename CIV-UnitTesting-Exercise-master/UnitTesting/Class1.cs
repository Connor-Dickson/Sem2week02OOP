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
            var ans = RecursiveCalculations.FibocacciRec(0, 1, 3);
            Assert.AreEqual(3 , ans); //method is returning incorrect value
        }
        [TestCase]
        public void When_FactorialRec_Expect_Factresult()
        {
            var ans = RecursiveCalculations.FactorialRec(4, 1);
            Assert.AreEqual(24, ans);
        }
        [TestCase]
        public void When_FibCheck_Expect_FibonacciNumber()
        {
            var ans = RecursiveCalculations.FibCheck(13);
            Assert.AreEqual(true, ans);
        }
        [TestCase]
        public void When_PrimeCheckRec_Expect_PrimeNumber()
        {
            var ans = RecursiveCalculations.PrimeCheckRec(5, 2);
            Assert.AreEqual(true, ans);
        }
    } 
}
