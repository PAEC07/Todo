
 using Todo.Models;


namespace Todo.Repositories.Options
{
    public interface InterfaceCategoryIRepository
    {
        public Task<List<Category>> Get();
        //auf int geändert
        public Task<Category> Get(int id);

        public Task Add(Category option);

        public Task Update(Category option);

        public Task Delete(Category option);


    }
}
