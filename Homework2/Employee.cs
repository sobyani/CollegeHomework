using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        protected Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public virtual decimal CalculateMonthlySalary()
        {
            return BaseSalary;
        }
    }
}
