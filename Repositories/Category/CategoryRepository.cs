using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;

using Todo.Repositories.CategoryNamespace;

namespace Todo.Repositories.CategoryNamespace
{


   
        

        public class CategoryRepository : ICategoryRepository
        {
            private readonly ApplicationDbContext _DbContext;
            public CategoryRepository(ApplicationDbContext DbContext)
            {
                _DbContext = DbContext;


            }

            // public async Task AddCategory(CategoryItem item)
        public async Task Add(CategoryItem item)
        {
            
                _DbContext.CategoryItems.Add(item);
                await _DbContext.SaveChangesAsync();
        
        }

           

            public async Task Update(CategoryItem item)
            {
                _DbContext.CategoryItems.Update(item);
                await _DbContext.SaveChangesAsync();
            }
            public async Task<List<CategoryItem>> Get()
            {
                return await _DbContext.CategoryItems.ToListAsync();
            }

            public async Task<CategoryItem> Get(int id)
            {
                return await _DbContext.CategoryItems.FindAsync(id);

            }

            public async Task Delete(CategoryItem item)
            {
                _DbContext.CategoryItems.Remove(item);
                await _DbContext.SaveChangesAsync();
            }


        }
    }



