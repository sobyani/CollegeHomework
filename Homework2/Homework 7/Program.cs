using Homework_7;

class Program
{
    static void Main(string[] args)
    {
        var validator = new OrderValidator();
        var repository = new OrderRepository();
        var notificationService = new NotificationService();

        var processor = new OrderProcessor(validator, repository, notificationService);

        Console.WriteLine("--- Обработка нового заказа ---");
        Console.Write("Введите название товара: ");
        string itemName = Console.ReadLine();
        Console.Write("Введите количество: ");
        int quantity = int.Parse(Console.ReadLine());

        processor.ProcessOrder(itemName, quantity);

        Console.WriteLine("\n--- Попытка обработки некорректного заказа ---");
        Console.Write("Введите название товара: ");
        itemName = Console.ReadLine();
        Console.Write("Введите количество: ");
        quantity = int.Parse(Console.ReadLine());

        processor.ProcessOrder(itemName, quantity);
    }
}