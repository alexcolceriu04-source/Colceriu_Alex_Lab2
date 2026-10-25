using System.Collections.Generic;

namespace Colceriu_Alex_Lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();
        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();
        public IEnumerable<BookCategory> BookCategories { get; set; } = Enumerable.Empty<BookCategory>();
    }
}