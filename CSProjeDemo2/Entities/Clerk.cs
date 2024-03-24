using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class Clerk : Employee
    {
        public override double HourlyRate => 500;
        public double Shift { get; set; }
        public override double CalculateSalary()
        {
            if(WorkingHours > 180)
            {
                double shiftHours = WorkingHours - 180;
                Shift = HourlyRate * 1.5 * shiftHours;
                BasePayment = 180 * HourlyRate;
                TotalPayment = Shift + BasePayment;
            }
            else if (WorkingHours < 10)
            {
                TotalPayment = HourlyRate * WorkingHours;
                BasePayment = TotalPayment;
                Console.WriteLine("This guy is an ATM teller");
            }
            else
            {
                TotalPayment = HourlyRate * WorkingHours;
                BasePayment = TotalPayment;
            }
            return TotalPayment;
        }
    }
}
