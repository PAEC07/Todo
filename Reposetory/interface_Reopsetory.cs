using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo
{
    public interface IReposetory
    {
        
        public  Task<List<TodoItem>> Get();

        public Task<TodoItem> Get(Guid id);

        public Task Add(TodoItem todoItem);

        public Task Update(TodoItem todoItem);

        public Task Delete(TodoItem todoItem);
    }
}
 