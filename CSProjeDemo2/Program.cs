using CSProjeDemo2.Entities;
using CSProjeDemo2.Helpers;
using CSProjeDemo2.Services;

class Program
{
    static void Main(string[] args)
    {
        // Example JSON file path
        string filePath = "C:\\Users\\muham\\Desktop\\Muhammet-Guler\\ConsolBordroHesaplama\\CSProjeDemo2\\employees.json";

        // Read employee list from JSON file
        List<Manager> managers = FileReader.ReadManagerList(filePath);
        List<Clerk> clerks = FileReader.ReadClerkList(filePath);

        Console.Write("Yöneticileri listelemek için 1'e, katipleri listelemek için 2'ye basın: ");
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
            Console.WriteLine("Yanlış numara!");
            Console.ReadLine();
        }




    }
}
