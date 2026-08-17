using NUnit.Framework;
using UtilLib;
using System;

namespace UtilLib.Tests
{
    [TestFixture]   
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        
        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            var result = parser.ParseHostName("http://www.google.com");

            Assert.That(result, Is.EqualTo("www.google.com"));
        }

        
        [Test]
        public void ParseHostName_HttpsUrl_ReturnsHostName()
        {
            var result = parser.ParseHostName("https://www.microsoft.com");

            Assert.That(result, Is.EqualTo("www.microsoft.com"));
        }

      
        [Test]
        public void ParseHostName_InvalidUrl_ThrowsFormatException()
        {
            Assert.That(() => parser.ParseHostName("google.com"),
                        Throws.TypeOf<FormatException>());
        }

        
        [Test]
        public void ParseHostName_EmptyUrl_ThrowsArgumentException()
        {
            Assert.That(() => parser.ParseHostName(""),
                        Throws.TypeOf<ArgumentException>());
        }

        
        [Test]
        public void ParseHostName_NullUrl_ThrowsArgumentException()
        {
            string nullUrl = null!;

            Assert.That(() => parser.ParseHostName(nullUrl),
                        Throws.TypeOf<ArgumentException>());
        }
    }
}