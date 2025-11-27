using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class UserInterface
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n=== Библиотека ===");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Найти книгу");
            Console.WriteLine("4. Показать все книги");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");
        }

        public static void HandleAddBook(Library library)
        {
            Console.Write("Название: ");
            string? title = Console.ReadLine();

            Console.Write("Автор: ");
            string? author = Console.ReadLine();

            Console.Write("Год издания (или Enter, если неизвестен): ");
            string? yearInput = Console.ReadLine();
            int? year = null;

            if (!string.IsNullOrEmpty(yearInput))
            {
                if (int.TryParse(yearInput, out int parsedYear))
                    year = parsedYear;
                else
                {
                    Console.WriteLine("Некорректный год. Книга будет добавлена без года.");
                }
            }

            library.AddBook(title, author, year);
            Console.WriteLine("Книга добавлена!");
        }

        public static void HandleRemoveBook(Library library)
        {
            Console.Write("Введите ID книги для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (library.RemoveBook(id))
                    Console.WriteLine("Книга удалена!");
                else
                    Console.WriteLine("Книга не найдена.");
            }
            else
            {
                Console.WriteLine("Некорректный ID.");
            }
        }

        public static void HandleFindBook(Library library)
        {
            Console.WriteLine("1. Поиск по названию");
            Console.WriteLine("2. Поиск по автору");
            Console.Write("Выберите критерий: ");

            string? choice = Console.ReadLine();
            Console.Write("Запрос: ");
            string? query = Console.ReadLine();

            List<Book> results = choice == "1"
                ? library.FindBooksByTitle(query)
                : library.FindBooksByAuthor(query);

            PrintBooks(results);
        }

        public static void HandleShowAllBooks(Library library)
        {
            List<Book> books = library.FindAllBooks();
            PrintBooks(books);
        }

        public static void PrintBooks(List<Book> books)
        {
            if (!books.Any())
            {
                Console.WriteLine("Книги не найдены.");
                return;
            }

            Console.WriteLine("\nРезультаты:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Название: {book.Title}, " +
                                  $"Автор: {book.Author}, Год: {book.Year ?? '—'}");
            }
        }
    }
}
