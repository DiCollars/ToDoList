using Microsoft.EntityFrameworkCore;
using ToDoList.Models.Data_base;

namespace ToDoList.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Day> Days { get; set; }

        public DbSet<TaskOf> TaskOfs { get; set; }

        public DbSet<Month> Months { get; set; }

        public  ApplicationContext( DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
