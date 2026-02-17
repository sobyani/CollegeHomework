using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    public class ConsoleMenu
    {
        private readonly ITaskService _taskService;

        public ConsoleMenu(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Менеджер задач ===");
                Console.WriteLine("1 — Добавить задачу");
                Console.WriteLine("2 — Показать все задачи");
                Console.WriteLine("3 — Отметить задачу выполненной");
                Console.WriteLine("4 — Удалить задачу");
                Console.WriteLine("0 — Выход");
                Console.Write("Выберите действие: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowAllTasks();
                        break;
                    case "3":
                        MarkTaskCompleted();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        private void AddTask()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();

            try
            {
                _taskService.AddTask(title);
                Console.WriteLine("Задача добавлена!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private void ShowAllTasks()
        {
            var tasks = _taskService.GetAllTasks();
            if (!tasks.Any())
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            Console.WriteLine("\nСписок задач:");
            foreach (var task in tasks)
            {
                string status = task.IsCompleted ? "[Выполнено]" : "[Не выполнено]";
                Console.WriteLine($"{task.Id}. {task.Title} {status}");
            }
        }

        private void MarkTaskCompleted()
        {
            Console.Write("Введите ID задачи для отметки как выполненной: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Некорректный ID.");
                return;
            }

            if (_taskService.MarkTaskAsCompleted(id))
                Console.WriteLine("Задача отмечена как выполненная!");
            else
                Console.WriteLine("Задача с таким ID не найдена.");
        }

        private void RemoveTask()
        {
            Console.Write("Введите ID задачи для удаления: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Некорректный ID.");
                return;
            }

            if (_taskService.RemoveTask(id))
                Console.WriteLine("Задача удалена!");
            else
                Console.WriteLine("Задача с таким ID не найдена.");
        }
    }
}
