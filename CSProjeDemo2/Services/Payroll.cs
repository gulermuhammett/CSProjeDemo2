using CSProjeDemo2.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Services
{
    public static class Payroll
    {
        public static void GeneratePayrollManager(List<Manager> managers)
        {
            Console.WriteLine("Generating Payroll...");
            int value = 1;

            do
            {
                for (int i = 0; i < managers.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {managers[i].Name}");
                }
                Console.Write($"Selected Manager Number: ");
                int indexOfSelectedManager = int.Parse(Console.ReadLine()) - 1;

                Console.Write($"Enter working hours for {managers[indexOfSelectedManager].Name}: ");
                managers[indexOfSelectedManager].WorkingHours = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus value: ");
                managers[indexOfSelectedManager].Bonus = int.Parse(Console.ReadLine());
                double salary = managers[indexOfSelectedManager].CalculateSalary();

                string json = JsonConvert.SerializeObject(new
                {
                    EmployeeName = managers[indexOfSelectedManager].Name,
                    managers[indexOfSelectedManager].WorkingHours,
                    BasePayment = $"{managers[indexOfSelectedManager].BasePayment:C}",
                    BonusPayment = $"{managers[indexOfSelectedManager].Bonus:C}",
                    TotalPayment = $"{salary:C}"
                }, Formatting.Indented);

                string directoryPath = "C:\\Users\\cgr_g\\Desktop\\C#\\CSProjeDemo2\\CSProjeDemo2\\Results";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string fileName = Path.Combine(directoryPath, $"{managers[indexOfSelectedManager].Name}_Payroll_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json");
                File.WriteAllText(fileName, json);

                Console.WriteLine("Payroll Generated.");

                Console.Write("Do you continue? (Yes:Press 1 No:Press 2): ");
                value = int.Parse(Console.ReadLine());
            } while (value == 1);

            GenerateLowHourManagerReport(managers);
        }

        public static void GeneratePayrollClerks(List<Clerk> clerks)
        {
            Console.WriteLine("Generating Payroll...");
            int value = 1;

            do
            {
                for (int i = 0; i < clerks.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {clerks[i].Name}");
                }
                Console.Write($"Selected Clerk Number: ");
                int indexOfSelectedClerk = int.Parse(Console.ReadLine()) - 1;

                Console.Write($"Enter working hours for {clerks[indexOfSelectedClerk].Name}: ");
                clerks[indexOfSelectedClerk].WorkingHours = int.Parse(Console.ReadLine());
                double salary = clerks[indexOfSelectedClerk].CalculateSalary();

                string json = JsonConvert.SerializeObject(new
                {
                    EmployeeName = clerks[indexOfSelectedClerk].Name,
                    clerks[indexOfSelectedClerk].WorkingHours,
                    BasePayment = $"{clerks[indexOfSelectedClerk].BasePayment:C}",
                    ShiftPayment = $"{clerks[indexOfSelectedClerk].Shift:C}",
                    TotalPayment = $"{salary:C}"
                }, Formatting.Indented);

                string directoryPath = "C:\\Users\\cgr_g\\Desktop\\C#\\CSProjeDemo2\\CSProjeDemo2\\Results";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string fileName = Path.Combine(directoryPath, $"{clerks[indexOfSelectedClerk].Name}_Payroll_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json");
                File.WriteAllText(fileName, json);

                Console.WriteLine("Payroll Generated.");

                Console.Write("Do you continue? (Yes:Press 1 No:Press 2): ");
                value = int.Parse(Console.ReadLine());
            } while (value == 1);

            GenerateLowHourClerkReport(clerks);
        }

        public static void GenerateLowHourManagerReport(List<Manager> managers)
        {
            Console.WriteLine("Low Hour Employee Report:");
            foreach (var manager in managers)
            {
                if (manager.WorkingHours < 150)
                {
                    Console.WriteLine($"- {manager.Name} / Working Hours: {manager.WorkingHours} hours");
                }
            }
        }

        public static void GenerateLowHourClerkReport(List<Clerk> clerks)
        {
            Console.WriteLine("Low Hour Employee Report:");
            foreach (var clerk in clerks)
            {
                if (clerk.WorkingHours < 150)
                {
                    Console.WriteLine($"- {clerk.Name} / Working Hours: {clerk.WorkingHours} hours");
                }
            }
        }
    }
}
