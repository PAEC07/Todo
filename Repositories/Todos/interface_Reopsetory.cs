using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repository;
using Todo.Models;
using TodoServiceNamespace;

namespace Todo.Repositories.Todos
{
    public interface InterfaceTodoIRepository

    {
        
        public  Task<List<TodoItem>> Get();
        //auf int geändert
        public Task<TodoItem> Get(int id);

        public Task Add(TodoItem todoItem);

        public Task Update(TodoItem todoItem);

        public Task Delete(TodoItem todoItem);
        
        
    }
}
 