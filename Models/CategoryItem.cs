using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Todo.Models
{
    public class CategoriesItem
    {
        [Key] // Primärschlüssel
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // DB generiert automatisch
        public int id { get; set; }
        public string name { get; set; } = "";
        public CategoriesItem( string Name)
        {
            
            name = Name;
        }

        public override string ToString()
        {
            
            return name;
        }


        public CategoriesItem() { }
    }
}
