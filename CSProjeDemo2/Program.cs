using CSProjeDemo2.Entities;
using CSProjeDemo2.Helpers;
using CSProjeDemo2.Services;

class Program
{
    static void Main(string[] args)
    {
        // Example JSON file path
        string filePath = "C:\\Users\\cgr_g\\Desktop\\C#\\CSProjeDemo2\\CSProjeDemo2\\employees.json";

        // Read employee list from JSON file
        List<Manager> managers = FileReader.ReadManagerList(filePath);
        List<Clerk> clerks = FileReader.ReadClerkList(filePath);

        Console.Write("Press 1 to list managers or press 2 to list clerks: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Payroll.GeneratePayrollManager(managers);
            Console.ReadLine();
        }
        else if (choice == 2)
        {
            Payroll.GeneratePayrollClerks(clerks);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong number!");
            Console.ReadLine();
        }




    }
}
