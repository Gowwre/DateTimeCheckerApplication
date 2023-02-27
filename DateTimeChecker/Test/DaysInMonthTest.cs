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
    public void TestDaysInMonth_LeapYearFebruary_Returns29()
    {
        // Arrange
        int year = 2020;
        int month = 2;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(29, result);
    }
    
    [Test]
    public void TestDaysInMonth_NonLeapYearFebruary_Returns28()
    {
        // Arrange
        int year = 2021;
        int month = 2;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(28, result);
    }
    
    [Test]
    public void TestDaysInMonth_January_Returns31()
    {
        // Arrange
        int year = 2022;
        int month = 1;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(31, result);
    }
    
    [Test]
    public void TestDaysInMonth_June_Returns30()
    {
        // Arrange
        int year = 2022;
        int month = 6;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(30, result);
    }
    
    [Test]
    public void TestDaysInMonth_InvalidMonth_Returns0()
    {
        // Arrange
        int year = 2022;
        int month = 13;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(0, result);
    }
    
    [Test]
    public void TestDaysInMonth_Year0_Returns0()
    {
        // Arrange
        int year = 0;
        int month = 2;
        
        // Act
        var result = _checker.DaysInMonth(year, month);
        
        // Assert
        Assert.AreEqual(0, result);
    }
    }
}
