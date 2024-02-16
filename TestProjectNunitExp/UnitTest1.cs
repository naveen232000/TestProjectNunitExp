using EmployeeLibrary;

namespace TestProjectNunitExp
{
    [TestFixture]
    public class Tests
    {
        EmployeeManagement empMg;
        [SetUp]
        public void Setup()
        {
            empMg = new EmployeeManagement();
        }

        [Test]
        public void AllEmpNotNullTest()
        {
        foreach (Employee emp in empMg.AllEmp()) 
            { 
                Assert.IsNotNull(emp.Id);
                Assert.IsNotNull(emp.Name);
                Assert.IsNotNull(emp.Salary);
                Assert.IsNotNull(emp.Doj);
                Console.WriteLine($"{emp.Id,-5} {emp.Name,-10} {emp.Salary,-10} {emp.Doj,-10} ");
            }
        }
        [Test]
        public void SearchEmpTest()
        {
            int id = 3;
            string name = "Ram";
            foreach (Employee emp in empMg.SearchEmp(id))
            {
                Console.WriteLine($"{emp.Id,-5} {emp.Name,-10} {emp.Salary,-10} {emp.Doj,-10} ");

                Assert.That(emp.Id, Is.EqualTo(id));
                Assert.That(emp.Name, Is.EqualTo(name));

            }
        }
    }
}