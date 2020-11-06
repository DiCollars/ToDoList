using System;
using System.Collections.Generic;
using ToDoList.Models.Data_base;

namespace ToDoList.Models
{
    public class Day
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int MonthId { get; set; }

        public Month Month { get; set; }

        public List<TaskOf> _Tasks { get; set; }
    }
}
