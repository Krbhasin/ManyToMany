using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class Books
    {
        public int BooksId { get; set; }
    	public string Title { get; set; }
    	public virtual ICollection<BooksCatagory> BooksCategories { get; set; }
    }
}