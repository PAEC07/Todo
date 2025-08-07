using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository;
using Todo.Models;

using TodoServiceNamespace;

namespace InterfaceIRepository
{
    public interface IRepository
        
    {
        
        public  Task<List<TodoItem >> Get();

        public Task<TodoItem> Get(Guid id);

        public Task Add(TodoItem todoItem);

        public Task Update(TodoItem todoItem);

        public Task Delete(TodoItem todoItem);
        Task MarkAsComplete(TodoItem id);
    }
}
 