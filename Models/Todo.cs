
using Microsoft.Identity.Client;

namespace Todo.Models
{
    public class TodoItem
    {
        
        public TodoItem(int Id1, string Titel1, string Discription1, bool Erledigt1, String CategoriesName01)
        {
            if (Titel1 == null || Discription1 == null)
            {
                Id = -1;
                Titel = "Fehler";
                Discription = "Fehler";
                Erledigt = false;

            }
            Id = Id1;
            Titel = Titel1;
            Discription = Discription1;
            Erledigt = Erledigt1;
            CategoriesName = CategoriesName01;

        }
        
        

        public TodoItem() { }
        public int Id { get; set; }
        public string? Titel { get; set; }
        public string? Discription { get; set; }

        public bool Erledigt { get; set; }

        public string? CategoriesName { get; set; } 


    }
}
