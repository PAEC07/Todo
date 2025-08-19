using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;

using Todo.Repositories.CategoriesNamespace;

namespace Todo.Repositories.CategoriesNamespace
{





    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly ApplicationDbContext _DbContext;
        public CategoriesRepository(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;


        }

        // public async Task AddCategories(CategoriesItem item)
        public async Task Add(CategoriesItem item)
        {
            
            _DbContext.CategoriesItems.Add(item);
            await _DbContext.SaveChangesAsync();

        }



        public async Task Update(CategoriesItem item)
        {
            _DbContext.CategoriesItems.Update(item);
            await _DbContext.SaveChangesAsync();
        }
        public async Task<List<CategoriesItem>> Get()
        {
            return await _DbContext.CategoriesItems.ToListAsync();
        }

        public async Task<CategoriesItem> Get(int id)
        {
            return await _DbContext.CategoriesItems.FindAsync(id);

        }

        public async Task Remove(CategoriesItem item)
        {

            _DbContext.CategoriesItems.Remove(item);
            await _DbContext.SaveChangesAsync();

        }
        public async Task RemoveById(int id)
        {
            var entity = await _DbContext.CategoriesItems.FindAsync(id);
            if (entity != null)
            {
                _DbContext.CategoriesItems.Remove(entity);
                await _DbContext.SaveChangesAsync();
            }
        }
    }
}


