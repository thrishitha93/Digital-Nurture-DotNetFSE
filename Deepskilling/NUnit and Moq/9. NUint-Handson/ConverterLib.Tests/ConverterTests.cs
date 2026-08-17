using ConverterLib;
using Moq;
using NUnit.Framework;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Mock<IDollarToEuroExchangeRateFeed> mockFeed;
        private Converter converter;

        [SetUp]
        public void Setup()
        {
            mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();

            mockFeed
                .Setup(x => x.GetExchangeRate())
                .Returns(0.85);

            converter = new Converter(mockFeed.Object);
        }

        [Test]
        public void USDToEuro_100Dollar_Returns85Euro()
        {
            double result = converter.USDToEuro(100);

            Assert.That(result, Is.EqualTo(85));
        }
    }
}