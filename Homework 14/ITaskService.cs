using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
   
        public interface ITaskService
        {
            void AddTask(string title);
            List<TaskItem> GetAllTasks();
            bool MarkTaskAsCompleted(int id);
            bool RemoveTask(int id);
        }

    
}
