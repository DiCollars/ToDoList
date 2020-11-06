namespace ToDoList.Models
{
    public class TaskOf
    {
        public int Id { get; set; }

        public string Summary { get; set; }

        public bool Status { get; set; }

        public Priority Priority { get; set; }

        public Priority SubPriority { get; set; }

        public int DayId { get; set; }

        public Day Day { get; set; }
    }

    public enum Priority
    {
        Lower,
        Low,
        Medium,
        High
    }
}
