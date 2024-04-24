using Microsoft.EntityFrameworkCore;

namespace To_Do_List_Application_Back_End.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
