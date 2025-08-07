using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;
using InterfaceIRepository;

namespace Repository
{
    public class TodoIRepository : IRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public TodoIRepository(ApplicationDbContext DbContext) {
            _DbContext = DbContext; 
        }
    
        public async Task Add(TodoItem item)
        {
            await _DbContext.TodoItems.AddAsync(item);
            await _DbContext.SaveChangesAsync();
        }
        public async Task Update(TodoItem item)
        {
            _DbContext.TodoItems.Update(item);
            await _DbContext.SaveChangesAsync();
        }
        public async Task Delete(TodoItem item)
        {
             _DbContext.TodoItems.Remove(item);
            await _DbContext.SaveChangesAsync();
        }

        public async Task MarkAsComplete(TodoItem id)
        {
            var item = await _DbContext.TodoItems.FindAsync(id);
            if (item != null)
            {
                item.Erledigt = true;
                _DbContext.TodoItems.Update(item);
            }
        }

        public async Task RemooveMarkAsIncomplete(TodoItem id)
        {
            var item = await _DbContext.TodoItems.FindAsync(id);
            if (item != null)
            {
                item.Erledigt = false;
                _DbContext.TodoItems.Update(item);
            }
        }

        public async Task<List<TodoItem>> Get()
        {
            return await _DbContext.TodoItems.ToListAsync();

        }

        public async Task<TodoItem> Get(Guid id)
        {
            return await _DbContext.TodoItems.FindAsync(id);

        }

    }
}

