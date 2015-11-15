using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TravisSample.Test
{
    [TestFixture]
    public class TestCalculator
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [TestCase(1,2,3)]
        [TestCase(1,4,5)]
        [TestCase(3,2,5)]
        [TestCase(1,7,8)]
        public void TestAdd(int a, int b, int sum)
        {
            Assert.AreEqual(sum, _cal.Add(a, b));
        }

        [TestCase(10, 2, 8)]
        [TestCase(11, 4, 7)]
        [TestCase(13, 2, 11)]
        [TestCase(12, 7, 5)]
        public void TestSubtract(int a, int b, int sub)
        {
            Assert.AreEqual(sub, _cal.Subtract(a, b));
        }
    }
}
