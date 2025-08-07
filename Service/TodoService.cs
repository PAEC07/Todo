using Todo.Models;
using InterfaceIRepository;
using Repository;

namespace TodoServiceNamespace
{
    public class TodoService
    {
        private readonly IRepository _todoreposetory;

        public TodoService(IRepository todoreposetory)
        {
            _todoreposetory = todoreposetory;
        }

        public async Task AddTodoItem(TodoItem item)
        {
            await _todoreposetory.Add(item);    
        }
        
        public async Task UpdateTodoItem(TodoItem item)
        {
            await _todoreposetory.Update(item);
        }

        public async Task DeleteTodoItem(TodoItem item)
        {
            await _todoreposetory.Delete(item);
        }

        public async Task MarkAsComplete(TodoItem id)
        {
            await _todoreposetory.MarkAsComplete(id);
        }
        
        public async Task RemoveMarkAsComplete(TodoItem id)
        {
            await _todoreposetory.MarkAsComplete(id);
        }

        public async Task<TodoItem> GetTodoItem(Guid id)
        {
            return await _todoreposetory.Get(id);
        }

        public async Task<List<TodoItem>> GetAllTodoItems()
        {
            return await _todoreposetory.Get();
        }

    }
}
