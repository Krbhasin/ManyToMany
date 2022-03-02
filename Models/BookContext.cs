using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Models
{
    public class BooksContext:DbContext
    {
        private const string connectionString = "Data Source=localhost;Initial Catalog=ManyToMAny;User Id=root; Password=root";
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BooksCatagory>().HasKey(table => new {
            table.BooksId, table.CategoryId
            });
        }
 
        public DbSet<Catagories> Categories { get; set; }
        public DbSet<Books> Bookss { get; set; }
		public DbSet<BooksCatagory> BooksCategories { get; set; }
    }
}