using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageScore { get; set; }

        public Student(string name, int age, double averageScore)
        {
            Name = name;
            Age = age;
            AverageScore = averageScore;
        }
    }
}
