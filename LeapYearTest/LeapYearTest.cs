using LeapYearCode;
using System;
using Xunit;

namespace LeapYearTest
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(2000, true)]
        [InlineData(400, true)]
        [InlineData(700, false)]
        [InlineData(2008, true)]
        [InlineData(2009, false)]
        [InlineData(1808, true)]
        [InlineData(1900, false)]
        [InlineData(1708, true)]
        public void CheckLeapYear(int year,bool expected)
        {
            var LeapYear = new LeapYear();
            var result = LeapYear.IsLeapYear(year);
            Assert.Equal(expected, result);
        }
    }
}
