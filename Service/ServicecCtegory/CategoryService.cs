using Repository;
using Todo.Models;
using Todo.Repositories.Todo;

using Todo.Service.ServiceTodo;
using Todo.Repositories.CategoriesNamespace;



namespace Todo.Service
{
    public class ServiceCategories
    {
        readonly CategoriesRepository _repo;

      
        public ServiceCategories(CategoriesRepository item)
        {
            _repo = item;
        }

        

        public async Task AddCategoriesItem(CategoriesItem item)
        {
            await _repo.Add(item);
        }
        public async Task Remove(CategoriesItem item)
        {
            await _repo.Add(item);
        }

        public async Task UpdateCategoriesItem(CategoriesItem item)
        {
            await _repo.Update(item);
        }
        public async Task<List<CategoriesItem>> GetCategoriesItems()
        {
            return await _repo.Get();

        }

        public async Task<CategoriesItem> GetCategoriesItem(int id)
        {
            return await _repo.Get(id);
        }
    }
}
