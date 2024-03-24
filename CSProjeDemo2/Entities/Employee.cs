using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public double BasePayment { get; set; }
        public double TotalPayment { get; set; }
        public int WorkingHours { get; set; }
        public abstract double HourlyRate { get; }
        public abstract double CalculateSalary();
    }
}
