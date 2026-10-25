using System.Collections.Generic;

namespace Colceriu_Alex_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}