using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;
using Todo.Repositories.Category;
using Todo.Repositories.CategoryNamespace;


namespace Todo.Repositories.Category
{
    public class CategoryIRepository
    {
        public class CategoryRepository : InterfaceCategoryIRepository
        {
            private readonly ApplicationDbContext _DbContext;
            public CategoryRepository(ApplicationDbContext DbContext)
            {
                _DbContext = DbContext;
            }

            public async Task Add(CategoryItem item)
            {
                _DbContext.Categorys.Add(item);
                await _DbContext.SaveChangesAsync();
            }

            public async Task Update(CategoryItem item)
            {
                _DbContext.Categorys.Update(item);
                await _DbContext.SaveChangesAsync();
            }
            public async Task<List<CategoryItem>> Get()
            {
                return await _DbContext.Categorys.ToListAsync();
            }

            public async Task<CategoryItem> Get(int id)
            {
                return await _DbContext.Categorys.FindAsync(id);
            }

            public async Task Delete(CategoryItem item)
            {
                _DbContext.Categorys.Remove(item);
                await _DbContext.SaveChangesAsync();
            }


        }
    }
}

