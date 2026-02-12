using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public class OrderRepository : IOrderRepository
    {
        public void Save(string itemName, int quantity)
        {
            File.WriteAllText("order.txt", $"Товар: {itemName}, Количество: {quantity}");
            Console.WriteLine("Заказ сохранен в файл.");
        }
    }
}
