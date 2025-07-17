using Microsoft.EntityFrameworkCore;
using SmartTaskManager.Model;

namespace SmartTaskManager.Database
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) 
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<TasksItems> TasksItems { get; set; }
    }
}
