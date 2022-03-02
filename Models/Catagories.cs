using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Catagories
    {
        [Key]
        public int CategoryId { get; set; }
	    public string CategoryName { get; set; }
	    public virtual ICollection<BooksCatagory> BooksCategories { get; set; }
    }
}