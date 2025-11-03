using Homework_11;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Создание профилей студентов ---");

        var student1 = new Student("Иван", "Петров", 19);
        Console.WriteLine("Студент 1:");
        student1.Introduce();
        Console.WriteLine($"Полное имя: {student1.FullName}");

        var student2 = new Student("Анна", "Сидорова", 20);
        Console.WriteLine("Студент 2:");
        student2.Introduce();
        Console.WriteLine($"Полное имя: {student2.FullName}");

        Console.WriteLine("--- Попытка изменить возраст на некорректное значение ---");

        student1.Age = 150;

        Console.WriteLine($"Текущий возраст студента 1: {student1.Age}");
    }
}