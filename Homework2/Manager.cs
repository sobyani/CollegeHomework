using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public Manager(string name, decimal baseSalary, decimal bonus)
            : base(name, baseSalary)
        {
            Bonus = bonus;
        }

        public override decimal CalculateMonthlySalary()
        {
            return BaseSalary + Bonus;
        }
    }
}
