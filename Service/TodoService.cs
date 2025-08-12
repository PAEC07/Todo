using Todo.Models;
using Todo.Repositories.Todos;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using Todo.Data;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Identity.Client;
using Todo.Repositories.Todos;

namespace TodoServiceNamespace
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
        public void StartEdit(TodoItem item, String editTitle, String editDescription)
        {
            if (item == null || item.Titel == null || item.Discription == null)
            {
                return;
            }

            editid = item.Id;
            editTitle = item.Titel;
            editDescription = item.Discription;

        }

        public async Task SaveEdit(TodoItem item,String editTitle,String editDescription)
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
    }
}

                    //context.TodoItems.Update(item);
                    //await context.SaveChangesAsync();