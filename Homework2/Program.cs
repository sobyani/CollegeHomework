using Homework2;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Manager("Иван Петров", 100000, 5000),
            new Developer("Анна Сидорова", 90000, 1050),
            new Manager("Олег Васильев", 120000, 10000)
        };

        Console.WriteLine("--- Расчет заработной платы ---");
        foreach (Employee employee in employees)
        {
            decimal salary = employee.CalculateMonthlySalary();
            Console.WriteLine($"Зарплата для {employee.GetType().Name} {employee.Name}: {salary}");
        }
    }
}