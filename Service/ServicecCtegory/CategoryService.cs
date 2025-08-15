using Repository;
using Todo.Models;
using Todo.Repositories.Todo;

using Todo.Service.ServiceTodo;
using Todo.Repositories.CategoryNamespace;



namespace Todo.Service
{
    public class ServiceCategory
    {
        readonly CategoryRepository _repo;

      
        public ServiceCategory(CategoryRepository item)
        {
            _repo = item;
        }

        

        public async Task AddCategoryItem(CategoryItem item)
        {
            await _repo.Add(item);
        }
        public async Task Remove(CategoryItem item)
        {
            await _repo.Add(item);
        }

        public async Task UpdateCategoryItem(CategoryItem item)
        {
            await _repo.Update(item);
        }
        public async Task<List<CategoryItem>> GetCategoryItems()
        {
            return await _repo.Get();
        }
    }
}
