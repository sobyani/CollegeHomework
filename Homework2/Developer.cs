using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Developer : Employee
    {
        public int LinesOfCodeWritten { get; set; }

        public Developer(string name, decimal baseSalary, int linesOfCodeWritten)
            : base(name, baseSalary)
        {
            LinesOfCodeWritten = linesOfCodeWritten;
        }

        public override decimal CalculateMonthlySalary()
        {
            decimal codeBonus = LinesOfCodeWritten * 5m;
            return BaseSalary + codeBonus;
        }
    }
}
