using NUnit.Framework;

namespace LeapYearCalculatorLib.Tests
{
    internal class LeapYearCalculator
    {
        public int CheckLeapYear(int year)
        {
            if (year < 1753 || year > 9999)
            {
                return -1;
            }

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return 1;
            }

            return 0;
        }
    }

    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new LeapYearCalculator();
        }

        // Parameterized Test Cases
        [TestCase(2000, 1)]   // Leap year
        [TestCase(2024, 1)]   // Leap year
        [TestCase(1900, 0)]   // Not leap year
        [TestCase(2023, 0)]   // Not leap year
        [TestCase(1753, 0)]   // Valid lower bound
        [TestCase(9999, 0)]   // Valid upper bound
        [TestCase(1700, -1)]  // Invalid (below range)
        [TestCase(10000, -1)] // Invalid (above range)
        public void CheckLeapYear_ValidAndInvalidInputs_ReturnsExpectedResult(int year, int expected)
        {
            // Act
            int result = _calculator.CheckLeapYear(year);

            // Assert (Single Assertion Rule)
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}