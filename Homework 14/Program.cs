using Homework_14;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<TaskItem> tasks = new List<TaskItem>();

        while (true)
        {
            Console.WriteLine("\n--- Меню ---");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Посмотреть задачи");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    ViewTasks(tasks);
                    break;
                case "3":
                    MarkTaskAsDone(tasks);
                    break;
                case "4":
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, введите число от 1 до 4.");
                    break;
            }
        }
    }

    static void AddTask(List<TaskItem> tasks)
    {
        Console.Write("Введите описание задачи: ");
        string description = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(description))
        {
            TaskItem newTask = new TaskItem(description);
            tasks.Add(newTask);
            Console.WriteLine("Задача добавлена!");
        }
        else
        {
            Console.WriteLine("Описание задачи не может быть пустым.");
        }
    }

    static void ViewTasks(List<TaskItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
            return;
        }

        Console.WriteLine("\n--- Текущие задачи ---");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tasks[i].IsDone ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
        }
    }

    static void MarkTaskAsDone(List<TaskItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
            return;
        }

        Console.WriteLine("\n--- Отметить задачу как выполненную ---");
        ViewTasks(tasks);

        Console.Write("Введите номер задачи для выполнения: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int taskNumber) &&
            taskNumber > 0 &&
            taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsDone = true;
            Console.WriteLine($"Задача \"{tasks[taskNumber - 1].Description}\" отмечена как выполненная!");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }
}
