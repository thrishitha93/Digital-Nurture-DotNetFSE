using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerCommLib.CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();

            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            customerComm = new CustomerCommLib.CustomerComm(mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ReturnsTrue_AndCallsSendMail()
        {
            // Act
            bool result = customerComm.SendMailToCustomer();

            // Assert result
            Assert.That(result, Is.True);

            // 🔥 Verify interaction (MOST IMPORTANT)
            mockMailSender.Verify(x => x.SendMail(
                "cust123@abc.com",
                "Some Message"
            ), Times.Once);
        }
    }
}