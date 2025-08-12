using System.Drawing;

namespace Todo.Models
{
    public class Category
    {
        public int id { get; set; } = -1;
        public string name { get; set; } = "Fehler";
        public Category(int Id, String Name)
        {
            name = Name;
            id = Id;
        }
    public Category() { }
    }


}

