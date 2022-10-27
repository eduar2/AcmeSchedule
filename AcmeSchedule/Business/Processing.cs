using AcmeSchedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedule.Business
{
    public static class Processing
    {

        public static List<Employee> ProcessFile(string inputFile)
        {
            List<Employee> employees = new List<Employee>();
            foreach (string line in System.IO.File.ReadLines(inputFile))
            {
                Employee employee = ProcessLine(line);
                employees.Add(employee);
            }
            return employees;
        }

        public static Employee ProcessLine(string line)
        {
            string[] input = line.Split('=');
            Employee employee = new Employee();
            employee.schedules = new List<ScheduleWork>();
            if (input.Length == 2)
            {
                string name = input[0];
                string schedules = input[1];
                string[] dayHours = schedules.Split(',');
                employee.Name = name;
                foreach (string workDay in dayHours)
                {
                    ScheduleWork schedule = new ScheduleWork();
                    try
                    {

                        schedule.Day = workDay.Substring(0, 2);
                        schedule.StartHour = Convert.ToInt32(workDay.Substring(2, 2));
                        schedule.EndHour = Convert.ToInt32(workDay.Substring(8, 2));
                        schedule.numberOfHours = schedule.EndHour - schedule.StartHour;
                    }
                    catch (Exception)
                    {
                        schedule.hasError = true;
                        employee.HasError = true;
                        throw;
                    }
                    employee.schedules.Add(schedule);
                }
            }
            return employee;
        }

        public static void CalculateValues(ref List<Employee> employees)
        {
            double rate = 0;
            DefinitionRules rules = new DefinitionRules();
            foreach (Employee employee in employees)
            {
                if (!employee.HasError)
                {
                    double payment = 0;
                    foreach (ScheduleWork schedule in employee.schedules)
                    {
                        List<ScheduleRule> aplicableRules = rules.schedules.FindAll(s => s.Day == schedule.Day);
                        for (int i = 0; i < aplicableRules.Count; i++)
                        {
                            payment = payment + CalculatePayment(schedule.StartHour, schedule.EndHour, aplicableRules[i]);
                        }
                    }
                    employee.payment = payment;
                }
            }
        }

        public static double CalculatePayment(int start, int end, ScheduleRule input)
        {
            int startRate = input.StartHour;
            int endRate = input.EndHour;
            int numberHours = end - start;
            int numberHoursRate = endRate - startRate;
            double rate = 0;
            if (start >= startRate && start < endRate)
            {
                numberHours = numberHours <= numberHoursRate ? numberHours : numberHoursRate;
                rate = input.Cost * numberHours;
            }
            return rate;
        }


    }
}
