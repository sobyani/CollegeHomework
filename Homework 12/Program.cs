using Homework_12;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---Система учета сткдентов---");

        Console.WriteLine($"Начальное количество студентов в системе: {Student.Count}");

        Book book1 = new Book("Хоббит", "Дж. Р. Р. Толкин");
        Student student1 = new Student("Иван", book1);
        Console.WriteLine("Создан студент Иван");       
        Console.WriteLine($"Текущее количество студентов в системе:{Student.Count}");

        Book book2 = new Book("1984", "Джордж Оруэлл");
        Student student2 = new Student("Анна", book2);
        Console.WriteLine("Создан студент Анна.");
        Console.WriteLine($"Текущее количество студентов в системе: {Student.Count}");

        Console.WriteLine("\n---Эксперимент с копированием---");

        Console.WriteLine($"Оригинальный студент: {student1}");

        Console.WriteLine("...Копируем данные и вносим изменения...");

        Student studentCopy = student1;
        Book bookCopy = student1.FavoriteBook;
        studentCopy.Name = "Пётр";
        bookCopy.Title = "Властелин Колец";

        Console.WriteLine("Изменяем имя у копии студента на 'Пётр'.");
        Console.WriteLine("Изменяем название у копии книги на 'Властелин Колец'.");

        Console.WriteLine("\nРезультат после изменений:");
        Console.WriteLine($"Имя оригинального студента (student1): {student1.Name}");
        Console.WriteLine($"Название любимой книги оригинального студента (student1.FavoriteBook): {student1.FavoriteBook.Title}");
        Console.WriteLine("\nВывод: Имя студента изменилось, так как классы копируются по ссылке.");
        Console.WriteLine("Вывод: Книга не изменилась, так как структуры копируются по значению.");
    }
}

