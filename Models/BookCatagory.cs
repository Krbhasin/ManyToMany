using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManyToMany.Models
{
    public class BooksCatagory
    {
        [Key, Column(Order = 1)]
    	public int BooksId { get; set; }
    	[Key, Column(Order = 2)]
    	public int CategoryId { get; set; }
    	public Books Books { get; set; }
    	public Catagories Category { get; set; }
    }
}