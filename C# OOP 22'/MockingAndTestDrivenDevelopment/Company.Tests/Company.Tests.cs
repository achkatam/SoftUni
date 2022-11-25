namespace Company.Tests
{
    using NUnit.Framework;

    public class Tests
    {
        private Company company;

        [SetUp]
        public void Setup()
        {
            company = new Company();
        }

        [Test]
        public void TEST_COMPANY_PAYS_SALARY_TO_ALL_EMPLOYEES()
        {


            var employee1 = new Employee() { Salary = 100 };
            var employee2 = new Employee() { Salary = 1000 };

            company.Add(employee1);
            company.Add(employee2);

            company.GiveSalary();

            Assert.AreEqual(100, employee1.EarnedSalary);
            Assert.AreEqual(1000, employee2.EarnedSalary);
        }

        [Test]
        public void TEST_COMPANY_INCREASES_SALARY_YEARLY()
        {


            var employee1 = new Employee() { Salary = 100 };
            var employee2 = new Employee() { Salary = 1000 };

            company.Add(employee1);
            company.Add(employee2);

            company.ReiseSalary(20);

            Assert.AreEqual(100, employee1.EarnedSalary);
            Assert.AreEqual(1000, employee2.EarnedSalary);
        }
    }
}