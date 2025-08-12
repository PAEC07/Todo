using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;




namespace Todo.Repositories.Todos
{
    public class TodoIRepository : InterfaceTodoIRepository
    {
        private readonly ApplicationDbContext _DbContext;
        public TodoIRepository(ApplicationDbContext DbContext) {
            _DbContext = DbContext; 
        }

        

        public async Task Add(TodoItem item)
        {

                _DbContext.TodoItems.Add(item);
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
            
            {
                return await _DbContext.TodoItems.ToListAsync();// Hier wird eine Leere liste übergeben 
               
            }

        }
    
        public async Task<TodoItem> Get(int id)
        {
          
            
                return await _DbContext.TodoItems.FindAsync(id) ?? new TodoItem(-1, "Fehler", "Fehler", false);
            
        }

        public Task MarkAsComplete(TodoItem id)
        {
            throw new NotImplementedException();
        }
    }
}

