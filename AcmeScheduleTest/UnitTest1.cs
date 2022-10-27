using AcmeSchedule.Business;
using AcmeSchedule.Model;


namespace AcmeScheduleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double expectedPayment = 215;

            List<ScheduleWork> listWorkedTime = new List<ScheduleWork>();
            Employee employee = new Employee();
            employee.Name = "RENE" ;

            listWorkedTime.Add(new ScheduleWork() { Day = "MO", StartHour = 10, EndHour = 12 });
            listWorkedTime.Add(new ScheduleWork() { Day = "TU", StartHour = 10, EndHour = 12 });
            listWorkedTime.Add(new ScheduleWork() { Day = "TH", StartHour = 1, EndHour = 3 });
            listWorkedTime.Add(new ScheduleWork() { Day = "SA", StartHour = 14, EndHour = 18 });
            listWorkedTime.Add(new ScheduleWork() { Day = "SU", StartHour = 20, EndHour = 21 });
            employee.schedules = listWorkedTime;
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            Processing.CalculateValues(ref employees);
            Assert.That(employees[0].payment, Is.EqualTo(expectedPayment));
        }
    }
}