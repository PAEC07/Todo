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

        int editid = -1;
        public void StartEdit(CategoriesItem item, string editname)
        {
            if (item == null || item.name == null)
            {
                return;
            }

            editid = item.id;
            editname = item.name;

        }

        public async Task SaveEdit(CategoriesItem item, string name)
        {
            item.name = name;
            await _repo.Update(item);
        }

        public async Task<List<CategoriesItem>> GetAllCategoriesItems()
        {
            return await _repo.Get();

        }

        public async Task<CategoriesItem> GetCategoriesItem(int id)
        {
            return await _repo.Get(id);
        }
    }
}
