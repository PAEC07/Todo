using System;
using Todo.Data;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Models;
using InterfaceIRepository;
using Microsoft.EntityFrameworkCore;

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

