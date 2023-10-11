using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_anf_Objects
{
    using System;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two book objects
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);

            // Display book information
            Console.WriteLine("Book 1 Information:");
            book1.DisplayBookInfo();

            Console.WriteLine("Book 2 Information:");
            book2.DisplayBookInfo();
        }
    }

    
    
        
        
     
    }

