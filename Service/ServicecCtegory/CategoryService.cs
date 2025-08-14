using Repository;
using Todo.Models;
using Todo.Repositories.Todo;
using Todo.Repositories.Category;
using Todo.Service.ServiceTodo;



namespace Todo.Service
{
    public class ServiceCategory
    {
        private CategoryIRepository _repo01;
        public ServiceCategory(CategoryIRepository repositoryCategory)
        {
            _repo01 = repositoryCategory;
        }


        public async Task AddCategoryItem(CategoryItem item)
        {
           // await _repo01.Add(item);
        }public async Task Remove(CategoryItem item)
        {
          //  await _repo01.Add(item);
        }

        public async Task AddCategoryToTodoItem(CategoryItem item, TodoItem todoItem)
        {
            if (item == null || todoItem == null)
            {
                return;
            }
            
            todoItem.CategoryId = item.id;
            
        
        }
    }
}
