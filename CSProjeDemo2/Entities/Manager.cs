using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class Manager : Employee
    {
        public override double HourlyRate => 500;
        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            TotalPayment = HourlyRate * WorkingHours + Bonus;
            BasePayment = TotalPayment - Bonus;
            return TotalPayment;
        }
    }
}
