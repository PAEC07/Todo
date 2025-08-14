
 using Todo.Models;



namespace Todo.Repositories.CategoryNamespace
{
    public interface InterfaceCategoryIRepository
    {
        public Task<List<CategoryItem>> Get();
        //auf int geändert
        public Task<CategoryItem> Get(int id);

        public Task Add(CategoryItem option);

        public Task Update(CategoryItem option);

        public Task Delete(CategoryItem option);


    }
}
