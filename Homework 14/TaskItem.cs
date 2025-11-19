using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
     class TaskItem
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public TaskItem(string description)
        {
            Description = description;
            IsDone = false;
        }
    }
}
