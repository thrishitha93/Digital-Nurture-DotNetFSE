using NUnit.Framework;
using NUnit.Framework.Legacy;
using CollectionsLib;
using System.Linq;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        // Scenario 1
        [Test]
        public void GetEmployees_NoNullEmployees_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees, Has.None.Null);
        }

        // Scenario 2
        [Test]
        public void GetEmployees_Employee100Exists_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees.Any(e => e.EmpId == 100), Is.True);
        }

        // Scenario 3
        [Test]
        public void GetEmployees_AllEmployeesUnique_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees.Distinct().Count(), Is.EqualTo(employees.Count));
        }

        // Scenario 4
        [Test]
        public void GetEmployees_CollectionsAreEqual()
        {
            var actual = manager.GetEmployees();
            var expected = manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}