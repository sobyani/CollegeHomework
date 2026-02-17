using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(int id,string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название задачи не может быть пустым", nameof(title));
            Id = id;
            Title = title;
            IsCompleted = false;
        }
        

    }
}
