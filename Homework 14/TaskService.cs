using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    public class TaskService : ITaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public void AddTask(string title)
        {
            int newId = _tasks.Count > 0 ? _tasks.Max(t => t.Id) + 1 : 1;
            var task = new TaskItem(newId, title);
            _tasks.Add(task);
        }

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public bool MarkTaskAsCompleted(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return false;

            task.IsCompleted = true;
            return true;
        }

        public bool RemoveTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return false;

            _tasks.Remove(task);
            return true;
        }
    }
}
