using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public class ViewModel 
    {
        public List<TaskOf> ListTasks { get; set; }

        public (int, DateTime)[] ListCountDays { get; set; }

        public List<KeyValuePair<int, string>> AllMonths { get; set; }
    }
}
