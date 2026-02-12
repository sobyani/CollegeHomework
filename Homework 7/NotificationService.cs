using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public class NotificationService : INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Отправка email-уведомления: 'Ваш заказ принят'.");
        }
    }
}
