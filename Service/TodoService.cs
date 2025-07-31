using System;
using Todo.Models;
using InterfaceIRepository;
namespace Todo.TodoService
{
    public class TodoService
    {
        private readonly IRepository<TodoItem> _todoreposetory;

        public TodoService(IRepository<TodoItem> todoreposetory)
        {
            _todoreposetory = todoreposetory;
        }

        public void AddTodoItem(TodoItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _todoreposetory.Add(item);
        }
    }
}


//https://www.youtube.com/watch?v=rsfYoA4LsS8&t=205s