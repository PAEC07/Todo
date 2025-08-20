using Todo.Models;
using Todo.Repositories.Todo;

namespace Todo.Service.ServiceTodo
{
    public class TodoService
    {
        private TodoIRepository _repo;



        public TodoService(TodoIRepository todoreposetory)
        {
            _repo = todoreposetory;
        }
        //-----------------------Add----------------------------    
        public async Task AddTodoItem(TodoItem item)
        {
            await _repo.Add(item);
        }

        //-----------------------Edit----------------------------
        int editid = -1;
        public void StartEdit(TodoItem item, string editTitle, string editDescription)
        {
            if (item == null || item.Titel == null || item.Discription == null)
            {
                return;
            }

            editid = item.Id;
            editTitle = item.Titel;
            editDescription = item.Discription;

        }

        public async Task SaveEdit(TodoItem item, string editTitle, string editDescription)
        {
            item.Titel = editTitle;
            item.Discription = editDescription;
            await _repo.Update(item);
        }






        //-------------------------Mark as Complete & Remove----------------------------

        public async Task MarkAsComplete(TodoItem item)
        {
            item.Erledigt = true;
            await _repo.Update(item);
        }

        public async Task RemoveMarkAsComplete(TodoItem item)
        {
            item.Erledigt = false;
            await _repo.Update(item);
        }

        //-----------------------Update----------------------------
        public async Task<TodoItem> GetTodoItem(int id)
        {
            return await _repo.Get(id);
        }

        public async Task<List<TodoItem>> GetAllTodoItems()
        {
            return await _repo.Get();
        }

        //-----------------------Delete----------------------------
        public async Task DeleteTodoItem(TodoItem item)
        {

            await _repo.Delete(item);


        }

        public async Task UpdateCategories(TodoItem item)
        {

            await _repo.Update(item);

        }
    }
}

//context.TodoItems.Update(item);
//await context.SaveChangesAsync();