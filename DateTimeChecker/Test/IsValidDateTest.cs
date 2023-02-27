using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker.Test
{
  [TestFixture]
  public class IsValidDateTest
  {
        Checker checker;
    [SetUp]
    public void SetUp()
    {
      checker = new Checker();
    }

        [Test]
        [TestCase(2020, 2, 29, ExpectedResult = true)]
        [TestCase(2021, 2, 29, ExpectedResult = false)]
        [TestCase(2021, 4, 31, ExpectedResult = false)]
        [TestCase(2022, 4, 30, ExpectedResult = true)]
        [TestCase(2000, 2, 29, ExpectedResult = true)]
        [TestCase(2009, 2, 29, ExpectedResult = false)]
        [TestCase(999, 2, 29, ExpectedResult = false)]
        [TestCase(3001, 2, 29, ExpectedResult = false)]
        [TestCase(null, 2, 29, ExpectedResult = false)]
        [TestCase(2021, 1, 31, ExpectedResult = true)]
        [TestCase(2021, 3, 31, ExpectedResult = true)]
        [TestCase(2021, 5, 31, ExpectedResult = true)]
        [TestCase(2021, 7, 31, ExpectedResult = true)]
        [TestCase(2021, 8, 31, ExpectedResult = true)]
        [TestCase(2021, 10, 31, ExpectedResult = true)]
        [TestCase(2021, 12, 31, ExpectedResult = true)]
        [TestCase(2021, 4, 30, ExpectedResult = true)]
        [TestCase(2021, 6, 30, ExpectedResult = true)]
        [TestCase(2021, 9, 30, ExpectedResult = true)]
        [TestCase(2021, 11, 30, ExpectedResult = true)]
        [TestCase(2021, 2, 30, ExpectedResult = false)]
        [TestCase(2021, 4, 31, ExpectedResult = false)]
        [TestCase(2021, 6, 31, ExpectedResult = false)]
        [TestCase(2021, 9, 31, ExpectedResult = false)]
        [TestCase(2021, 11, 31, ExpectedResult = false)]
        [TestCase(2021, 2, null, ExpectedResult = false)]
        [TestCase(2021, null, 29, ExpectedResult = false)]
        [TestCase(null, null, null, ExpectedResult = false)]
public bool IsValidDate_ValidInputs_ReturnsExpectedResult(int year, int month, int day)
    {
      return checker.IsValidDate(year, month, day);
    }
  }
}
