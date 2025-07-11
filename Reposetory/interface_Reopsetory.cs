using System;


namespace Todo
{
    public interface TodoIReposetory 
    {
        
        public  Task<List<TodoItem>> Get();

        public Task<TodoItem> Get(Guid id);

        public Task Add(TodoItem todoItem);

        public Task Update(TodoItem todoItem);

        public Task Delete(TodoItem todoItem);
    }
}
 