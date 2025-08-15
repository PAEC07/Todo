using System.Drawing;

namespace Todo.Models
{
    public class CategoryItem
    {
        public int id { get; set; } 
        public string name { get; set; }
        
        
        

        public CategoryItem(int Id, String Name, int ID)
        {
            id = Id;
            name = Name;
            
           
        }

        public CategoryItem() { } // Default constructor for EF Core
    }

}

