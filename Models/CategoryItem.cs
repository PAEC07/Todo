using System.Drawing;

namespace Todo.Models
{
    public class CategoryItem
    {
        public int id { get; set; } 
        public string name { get; set; }
        
        public int CategoryID { get; set; }
        public CategoryItem(int Id, String Name, int ID)
        {
            id = Id;
            name = Name;
            CategoryID = ID;
        }
        
    }

}

