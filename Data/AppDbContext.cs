
using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public required DbSet<TodoItem> TodoItems { get; set; }
        public  DbSet<Category> Categorys { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("paul");
            base.OnModelCreating(modelBuilder);
        }

    }



}
