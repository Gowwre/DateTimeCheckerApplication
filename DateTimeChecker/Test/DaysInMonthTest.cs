using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace DateTimeChecker.Test
{
    [TestFixture]
    public class DaysInMonthTest
    {
        private Checker _checker;

        [SetUp]
        public void SetUp()
        {
            _checker = new Checker();
        }

        [Test]
        [TestCase(2020,1,ExpectedResult = 31)]
        [TestCase(2020,2,ExpectedResult = 29)]
        [TestCase(2021,2,ExpectedResult = 28)]
        [TestCase(2020,3,ExpectedResult = 31)]
        [TestCase(2020,4,ExpectedResult = 30)]
        [TestCase(2020,5,ExpectedResult = 31)]
        [TestCase(2020,6,ExpectedResult = 30)]
        [TestCase(2020,7,ExpectedResult = 31)]
        [TestCase(2020,8,ExpectedResult = 31)]
        [TestCase(2020,9,ExpectedResult = 30)]
        [TestCase(2020,10,ExpectedResult = 31)]
        [TestCase(2020,11,ExpectedResult = 30)]
        [TestCase(2020,12,ExpectedResult = 31)]
        public int DaysInMonth_ValidInputs_ReturnsExpectedResult(int year, int month)
        {
            return _checker.DaysInMonth(year, month);
        }
        
    }
}
