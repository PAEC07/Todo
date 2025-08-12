using Todo.Data;
using Todo.Models;
using Microsoft.EntityFrameworkCore;
using Todo.Repositories.Options;

namespace Todo.Repositories.Options
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

            public async Task AddCategory(Category category) {
                _DbContext.Categorys.Add(category);
                await _DbContext.SaveChangesAsync();
            }

            public async Task UpdateCategory(Category category)
            {
                _DbContext.Categorys.Update(category);
                await _DbContext.SaveChangesAsync();
            }
            //Weiter Methoden zu den Kategoreien Anführen

        }
    }
}
            
