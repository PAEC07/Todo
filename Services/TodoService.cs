//using Todo.Models;
//namespace Todo
//{
//    public class TodoService
//    {
//        private readonly IReposetory<TodoItem> _todoreposetory;

//        public TodoService(IReposetory<TodoItem> todoreposetory)
//        {
//            _todoreposetory = todoreposetory;
//        }

//        public void AddTodoItem(TodoItem item)
//        {
//            if (item == null) throw new ArgumentNullException(nameof(item));
//            _todoreposetory.Add(item);
//        }
//    }
//}
////https://www.youtube.com/watch?v=rsfYoA4LsS8&t=205s