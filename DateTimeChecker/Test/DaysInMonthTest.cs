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
        public void TestDaysInMonth()
        {
            var result = _checker.DaysInMonth(2020,1);
            Assert.AreEqual(31, result);
        }
    }
}
