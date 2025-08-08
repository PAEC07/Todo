using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;
using InterfaceIRepository;
using System.Net.Security;

namespace Repository
{
    public class TodoIRepository 
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        public TodoIRepository(IDbContextFactory<ApplicationDbContext> contextFactory) {
            _contextFactory = contextFactory; 
        }

        public Dbset<TodoItem> TodoItems

        public async Task Add(TodoItem item)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item), "TodoItem cannot be null");
                }
                context.TodoItems.Add(item);
                await context.SaveChangesAsync();
            }

        }

        public async Task Update(TodoItem item)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                context.TodoItems.Update(item);
                await context.SaveChangesAsync();
            }
        }


        
        public async Task Delete(TodoItem item)
        {
         using (var context = _contextFactory.CreateDbContext())
            {
                if (item != null)
                {
                    context.TodoItems.Remove(item);
                    await context.SaveChangesAsync();
                   
                    
                    return;
                }
                
            }


        }

        

        
        public async Task<List<TodoItem>> Get()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return await context.TodoItems.ToListAsync();// 
            }

        }
    
        public async Task<TodoItem> Get(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return await context.TodoItems.FindAsync(id) ?? new TodoItem(-1, "Fehler", "Fehler", false);
            }
        }

        public Task MarkAsComplete(TodoItem id)
        {
            throw new NotImplementedException();
        }
    }
}

