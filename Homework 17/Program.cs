using Homework_17;

class Program
{
    static void Main()
    {
        // Создаём список студентов
        List<Student> students = new List<Student>
        {
            new Student("Петров Иван", 20, 85.5),
            new Student("Сидорова Анна", 23, 78.1),
            new Student("Кузнецов Олег", 19, 74.9),
            new Student("Васильева Мария", 26, 92.3),
            new Student("Смирнов Алексей", 22, 95.2)
        };

        // 1. Найти хорошистов (балл от 75 до 90)
        Console.WriteLine("--- Список студентов‑хорошистов (балл от 75 до 90) ---");
        var goodStudents = students
            .Where(s => s.AverageScore >= 75 && s.AverageScore <= 90)
            .Select(s => $"{s.Name} - {s.AverageScore:0.1}");
        foreach (var student in goodStudents)
        {
            Console.WriteLine(student);
        }

        // 2. Сформировать простой список имён
        Console.WriteLine("\n--- Все студенты ---");
        var names = students.Select(s => s.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // 3. Отсортировать студентов по возрасту (от младшего к старшему)
        Console.WriteLine("\n--- Сортировка по возрасту ---");
        var sortedByAge = students
            .OrderBy(s => s.Age)
            .Select(s => $"{s.Name} - {s.Age} лет");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine(student);
        }

        // 4. Сформировать рейтинг лучших студентов младше 25 лет (по убыванию балла)
        Console.WriteLine("\n--- Рейтинг студентов младше 25 лет (по убыванию балла) ---");
        var topStudents = students
            .Where(s => s.Age < 25)
            .OrderByDescending(s => s.AverageScore)
            .Select(s => $"{s.Name} - {s.AverageScore:0.1}");
        foreach (var student in topStudents)
        {
            Console.WriteLine(student);
        }
    }
}
