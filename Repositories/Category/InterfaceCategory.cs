
 using Todo.Models;



namespace Todo.Repositories.CategoryNamespace
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryItem>> Get();
        
        public Task<CategoryItem> Get(int id);

        public Task Add(CategoryItem categoryItem);

        internal Task Update(CategoryItem categoryItem);

        internal Task Delete(CategoryItem categoryItem);


    }
}
