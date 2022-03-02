using System;
using System.Collections.Generic;
using System.Linq;
using ManyToMany.Models;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        using (var context = new BooksContext())
		{	
			context.Database.EnsureCreated();

			BooksCatagory bc1 = new BooksCatagory()
			{
				BooksId = 1,
				CategoryId = 1
			};
			
			BooksCatagory bc2 = new BooksCatagory()
			{
				BooksId = 1,
				CategoryId = 2
			};
			
			BooksCatagory bc3 = new BooksCatagory()
			{
				BooksId = 2,
				CategoryId = 1
			};
			
			BooksCatagory bc4 = new BooksCatagory()
			{
				BooksId = 2,
				CategoryId = 2
			};
			
			Books Books1 = new Books()
			{
				Title = "MyBooks 1",
				BooksCategories = new List<BooksCatagory>()
				{
					bc1,
					bc2
				}
			};
			Books Books2 = new Books()
			{
				Title = "MyBooks 2",
				BooksCategories = new List<BooksCatagory>()
				{
					bc3,
					bc4
				}
			};
			
			Catagories category1 = new Catagories()
			{
				CategoryName = "category 1",
				BooksCategories = new List<BooksCatagory>()
				{
					bc1,
					bc3
				}
			};
			Catagories category2= new Catagories()
			{
				CategoryName = "category 2",
				BooksCategories = new List<BooksCatagory>()
				{
					bc2,
					bc4
				}
			};
			
		    context.Bookss.Add(Books1);
			context.Bookss.Add(Books2);
			context.Categories.Add(category1);
			context.Categories.Add(category2);

		    context.SaveChanges();
			
			var categories = context.Categories.ToList();
			var Bookss = context.Bookss.ToList();
			var BooksCategories = context.BooksCategories.ToList();
        }
		}	
    }
}

