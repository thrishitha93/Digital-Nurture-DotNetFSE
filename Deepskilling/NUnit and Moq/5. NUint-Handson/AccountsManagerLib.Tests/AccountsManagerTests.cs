using NUnit.Framework;
using AccountsManagerLib;
using System;

namespace AccountsManagerLib.Tests
{
    public class AccountsManagerTests
    {
        private AccountsManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountsManager();
        }

        [Test]
        public void ValidateUser_ValidUser1_ReturnsWelcomeMessage()
        {
            var result = manager.ValidateUser("user_11", "secret@user11");

            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void ValidateUser_ValidUser2_ReturnsWelcomeMessage()
        {
            var result = manager.ValidateUser("user_22", "secret@user22");

            Assert.That(result, Is.EqualTo("Welcome user_22!!!"));

        }

        [Test]
        public void ValidateUser_InvalidPassword_ReturnsErrorMessage()
        {
            var result = manager.ValidateUser("user_11", "wrong");

            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void ValidateUser_InvalidUser_ReturnsErrorMessage()
        {
            var result = manager.ValidateUser("wrong_user", "secret@user11");

            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void ValidateUser_EmptyUserId_ThrowsException()
        {
            Assert.Throws<FormatException>(() => manager.ValidateUser("", "password"));
        }

        [Test]
        public void ValidateUser_EmptyPassword_ThrowsException()
        {
            Assert.Throws<FormatException>(() => manager.ValidateUser("user_11", ""));
        }

        [Test]
        public void ValidateUser_NullInputs_ThrowsException()
        {
            Assert.Throws<FormatException>(() => manager.ValidateUser(null!, null!));
        }
    }
}