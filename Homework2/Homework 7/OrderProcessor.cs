using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public class OrderProcessor
    {
        private readonly IOrderValidator _validator;
        private readonly IOrderRepository _repository;
        private readonly INotificationService _notificationService;

        public OrderProcessor(
            IOrderValidator validator,
            IOrderRepository repository,
            INotificationService notificationService)
        {
            _validator = validator;
            _repository = repository;
            _notificationService = notificationService;
        }

        public void ProcessOrder(string itemName, int quantity)
        {
            // 1. Валидация
            if (!_validator.Validate(itemName, quantity, Console.WriteLine))
            {
                return;
            }

            // 2. Сохранение
            _repository.Save(itemName, quantity);

            // 3. Уведомление
            _notificationService.SendNotification();
        }
    }
}
