// See https://aka.ms/new-console-template for more information
using AcmeSchedule.Business;
using AcmeSchedule.Model;

namespace AcmeSchedule

{
    class Program
    {
        static void Main(string[] args)
        {
            string proposedFile = @"C:\temp\employeesSchedules.txt";
            Console.WriteLine($"Enter the full path and file name to process...(press enter to proccess the file: {proposedFile})");
            string inputFile = Console.ReadLine().Trim();
            inputFile = string.IsNullOrEmpty(inputFile) ? proposedFile : inputFile;
            string validateFile = Validations.ValidateFile(inputFile);
            if (String.IsNullOrEmpty(validateFile))
            {
                List<Employee> employees = Processing.ProcessFile(inputFile);
                if (employees.Count > 0)
                {
                    Processing.CalculateValues(ref employees);
                }
                foreach (Employee emp in employees)
                {
                    if (!emp.HasError)
                    {
                        Console.WriteLine($"The amount to pay to {emp.Name} is: {emp.payment} USD");
                    }
                    else
                    {
                        Console.WriteLine($"Correct the input format to calculate the amount to pay to {emp.Name}");
                    }
                }
            }
            else
            {
                Console.WriteLine(validateFile);
                
            }
        }

    }
}



