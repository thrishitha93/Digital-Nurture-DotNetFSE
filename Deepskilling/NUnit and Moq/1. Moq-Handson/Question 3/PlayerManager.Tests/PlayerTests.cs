using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> mockMapper;

        [OneTimeSetUp]
        public void Init()
        {
            mockMapper = new Mock<IPlayerMapper>();

            mockMapper
                .Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
                .Returns(false);
        }

        [TestCase]
        public void RegisterNewPlayer_ShouldCreatePlayer()
        {
            var player = Player.RegisterNewPlayer("Virat", mockMapper.Object);

            Assert.That(player, Is.Not.Null);
            Assert.That(player.Name, Is.EqualTo("Virat"));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));
        }
    }
}