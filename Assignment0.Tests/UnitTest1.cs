using System;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DivisibleByFour()
        {
            var number = 40;
            var testClass = new TestClass();
            bool actual = testClass.IsLeapYear(number);
            Assert.Equal(true, actual);
        }

        [Fact]
        public void DivisibleByHundred() 
        {
            var number = 100;
            var testClass = new TestClass();
            bool actual = testClass.IsLeapYear(number);
            Assert.Equal(false, actual);

        }
        [Fact]
        public void DivisibleByFourHundred() 
        {
            var number = 400;
            var testClass = new TestClass();
            bool actual = testClass.IsLeapYear(number);
            Assert.Equal(true, actual);

        }
    }
}
