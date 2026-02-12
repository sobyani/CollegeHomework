using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public class OrderValidator : IOrderValidator
    {
        public bool Validate(string itemName, int quantity, Action<string> errorCallback)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                errorCallback("Ошибка: Название товара не может быть пустым.");
                return false;
            }

            if (quantity <= 0)
            {
                errorCallback("Ошибка: Количество должно быть больше нуля.");
                return false;
            }

            Console.WriteLine("Заказ прошел валидацию.");
            return true;
        }
    }
}
