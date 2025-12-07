using Homework_1;

class Program
{
    static void Main()
    {
        var inventory = new Inventory();
        Console.WriteLine("Система учёта товаров на складе\n");

        while (true)
        {
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Удалить товар по ID");
            Console.WriteLine("3. Показать все товары");
            Console.WriteLine("4. Выход");
            Console.Write("\nВыберите действие (1–4): ");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Работа завершена.");
                break;
            }

            switch (choice)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    RemoveProduct(inventory);
                    break;
                case "3":
                    ShowAllProducts(inventory);
                    break;
                default:
                    Console.WriteLine("Неверная команда. Введите 1, 2, 3 или 4.\n");
                    break;
            }
        }
    }

    static void AddProduct(Inventory inventory)
    {
        Console.Write("Название товара: ");
        string name = Console.ReadLine();

        Console.Write("Цена товара (руб.): ");
        double price = double.Parse(Console.ReadLine());

        inventory.AddProduct(name, price);
        Console.WriteLine($"Товар «{name}» добавлен с ID {inventory.GetAllProducts().Last().Id}\n");
    }

    static void RemoveProduct(Inventory inventory)
    {
        Console.Write("Введите ID товара для удаления: ");
        int id = int.Parse(Console.ReadLine());

        if (inventory.RemoveProduct(id))
            Console.WriteLine($"Товар с ID {id} удалён.\n");
        else
            Console.WriteLine($"Товар с ID {id} не найден.\n");
    }

    static void ShowAllProducts(Inventory inventory)
    {
        var products = inventory.GetAllProducts();

        if (!products.Any())
        {
            Console.WriteLine("Склад пуст.\n");
            return;
        }

        Console.WriteLine("Товары на складе:");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id}, Name: «{product.Name}», Price: {product.Price:C}");
        }
        Console.WriteLine();
    }
}