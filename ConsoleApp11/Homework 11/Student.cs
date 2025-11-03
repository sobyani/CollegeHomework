using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    internal class Student
    {
        private int _age;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (value >= 6 && value <= 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: возраст должен быть в диапазоне от 6 до 100!");
                }
            }
        }

        public string FullName => $"{FirstName} {LastName}".Trim();

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Привет, меня зовут {FullName}, мне {Age} лет.");
        }
    }
}
