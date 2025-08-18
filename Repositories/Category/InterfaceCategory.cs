
 using Todo.Models;



namespace Todo.Repositories.CategoriesNamespace
{
    public interface ICategoriesRepository
    {
        public Task<List<CategoriesItem>> Get();
        
        public Task<CategoriesItem> Get(int id);

        public Task Add(CategoriesItem CategoriesItem);

        internal Task Update(CategoriesItem CategoriesItem);

        internal Task Delete(CategoriesItem CategoriesItem);


    }
}
